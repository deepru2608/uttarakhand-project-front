using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace uttarakhand_project_front.Migrations
{
    public partial class AddTablesInDb_20200829 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "QualifyingExamDetailsMaster",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeStamp",
                table: "QualifyingExamDetailsMaster",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "CourseMaster",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeStamp",
                table: "CourseMaster",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "OtpTableMaster",
                columns: table => new
                {
                    UniqueId = table.Column<string>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Otp = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    IsValid = table.Column<bool>(nullable: false, defaultValue: false),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtpTableMaster", x => x.UniqueId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OtpTableMaster");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "QualifyingExamDetailsMaster");

            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "QualifyingExamDetailsMaster");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "CourseMaster");

            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "CourseMaster");
        }
    }
}
