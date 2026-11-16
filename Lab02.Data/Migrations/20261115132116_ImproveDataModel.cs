using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab02.Data.Migrations
{
    /// <inheritdoc />
    public partial class ImproveDataModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Masters_Phone",
                table: "Masters",
                column: "Phone",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Masters_Phone",
                table: "Masters");
        }
    }
}
