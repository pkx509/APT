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

namespace GFCA.Application.Organizations.Employees.Queries.GetEmployee
{
    public class GetEmployeeQueryHandler : IRequestHandler<GetEmployeeQuery, EmployeeVm>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public GetEmployeeQueryHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<EmployeeVm> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            var data = new EmployeeVm();
            data.Employees = await _context.Employees
                .ProjectTo<EmployeeDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return data;
        }
    }
}
