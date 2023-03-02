using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataAdditition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("00966db1-31e3-4003-affc-c27257a3e1d0"), "travel", "London", new DateTime(2023, 10, 2, 16, 45, 55, 854, DateTimeKind.Utc).AddTicks(4791), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" },
                    { new Guid("394143f9-9b69-4f5b-8fb5-b552b1d41dc3"), "drinks", "London", new DateTime(2023, 8, 2, 16, 45, 55, 854, DateTimeKind.Utc).AddTicks(4775), "Activity 5 months in future", "Future Activity 5", "Just another pub" },
                    { new Guid("6de34304-6ab7-49c9-84bb-4ba8a0fa9f05"), "culture", "Paris", new DateTime(2023, 2, 2, 16, 45, 55, 854, DateTimeKind.Utc).AddTicks(4758), "Activity 1 month ago", "Past Activity 2", "Louvre" },
                    { new Guid("be4cefd3-eb84-4624-909f-a011eec20e2c"), "music", "London", new DateTime(2023, 9, 2, 16, 45, 55, 854, DateTimeKind.Utc).AddTicks(4788), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" },
                    { new Guid("c531332b-392f-4ff5-96e7-515732985617"), "drinks", "London", new DateTime(2023, 7, 2, 16, 45, 55, 854, DateTimeKind.Utc).AddTicks(4772), "Activity 4 months in future", "Future Activity 4", "Yet another pub" },
                    { new Guid("c67701c2-92e8-45ca-ab04-538c5f95a711"), "culture", "London", new DateTime(2023, 4, 2, 16, 45, 55, 854, DateTimeKind.Utc).AddTicks(4763), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" },
                    { new Guid("cbf4fe24-86e5-46e8-914a-494450da5a55"), "film", "London", new DateTime(2023, 11, 2, 16, 45, 55, 854, DateTimeKind.Utc).AddTicks(4794), "Activity 8 months in future", "Future Activity 8", "Cinema" },
                    { new Guid("cdc4a30d-1e68-4a82-b896-0fc775485496"), "drinks", "London", new DateTime(2023, 6, 2, 16, 45, 55, 854, DateTimeKind.Utc).AddTicks(4770), "Activity 3 months in future", "Future Activity 3", "Another pub" },
                    { new Guid("f03a6fc7-ecf7-4332-8c07-bb9949fde259"), "music", "London", new DateTime(2023, 5, 2, 16, 45, 55, 854, DateTimeKind.Utc).AddTicks(4767), "Activity 2 months in future", "Future Activity 2", "O2 Arena" },
                    { new Guid("f892b173-da9a-43d4-8653-d4cf2556651d"), "drinks", "London", new DateTime(2023, 1, 2, 16, 45, 55, 854, DateTimeKind.Utc).AddTicks(4747), "Activity 2 months ago", "Past Activity 1", "Pub" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("00966db1-31e3-4003-affc-c27257a3e1d0"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("394143f9-9b69-4f5b-8fb5-b552b1d41dc3"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("6de34304-6ab7-49c9-84bb-4ba8a0fa9f05"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("be4cefd3-eb84-4624-909f-a011eec20e2c"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("c531332b-392f-4ff5-96e7-515732985617"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("c67701c2-92e8-45ca-ab04-538c5f95a711"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("cbf4fe24-86e5-46e8-914a-494450da5a55"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("cdc4a30d-1e68-4a82-b896-0fc775485496"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("f03a6fc7-ecf7-4332-8c07-bb9949fde259"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("f892b173-da9a-43d4-8653-d4cf2556651d"));
        }
    }
}
