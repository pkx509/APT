using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GFCA.Infrastructure.Persistence.Migrations
{
    public partial class changevaluetovaluableintradeactivity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value",
                schema: "dbo",
                table: "TradeActivity",
                newName: "Valuable");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 499, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Channel",
                keyColumn: "ChannelId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 496, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Channel",
                keyColumn: "ChannelId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 496, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Channel",
                keyColumn: "ChannelId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 496, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Channel",
                keyColumn: "ChannelId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 496, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Channel",
                keyColumn: "ChannelId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 496, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Channel",
                keyColumn: "ChannelId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 496, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 495, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DocumentType",
                keyColumn: "DocumentTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 475, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DocumentType",
                keyColumn: "DocumentTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 489, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DocumentType",
                keyColumn: "DocumentTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 489, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DocumentType",
                keyColumn: "DocumentTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 489, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "DocumentType",
                keyColumn: "DocumentTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 489, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 500, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 500, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 500, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 500, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 500, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 500, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 500, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 500, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 500, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 500, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Supplier",
                keyColumn: "SupplierId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 494, DateTimeKind.Local).AddTicks(1340));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Supplier",
                keyColumn: "SupplierId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 494, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "TradeInvesment",
                keyColumn: "TradeInvesmentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 497, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "TradeInvesment",
                keyColumn: "TradeInvesmentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 24, 18, 40, 45, 497, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Workflow",
                keyColumn: "WorkflowId",
                keyValue: 1,
                columns: new[] { "BeginDate", "CreatedDate" },
                values: new object[] { new DateTime(2021, 5, 24, 18, 40, 45, 511, DateTimeKind.Local).AddTicks(8910), new DateTime(2021, 5, 24, 18, 40, 45, 512, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Workflow",
                keyColumn: "WorkflowId",
                keyValue: 2,
                columns: new[] { "BeginDate", "CreatedDate" },
                values: new object[] { new DateTime(2021, 5, 24, 18, 40, 45, 512, DateTimeKind.Local).AddTicks(2490), new DateTime(2021, 5, 24, 18, 40, 45, 512, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Workflow",
                keyColumn: "WorkflowId",
                keyValue: 3,
                columns: new[] { "BeginDate", "CreatedDate" },
                values: new object[] { new DateTime(2021, 5, 24, 18, 40, 45, 512, DateTimeKind.Local).AddTicks(2890), new DateTime(2021, 5, 24, 18, 40, 45, 512, DateTimeKind.Local).AddTicks(2970) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Valuable",
                schema: "dbo",
                table: "TradeActivity",
                newName: "Value");

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
        }
    }
}
