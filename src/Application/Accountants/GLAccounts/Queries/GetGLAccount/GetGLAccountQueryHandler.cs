using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using GFCA.Application.Common.Interfaces;
using GFCA.Shared.Models.Dto;
using GFCA.Shared.Models.Vm;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GFCA.Application.Accountants.GLAccounts.Queries.GetGLAccount
{
    public class GetGLAccountQueryHandler : IRequestHandler<GetGLAccountQuery, GLAccountVm>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public GetGLAccountQueryHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<GLAccountVm> Handle(GetGLAccountQuery request, CancellationToken cancellationToken)
        {
            var data = new GLAccountVm();
            data.Accounts = await _context.GLAccounts
                .ProjectTo<GLAccountDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return data;
        }
    }
}
