using Microsoft.EntityFrameworkCore.Migrations;

namespace Sporting2021_power.Migrations
{
    public partial class newMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Customer",
                table: "Incident");

            migrationBuilder.DropColumn(
                name: "Technician",
                table: "Incident");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Customer",
                newName: "CoID");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Incident",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Customer_id",
                table: "Incident",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TechId",
                table: "Incident",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TechnicianId",
                table: "Incident",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Customer",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CountryName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Registration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Product_id = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: true),
                    Customer_id = table.Column<int>(type: "INTEGER", nullable: false),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registration_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Registration_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Incident_CustomerId",
                table: "Incident",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Incident_TechnicianId",
                table: "Incident",
                column: "TechnicianId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CountryId",
                table: "Customer",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Registration_CustomerId",
                table: "Registration",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Registration_ProductId",
                table: "Registration",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Country_CountryId",
                table: "Customer",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Incident_Customer_CustomerId",
                table: "Incident",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Incident_Technician_TechnicianId",
                table: "Incident",
                column: "TechnicianId",
                principalTable: "Technician",
                principalColumn: "TechnicianId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Country_CountryId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Incident_Customer_CustomerId",
                table: "Incident");

            migrationBuilder.DropForeignKey(
                name: "FK_Incident_Technician_TechnicianId",
                table: "Incident");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Registration");

            migrationBuilder.DropIndex(
                name: "IX_Incident_CustomerId",
                table: "Incident");

            migrationBuilder.DropIndex(
                name: "IX_Incident_TechnicianId",
                table: "Incident");

            migrationBuilder.DropIndex(
                name: "IX_Customer_CountryId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Incident");

            migrationBuilder.DropColumn(
                name: "Customer_id",
                table: "Incident");

            migrationBuilder.DropColumn(
                name: "TechId",
                table: "Incident");

            migrationBuilder.DropColumn(
                name: "TechnicianId",
                table: "Incident");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Customer");

            migrationBuilder.RenameColumn(
                name: "CoID",
                table: "Customer",
                newName: "Country");

            migrationBuilder.AddColumn<string>(
                name: "Customer",
                table: "Incident",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Technician",
                table: "Incident",
                type: "TEXT",
                nullable: true);
        }
    }
}
