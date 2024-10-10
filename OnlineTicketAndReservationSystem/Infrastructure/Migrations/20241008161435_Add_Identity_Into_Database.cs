using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Add_Identity_Into_Database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Role_User_CreatedUserId",
                table: "Role");

            migrationBuilder.DropForeignKey(
                name: "FK_Role_User_UpdatedUserId",
                table: "Role");

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

            migrationBuilder.DropIndex(
                name: "IX_Role_CreatedUserId",
                table: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Role_UpdatedUserId",
                table: "Role");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0351c650-5ee4-4258-9500-537ede428e60"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("73b05b9b-2748-4d9d-85e6-41915cf5d29f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("91cd48a1-7da4-4beb-af28-d715a175598a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("bd3ee152-3818-4831-9859-74d7068e0d05"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d2cbd482-a755-499c-981b-8601f7f3b9dc"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("372ada54-8cfb-4475-8ec9-fcde8113901d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("6282afc8-f82f-4d6f-9e4e-e22374cedee9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("86a9d4a5-3239-49dd-89c0-b2555a582b51"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("a3bc534e-8441-43a3-bc83-5ceabc69070d"));

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "UpdatedDataTime",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "UpdatedUserId",
                table: "Role");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "User",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "User",
                newName: "PasswordHash");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedUserId",
                table: "User",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedUserId",
                table: "User",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "User",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "User",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "User",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BuyDate",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 8, 19, 44, 27, 164, DateTimeKind.Local).AddTicks(4431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 10, 3, 16, 32, 54, 75, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Role",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Role",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedName",
                table: "Role",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoleStatusId",
                table: "Role",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CityStatusId",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: new Guid("84c3d84b-b54f-4e03-8fc6-5130cd643c47"),
                columns: new[] { "CreatedDateTime", "UpdatedDataTime" },
                values: new object[] { new DateTime(2024, 10, 8, 19, 44, 27, 162, DateTimeKind.Local).AddTicks(1868), new DateTime(2024, 10, 8, 19, 44, 27, 162, DateTimeKind.Local).AddTicks(1871) });

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

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"),
                columns: new[] { "AccessFailedCount", "ConcurrencyStamp", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedDataTime" },
                values: new object[] { 0, "eefa71c2-b0a5-413d-9795-0598e885b167", false, false, null, null, null, null, false, null, false, new DateTime(2024, 10, 8, 19, 44, 27, 167, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "User",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "User",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Role",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

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

            migrationBuilder.DropIndex(
                name: "EmailIndex",
                table: "User");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "User");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "Role");

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

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "User");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "User");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "User");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "User");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "User");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "User");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "NormalizedName",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "RoleStatusId",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "CityStatusId",
                table: "Cities");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "User",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "User",
                newName: "Password");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedUserId",
                table: "User",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedUserId",
                table: "User",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BuyDate",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 3, 16, 32, 54, 75, DateTimeKind.Local).AddTicks(6742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 10, 8, 19, 44, 27, 164, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Role",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUserId",
                table: "Role",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDataTime",
                table: "Role",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedUserId",
                table: "Role",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: new Guid("84c3d84b-b54f-4e03-8fc6-5130cd643c47"),
                columns: new[] { "CreatedDateTime", "UpdatedDataTime" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 32, 54, 72, DateTimeKind.Local).AddTicks(3316), new DateTime(2024, 10, 3, 16, 32, 54, 72, DateTimeKind.Local).AddTicks(3321) });

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

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"),
                column: "UpdatedDataTime",
                value: new DateTime(2024, 10, 3, 16, 32, 54, 83, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.CreateIndex(
                name: "IX_User_CreatedUserId",
                table: "User",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UpdatedUserId",
                table: "User",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_CreatedUserId",
                table: "Role",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_UpdatedUserId",
                table: "Role",
                column: "UpdatedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Role_User_CreatedUserId",
                table: "Role",
                column: "CreatedUserId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Role_User_UpdatedUserId",
                table: "Role",
                column: "UpdatedUserId",
                principalTable: "User",
                principalColumn: "Id");

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
    }
}
