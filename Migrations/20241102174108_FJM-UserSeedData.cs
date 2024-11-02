using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Fan_Fusion.Migrations
{
    public partial class FJMUserSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://images.unsplash.com/photo-1527684651001-731c474bbb5a?q=80&w=2787&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://images.unsplash.com/photo-1692800148019-2f17672c1d57?q=80&w=2160&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://images.unsplash.com/photo-1624367171718-14026220ee35?q=80&w=2787&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "https://i.pinimg.com/564x/87/ef/aa/87efaa9ba7edde6a0767494276e5e4ed.jpg");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "https://images.unsplash.com/photo-1680456693517-bebac4b68f54?q=80&w=2788&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "https://images.unsplash.com/photo-1569008593571-a98b326533a3?w=800&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MjN8fHRlZW5zJTIwZmFudGFzeXxlbnwwfHwwfHx8MA%3D%3D");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "https://images.unsplash.com/photo-1616091216791-a5360b5fc78a?q=80&w=2795&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "https://images.unsplash.com/photo-1577081320692-6eff449819c0?w=800&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NDJ8fGdob3N0JTIwbGFkeXxlbnwwfHwwfHx8MA%3D%3D");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "https://i.pinimg.com/736x/dc/10/7c/dc107cb9703713233c63c5a2e0d954e2.jpg");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "https://i.pinimg.com/564x/89/8d/a6/898da60f9434db2c4bf5f142abe8af67.jpg");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 11,
                column: "Image",
                value: "https://i.pinimg.com/736x/06/8c/54/068c54bae09a0de9a39ffc2590829b37.jpg");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 12,
                column: "Image",
                value: "https://i.pinimg.com/736x/ca/0e/8c/ca0e8c618ae502879f58db63d82c147d.jpg");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 13,
                column: "Image",
                value: "https://i.pinimg.com/564x/24/4c/fa/244cfab30f2497b6b78c91b4065ed3c8.jpg");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 14,
                column: "Image",
                value: "https://i.pinimg.com/736x/63/1c/d7/631cd71a58e19362c662758289e769c8.jpg");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 15,
                column: "Image",
                value: "https://i.pinimg.com/736x/62/ae/08/62ae08e882f6c1098dd6a336e7a4508f.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://example.com/images/hogwarts.jpg");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://example.com/images/galactic.jpg");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://example.com/images/heartstrings.jpg");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "https://example.com/images/detective.jpg");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "https://example.com/images/castle.jpg");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "https://example.com/images/abyss.jpg");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "https://example.com/images/cafe.jpg");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "https://example.com/images/whispers.jpg");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "https://example.com/images/heroes.jpg");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "https://example.com/images/letters.jpg");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 11,
                column: "Image",
                value: "https://example.com/images/stand.jpg");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 12,
                column: "Image",
                value: "https://example.com/images/comedy.jpg");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 13,
                column: "Image",
                value: "https://example.com/images/lines.jpg");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 14,
                column: "Image",
                value: "https://example.com/images/express.jpg");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 15,
                column: "Image",
                value: "https://example.com/images/paths.jpg");
        }
    }
}
