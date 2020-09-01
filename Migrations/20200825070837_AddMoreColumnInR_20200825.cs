using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace uttarakhand_project_front.Migrations
{
    public partial class AddMoreColumnInR_20200825 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FinalSubmitTimeStamp",
                table: "RegistrationMaster",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "IsFinalSubmit",
                table: "RegistrationMaster",
                nullable: false,
                defaultValue: "No");

            migrationBuilder.AddColumn<string>(
                name: "IsPaymentDone",
                table: "RegistrationMaster",
                nullable: false,
                defaultValue: "No");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinalSubmitTimeStamp",
                table: "RegistrationMaster");

            migrationBuilder.DropColumn(
                name: "IsFinalSubmit",
                table: "RegistrationMaster");

            migrationBuilder.DropColumn(
                name: "IsPaymentDone",
                table: "RegistrationMaster");
        }
    }
}
