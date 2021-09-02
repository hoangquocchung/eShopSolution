using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ProductImageDataSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "7ac4d3aa-bf95-4d62-8d96-58a251bb2621");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "15908158-1b31-44b9-9261-b209d2608abc", "AQAAAAEAACcQAAAAEL3A3scgjunX3ohMfSORcL/+FHZsJIVoA66SpdYK5BtR239xnUVXSgm1R6DdhCGRqw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 2, 18, 4, 6, 392, DateTimeKind.Local).AddTicks(8430));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "9a9c27ab-151f-4b60-ac1b-78e562aefee8");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "062ef1fe-4ee0-4a71-a20e-3e23360cce19", "AQAAAAEAACcQAAAAEHJ36+/Dwp54XMX26naZQYXaeZNbtgfgqXI//2VRAg+Bmx+CBqpTGrGPTywwExXv3A==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 2, 18, 1, 32, 243, DateTimeKind.Local).AddTicks(5656));
        }
    }
}
