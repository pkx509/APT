using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities.Warehouses;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Warehouses.ProductCategories.Commands.CreateProductCategory
{
    public class CreateProductCategoryCommandHandler : IRequestHandler<CreateProductCategoryCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public CreateProductCategoryCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<int> Handle(CreateProductCategoryCommand request, CancellationToken cancellationToken)
        {
            var d = _mapper.Map<ProductCategoryDto>(request);
            var doc = _mapper.Map<ProductCategory>(d);

            try
            {

                await _context.BeginTransactionAsync();
                string userName = (_currentUser.UserId > 0) ? "Anonymous User" : _currentUser.UserName;


                _context.ProductCategories.Add(doc);
                await _context.SaveChangesAsync(cancellationToken);
                await _context.CommitTransactionAsync();

            }
            catch
            {
                _context.RollbackTransaction();
            }

            return doc.ProductCategoryId;
        }

    }
}
