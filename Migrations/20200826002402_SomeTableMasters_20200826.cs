using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace uttarakhand_project_front.Migrations
{
    public partial class SomeTableMasters_20200826 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GradutionMaxMarks",
                table: "RegistrationMaster");

            migrationBuilder.DropColumn(
                name: "GradutionName",
                table: "RegistrationMaster");

            migrationBuilder.DropColumn(
                name: "GradutionObtMarks",
                table: "RegistrationMaster");

            migrationBuilder.DropColumn(
                name: "GradutionPassingYear",
                table: "RegistrationMaster");

            migrationBuilder.DropColumn(
                name: "GradutionPercentageMarks",
                table: "RegistrationMaster");

            migrationBuilder.DropColumn(
                name: "GradutionStream",
                table: "RegistrationMaster");

            migrationBuilder.DropColumn(
                name: "GradutionUniversity",
                table: "RegistrationMaster");

            migrationBuilder.DropColumn(
                name: "PGradutionMaxMarks",
                table: "RegistrationMaster");

            migrationBuilder.DropColumn(
                name: "PGradutionObtMarks",
                table: "RegistrationMaster");

            migrationBuilder.DropColumn(
                name: "PGradutionPassingYear",
                table: "RegistrationMaster");

            migrationBuilder.DropColumn(
                name: "PGradutionPercentageMarks",
                table: "RegistrationMaster");

            migrationBuilder.DropColumn(
                name: "PGradutionStream",
                table: "RegistrationMaster");

            migrationBuilder.DropColumn(
                name: "PGradutionUniversity",
                table: "RegistrationMaster");

            migrationBuilder.DropColumn(
                name: "PostGradutionName",
                table: "RegistrationMaster");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "RegistrationMaster",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTimeStamp",
                table: "RegistrationMaster",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "IsActive",
                table: "RegistrationMaster",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "QualifyingUniqueId",
                table: "RegistrationMaster",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "RegistrationMaster",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTimeStamp",
                table: "RegistrationMaster",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "ExamCenterMaster",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CenterName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamCenterMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QualifyingExamDetailsMaster",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CourseName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QualifyingExamDetailsMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QualifyingExamMaster",
                columns: table => new
                {
                    UniqueId = table.Column<string>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefNo = table.Column<string>(nullable: false),
                    CourseName = table.Column<string>(nullable: false),
                    QualifyingType = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Stream = table.Column<string>(nullable: false),
                    University = table.Column<string>(nullable: false),
                    PassingYear = table.Column<string>(nullable: false),
                    MaxMarks = table.Column<string>(nullable: false),
                    ObtMarks = table.Column<string>(nullable: false),
                    PercentageMarks = table.Column<string>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QualifyingExamMaster", x => x.UniqueId);
                });

            migrationBuilder.InsertData(
                table: "ExamCenterMaster",
                columns: new[] { "Id", "CenterName" },
                values: new object[,]
                {
                    { 1, "Almora" },
                    { 14, "Berinag" },
                    { 13, "Kichha" },
                    { 12, "Lohaghat" },
                    { 10, "Khatima" },
                    { 9, "Ranikhet" },
                    { 8, "Rudrapur" },
                    { 11, "Dwarahat" },
                    { 6, "Pithoragarh" },
                    { 5, "Nainital" },
                    { 4, "Kashipur" },
                    { 3, "Haldwani" },
                    { 2, "Bageshwar" },
                    { 7, "Ram Nagar" }
                });

            migrationBuilder.InsertData(
                table: "QualifyingExamDetailsMaster",
                columns: new[] { "Id", "CourseName", "Name" },
                values: new object[,]
                {
                    { 9, "M_Ed_Theory", "B.Sc. B.Ed. Theory" },
                    { 14, "M_Ed_Practical", "D.EI.Ed. Practical" },
                    { 13, "M_Ed_Practical", "B.EI.Ed. Practical" },
                    { 12, "M_Ed_Practical", "L.T. Practical" },
                    { 11, "M_Ed_Practical", "B.T. Practical" },
                    { 10, "M_Ed_Practical", "B.Ed. Practical" },
                    { 8, "M_Ed_Theory", "B.A B.Ed. Theory" },
                    { 1, "B_Ed", "Graduation" },
                    { 6, "M_Ed_Theory", "B.EI.Ed. Theory" },
                    { 5, "M_Ed_Theory", "L.T. Theory" },
                    { 4, "M_Ed_Theory", "B.T. Theory" },
                    { 3, "M_Ed_Theory", "B.Ed. Theory" },
                    { 2, "B_Ed", "Post Graduation" },
                    { 15, "M_Ed_Practical", "B.A B.Ed. Practical" },
                    { 7, "M_Ed_Theory", "D.EI.Ed. Theory" },
                    { 16, "M_Ed_Practical", "B.Sc. B.Ed. Practical" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExamCenterMaster");

            migrationBuilder.DropTable(
                name: "QualifyingExamDetailsMaster");

            migrationBuilder.DropTable(
                name: "QualifyingExamMaster");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "RegistrationMaster");

            migrationBuilder.DropColumn(
                name: "CreatedTimeStamp",
                table: "RegistrationMaster");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "RegistrationMaster");

            migrationBuilder.DropColumn(
                name: "QualifyingUniqueId",
                table: "RegistrationMaster");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "RegistrationMaster");

            migrationBuilder.DropColumn(
                name: "UpdatedTimeStamp",
                table: "RegistrationMaster");

            migrationBuilder.AddColumn<string>(
                name: "GradutionMaxMarks",
                table: "RegistrationMaster",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GradutionName",
                table: "RegistrationMaster",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GradutionObtMarks",
                table: "RegistrationMaster",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GradutionPassingYear",
                table: "RegistrationMaster",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GradutionPercentageMarks",
                table: "RegistrationMaster",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GradutionStream",
                table: "RegistrationMaster",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GradutionUniversity",
                table: "RegistrationMaster",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PGradutionMaxMarks",
                table: "RegistrationMaster",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PGradutionObtMarks",
                table: "RegistrationMaster",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PGradutionPassingYear",
                table: "RegistrationMaster",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PGradutionPercentageMarks",
                table: "RegistrationMaster",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PGradutionStream",
                table: "RegistrationMaster",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PGradutionUniversity",
                table: "RegistrationMaster",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostGradutionName",
                table: "RegistrationMaster",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
