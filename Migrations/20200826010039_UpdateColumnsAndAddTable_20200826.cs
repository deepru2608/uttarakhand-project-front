using Microsoft.EntityFrameworkCore.Migrations;

namespace uttarakhand_project_front.Migrations
{
    public partial class UpdateColumnsAndAddTable_20200826 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QualifyingUniqueId",
                table: "RegistrationMaster");

            migrationBuilder.CreateTable(
                name: "CourseMaster",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CourseName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseMaster", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CourseMaster",
                columns: new[] { "Id", "CourseName" },
                values: new object[] { "B.Ed", "Bachelor of Education" });

            migrationBuilder.InsertData(
                table: "CourseMaster",
                columns: new[] { "Id", "CourseName" },
                values: new object[] { "M.Ed", "Master of Education" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseMaster");

            migrationBuilder.AddColumn<string>(
                name: "QualifyingUniqueId",
                table: "RegistrationMaster",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
