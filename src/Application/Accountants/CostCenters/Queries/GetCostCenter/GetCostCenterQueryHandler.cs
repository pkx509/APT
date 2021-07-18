using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using GFCA.Application.Common.Interfaces;
using GFCA.Shared.Models.Vm;
using GFCA.Shared.Models.Dto;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GFCA.Application.Accountants.CostCenters.Queries.GetCostCenter
{
    public class GetCostCenterQueryHandler : IRequestHandler<GetCostCenterQuery, CostCenterVm>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public GetCostCenterQueryHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<CostCenterVm> Handle(GetCostCenterQuery request, CancellationToken cancellationToken)
        {
            var data = new CostCenterVm();
            data.CostCenters = await _context.CostCenters
                .ProjectTo<CostCenterDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return data;
        }
    }
}
