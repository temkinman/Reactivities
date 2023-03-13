using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class IdentityCoontext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    DisplayName = table.Column<string>(type: "text", nullable: false),
                    Bio = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
    }
}
