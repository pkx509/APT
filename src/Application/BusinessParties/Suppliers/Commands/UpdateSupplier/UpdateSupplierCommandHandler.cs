using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Exceptions;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities.BusinessParties;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.BusinessParties.Suppliers.Commands.UpdateSupplier
{
    public class UpdateSupplierCommandHandler : IRequestHandler<UpdateSupplierCommand>
    {

        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public UpdateSupplierCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<Unit> Handle(UpdateSupplierCommand request, CancellationToken cancellationToken)
        {

            var doc = _mapper.Map<SupplierDto>(request);
            var entity = await _context.Suppliers.FindAsync(doc.SupplierId);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Supplier), request.SupplierId);
            }

            entity.SupplierCode = doc.SupplierCode;
            entity.SupplierName = doc.SupplierName;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

        }
    }
}
