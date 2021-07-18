using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Exceptions;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities.Sales;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Sales.Channels.Commands.UpdateChannel
{
    public class UpdateChannelCommandHandler : IRequestHandler<UpdateChannelCommand>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public UpdateChannelCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<Unit> Handle(UpdateChannelCommand request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<ChannelDto>(request);

            try
            {
                await _context.BeginTransactionAsync();
                var entity = await _context.Channels.FindAsync(request.ChannelId);
                if (entity == null)
                    throw new NotFoundException(nameof(Channel), dto.ChannelId);

                _mapper.Map<UpdateChannelCommand, Channel>(request, entity);

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
