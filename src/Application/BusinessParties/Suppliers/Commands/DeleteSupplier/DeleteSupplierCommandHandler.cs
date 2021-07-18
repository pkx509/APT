using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Exceptions;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities.BusinessParties;
using MediatR;

namespace GFCA.Application.BusinessParties.Suppliers.Commands.DeleteSupplier
{
    public class DeleteSupplierCommandHandler : IRequestHandler<DeleteSupplierCommand>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public DeleteSupplierCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<Unit> Handle(DeleteSupplierCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Suppliers.FindAsync(request.SupplierId);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Supplier), request.SupplierId);
            }

            _context.Suppliers.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
