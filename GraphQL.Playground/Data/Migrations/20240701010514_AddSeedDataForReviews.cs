using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraphQL.Playground.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedDataForReviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Rating", "Comment", "CourseId" },
                values: new object[] { 1, 5, "Great course!", 1 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Rating", "Comment", "CourseId" },
                values: new object[] { 2, 4, "Good course!", 1 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Rating", "Comment", "CourseId" },
                values: new object[] { 3, 3, "Average course!", 1 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Rating", "Comment", "CourseId" },
                values: new object[] { 4, 2, "Bad course!", 1 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Rating", "Comment", "CourseId" },
                values: new object[] { 5, 1, "Terrible course!", 1 });
            
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Rating", "Comment", "CourseId" },
                values: new object[] { 6, 5, "Great course!", 2 });
            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);
            
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
