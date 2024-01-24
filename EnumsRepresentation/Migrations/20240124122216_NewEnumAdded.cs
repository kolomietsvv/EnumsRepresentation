using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnumsRepresentation.Migrations
{
    /// <inheritdoc />
    public partial class NewEnumAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CarTypeEntity",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "описание для типа можно взять из аттрибута NewAdded", "NewAdded" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarTypeEntity",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
