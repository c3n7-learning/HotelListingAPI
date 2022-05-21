using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0251a584-ba37-4da5-a7f7-bb16e83e9646", "7ebac7b3-43ac-4792-b6d4-b6edcea934ac", "User", "USER" },
                    { "3f1d323a-499a-4d7f-9824-bbe10b105cbb", "4789c4e5-69bf-4983-8cd9-84d6d10d7518", "Administrator", "ADMINISTRATOR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0251a584-ba37-4da5-a7f7-bb16e83e9646");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f1d323a-499a-4d7f-9824-bbe10b105cbb");
        }
    }
}
