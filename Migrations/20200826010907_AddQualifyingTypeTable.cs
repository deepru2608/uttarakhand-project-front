using Microsoft.EntityFrameworkCore.Migrations;

namespace uttarakhand_project_front.Migrations
{
    public partial class AddQualifyingTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QualifyingTypeMaster",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QualifyingTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QualifyingTypeMaster", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "QualifyingTypeMaster",
                columns: new[] { "Id", "QualifyingTypeName" },
                values: new object[,]
                {
                    { 1, "Graduation" },
                    { 2, "Post Graduation" },
                    { 3, "Theory Exam" },
                    { 4, "Practical Exam" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QualifyingTypeMaster");
        }
    }
}
