using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeaShopApi.DataAccessLayer.Migrations
{
    public partial class mig_first2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DringImageUrl",
                table: "Drinks",
                newName: "DrinkImageUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DrinkImageUrl",
                table: "Drinks",
                newName: "DringImageUrl");
        }
    }
}
