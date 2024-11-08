using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Create_Blob_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AvatarId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BuyDate",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 7, 21, 29, 6, 586, DateTimeKind.Local).AddTicks(6215),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 10, 29, 19, 29, 46, 143, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.CreateTable(
                name: "Blob",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileAddress = table.Column<string>(type: "NVarChar(1000)", maxLength: 1000, nullable: false),
                    MimeType = table.Column<string>(type: "NVarChar(300)", maxLength: 300, nullable: false),
                    FileSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blob", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_AvatarId",
                table: "User",
                column: "AvatarId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Blob_AvatarId",
                table: "User",
                column: "AvatarId",
                principalTable: "Blob",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Blob_AvatarId",
                table: "User");

            migrationBuilder.DropTable(
                name: "Blob");

            migrationBuilder.DropIndex(
                name: "IX_User_AvatarId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "AvatarId",
                table: "User");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BuyDate",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 29, 19, 29, 46, 143, DateTimeKind.Local).AddTicks(7276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 7, 21, 29, 6, 586, DateTimeKind.Local).AddTicks(6215));
        }
    }
}
