using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Fan_Fusion.Migrations
{
    public partial class FJMUsersData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "Image", "LastName", "Uid", "Username" },
                values: new object[] { "fletcher@example.com", "Fletcher", "https://ca.slack-edge.com/T03F2SDTJ-U06ANN13BJA-a6223b135600-512", "Moore", "spB8Zq4wELSQ2CYU8B85GAlo9UF3", "fletcher_moore" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "Image", "LastName", "Uid", "Username" },
                values: new object[] { "yarelis@example.com", "Yarelis", "https://ca.slack-edge.com/T03F2SDTJ-U06964LME06-e7ae012d8792-512", "Martin", "BoMhkHml16cdAERkecfxE2RRMqO2", "yarelis_martin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "Image", "LastName", "Uid", "Username" },
                values: new object[] { "sirrena@example.com", "Sirena", "https://ca.slack-edge.com/T03F2SDTJ-U079DCXBYHW-e4fd2297a065-512", "Foster", "MxzBtnidXFYcqBl2zw0unXm6Vbl2", "sirena_foster" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "FirstName", "Image", "LastName", "Uid", "Username" },
                values: new object[] { "casey@example.com", "Casey", "https://ca.slack-edge.com/T03F2SDTJ-U078T3MSH0U-2ccec7b81ad3-512", "Cunningham", "t3CunL7C0nUSf9a28dcqBZs3J9y1", "casey_cunningham" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "https://i.pinimg.com/564x/2a/8a/6d/2a8a6d14195e800e21d58d25c96d6e4a.jpg");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "https://preview.redd.it/generic-e-girl-face-v0-4hqohs5o1h6a1.jpg?width=640&crop=smart&auto=webp&s=bc432d97ba360c6412daa30e0cb5d00d25e35d1e");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "https://media.istockphoto.com/id/1020474390/photo/displeased-mature-man.jpg?s=612x612&w=0&k=20&c=LgsEpwyAuPXh7VcYoQooNb7Jh7U7pl1l9xzwm0SC-is=");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "https://thumbs.dreamstime.com/b/teen-girl-orange-shirt-10766265.jpg");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "Image",
                value: "https://media.istockphoto.com/id/181894143/photo/nervous-young-man.jpg?s=612x612&w=0&k=20&c=VGM3L-GNjuU6azlEu9HWgSR872iObXPJ81AyjUqD8AQ=");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "Image",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTa3HD9NGpcssX7w3fcMClAQtN6Xa638VkEHg&s");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "Image",
                value: "https://thumbs.dreamstime.com/b/woman-wearing-black-generic-glasses-happy-43745660.jpg");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                column: "Image",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQAnWbXLAOuwYf2v-B7jQedXh_QVlUNPoqdhEpxc_OC5BeSx7YRtvaDlebgEpxBIg_Qr9s&usqp=CAU");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                column: "Image",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS24W-X-ipaKgDC5RYy4mUbOh6SpAExS7_7gIVeN1nc-dud4ybbFEfj0qcP6PIF4dh3I3I&usqp=CAU");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "Image", "LastName", "Uid", "Username" },
                values: new object[] { "john@example.com", "John", "https://example.com/images/john.jpg", "Doe", "user001", "john_doe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "Image", "LastName", "Uid", "Username" },
                values: new object[] { "jane@example.com", "Jane", "https://example.com/images/jane.jpg", "Smith", "user002", "jane_smith" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "Image", "LastName", "Uid", "Username" },
                values: new object[] { "alice@example.com", "Alice", "https://example.com/images/alice.jpg", "Johnson", "user003", "alice_johnson" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "FirstName", "Image", "LastName", "Uid", "Username" },
                values: new object[] { "bob@example.com", "Bob", "https://example.com/images/bob.jpg", "Brown", "user004", "bob_brown" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "https://example.com/images/eve.jpg");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "https://example.com/images/fiona.jpg");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "https://example.com/images/george.jpg");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "https://example.com/images/hannah.jpg");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "Image",
                value: "https://example.com/images/ian.jpg");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "Image",
                value: "https://example.com/images/jack.jpg");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "Image",
                value: "https://example.com/images/kathy.jpg");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                column: "Image",
                value: "https://example.com/images/liam.jpg");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                column: "Image",
                value: "https://example.com/images/mia.jpg");
        }
    }
}
