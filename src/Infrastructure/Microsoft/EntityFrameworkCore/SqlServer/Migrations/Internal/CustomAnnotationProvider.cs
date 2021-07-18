using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
//using Microsoft.EntityFrameworkCore.Migrations;

namespace Microsoft.EntityFrameworkCore.SqlServer.Migrations.Internal
{
    public class CustomAnnotationProvider : Microsoft.EntityFrameworkCore.SqlServer.Migrations.Internal.SqlServerMigrationsAnnotationProvider
    {
        public CustomAnnotationProvider(Microsoft.EntityFrameworkCore.Migrations.MigrationsAnnotationProviderDependencies dependencies)
            : base(dependencies)
        {
        }

        public override IEnumerable<IAnnotation> For(IProperty property)
        {
            var baseAnnotations = base.For(property);

            var orderAnnotation = property.FindAnnotation(CustomAnnotationNames.ColumnOrder);

            return orderAnnotation == null
                ? baseAnnotations
                : baseAnnotations.Concat(new[] { orderAnnotation });
        }
    }
}
