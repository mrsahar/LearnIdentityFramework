using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnIdentityFramework.Migrations
{
    /// <inheritdoc />
    public partial class addfirstName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "AspNetUsers",
                newName: "FirstName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "AspNetUsers",
                newName: "firstName");
        }
    }
}
