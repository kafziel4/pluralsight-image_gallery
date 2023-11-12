using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Company.IDP.Migrations
{
    /// <inheritdoc />
    public partial class AddAcountActivation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("0e5cd44c-d19b-4998-8aa2-00d07b026bf9"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("7304ecd6-15fb-4d65-9222-dacc17f3aac6"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("80b56c72-5b49-4c74-8da7-e91bcf96e4ae"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("957f3e73-320d-4973-94c1-808de5ce491d"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("be5aa826-fae4-42e9-b24d-5fe9783a7cea"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("ca0a733e-b10d-4ceb-953c-839e4aa30d2a"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("cba632c5-d625-4c3e-8d0e-b153256245b3"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("de662e2a-6d9d-4039-ae99-9cf485c092fd"));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecurityCode",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SecurityCodeExpirationDate",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("231f40ec-ca39-402d-9f73-f8060e82dcb4"), "e71501c4-c961-4a9f-a260-24542f3b5e01", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("3136104d-3161-4b37-bfbd-1517a30233f0"), "97ce1651-4173-46c7-9dc4-20f297da9a7f", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("325094a5-41a3-4923-925c-c675e410dd10"), "e040df81-d7e1-4bf3-82d2-73274782e3d2", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("48e58243-1c17-485a-9462-67e20116d536"), "d0de8009-3a95-42f1-bc2e-ad3a7f4723fd", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("4da15930-32da-4172-9961-96f84c566d88"), "00e568b1-31a3-4e7f-bfbc-58a027dafca6", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("9a48f5ef-a094-49eb-8e60-43c77d4554d2"), "d4ca3e5b-2764-4527-acfd-8feee94e9fd6", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("a3695246-4dd4-479a-b79b-55b68809852a"), "3a5299d2-dd88-42e9-b796-f012d755b1a3", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("f1de5920-302a-4ecf-a6c0-80413827730c"), "e4887746-25f8-4fb2-abc4-0d852ab3197c", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityCode", "SecurityCodeExpirationDate" },
                values: new object[] { "f38a54ff-8b5f-4e8d-8972-94f67ba9d6ae", "david@someprovider.com", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityCode", "SecurityCodeExpirationDate" },
                values: new object[] { "e9f5fcd9-448d-444c-83cf-5c5bc05846fe", "emma@someprovider.com", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("231f40ec-ca39-402d-9f73-f8060e82dcb4"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("3136104d-3161-4b37-bfbd-1517a30233f0"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("325094a5-41a3-4923-925c-c675e410dd10"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("48e58243-1c17-485a-9462-67e20116d536"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("4da15930-32da-4172-9961-96f84c566d88"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("9a48f5ef-a094-49eb-8e60-43c77d4554d2"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("a3695246-4dd4-479a-b79b-55b68809852a"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("f1de5920-302a-4ecf-a6c0-80413827730c"));

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCodeExpirationDate",
                table: "Users");

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("0e5cd44c-d19b-4998-8aa2-00d07b026bf9"), "c8ec4a13-1621-4dff-bc0b-fe18763f3ce9", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("7304ecd6-15fb-4d65-9222-dacc17f3aac6"), "d4215c35-e8a2-4359-bc01-228d8ccbe8a9", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("80b56c72-5b49-4c74-8da7-e91bcf96e4ae"), "8c5b960f-8205-4957-a07d-79bcfa0317fa", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("957f3e73-320d-4973-94c1-808de5ce491d"), "c4d8ea78-f967-4e59-b43c-21f3dcf44c53", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" },
                    { new Guid("be5aa826-fae4-42e9-b24d-5fe9783a7cea"), "25e18e90-2ef5-4c37-ad0c-86f9d21178d5", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("ca0a733e-b10d-4ceb-953c-839e4aa30d2a"), "143a9252-0b59-4c16-9881-efabc318bd98", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("cba632c5-d625-4c3e-8d0e-b153256245b3"), "ad5d7d36-ee80-411a-9255-50da187d241b", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("de662e2a-6d9d-4039-ae99-9cf485c092fd"), "48a27d1d-132d-460d-9aa6-5706791811c0", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "64a2d482-fad7-4276-b767-4114cfa88cfe");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "55b59159-3b6d-43db-a38f-6b3b9de1a8a4");
        }
    }
}
