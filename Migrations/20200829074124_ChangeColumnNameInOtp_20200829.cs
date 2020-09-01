using Microsoft.EntityFrameworkCore.Migrations;

namespace uttarakhand_project_front.Migrations
{
    public partial class ChangeColumnNameInOtp_20200829 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "OtpTableMaster");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "OtpTableMaster",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "OtpTableMaster");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "OtpTableMaster",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
