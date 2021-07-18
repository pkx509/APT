using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Exceptions;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities.Accountants;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Accountants.CostCenters.Commands.UpdateCostCenter
{
    public class UpdateCostCenterCommandHandler : IRequestHandler<UpdateCostCenterCommand>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public UpdateCostCenterCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<Unit> Handle(UpdateCostCenterCommand request, CancellationToken cancellationToken)
        {
            var costCenterDto = _mapper.Map<CostCenterDto>(request);

            try
            {
                await _context.BeginTransactionAsync();
                var entity = await _context.CostCenters.FindAsync(request.CostCenterId);
                if (entity == null)
                    throw new NotFoundException(nameof(CostCenter), costCenterDto.CostCenterId);

                entity.CenterCode = costCenterDto.CostCenterCode;
                entity.CenterName = costCenterDto.CostCenterName;

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
