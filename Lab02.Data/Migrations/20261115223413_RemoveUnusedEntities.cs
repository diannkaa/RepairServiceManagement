using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab02.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUnusedEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RepairPayments");

            migrationBuilder.DropTable(
                name: "RequestParts");

            migrationBuilder.DropTable(
                name: "Parts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parts",
                columns: table => new
                {
                    PartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parts", x => x.PartId);
                });

            migrationBuilder.CreateTable(
                name: "RepairPayments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairPayments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_RepairPayments_RepairRequests_RequestId",
                        column: x => x.RequestId,
                        principalTable: "RepairRequests",
                        principalColumn: "RequestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestParts",
                columns: table => new
                {
                    RequestId = table.Column<int>(type: "int", nullable: false),
                    PartId = table.Column<int>(type: "int", nullable: false),
                    QuantityUsed = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestParts", x => new { x.RequestId, x.PartId });
                    table.ForeignKey(
                        name: "FK_RequestParts_Parts_PartId",
                        column: x => x.PartId,
                        principalTable: "Parts",
                        principalColumn: "PartId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequestParts_RepairRequests_RequestId",
                        column: x => x.RequestId,
                        principalTable: "RepairRequests",
                        principalColumn: "RequestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RepairPayments_RequestId",
                table: "RepairPayments",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestParts_PartId",
                table: "RequestParts",
                column: "PartId");
        }
    }
}
