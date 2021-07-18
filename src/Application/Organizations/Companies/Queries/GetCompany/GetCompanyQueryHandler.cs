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

namespace GFCA.Application.Organizations.Companies.Queries.GetCompany
{
    public class GetCompanyQueryHandler : IRequestHandler<GetCompanyQuery, CompanyVm>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public GetCompanyQueryHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<CompanyVm> Handle(GetCompanyQuery request, CancellationToken cancellationToken)
        {
            var data = new CompanyVm();
            data.Companies = await _context.Companies
                .ProjectTo<CompanyDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return data;
        }
    }
}
