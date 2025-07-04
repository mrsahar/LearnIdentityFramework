using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnIdentityFramework.Migrations
{
    /// <inheritdoc />
    public partial class addfandLName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "firstName",
                table: "AspNetUsers",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "firstName",
                table: "AspNetUsers");
        }
    }
}
