using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Exceptions;
using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Entities.Documents;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Documents.Budgets.Commands.UpdateBudget
{
    public class UpdateBudgetCommandHandler : IRequestHandler<UpdateBudgetCommand>
    {

        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public UpdateBudgetCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser, IDateTime datetime, IMapper mapper)
        {
            _mapper = mapper;
            _dateTime = datetime;
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<Unit> Handle(UpdateBudgetCommand request, CancellationToken cancellationToken)
        {

            var doc = _mapper.Map<BudgetDto>(request);
            var entity = await _context.Budgets.FindAsync(doc.BudgetId);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Budget), request.BudgetId);
            }

            entity.BudgetTypeId = doc.BudgetTypeId??0;
            entity.BrandId = doc.BrandId??0;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

        }
    }
}
