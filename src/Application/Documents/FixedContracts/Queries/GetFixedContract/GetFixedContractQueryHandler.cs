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

namespace GFCA.Application.Documents.FixedContracts.Queries.GetFixedContract
{
    public class GetFixedContractQueryHandler : IRequestHandler<GetFixedContractQuery, FixedContractVm>
    {

        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public GetFixedContractQueryHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<FixedContractVm> Handle(GetFixedContractQuery request, CancellationToken cancellationToken)
        {
            var data = new FixedContractVm();
            data.FixedContracts = await _context.FixedContracts
                .ProjectTo<FixedContractDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return data;
        }
    }
}
