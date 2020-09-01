using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace uttarakhand_project_front.Migrations
{
    public partial class AddPaymentTable_20200829 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentMaster",
                columns: table => new
                {
                    UniqueId = table.Column<string>(nullable: false),
                    RegPayId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefNo = table.Column<string>(nullable: true),
                    OrderId = table.Column<string>(nullable: false),
                    Fee = table.Column<int>(nullable: false),
                    ServiceCharge = table.Column<int>(nullable: false),
                    TotalFee = table.Column<int>(nullable: false),
                    PaidStatus = table.Column<int>(nullable: false, defaultValue: 0),
                    PaidBy = table.Column<string>(nullable: true),
                    PaidOn = table.Column<DateTime>(nullable: false),
                    TransactionId = table.Column<string>(nullable: true),
                    TransactionPaymentId = table.Column<string>(nullable: true),
                    PaymentMethod = table.Column<string>(nullable: true),
                    RequestId = table.Column<string>(nullable: true),
                    ResponseCode = table.Column<string>(nullable: true),
                    ResponseMessage = table.Column<string>(nullable: true),
                    MerchantRefNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMaster", x => x.UniqueId);
                    table.ForeignKey(
                        name: "FK_PaymentMaster_RegistrationMaster_RefNo",
                        column: x => x.RefNo,
                        principalTable: "RegistrationMaster",
                        principalColumn: "RefNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMaster_RefNo",
                table: "PaymentMaster",
                column: "RefNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentMaster");
        }
    }
}
