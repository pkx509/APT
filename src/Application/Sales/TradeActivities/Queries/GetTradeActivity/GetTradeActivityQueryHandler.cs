using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using GFCA.Application.Common.Interfaces;
using GFCA.Shared.Models.Dto;
using GFCA.Shared.Models.Vm;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GFCA.Application.Sales.TradeActivities.Queries.GetTradeActivity
{
    public class GetTradeActivityQueryHandler : IRequestHandler<GetTradeActivityQuery, TradeActivityVm>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public GetTradeActivityQueryHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<TradeActivityVm> Handle(GetTradeActivityQuery request, CancellationToken cancellationToken)
        {
            var data = new TradeActivityVm();
            
            data.TradeActivities = await _context.TradeActivities
                //.AsNoTracking()
                .ProjectTo<TradeActivityDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return data;
        }
    }
}
