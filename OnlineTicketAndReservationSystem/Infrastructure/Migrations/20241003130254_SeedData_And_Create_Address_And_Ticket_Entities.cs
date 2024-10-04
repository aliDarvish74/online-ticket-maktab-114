using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedData_And_Create_Address_And_Ticket_Entities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDataTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Provinces_User_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Provinces_User_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TicketNumber = table.Column<string>(type: "VarChar(5)", maxLength: 5, nullable: false),
                    BuyDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 10, 3, 16, 32, 54, 75, DateTimeKind.Local).AddTicks(6742)),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SeatNumber = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDataTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_User_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tickets_User_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tickets_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDataTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cities_User_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cities_User_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PostalCode = table.Column<string>(type: "VarChar(10)", maxLength: 10, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDataTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_User_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Addresses_User_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedDateTime", "CreatedUserId", "DateOfBirth", "Email", "FirstName", "LastName", "Password", "UpdatedDataTime", "UpdatedUserId", "Username" },
                values: new object[] { new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), null, "aa@gmail.com", "kiji", "..", "123", new DateTime(2024, 10, 3, 16, 32, 54, 83, DateTimeKind.Local).AddTicks(2586), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), "user1" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "CreatedDateTime", "CreatedUserId", "Name", "UpdatedDataTime", "UpdatedUserId" },
                values: new object[] { new Guid("84c3d84b-b54f-4e03-8fc6-5130cd643c47"), new DateTime(2024, 10, 3, 16, 32, 54, 72, DateTimeKind.Local).AddTicks(3316), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), "تهران", new DateTime(2024, 10, 3, 16, 32, 54, 72, DateTimeKind.Local).AddTicks(3321), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50") });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BuyDate", "CreatedDateTime", "CreatedUserId", "SeatNumber", "TicketNumber", "UpdatedDataTime", "UpdatedUserId", "UserId" },
                values: new object[,]
                {
                    { new Guid("372ada54-8cfb-4475-8ec9-fcde8113901d"), new DateTime(2024, 10, 3, 16, 32, 54, 75, DateTimeKind.Local).AddTicks(7953), new DateTime(2024, 10, 3, 16, 32, 54, 75, DateTimeKind.Local).AddTicks(7954), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), 0, "78955", new DateTime(2024, 10, 3, 16, 32, 54, 75, DateTimeKind.Local).AddTicks(7955), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50") },
                    { new Guid("6282afc8-f82f-4d6f-9e4e-e22374cedee9"), new DateTime(2024, 10, 3, 16, 32, 54, 75, DateTimeKind.Local).AddTicks(7869), new DateTime(2024, 10, 3, 16, 32, 54, 75, DateTimeKind.Local).AddTicks(7879), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), 0, "11727", new DateTime(2024, 10, 3, 16, 32, 54, 75, DateTimeKind.Local).AddTicks(7881), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50") },
                    { new Guid("86a9d4a5-3239-49dd-89c0-b2555a582b51"), new DateTime(2024, 10, 3, 16, 32, 54, 75, DateTimeKind.Local).AddTicks(7930), new DateTime(2024, 10, 3, 16, 32, 54, 75, DateTimeKind.Local).AddTicks(7931), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), 0, "77083", new DateTime(2024, 10, 3, 16, 32, 54, 75, DateTimeKind.Local).AddTicks(7931), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50") },
                    { new Guid("a3bc534e-8441-43a3-bc83-5ceabc69070d"), new DateTime(2024, 10, 3, 16, 32, 54, 75, DateTimeKind.Local).AddTicks(7944), new DateTime(2024, 10, 3, 16, 32, 54, 75, DateTimeKind.Local).AddTicks(7945), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), 0, "40092", new DateTime(2024, 10, 3, 16, 32, 54, 75, DateTimeKind.Local).AddTicks(7945), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50") }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedDateTime", "CreatedUserId", "Name", "ProvinceId", "UpdatedDataTime", "UpdatedUserId" },
                values: new object[,]
                {
                    { new Guid("0351c650-5ee4-4258-9500-537ede428e60"), new DateTime(2024, 10, 3, 16, 32, 54, 72, DateTimeKind.Local).AddTicks(974), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), "سعادتشهر", new Guid("84c3d84b-b54f-4e03-8fc6-5130cd643c47"), new DateTime(2024, 10, 3, 16, 32, 54, 72, DateTimeKind.Local).AddTicks(975), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50") },
                    { new Guid("73b05b9b-2748-4d9d-85e6-41915cf5d29f"), new DateTime(2024, 10, 3, 16, 32, 54, 72, DateTimeKind.Local).AddTicks(982), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), "پرند", new Guid("84c3d84b-b54f-4e03-8fc6-5130cd643c47"), new DateTime(2024, 10, 3, 16, 32, 54, 72, DateTimeKind.Local).AddTicks(983), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50") },
                    { new Guid("91cd48a1-7da4-4beb-af28-d715a175598a"), new DateTime(2024, 10, 3, 16, 32, 54, 72, DateTimeKind.Local).AddTicks(958), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), "کرج", new Guid("84c3d84b-b54f-4e03-8fc6-5130cd643c47"), new DateTime(2024, 10, 3, 16, 32, 54, 72, DateTimeKind.Local).AddTicks(959), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50") },
                    { new Guid("bd3ee152-3818-4831-9859-74d7068e0d05"), new DateTime(2024, 10, 3, 16, 32, 54, 72, DateTimeKind.Local).AddTicks(965), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), "دماوند", new Guid("84c3d84b-b54f-4e03-8fc6-5130cd643c47"), new DateTime(2024, 10, 3, 16, 32, 54, 72, DateTimeKind.Local).AddTicks(966), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50") },
                    { new Guid("d2cbd482-a755-499c-981b-8601f7f3b9dc"), new DateTime(2024, 10, 3, 16, 32, 54, 72, DateTimeKind.Local).AddTicks(925), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), "تهران", new Guid("84c3d84b-b54f-4e03-8fc6-5130cd643c47"), new DateTime(2024, 10, 3, 16, 32, 54, 72, DateTimeKind.Local).AddTicks(936), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CreatedUserId",
                table: "Addresses",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UpdatedUserId",
                table: "Addresses",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CreatedUserId",
                table: "Cities",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_ProvinceId",
                table: "Cities",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_UpdatedUserId",
                table: "Cities",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Provinces_CreatedUserId",
                table: "Provinces",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Provinces_UpdatedUserId",
                table: "Provinces",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_CreatedUserId",
                table: "Tickets",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_UpdatedUserId",
                table: "Tickets",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_UserId",
                table: "Tickets",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"));
        }
    }
}
