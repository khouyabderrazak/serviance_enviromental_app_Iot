using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projetiot.Migrations
{
    /// <inheritdoc />
    public partial class updateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Pression",
                table: "IOTdatas",
                newName: "vitesse");

            migrationBuilder.AddColumn<string>(
                name: "soleil",
                table: "IOTdatas",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "soleil",
                table: "IOTdatas");

            migrationBuilder.RenameColumn(
                name: "vitesse",
                table: "IOTdatas",
                newName: "Pression");
        }
    }
}
