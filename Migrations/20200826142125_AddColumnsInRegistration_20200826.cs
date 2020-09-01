using Microsoft.EntityFrameworkCore.Migrations;

namespace uttarakhand_project_front.Migrations
{
    public partial class AddColumnsInRegistration_20200826 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IsEconomicallyWeakerSection",
                table: "RegistrationMaster",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "IsAppearing",
                table: "RegistrationMaster",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "IsKumaunUniversity",
                table: "RegistrationMaster",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAppearing",
                table: "RegistrationMaster");

            migrationBuilder.DropColumn(
                name: "IsKumaunUniversity",
                table: "RegistrationMaster");

            migrationBuilder.AlterColumn<string>(
                name: "IsEconomicallyWeakerSection",
                table: "RegistrationMaster",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
