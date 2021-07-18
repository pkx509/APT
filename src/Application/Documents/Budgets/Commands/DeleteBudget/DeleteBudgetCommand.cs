using System;
using MediatR;

namespace GFCA.Application.Documents.Budgets.Commands.DeleteBudget
{
    public class DeleteBudgetCommand : IRequest
    {
        public int BudgetId { get; set; }
    }
}
