using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Exceptions;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities.Accountants;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Accountants.GLAccounts.Commands.UpdateGLAccount
{
    public class UpdateGLAccountCommandHandler : IRequestHandler<UpdateGLAccountCommand>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public UpdateGLAccountCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<Unit> Handle(UpdateGLAccountCommand request, CancellationToken cancellationToken)
        {
            var glAccountDto = _mapper.Map<GLAccountDto>(request);

            try
            {
                await _context.BeginTransactionAsync();
                var entity = await _context.GLAccounts.FindAsync(request.AccountId);
                if (entity == null)
                    throw new NotFoundException(nameof(GLAccount), glAccountDto.AccountId);

                entity.GLGroupId = glAccountDto.GLGroupId??0;
                entity.GLCode = glAccountDto.GLCode;
                entity.GLName = glAccountDto.GLName;
                entity.Purpose = glAccountDto.Purpose;
                entity.Remark = glAccountDto.Remark;

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
