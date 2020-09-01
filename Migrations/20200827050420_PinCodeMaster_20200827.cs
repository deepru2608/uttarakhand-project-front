using Microsoft.EntityFrameworkCore.Migrations;

namespace uttarakhand_project_front.Migrations
{
    public partial class PinCodeMaster_20200827 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PincodeMaster",
                columns: table => new
                {
                    PincodeValue = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PincodeMaster", x => x.PincodeValue);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PincodeMaster");
        }
    }
}
