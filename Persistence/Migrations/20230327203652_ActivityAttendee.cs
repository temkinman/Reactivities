using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ActivityAttendee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("08f9348a-00ee-45de-8131-62b7d0d3e947"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("2c816c22-39aa-429d-aa0d-1741c877cc65"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("64f1e3d4-e518-482e-988d-7403d95ae3a8"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("6b3201af-8b4e-4a81-b0c2-958ff27ed565"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("78950545-4287-40d6-bd58-55a91cd774ab"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("7f5fced4-25ac-4d95-8354-be781caa6f1b"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("9ed7a0be-7d76-49bf-9e7b-cb2f3f29cba7"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("ab6a7c91-2c22-4c1f-96b8-a15cd9349942"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("e27e820b-419a-4100-a40e-ab3578ea5ff2"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("fe5583e9-c277-4a8c-9b49-743136e50dee"));

            migrationBuilder.CreateTable(
                name: "ActivityAttendees",
                columns: table => new
                {
                    AppUserId = table.Column<string>(type: "text", nullable: false),
                    ActivityId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsHost = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityAttendees", x => new { x.AppUserId, x.ActivityId });
                    table.ForeignKey(
                        name: "FK_ActivityAttendees_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityAttendees_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ActivityAttendees_ActivityId",
                table: "ActivityAttendees",
                column: "ActivityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityAttendees");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("4db25926-02f8-441a-8896-1aebd477cc94"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("7cc67150-7801-41e6-8eae-8955c5516625"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("805da741-504e-403a-8f1a-c89f7c8cc70f"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("81d6e3ab-7501-43fd-9938-fb2d94363286"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("968855e4-3963-41b9-80ca-c95698881845"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("9f8e6232-0253-4a30-94b5-5c32b96edc19"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("a153e109-2405-4de8-98af-830f35b77032"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("d43962ca-57c3-4f6e-bd3e-2056947225fd"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("dd08fe2d-f9f6-43e1-9e94-6d372f28040a"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("ecff0f2d-5789-4f25-a8ca-2163c1a437df"));

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("08f9348a-00ee-45de-8131-62b7d0d3e947"), "drinks", "London", new DateTime(2023, 6, 13, 12, 47, 19, 772, DateTimeKind.Utc).AddTicks(8979), "Activity 3 months in future", "Future Activity 3", "Another pub" },
                    { new Guid("2c816c22-39aa-429d-aa0d-1741c877cc65"), "culture", "Paris", new DateTime(2023, 2, 13, 12, 47, 19, 772, DateTimeKind.Utc).AddTicks(8963), "Activity 1 month ago", "Past Activity 2", "Louvre" },
                    { new Guid("64f1e3d4-e518-482e-988d-7403d95ae3a8"), "drinks", "London", new DateTime(2023, 8, 13, 12, 47, 19, 772, DateTimeKind.Utc).AddTicks(8982), "Activity 5 months in future", "Future Activity 5", "Just another pub" },
                    { new Guid("6b3201af-8b4e-4a81-b0c2-958ff27ed565"), "travel", "London", new DateTime(2023, 10, 13, 12, 47, 19, 772, DateTimeKind.Utc).AddTicks(8986), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" },
                    { new Guid("78950545-4287-40d6-bd58-55a91cd774ab"), "music", "London", new DateTime(2023, 9, 13, 12, 47, 19, 772, DateTimeKind.Utc).AddTicks(8984), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" },
                    { new Guid("7f5fced4-25ac-4d95-8354-be781caa6f1b"), "film", "London", new DateTime(2023, 11, 13, 12, 47, 19, 772, DateTimeKind.Utc).AddTicks(8988), "Activity 8 months in future", "Future Activity 8", "Cinema" },
                    { new Guid("9ed7a0be-7d76-49bf-9e7b-cb2f3f29cba7"), "drinks", "London", new DateTime(2023, 7, 13, 12, 47, 19, 772, DateTimeKind.Utc).AddTicks(8981), "Activity 4 months in future", "Future Activity 4", "Yet another pub" },
                    { new Guid("ab6a7c91-2c22-4c1f-96b8-a15cd9349942"), "music", "London", new DateTime(2023, 5, 13, 12, 47, 19, 772, DateTimeKind.Utc).AddTicks(8977), "Activity 2 months in future", "Future Activity 2", "O2 Arena" },
                    { new Guid("e27e820b-419a-4100-a40e-ab3578ea5ff2"), "culture", "London", new DateTime(2023, 4, 13, 12, 47, 19, 772, DateTimeKind.Utc).AddTicks(8965), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" },
                    { new Guid("fe5583e9-c277-4a8c-9b49-743136e50dee"), "drinks", "London", new DateTime(2023, 1, 13, 12, 47, 19, 772, DateTimeKind.Utc).AddTicks(8954), "Activity 2 months ago", "Past Activity 1", "Pub" }
                });
        }
    }
}
