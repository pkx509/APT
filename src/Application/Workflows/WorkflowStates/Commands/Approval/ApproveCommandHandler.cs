using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Interfaces;
using MediatR;

namespace GFCA.Application.WorkflowStates.Approval
{
    public class ApproveCommandHandler : IRequestHandler<ApproveCommand>
    {
        
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public ApproveCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }


        public Task<Unit> Handle(ApproveCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

    }
}
