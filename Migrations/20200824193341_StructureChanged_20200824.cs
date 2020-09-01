using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace uttarakhand_project_front.Migrations
{
    public partial class StructureChanged_20200824 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RegistrationMaster",
                table: "RegistrationMaster");

            migrationBuilder.AlterColumn<string>(
                name: "RefNo",
                table: "RegistrationMaster",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "RegistrationMaster",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegistrationMaster",
                table: "RegistrationMaster",
                column: "RefNo");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_RegistrationMaster_UniqueKey",
                table: "RegistrationMaster",
                column: "UniqueKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RegistrationMaster",
                table: "RegistrationMaster");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_RegistrationMaster_UniqueKey",
                table: "RegistrationMaster");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "RegistrationMaster",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<int>(
                name: "RefNo",
                table: "RegistrationMaster",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegistrationMaster",
                table: "RegistrationMaster",
                column: "UniqueKey");
        }
    }
}
