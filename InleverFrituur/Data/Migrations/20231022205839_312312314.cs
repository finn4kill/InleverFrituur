using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InleverFrituur.Data.Migrations
{
    /// <inheritdoc />
    public partial class _312312314 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
