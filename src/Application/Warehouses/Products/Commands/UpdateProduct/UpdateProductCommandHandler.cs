using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Exceptions;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities.Warehouses;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Warehouses.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {

        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public UpdateProductCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {

            var doc = _mapper.Map<ProductDto>(request);
            var entity = await _context.Products.FindAsync(doc.ProductId);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Product), request.ProductId);
            }

            entity.BrandId = doc.BrandId??0;
            entity.ProductCode = doc.ProductCode;
            entity.ProductCategoryId = doc.ProductCategoryId;
            entity.ProductCategoryName = doc.ProductCategoryName;
            entity.ProductName = doc.ProductName;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

        }
    }
}
