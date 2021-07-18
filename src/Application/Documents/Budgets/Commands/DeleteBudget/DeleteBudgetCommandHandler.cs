using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GFCA.Application.Common.Exceptions;
using GFCA.Application.Common.Interfaces;
using GFCA.Application.Documents.Budgets.Commands.DeleteBudget;
using GFCA.Domain.Entities.Documents;
using MediatR;

namespace GFCA.Application.Documents.Commands.DeleteBudget
{
    public class DeleteBudgetCommandHandler : IRequestHandler<DeleteBudgetCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public DeleteBudgetCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteBudgetCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Budgets.FindAsync(request.BudgetId);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Budget), request.BudgetId);
            }

            _context.Budgets.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
