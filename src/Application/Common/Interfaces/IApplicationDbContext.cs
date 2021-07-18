using GFCA.Domain.Entities;
using GFCA.Domain.Entities.Sales;
using GFCA.Domain.Entities.Accountants;
using GFCA.Domain.Entities.Warehouses;
using GFCA.Domain.Entities.Workflows;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using GFCA.Domain.Entities.Organizations;
using GFCA.Domain.Entities.Documents;
using GFCA.Domain.Entities.BusinessParties;

namespace GFCA.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {

        DbSet<CostCenter> CostCenters { get; set; }
        DbSet<FixedContract> FixedContracts { get; set; }
        DbSet<GLAccount> GLAccounts { get; set; }
        DbSet<GLGroup> GLGroups { get; set; }

        DbSet<Budget> Budgets { get; set; }
        DbSet<BudgetType> BudgetTypes { get; set; }
        DbSet<SaleForecast> SaleForecasts { get; set; }
        DbSet<SourceFund> SourceFunds { get; set; }
        DbSet<TradeInvesment> TradeInvesments { get; set; }
        DbSet<TradeActivity> TradeActivities { get; set; }

        DbSet<ProductCategory> ProductCategories { get; set; }
        DbSet<Product> Products { get; set; }

        DbSet<Actor> Actors { get; set; }
        DbSet<ActorState> ActorStates { get; set; }
        DbSet<FlowItem> FlowItems { get; set; }
        DbSet<OperatorCondition> OperatorConditions { get; set; }
        DbSet<StateFlowItem> StateFlowItems { get; set; }
        DbSet<StateProcess> StateProcesses { get; set; }
        DbSet<WorkflowAction> WorkflowActions { get; set; }
        DbSet<WorkflowActivity> WorkflowActivities { get; set; }
        DbSet<Workflow> Workflows { get; set; }
        DbSet<WorkflowState> WorkflowStates { get; set; }

        DbSet<Brand> Brands { get; set; }
        DbSet<Supplier> Suppliers { get; set; }
        DbSet<Channel> Channels { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<CustomerProduct> CustomerProducts { get; set; }
        DbSet<DocumentAction> DocumentActions { get; set; }
        DbSet<Document> Documents { get; set; }
        DbSet<DocumentType> DocumentTypes { get; set; }

        DbSet<Company> Companies { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<Department> Departments { get; set; }

        DbSet<EmailInbound> EmailInbounds { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        void RollbackTransaction();

    }
}
