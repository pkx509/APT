using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities.Sales;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Sales.TradeActivities.Commands.CreateTradeActivity
{
    public class CreateTradeActivityCommandHandler : IRequestHandler<CreateTradeActivityCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public CreateTradeActivityCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<int> Handle(CreateTradeActivityCommand request, CancellationToken cancellationToken)
        {

            var dto = _mapper.Map<TradeActivityDto>(request);
            var ent = _mapper.Map<TradeActivity>(dto);

            try
            {
                await _context.BeginTransactionAsync();

                _context.TradeActivities.Add(ent);
                await _context.SaveChangesAsync(cancellationToken);
                await _context.CommitTransactionAsync();
            }
            catch
            {
                _context.RollbackTransaction();
            }
            return ent.TradeActivityId;
        }

    }
}
