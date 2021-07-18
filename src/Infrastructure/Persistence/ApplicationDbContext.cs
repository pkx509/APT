using GFCA.Application.Common.Interfaces;
using GFCA.Domain.Common;
using GFCA.Domain.Entities;
using GFCA.Domain.Entities.Sales;
using GFCA.Domain.Entities.Accountants;
using GFCA.Domain.Entities.Warehouses;
using GFCA.Domain.Entities.Workflows;
using GFCA.Infrastructure.Identity;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Options;
using System.Data;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer.Migrations.Internal;
using GFCA.Domain.Entities.Organizations;
using GFCA.Domain.Entities.Documents;
using GFCA.Domain.Entities.BusinessParties;

namespace GFCA.Infrastructure.Persistence
{
    public class ApplicationDbContext
        //: ApiAuthorizationDbContext<ApplicationUser>
        : KeyApiAuthorizationDbContext<User, Role, int>
        , IApplicationDbContext
    {

        #region [ Fields ]

        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;
        private IDbContextTransaction _currentTransaction;

        #endregion [ Fields ]

        #region [ Entities ]

        public DbSet<CostCenter> CostCenters { get; set; }
        public DbSet<FixedContract> FixedContracts { get; set; }
        public DbSet<GLAccount> GLAccounts { get; set; }
        public DbSet<GLGroup> GLGroups { get; set; }

        public DbSet<Budget> Budgets { get; set; }
        public DbSet<BudgetType> BudgetTypes { get; set; }
        public DbSet<SaleForecast> SaleForecasts { get; set; }
        public DbSet<SourceFund> SourceFunds { get; set; }
        public DbSet<TradeInvesment> TradeInvesments { get; set; }
        public DbSet<TradeActivity> TradeActivities { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<ActorState> ActorStates { get; set; }
        public DbSet<FlowItem> FlowItems { get; set; }
        public DbSet<OperatorCondition> OperatorConditions { get; set; }
        public DbSet<StateFlowItem> StateFlowItems { get; set; }
        public DbSet<StateProcess> StateProcesses { get; set; }
        public DbSet<WorkflowAction> WorkflowActions { get; set; }
        public DbSet<WorkflowActivity> WorkflowActivities { get; set; }
        public DbSet<Workflow> Workflows { get; set; }
        public DbSet<WorkflowState> WorkflowStates { get; set; }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerProduct> CustomerProducts { get; set; }
        public DbSet<DocumentAction> DocumentActions { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public DbSet<EmailInbound> EmailInbounds { get; set; }

        #endregion [ Entities ]

        #region [ Constructors ]
        
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions,
            ICurrentUserService currentUserService,
            IDateTime dateTime) : base(options, operationalStoreOptions)
        {
            _currentUserService = currentUserService;
            _dateTime = dateTime;
        }

        #endregion [ Constructors ]

        #region [ Methods Unit of Work ]

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {

                int userId = _currentUserService.UserId?? -1;
                string userName = "Anonymous User";
                if (entry.State == EntityState.Added)
                    userName = (userId <= 0) ? "Anonymous User" : _currentUserService.UserName;
                
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = userName;
                        entry.Entity.CreatedDate = _dateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.UpdatedBy = userName;
                        entry.Entity.UpdatedDate = _dateTime.Now;
                        break;
                }
            }
            
            return base.SaveChangesAsync(cancellationToken);
        }

        public async Task BeginTransactionAsync()
        {
            if (_currentTransaction != null)
            {
                return;
            }

            _currentTransaction = await base.Database.BeginTransactionAsync(IsolationLevel.ReadCommitted).ConfigureAwait(false);
        }

        public async Task CommitTransactionAsync()
        {
            try
            {
                await SaveChangesAsync().ConfigureAwait(false);

                _currentTransaction?.Commit();
            }
            catch
            {
                RollbackTransaction();
                throw;
            }
            finally
            {
                if (_currentTransaction != null)
                {
                    _currentTransaction.Dispose();
                    _currentTransaction = null;
                }
            }
        }

        public void RollbackTransaction()
        {
            try
            {
                _currentTransaction?.Rollback();
                //_currentTransaction?.RollbackAsync();
            }
            finally
            {
                if (_currentTransaction != null)
                {
                    _currentTransaction.Dispose();
                    _currentTransaction = null;
                }
            }
        }

        #endregion [ Methods Unit of Work ]

        #region [ Methods Configuration database ]

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ReplaceService<IMigrationsAnnotationProvider, CustomAnnotationProvider>();
            optionsBuilder.ReplaceService<IMigrationsSqlGenerator, CustomSqlServerMigrationsSqlGenerator>();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
            builder.ApplyAllConfigurations<ApplicationDbContext>();
            builder.CascadeAllRelationsOnDelete();
            base.OnModelCreating(builder);

            builder.SeedMasterData();

        }

        #endregion [ Methods Configuration database ]

    }

}
