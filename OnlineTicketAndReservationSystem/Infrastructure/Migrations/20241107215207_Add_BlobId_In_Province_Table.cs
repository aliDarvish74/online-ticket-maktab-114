using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Add_BlobId_In_Province_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_User_CreatedUserId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_User_UpdatedUserId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_User_UserId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets");

            migrationBuilder.RenameTable(
                name: "Tickets",
                newName: "Ticket");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_UserId",
                table: "Ticket",
                newName: "IX_Ticket_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_UpdatedUserId",
                table: "Ticket",
                newName: "IX_Ticket_UpdatedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_CreatedUserId",
                table: "Ticket",
                newName: "IX_Ticket_CreatedUserId");

            migrationBuilder.AddColumn<int>(
                name: "ProvincePictureId",
                table: "Provinces",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BuyDate",
                table: "Ticket",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 7, 21, 29, 6, 586, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ticket",
                table: "Ticket",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Provinces_ProvincePictureId",
                table: "Provinces",
                column: "ProvincePictureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Provinces_Blob_ProvincePictureId",
                table: "Provinces",
                column: "ProvincePictureId",
                principalTable: "Blob",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_User_CreatedUserId",
                table: "Ticket",
                column: "CreatedUserId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_User_UpdatedUserId",
                table: "Ticket",
                column: "UpdatedUserId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_User_UserId",
                table: "Ticket",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Provinces_Blob_ProvincePictureId",
                table: "Provinces");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_User_CreatedUserId",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_User_UpdatedUserId",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_User_UserId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Provinces_ProvincePictureId",
                table: "Provinces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ticket",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "ProvincePictureId",
                table: "Provinces");

            migrationBuilder.RenameTable(
                name: "Ticket",
                newName: "Tickets");

            migrationBuilder.RenameIndex(
                name: "IX_Ticket_UserId",
                table: "Tickets",
                newName: "IX_Tickets_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Ticket_UpdatedUserId",
                table: "Tickets",
                newName: "IX_Tickets_UpdatedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Ticket_CreatedUserId",
                table: "Tickets",
                newName: "IX_Tickets_CreatedUserId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BuyDate",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 7, 21, 29, 6, 586, DateTimeKind.Local).AddTicks(6215),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_User_CreatedUserId",
                table: "Tickets",
                column: "CreatedUserId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_User_UpdatedUserId",
                table: "Tickets",
                column: "UpdatedUserId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_User_UserId",
                table: "Tickets",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
