using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Content.Server.Database.Migrations.Sqlite
{
    /// <inheritdoc />
    public partial class HeightWidths : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "height",
                table: "profile",
                type: "INTEGER",
                nullable: false,
                defaultValue: 170);

            migrationBuilder.AddColumn<int>(
                name: "width",
                table: "profile",
                type: "INTEGER",
                nullable: false,
                defaultValue: 100);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "height",
                table: "profile");

            migrationBuilder.DropColumn(
                name: "width",
                table: "profile");
        }
    }
}
