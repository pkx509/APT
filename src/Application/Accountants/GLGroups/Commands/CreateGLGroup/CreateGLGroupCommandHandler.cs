using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities.Accountants;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Accountants.GLGroups.Commands.CreateGLGroup
{
    public class CreateGLGroupCommandHandler : IRequestHandler<CreateGLGroupCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public CreateGLGroupCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<int> Handle(CreateGLGroupCommand request, CancellationToken cancellationToken)
        {

            var dto = _mapper.Map<GLGroupDto>(request);
            var ent = _mapper.Map<GLGroup>(dto);

            try
            {
                await _context.BeginTransactionAsync();

                _context.GLGroups.Add(ent);
                await _context.SaveChangesAsync(cancellationToken);
                await _context.CommitTransactionAsync();
            }
            catch
            {
                _context.RollbackTransaction();
            }
            return ent.GroupId;
        }

    }
}