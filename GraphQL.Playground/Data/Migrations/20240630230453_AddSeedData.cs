using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraphQL.Playground.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name", "Description", "Review", "DateAdded", "DateUpdated" },
                values: new object[] { 1, "GraphQL", "GraphQL is a query language for APIs and a runtime for executing those queries by using a type system you define for your data.", 5, "2024-06-30 23:04:53", "2024-06-30 23:04:53" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name", "Description", "Review", "DateAdded", "DateUpdated" },
                values: new object[] { 2, "Entity Framework Core", "Entity Framework Core is a modern object-database mapper for .NET. It supports LINQ queries, change tracking, updates, and schema migrations.", 4, "2024-06-30 23:04:53", "2024-06-30 23:04:53" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name", "Description", "Review", "DateAdded", "DateUpdated" },
                values: new object[] { 3, "ASP.NET Core", "ASP.NET Core is a cross-platform, high-performance, open-source framework for building modern, cloud-based, Internet-connected applications.", 4, "2024-06-30 23:04:53", "2024-06-30 23:04:53" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValues: new object[] { 1 });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValues: new object[] { 2 });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValues: new object[] { 3 });
        }
    }
}
