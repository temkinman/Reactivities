using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class IsCanceledProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCancelled",
                table: "Activities",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsCancelled",
                table: "Activities");

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("4db25926-02f8-441a-8896-1aebd477cc94"), "drinks", "London", new DateTime(2023, 6, 27, 20, 36, 52, 88, DateTimeKind.Utc).AddTicks(8026), "Activity 3 months in future", "Future Activity 3", "Another pub" },
                    { new Guid("7cc67150-7801-41e6-8eae-8955c5516625"), "drinks", "London", new DateTime(2023, 7, 27, 20, 36, 52, 88, DateTimeKind.Utc).AddTicks(8028), "Activity 4 months in future", "Future Activity 4", "Yet another pub" },
                    { new Guid("805da741-504e-403a-8f1a-c89f7c8cc70f"), "music", "London", new DateTime(2023, 5, 27, 20, 36, 52, 88, DateTimeKind.Utc).AddTicks(8023), "Activity 2 months in future", "Future Activity 2", "O2 Arena" },
                    { new Guid("81d6e3ab-7501-43fd-9938-fb2d94363286"), "music", "London", new DateTime(2023, 9, 27, 20, 36, 52, 88, DateTimeKind.Utc).AddTicks(8033), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" },
                    { new Guid("968855e4-3963-41b9-80ca-c95698881845"), "drinks", "London", new DateTime(2023, 8, 27, 20, 36, 52, 88, DateTimeKind.Utc).AddTicks(8030), "Activity 5 months in future", "Future Activity 5", "Just another pub" },
                    { new Guid("9f8e6232-0253-4a30-94b5-5c32b96edc19"), "travel", "London", new DateTime(2023, 10, 27, 20, 36, 52, 88, DateTimeKind.Utc).AddTicks(8035), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" },
                    { new Guid("a153e109-2405-4de8-98af-830f35b77032"), "culture", "Paris", new DateTime(2023, 2, 27, 20, 36, 52, 88, DateTimeKind.Utc).AddTicks(8002), "Activity 1 month ago", "Past Activity 2", "Louvre" },
                    { new Guid("d43962ca-57c3-4f6e-bd3e-2056947225fd"), "culture", "London", new DateTime(2023, 4, 27, 20, 36, 52, 88, DateTimeKind.Utc).AddTicks(8021), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" },
                    { new Guid("dd08fe2d-f9f6-43e1-9e94-6d372f28040a"), "drinks", "London", new DateTime(2023, 1, 27, 20, 36, 52, 88, DateTimeKind.Utc).AddTicks(7993), "Activity 2 months ago", "Past Activity 1", "Pub" },
                    { new Guid("ecff0f2d-5789-4f25-a8ca-2163c1a437df"), "film", "London", new DateTime(2023, 11, 27, 20, 36, 52, 88, DateTimeKind.Utc).AddTicks(8038), "Activity 8 months in future", "Future Activity 8", "Cinema" }
                });
        }
    }
}
