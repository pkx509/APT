using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace Microsoft.EntityFrameworkCore.Migrations
{
    public class CustomSqlServerMigrationsSqlGenerator : Microsoft.EntityFrameworkCore.Migrations.SqlServerMigrationsSqlGenerator
    {
        internal const string DatabaseCollationName = "Thai_CI_AS";

        public CustomSqlServerMigrationsSqlGenerator(Microsoft.EntityFrameworkCore.Migrations.MigrationsSqlGeneratorDependencies dependencies, Microsoft.EntityFrameworkCore.Migrations.IMigrationsAnnotationProvider migrationsAnnotations)
            : base(dependencies, migrationsAnnotations) { }

        protected override void Generate(SqlServerCreateDatabaseOperation operation, IModel model, MigrationCommandListBuilder builder)
        {

            base.Generate(operation, model, builder);
            if (DatabaseCollationName != null)
            {
                builder
                    .Append("ALTER DATABASE ")
                    .Append(Dependencies.SqlGenerationHelper.DelimitIdentifier(operation.Name))
                    .Append(" COLLATE ")
                    .Append(DatabaseCollationName)
                    .AppendLine(Dependencies.SqlGenerationHelper.StatementTerminator)
                    .EndCommand(suppressTransaction: true);
            }

        }
        
        protected override void CreateTableColumns(CreateTableOperation operation, IModel model, MigrationCommandListBuilder builder)
        {
            operation.Columns.Sort(new ColumnOrderComparision());
            base.CreateTableColumns(operation, model, builder);
        }

        internal class ColumnOrderComparision : IComparer<AddColumnOperation>
        {
            public int Compare(AddColumnOperation x, AddColumnOperation y)
            {
                var orderX = Convert.ToInt32(x.FindAnnotation(CustomAnnotationNames.ColumnOrder)?.Value ?? 0);
                var orderY = Convert.ToInt32(y.FindAnnotation(CustomAnnotationNames.ColumnOrder)?.Value ?? 0);
                return orderX.CompareTo(orderY);
            }
        }
        
    }

}
