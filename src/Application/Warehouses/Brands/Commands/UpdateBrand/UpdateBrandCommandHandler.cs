using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Exceptions;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities.Warehouses;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Warehouses.Brands.Commands.UpdateBrand
{
    public class UpdateBrandCommandHandler: IRequestHandler<UpdateBrandCommand>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public UpdateBrandCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<Unit> Handle(UpdateBrandCommand request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<BrandDto>(request);

            try
            {
                await _context.BeginTransactionAsync();
                var entity = await _context.Brands.FindAsync(request.BrandId);
                if (entity == null)
                    throw new NotFoundException(nameof(Brand), dto.BrandId);

                _mapper.Map<UpdateBrandCommand, Brand>(request, entity);

                await _context.SaveChangesAsync(cancellationToken);
                await _context.CommitTransactionAsync();
            }
            catch
            {
                _context.RollbackTransaction();
            }

            return Unit.Value;
        }
    }
}
