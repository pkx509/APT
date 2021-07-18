using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities.Sales;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Sales.Channels.Commands.CreateChannel
{
    public class CreateChannelCommandHandler : IRequestHandler<CreateChannelCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public CreateChannelCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<int> Handle(CreateChannelCommand request, CancellationToken cancellationToken)
        {

            var channelDto = _mapper.Map<ChannelDto>(request);
            var channelEnt = _mapper.Map<Channel>(channelDto);
            try
            {
                await _context.BeginTransactionAsync();

                _context.Channels.Add(channelEnt);
                await _context.SaveChangesAsync(cancellationToken);
                await _context.CommitTransactionAsync();
            }
            catch
            {
                _context.RollbackTransaction();
            }
            return channelEnt.ChannelId;
        }


    }
}
