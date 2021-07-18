using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Interfaces;
using MediatR;

namespace GFCA.Application.Accountants.CostCenters.Commands.DeleteCostCenter
{
    public class DeleteCostCenterCommandHandler : IRequestHandler<DeleteCostCenterCommand>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public DeleteCostCenterCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<Unit> Handle(DeleteCostCenterCommand request, CancellationToken cancellationToken)
        {
            try
            {
                await _context.BeginTransactionAsync();

                var entity = await _context.CostCenters.FindAsync(request.CostCenterId);

                _context.CostCenters.Remove(entity);

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
