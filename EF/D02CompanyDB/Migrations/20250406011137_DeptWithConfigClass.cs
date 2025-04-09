using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace D02CompanyDB.Migrations
{
    /// <inheritdoc />
    public partial class DeptWithConfigClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    deptID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    YearOfCreation = table.Column<int>(type: "int", nullable: false, defaultValue: 2025)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.deptID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
