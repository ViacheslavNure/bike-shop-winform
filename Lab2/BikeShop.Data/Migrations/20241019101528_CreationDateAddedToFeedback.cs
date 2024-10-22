using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BikeShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreationDateAddedToFeedback : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Feedback",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_BikeType_Name",
                table: "BikeType",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_BikeType_Name",
                table: "BikeType");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Feedback");
        }
    }
}
