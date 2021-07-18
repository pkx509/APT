using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities.Accountants;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Accountants.CostCenters.Commands.CreateCostCenter
{
    public class CreateCostCenterCommandHandler : IRequestHandler<CreateCostCenterCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public CreateCostCenterCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<int> Handle(CreateCostCenterCommand request, CancellationToken cancellationToken)
        {

            var costCenterDto = _mapper.Map<CostCenterDto>(request);
            var costCenterEnt = _mapper.Map<CostCenter>(costCenterDto);

            try
            {
                await _context.BeginTransactionAsync();

                _context.CostCenters.Add(costCenterEnt);
                await _context.SaveChangesAsync(cancellationToken);
                await _context.CommitTransactionAsync();
            }
            catch
            {
                _context.RollbackTransaction();
            }
            return costCenterEnt.CostCenterId;
        }


    }
}
