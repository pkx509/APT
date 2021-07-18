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

namespace GFCA.Application.Workflows.Workflows.Queries.GetWorkflow
{
    public class GetWorkflowQueryHandler : IRequestHandler<GetWorkflowQuery, WorkflowVm>
    {

        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public GetWorkflowQueryHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<WorkflowVm> Handle(GetWorkflowQuery request, CancellationToken cancellationToken)
        {
            var data = new WorkflowVm();
            data.Workflows = await _context.Workflows
                .ProjectTo<WorkflowDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return data;
        }
    }
}
