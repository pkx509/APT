using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Exceptions;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities.Warehouses;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Warehouses.ProductCategories.Commands.UpdateProductCategory
{
    public class UpdateProductCategoryCommandHandler : IRequestHandler<UpdateProductCategoryCommand>
    {

        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public UpdateProductCategoryCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<Unit> Handle(UpdateProductCategoryCommand request, CancellationToken cancellationToken)
        {

            var doc = _mapper.Map<ProductCategoryDto>(request);
            var entity = await _context.ProductCategories.FindAsync(doc.ProductCategoryId);

            if (entity == null)
            {
                throw new NotFoundException(nameof(ProductCategory), request.ProductCategoryId);
            }

            entity.ProductCategoryName = doc.ProductCategoryName;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

        }
    }
}
