using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities.Accountants;
using GFCA.Shared.Models.Dto;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GFCA.Application.Accountants.GLAccounts.Commands.CreateGLAccount
{
    public class CreateGLAccountCommandHandler : IRequestHandler<CreateGLAccountCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public CreateGLAccountCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<int> Handle(CreateGLAccountCommand request, CancellationToken cancellationToken)
        {

            //var dto = _mapper.Map<GLAccountDto>(request);
            var ent = _mapper.Map<GLAccount>(request);

            try
            {
                await _context.BeginTransactionAsync();
                var glGroup = await _context.GLGroups.FindAsync(request.GLGroupId??0);
                ent.AccountId = request.AccountId??0;
                ent.GLGroupId = glGroup.GroupId;
                ent.GLGroup = glGroup;
                //_context.GLGroups.Attach(glGroup);
                
                _context.GLAccounts.Add(ent);
                await _context.SaveChangesAsync(cancellationToken);
                await _context.CommitTransactionAsync();
            }
            catch //(Exception ex)
            {
                _context.RollbackTransaction();
            }
            return ent.AccountId;
        }


    }
}
