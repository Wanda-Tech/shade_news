using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewsWebsite.Migrations
{
    /// <inheritdoc />
    public partial class shadeCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "user_id",
                keyValue: 1,
                column: "email",
                value: "fonutchi87@gmail.com");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "user_id",
                keyValue: 1,
                column: "email",
                value: "fonutchi87@gmail.com");
        }
    }
}
