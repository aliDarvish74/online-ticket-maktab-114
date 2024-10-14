using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2381bdda-6363-4569-b4da-4f822b9aad29"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("288dbab1-4e47-4979-b157-f83602931b57"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6b23a659-efc8-4fad-ace5-a7a0dd6f6795"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7cd36a24-2e75-4846-871e-0e3b895b3b97"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b62abac5-9927-4023-9df2-f5b587bbd873"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("325f8e99-898a-4754-8cfb-e1a9d03a01cc"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("8134661f-ce82-412c-9675-0df6443ad8ca"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("da310e66-d7a3-4d9a-b951-84d94e135e48"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("db308e20-f738-44c6-b1fb-29f36e7e7eda"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BuyDate",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 11, 10, 43, 30, 90, DateTimeKind.Local).AddTicks(3880),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 10, 8, 19, 44, 27, 164, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CityStatusId", "CreatedDateTime", "CreatedUserId", "Name", "ProvinceId", "UpdatedDataTime", "UpdatedUserId" },
                values: new object[,]
                {
                    { new Guid("238055ba-31fa-4b43-94d4-f5ca3d9234e2"), 0, new DateTime(2024, 10, 11, 10, 43, 30, 87, DateTimeKind.Local).AddTicks(6294), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), "سعادتشهر", new Guid("84c3d84b-b54f-4e03-8fc6-5130cd643c47"), new DateTime(2024, 10, 11, 10, 43, 30, 87, DateTimeKind.Local).AddTicks(6295), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50") },
                    { new Guid("4039b0a8-7a2f-4be1-9a53-1c846ab9be58"), 0, new DateTime(2024, 10, 11, 10, 43, 30, 87, DateTimeKind.Local).AddTicks(6216), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), "تهران", new Guid("84c3d84b-b54f-4e03-8fc6-5130cd643c47"), new DateTime(2024, 10, 11, 10, 43, 30, 87, DateTimeKind.Local).AddTicks(6234), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50") },
                    { new Guid("4a1c90dd-7870-45e1-8998-310c5ee018d9"), 0, new DateTime(2024, 10, 11, 10, 43, 30, 87, DateTimeKind.Local).AddTicks(6285), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), "دماوند", new Guid("84c3d84b-b54f-4e03-8fc6-5130cd643c47"), new DateTime(2024, 10, 11, 10, 43, 30, 87, DateTimeKind.Local).AddTicks(6287), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50") },
                    { new Guid("831a8b53-6870-4e52-ae2e-9f5634aaad54"), 0, new DateTime(2024, 10, 11, 10, 43, 30, 87, DateTimeKind.Local).AddTicks(6274), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), "کرج", new Guid("84c3d84b-b54f-4e03-8fc6-5130cd643c47"), new DateTime(2024, 10, 11, 10, 43, 30, 87, DateTimeKind.Local).AddTicks(6276), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50") },
                    { new Guid("b28d6216-aebb-4b51-99d9-a0dc7266b322"), 0, new DateTime(2024, 10, 11, 10, 43, 30, 87, DateTimeKind.Local).AddTicks(6302), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), "پرند", new Guid("84c3d84b-b54f-4e03-8fc6-5130cd643c47"), new DateTime(2024, 10, 11, 10, 43, 30, 87, DateTimeKind.Local).AddTicks(6303), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50") }
                });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: new Guid("84c3d84b-b54f-4e03-8fc6-5130cd643c47"),
                columns: new[] { "CreatedDateTime", "UpdatedDataTime" },
                values: new object[] { new DateTime(2024, 10, 11, 10, 43, 30, 87, DateTimeKind.Local).AddTicks(9658), new DateTime(2024, 10, 11, 10, 43, 30, 87, DateTimeKind.Local).AddTicks(9665) });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BuyDate", "CreatedDateTime", "CreatedUserId", "SeatNumber", "TicketNumber", "UpdatedDataTime", "UpdatedUserId", "UserId" },
                values: new object[,]
                {
                    { new Guid("2c3ba574-16e7-4272-a43a-d4db6df07a1a"), new DateTime(2024, 10, 11, 10, 43, 30, 90, DateTimeKind.Local).AddTicks(4882), new DateTime(2024, 10, 11, 10, 43, 30, 90, DateTimeKind.Local).AddTicks(4888), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), 0, "41766", new DateTime(2024, 10, 11, 10, 43, 30, 90, DateTimeKind.Local).AddTicks(4889), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50") },
                    { new Guid("86d8cb35-1dba-431c-90a1-46b60c5e0c0c"), new DateTime(2024, 10, 11, 10, 43, 30, 90, DateTimeKind.Local).AddTicks(4946), new DateTime(2024, 10, 11, 10, 43, 30, 90, DateTimeKind.Local).AddTicks(4948), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), 0, "76665", new DateTime(2024, 10, 11, 10, 43, 30, 90, DateTimeKind.Local).AddTicks(4949), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50") },
                    { new Guid("d7ffd2f6-62eb-496a-875f-6fad16b0d1a8"), new DateTime(2024, 10, 11, 10, 43, 30, 90, DateTimeKind.Local).AddTicks(4961), new DateTime(2024, 10, 11, 10, 43, 30, 90, DateTimeKind.Local).AddTicks(4962), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), 0, "62691", new DateTime(2024, 10, 11, 10, 43, 30, 90, DateTimeKind.Local).AddTicks(4963), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50") },
                    { new Guid("fde8ab32-b718-4669-a7ad-1a7e84130bfc"), new DateTime(2024, 10, 11, 10, 43, 30, 90, DateTimeKind.Local).AddTicks(4924), new DateTime(2024, 10, 11, 10, 43, 30, 90, DateTimeKind.Local).AddTicks(4925), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), 0, "93117", new DateTime(2024, 10, 11, 10, 43, 30, 90, DateTimeKind.Local).AddTicks(4926), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_CreatedUserId",
                table: "User",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UpdatedUserId",
                table: "User",
                column: "UpdatedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_User_CreatedUserId",
                table: "User",
                column: "CreatedUserId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_User_UpdatedUserId",
                table: "User",
                column: "UpdatedUserId",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_User_CreatedUserId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_User_UpdatedUserId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_CreatedUserId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_UpdatedUserId",
                table: "User");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("238055ba-31fa-4b43-94d4-f5ca3d9234e2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4039b0a8-7a2f-4be1-9a53-1c846ab9be58"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4a1c90dd-7870-45e1-8998-310c5ee018d9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("831a8b53-6870-4e52-ae2e-9f5634aaad54"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b28d6216-aebb-4b51-99d9-a0dc7266b322"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("2c3ba574-16e7-4272-a43a-d4db6df07a1a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("86d8cb35-1dba-431c-90a1-46b60c5e0c0c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("d7ffd2f6-62eb-496a-875f-6fad16b0d1a8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("fde8ab32-b718-4669-a7ad-1a7e84130bfc"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BuyDate",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 8, 19, 44, 27, 164, DateTimeKind.Local).AddTicks(4431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 10, 11, 10, 43, 30, 90, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: new Guid("84c3d84b-b54f-4e03-8fc6-5130cd643c47"),
                columns: new[] { "CreatedDateTime", "UpdatedDataTime" },
                values: new object[] { new DateTime(2024, 10, 8, 19, 44, 27, 162, DateTimeKind.Local).AddTicks(1868), new DateTime(2024, 10, 8, 19, 44, 27, 162, DateTimeKind.Local).AddTicks(1871) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedDateTime", "CreatedUserId", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedDataTime", "UpdatedUserId", "UserName" },
                values: new object[] { new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), 0, "eefa71c2-b0a5-413d-9795-0598e885b167", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), null, "aa@gmail.com", false, "kiji", "..", false, null, null, null, "123", null, false, null, false, new DateTime(2024, 10, 8, 19, 44, 27, 167, DateTimeKind.Local).AddTicks(9998), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), "user1" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CityStatusId", "CreatedDateTime", "CreatedUserId", "Name", "ProvinceId", "UpdatedDataTime", "UpdatedUserId" },
                values: new object[,]
                {
                    { new Guid("2381bdda-6363-4569-b4da-4f822b9aad29"), 0, new DateTime(2024, 10, 8, 19, 44, 27, 161, DateTimeKind.Local).AddTicks(9667), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), "تهران", new Guid("84c3d84b-b54f-4e03-8fc6-5130cd643c47"), new DateTime(2024, 10, 8, 19, 44, 27, 161, DateTimeKind.Local).AddTicks(9685), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50") },
                    { new Guid("288dbab1-4e47-4979-b157-f83602931b57"), 0, new DateTime(2024, 10, 8, 19, 44, 27, 161, DateTimeKind.Local).AddTicks(9732), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), "دماوند", new Guid("84c3d84b-b54f-4e03-8fc6-5130cd643c47"), new DateTime(2024, 10, 8, 19, 44, 27, 161, DateTimeKind.Local).AddTicks(9733), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50") },
                    { new Guid("6b23a659-efc8-4fad-ace5-a7a0dd6f6795"), 0, new DateTime(2024, 10, 8, 19, 44, 27, 161, DateTimeKind.Local).AddTicks(9739), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), "سعادتشهر", new Guid("84c3d84b-b54f-4e03-8fc6-5130cd643c47"), new DateTime(2024, 10, 8, 19, 44, 27, 161, DateTimeKind.Local).AddTicks(9740), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50") },
                    { new Guid("7cd36a24-2e75-4846-871e-0e3b895b3b97"), 0, new DateTime(2024, 10, 8, 19, 44, 27, 161, DateTimeKind.Local).AddTicks(9745), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), "پرند", new Guid("84c3d84b-b54f-4e03-8fc6-5130cd643c47"), new DateTime(2024, 10, 8, 19, 44, 27, 161, DateTimeKind.Local).AddTicks(9746), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50") },
                    { new Guid("b62abac5-9927-4023-9df2-f5b587bbd873"), 0, new DateTime(2024, 10, 8, 19, 44, 27, 161, DateTimeKind.Local).AddTicks(9714), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), "کرج", new Guid("84c3d84b-b54f-4e03-8fc6-5130cd643c47"), new DateTime(2024, 10, 8, 19, 44, 27, 161, DateTimeKind.Local).AddTicks(9715), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50") }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "BuyDate", "CreatedDateTime", "CreatedUserId", "SeatNumber", "TicketNumber", "UpdatedDataTime", "UpdatedUserId", "UserId" },
                values: new object[,]
                {
                    { new Guid("325f8e99-898a-4754-8cfb-e1a9d03a01cc"), new DateTime(2024, 10, 8, 19, 44, 27, 164, DateTimeKind.Local).AddTicks(5940), new DateTime(2024, 10, 8, 19, 44, 27, 164, DateTimeKind.Local).AddTicks(5941), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), 0, "94477", new DateTime(2024, 10, 8, 19, 44, 27, 164, DateTimeKind.Local).AddTicks(5942), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50") },
                    { new Guid("8134661f-ce82-412c-9675-0df6443ad8ca"), new DateTime(2024, 10, 8, 19, 44, 27, 164, DateTimeKind.Local).AddTicks(5867), new DateTime(2024, 10, 8, 19, 44, 27, 164, DateTimeKind.Local).AddTicks(5875), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), 0, "87269", new DateTime(2024, 10, 8, 19, 44, 27, 164, DateTimeKind.Local).AddTicks(5875), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50") },
                    { new Guid("da310e66-d7a3-4d9a-b951-84d94e135e48"), new DateTime(2024, 10, 8, 19, 44, 27, 164, DateTimeKind.Local).AddTicks(5918), new DateTime(2024, 10, 8, 19, 44, 27, 164, DateTimeKind.Local).AddTicks(5920), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), 0, "61408", new DateTime(2024, 10, 8, 19, 44, 27, 164, DateTimeKind.Local).AddTicks(5921), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50") },
                    { new Guid("db308e20-f738-44c6-b1fb-29f36e7e7eda"), new DateTime(2024, 10, 8, 19, 44, 27, 164, DateTimeKind.Local).AddTicks(5930), new DateTime(2024, 10, 8, 19, 44, 27, 164, DateTimeKind.Local).AddTicks(5931), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), 0, "60393", new DateTime(2024, 10, 8, 19, 44, 27, 164, DateTimeKind.Local).AddTicks(5932), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"), new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50") }
                });
        }
    }
}
