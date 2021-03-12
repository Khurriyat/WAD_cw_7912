using Microsoft.EntityFrameworkCore.Migrations;

namespace WAD_SRP_DRY_7912.Migrations
{
    public partial class Customer_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfessionalId",
                table: "Customers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ProfessionalId",
                table: "Customers",
                column: "ProfessionalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Professionals_ProfessionalId",
                table: "Customers",
                column: "ProfessionalId",
                principalTable: "Professionals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Professionals_ProfessionalId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ProfessionalId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ProfessionalId",
                table: "Customers");
        }
    }
}
