using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ccb8b30-835b-4a0c-894c-9a88d2908b50",
                column: "ConcurrencyStamp",
                value: "c9bbcae2-ca55-4b3a-b2ac-d3c355545f4b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5dc40e3-44bd-45c8-a9d9-7176ad4ee329",
                column: "ConcurrencyStamp",
                value: "9e392d11-a75e-4dbf-a76c-2d6e244390c5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ab2ed75-74da-441c-bf9c-0cff68895f3e",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6645bb90-4102-42fe-b501-1046c5fc88d7", true, "AMIRHAMZAH92.KA@GMAIL.COM", "AQAAAAEAACcQAAAAEFbzFu1H6qfXVpc8JDZzfgik0T8ISG+7ZxpWNOWjlyhtLVZ5RlJMab/bHJTAMPz8mQ==", "8fcc85d3-a070-4862-86c3-c48019f2e9a3", "amirhamzah92.ka@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "210f8836-1773-4492-95f5-cb1b61980616",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "55a1f9c8-fae6-4327-b5d5-531bc3f37528", true, "RYDER9243@GMAIL.COM", "AQAAAAEAACcQAAAAEHMo12CZKZHr2bRo23V+aEnpTHxYnKV3xzBUg1aiu8PtZeMBGBQDikA6Mdxq4rhhQQ==", "dd18f5e1-8a74-4d55-98aa-ac5da4a16577", "ryder9243@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ccb8b30-835b-4a0c-894c-9a88d2908b50",
                column: "ConcurrencyStamp",
                value: "fe92b936-1f8f-4634-be5a-e1429df050f8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5dc40e3-44bd-45c8-a9d9-7176ad4ee329",
                column: "ConcurrencyStamp",
                value: "874ca5ae-0a04-4996-be47-481928d159d4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ab2ed75-74da-441c-bf9c-0cff68895f3e",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b72d7fa4-69c2-4c68-88e0-c06f73498371", false, null, "AQAAAAEAACcQAAAAEEVM/NIgIKRlQjSMvqNxfW6HyZXx3ETpbIamHADQ56pG0KbIbufEzUi8C+Yf9GRSNA==", "92fb8143-50d7-41f7-92dc-8237f0ce8ae4", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "210f8836-1773-4492-95f5-cb1b61980616",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d016e412-3f70-4162-8e96-f3b358f73460", false, null, "AQAAAAEAACcQAAAAEA2tBKD4pPx4MmVKhWX6ApGbCKCCvniX1tPzVy2oVS++R6c2VPHVRPu69nORvyLV1Q==", "69b4665c-1e80-4a0f-b533-3b113fdff6e5", null });
        }
    }
}
