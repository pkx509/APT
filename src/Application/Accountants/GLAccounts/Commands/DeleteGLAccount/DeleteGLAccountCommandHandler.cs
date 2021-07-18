using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Interfaces;
using MediatR;

namespace GFCA.Application.Accountants.GLAccounts.Commands.DeleteGLAccount
{
    public class DeleteGLAccountCommandHandler : IRequestHandler<DeleteGLAccountCommand>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public DeleteGLAccountCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<Unit> Handle(DeleteGLAccountCommand request, CancellationToken cancellationToken)
        {
            try
            {
                await _context.BeginTransactionAsync();

                var entity = await _context.GLAccounts.FindAsync(request.AccountId);

                _context.GLAccounts.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);
                await _context.CommitTransactionAsync();

            }
            catch
            {
                _context.RollbackTransaction();
            }

            return Unit.Value;
        }
    }
}
