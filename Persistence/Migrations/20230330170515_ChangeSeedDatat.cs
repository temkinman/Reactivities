using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ChangeSeedDatat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("1301565a-484b-4039-8bce-4ae2cc3342eb"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("1f0720d2-88a2-4af8-aed0-64521833baea"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("398cba62-4b07-4c11-973a-1205db025fc0"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("776f5bde-66e4-4668-86cd-f9312e7aea02"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("7f28bc88-cc7b-4bd1-a404-130f25e5ce3a"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("8a367040-95fc-4fff-875c-ec5c5354056f"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("8ed59834-b2cf-4d38-9578-ec324037d25f"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("918039f9-d583-4cf6-ad8f-bd3b9025dc34"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("bfa06c66-f1e5-4f57-9771-af732ce8c93c"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("ebb06d95-2c82-424b-8911-d47f0f4a0424"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "IsCancelled", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("1301565a-484b-4039-8bce-4ae2cc3342eb"), "music", "London", new DateTime(2023, 9, 28, 18, 55, 44, 325, DateTimeKind.Utc).AddTicks(9051), "Activity 6 months in future", false, "Future Activity 6", "Roundhouse Camden" },
                    { new Guid("1f0720d2-88a2-4af8-aed0-64521833baea"), "travel", "London", new DateTime(2023, 10, 28, 18, 55, 44, 325, DateTimeKind.Utc).AddTicks(9053), "Activity 2 months ago", false, "Future Activity 7", "Somewhere on the Thames" },
                    { new Guid("398cba62-4b07-4c11-973a-1205db025fc0"), "music", "London", new DateTime(2023, 5, 28, 18, 55, 44, 325, DateTimeKind.Utc).AddTicks(9031), "Activity 2 months in future", false, "Future Activity 2", "O2 Arena" },
                    { new Guid("776f5bde-66e4-4668-86cd-f9312e7aea02"), "culture", "London", new DateTime(2023, 4, 28, 18, 55, 44, 325, DateTimeKind.Utc).AddTicks(9028), "Activity 1 month in future", false, "Future Activity 1", "Natural History Museum" },
                    { new Guid("7f28bc88-cc7b-4bd1-a404-130f25e5ce3a"), "culture", "Paris", new DateTime(2023, 2, 28, 18, 55, 44, 325, DateTimeKind.Utc).AddTicks(9025), "Activity 1 month ago", false, "Past Activity 2", "Louvre" },
                    { new Guid("8a367040-95fc-4fff-875c-ec5c5354056f"), "film", "London", new DateTime(2023, 11, 28, 18, 55, 44, 325, DateTimeKind.Utc).AddTicks(9054), "Activity 8 months in future", false, "Future Activity 8", "Cinema" },
                    { new Guid("8ed59834-b2cf-4d38-9578-ec324037d25f"), "drinks", "London", new DateTime(2023, 6, 28, 18, 55, 44, 325, DateTimeKind.Utc).AddTicks(9044), "Activity 3 months in future", false, "Future Activity 3", "Another pub" },
                    { new Guid("918039f9-d583-4cf6-ad8f-bd3b9025dc34"), "drinks", "London", new DateTime(2023, 1, 28, 18, 55, 44, 325, DateTimeKind.Utc).AddTicks(9016), "Activity 2 months ago", false, "Past Activity 1", "Pub" },
                    { new Guid("bfa06c66-f1e5-4f57-9771-af732ce8c93c"), "drinks", "London", new DateTime(2023, 8, 28, 18, 55, 44, 325, DateTimeKind.Utc).AddTicks(9049), "Activity 5 months in future", false, "Future Activity 5", "Just another pub" },
                    { new Guid("ebb06d95-2c82-424b-8911-d47f0f4a0424"), "drinks", "London", new DateTime(2023, 7, 28, 18, 55, 44, 325, DateTimeKind.Utc).AddTicks(9046), "Activity 4 months in future", false, "Future Activity 4", "Yet another pub" }
                });
        }
    }
}
