using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace uttarakhand_project_front.Migrations
{
    public partial class ChangeConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IsPaymentDone",
                table: "RegistrationMaster",
                nullable: true,
                defaultValue: "No",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "No");

            migrationBuilder.AlterColumn<string>(
                name: "IsFinalSubmit",
                table: "RegistrationMaster",
                nullable: true,
                defaultValue: "No",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "No");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FinalSubmitTimeStamp",
                table: "RegistrationMaster",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AddColumn<DateTime>(
                name: "PaymentDoneTimeStamp",
                table: "RegistrationMaster",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentDoneTimeStamp",
                table: "RegistrationMaster");

            migrationBuilder.AlterColumn<string>(
                name: "IsPaymentDone",
                table: "RegistrationMaster",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "No",
                oldClrType: typeof(string),
                oldNullable: true,
                oldDefaultValue: "No");

            migrationBuilder.AlterColumn<string>(
                name: "IsFinalSubmit",
                table: "RegistrationMaster",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "No",
                oldClrType: typeof(string),
                oldNullable: true,
                oldDefaultValue: "No");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FinalSubmitTimeStamp",
                table: "RegistrationMaster",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
