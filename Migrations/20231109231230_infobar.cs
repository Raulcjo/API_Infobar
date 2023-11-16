using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfobarAPI.Migrations
{
    /// <inheritdoc />
    public partial class infobar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cargo",
                table: "Colaboradores",
                type: "longtext",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cargo",
                table: "Colaboradores");
        }
    }
}
