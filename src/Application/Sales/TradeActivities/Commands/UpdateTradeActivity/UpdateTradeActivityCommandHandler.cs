using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Exceptions;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities.Sales;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Sales.TradeActivities.Commands.UpdateTradeActivity
{
    public class UpdateTradeActivityCommandHandler : IRequestHandler<UpdateTradeActivityCommand>
    {
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public UpdateTradeActivityCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<Unit> Handle(UpdateTradeActivityCommand request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<TradeActivityDto>(request);

            try
            {
                await _context.BeginTransactionAsync();
                var entity = await _context.TradeActivities.FindAsync(request.TradeActivityId);
                if (entity == null)
                    throw new NotFoundException(nameof(TradeActivity), dto.TradeActivityId);

                //var entAcc = await _context.GLAccounts.FindAsync(request.GLAccount.AccountId);
                entity.AccountId = dto.AccountId??0;
                entity.ActivityType = dto.ActivityType; //AP Sale / AP MKT
                entity.ActivityName = dto.ActivityName;

                entity.FixedContract = dto.IsFixedContract? "X": string.Empty;
                entity.Deductable = dto.IsDeductable ? "X" : string.Empty;
                entity.SaleInTHBCS = dto.HaveSaleInTHB ? "X" : string.Empty;
                entity.SaleInGrossSale = dto.HaveSaleInGrossSale ? "X" : string.Empty;
                entity.SaleInNotSale = dto.HaveSaleInNotSale ? "X" : string.Empty;

                entity.SaleOutTHBCS = dto.HaveSaleOutTHB ? "X" : string.Empty;
                entity.SaleOutGrossSale = dto.HaveSaleOutGrossSale ? "X" : string.Empty;
                entity.SaleOutNotSale = dto.HaveSaleOutNotSale ? "X" : string.Empty;

                entity.NotRelateSaleAbsAmt = dto.AbsAmt ? "X" : string.Empty;
                entity.Remark = dto.Remark;

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
