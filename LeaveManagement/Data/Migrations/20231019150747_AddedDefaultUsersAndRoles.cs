using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ccb8b30-835b-4a0c-894c-9a88d2908b50", "fe92b936-1f8f-4634-be5a-e1429df050f8", "User", "USER" },
                    { "e5dc40e3-44bd-45c8-a9d9-7176ad4ee329", "874ca5ae-0a04-4996-be47-481928d159d4", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0ab2ed75-74da-441c-bf9c-0cff68895f3e", 0, "b72d7fa4-69c2-4c68-88e0-c06f73498371", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "amirhamzah92.ka@gmail.com", false, "Amir", "Hamzah", false, null, "AMIRHAMZAH92.KA@GMAIL.COM", null, "AQAAAAEAACcQAAAAEEVM/NIgIKRlQjSMvqNxfW6HyZXx3ETpbIamHADQ56pG0KbIbufEzUi8C+Yf9GRSNA==", null, false, "92fb8143-50d7-41f7-92dc-8237f0ce8ae4", null, false, null },
                    { "210f8836-1773-4492-95f5-cb1b61980616", 0, "d016e412-3f70-4162-8e96-f3b358f73460", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ryder9243@gmail.com", false, "Auni", "Dalilah", false, null, "RYDER9243@GMAIL.COM", null, "AQAAAAEAACcQAAAAEA2tBKD4pPx4MmVKhWX6ApGbCKCCvniX1tPzVy2oVS++R6c2VPHVRPu69nORvyLV1Q==", null, false, "69b4665c-1e80-4a0f-b533-3b113fdff6e5", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e5dc40e3-44bd-45c8-a9d9-7176ad4ee329", "0ab2ed75-74da-441c-bf9c-0cff68895f3e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1ccb8b30-835b-4a0c-894c-9a88d2908b50", "210f8836-1773-4492-95f5-cb1b61980616" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e5dc40e3-44bd-45c8-a9d9-7176ad4ee329", "0ab2ed75-74da-441c-bf9c-0cff68895f3e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1ccb8b30-835b-4a0c-894c-9a88d2908b50", "210f8836-1773-4492-95f5-cb1b61980616" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ccb8b30-835b-4a0c-894c-9a88d2908b50");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5dc40e3-44bd-45c8-a9d9-7176ad4ee329");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ab2ed75-74da-441c-bf9c-0cff68895f3e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "210f8836-1773-4492-95f5-cb1b61980616");
        }
    }
}
