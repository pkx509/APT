using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using GFCA.Application.Common.Interfaces;
using GFCA.Shared.Models.Dto;
using GFCA.Shared.Models.Vm;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GFCA.Application.Documents.SaleForecasts.Queries.GetSaleForecast
{
    public class GetSaleForecastQueryHandler : IRequestHandler<GetSaleForecastQuery, SaleForecastVm>
    {

        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public GetSaleForecastQueryHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<SaleForecastVm> Handle(GetSaleForecastQuery request, CancellationToken cancellationToken)
        {
            var data = new SaleForecastVm();
            data.SaleForecasts = await _context.SaleForecasts
                .ProjectTo<SaleForecastDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return data;
        }
    }
}
