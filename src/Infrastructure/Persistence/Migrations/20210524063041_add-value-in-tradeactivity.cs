using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GFCA.Infrastructure.Persistence.Migrations
{
    public partial class addvalueintradeactivity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                schema: "dbo",
                table: "TradeActivity",
                type: "varchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(max)",
                oldNullable: true)
                .Annotation("ColumnOrder", 15)
                .OldAnnotation("ColumnOrder", 14);

            migrationBuilder.AddColumn<string>(
                name: "Value",
                schema: "dbo",
                table: "TradeActivity",
                type: "varchar(50)",
                nullable: true)
                .Annotation("ColumnOrder", 14);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 436, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Channel",
                keyColumn: "ChannelId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Channel",
                keyColumn: "ChannelId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Channel",
                keyColumn: "ChannelId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Channel",
                keyColumn: "ChannelId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Channel",
                keyColumn: "ChannelId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Channel",
                keyColumn: "ChannelId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 433, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DocumentType",
                keyColumn: "DocumentTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 408, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DocumentType",
                keyColumn: "DocumentTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 426, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DocumentType",
                keyColumn: "DocumentTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 426, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DocumentType",
                keyColumn: "DocumentTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 426, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DocumentType",
                keyColumn: "DocumentTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 426, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 437, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 437, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 437, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 437, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 437, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 437, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 437, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 437, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 437, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 437, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Supplier",
                keyColumn: "SupplierId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 431, DateTimeKind.Local).AddTicks(3150));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Supplier",
                keyColumn: "SupplierId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 431, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "TradeInvesment",
                keyColumn: "TradeInvesmentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 434, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "TradeInvesment",
                keyColumn: "TradeInvesmentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 13, 30, 40, 434, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Workflow",
                keyColumn: "WorkflowId",
                keyValue: 1,
                columns: new[] { "BeginDate", "CreatedDate" },
                values: new object[] { new DateTime(2021, 5, 24, 13, 30, 40, 450, DateTimeKind.Local).AddTicks(1810), new DateTime(2021, 5, 24, 13, 30, 40, 450, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Workflow",
                keyColumn: "WorkflowId",
                keyValue: 2,
                columns: new[] { "BeginDate", "CreatedDate" },
                values: new object[] { new DateTime(2021, 5, 24, 13, 30, 40, 450, DateTimeKind.Local).AddTicks(6060), new DateTime(2021, 5, 24, 13, 30, 40, 450, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Workflow",
                keyColumn: "WorkflowId",
                keyValue: 3,
                columns: new[] { "BeginDate", "CreatedDate" },
                values: new object[] { new DateTime(2021, 5, 24, 13, 30, 40, 450, DateTimeKind.Local).AddTicks(6490), new DateTime(2021, 5, 24, 13, 30, 40, 450, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 1,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 2,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 3,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 4,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 5,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 6,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 7,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 8,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 9,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 10,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 11,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 12,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 13,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 14,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 15,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 16,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 17,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 18,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 19,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 20,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 21,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 22,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 23,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 24,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 25,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 26,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 27,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 28,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 29,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 30,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 31,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 32,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 33,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 34,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 35,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 36,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 37,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 38,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 39,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 40,
                column: "BeginDate",
                value: new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                schema: "dbo",
                table: "TradeActivity");

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                schema: "dbo",
                table: "TradeActivity",
                type: "varchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(max)",
                oldNullable: true)
                .Annotation("ColumnOrder", 14)
                .OldAnnotation("ColumnOrder", 15);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 319, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Channel",
                keyColumn: "ChannelId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 317, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Channel",
                keyColumn: "ChannelId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 317, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Channel",
                keyColumn: "ChannelId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 317, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Channel",
                keyColumn: "ChannelId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 317, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Channel",
                keyColumn: "ChannelId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 317, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Channel",
                keyColumn: "ChannelId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 317, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 316, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DocumentType",
                keyColumn: "DocumentTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 290, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DocumentType",
                keyColumn: "DocumentTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 309, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DocumentType",
                keyColumn: "DocumentTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 309, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DocumentType",
                keyColumn: "DocumentTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 309, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DocumentType",
                keyColumn: "DocumentTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 309, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 321, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 321, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 321, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 321, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 321, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 321, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 321, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 321, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 321, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 321, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Supplier",
                keyColumn: "SupplierId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 314, DateTimeKind.Local).AddTicks(3620));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Supplier",
                keyColumn: "SupplierId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 314, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "TradeInvesment",
                keyColumn: "TradeInvesmentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 317, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "TradeInvesment",
                keyColumn: "TradeInvesmentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 16, 16, 37, 1, 317, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Workflow",
                keyColumn: "WorkflowId",
                keyValue: 1,
                columns: new[] { "BeginDate", "CreatedDate" },
                values: new object[] { new DateTime(2021, 5, 16, 16, 37, 1, 333, DateTimeKind.Local).AddTicks(4140), new DateTime(2021, 5, 16, 16, 37, 1, 333, DateTimeKind.Local).AddTicks(9470) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Workflow",
                keyColumn: "WorkflowId",
                keyValue: 2,
                columns: new[] { "BeginDate", "CreatedDate" },
                values: new object[] { new DateTime(2021, 5, 16, 16, 37, 1, 333, DateTimeKind.Local).AddTicks(8910), new DateTime(2021, 5, 16, 16, 37, 1, 333, DateTimeKind.Local).AddTicks(9470) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Workflow",
                keyColumn: "WorkflowId",
                keyValue: 3,
                columns: new[] { "BeginDate", "CreatedDate" },
                values: new object[] { new DateTime(2021, 5, 16, 16, 37, 1, 333, DateTimeKind.Local).AddTicks(9400), new DateTime(2021, 5, 16, 16, 37, 1, 333, DateTimeKind.Local).AddTicks(9470) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 1,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 2,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 3,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 4,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 5,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 6,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 7,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 8,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 9,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 10,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 11,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 12,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 13,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 14,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 15,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 16,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 17,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 18,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 19,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 20,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 21,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 22,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 23,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 24,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 25,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 26,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 27,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 28,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 29,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 30,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 31,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 32,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 33,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 34,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 35,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 36,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 37,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 38,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 39,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "WorkflowState",
                keyColumn: "WorkflowStateId",
                keyValue: 40,
                column: "BeginDate",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
