using System;
namespace Microsoft.EntityFrameworkCore.SqlServer
{
    public class SqlColumnFor
    {
        public const string Id = "int";
        public const string Mesurement = "numeric(8,2)";
        public const string Value = "numeric(13,4)";
        public const string Year = "int";
        public const string Month = "int";
        public const string Code = "varchar(50)";
        public const string CodeRef = "varchar(200)";
        public const string CombineCode = "varchar(150)";
        public const string Name = "varchar(100)";
        public const string Description = "varchar(max)";
        public const string Date = "date";
        public const string DateTime = "datetime2";
        public const string Sort = "int";
        public const string Checker = "bit";
        public const string Marker = "varchar(1)"; //bit
    }
}
