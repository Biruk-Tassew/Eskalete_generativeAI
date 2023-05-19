using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TM.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class fixnames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rates_AspNetUsers_OwnerId",
                table: "Rates");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Rates_TaskId",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rates",
                table: "Rates");

            migrationBuilder.RenameTable(
                name: "Review",
                newName: "CheckList");

            migrationBuilder.RenameTable(
                name: "Rates",
                newName: "Tasks");

            migrationBuilder.RenameIndex(
                name: "IX_Review_TaskId",
                table: "CheckList",
                newName: "IX_CheckList_TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_Rates_OwnerId",
                table: "Tasks",
                newName: "IX_Tasks_OwnerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CheckList",
                table: "CheckList",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6c52d57-24b6-4524-be10-eb7bce4d3217",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cb76456-5df6-4654-a252-0f7eac52342e", "AQAAAAIAAYagAAAAEHaM11Ab0wONYYT2Lye75nhfsVvhRg8la5Vga1Y7dRDZs5HkOjl0iJBCkwlBJKbrcw==", "69e27cad-0191-4424-a28b-031064562616" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb8656da-2b94-474f-8709-85e0cd7ea903",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01f990f8-94b0-40ab-8ab9-240c2805832e", "AQAAAAIAAYagAAAAECetLnRSmqa5RWaBrTIIUt3YCVHKF7F0P+5DOljDzdBzscrOdvzjQtRNxGfu3FE0jQ==", "923c7fd4-96d6-4d0d-b621-f5b01c7309ac" });

            migrationBuilder.AddForeignKey(
                name: "FK_CheckList_Tasks_TaskId",
                table: "CheckList",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_AspNetUsers_OwnerId",
                table: "Tasks",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckList_Tasks_TaskId",
                table: "CheckList");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_AspNetUsers_OwnerId",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CheckList",
                table: "CheckList");

            migrationBuilder.RenameTable(
                name: "Tasks",
                newName: "Rates");

            migrationBuilder.RenameTable(
                name: "CheckList",
                newName: "Review");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_OwnerId",
                table: "Rates",
                newName: "IX_Rates_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_CheckList_TaskId",
                table: "Review",
                newName: "IX_Review_TaskId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rates",
                table: "Rates",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6c52d57-24b6-4524-be10-eb7bce4d3217",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c20c536-8484-4715-9b2b-f642f968423c", "AQAAAAIAAYagAAAAEFylChgN7fuzTLag3C/AvRXfgAqIknkhzxi7MfXhIYsO3ja8hCyNWXOiuHthTJ4aJw==", "af0532c0-c2de-4d56-91cc-5b8be0ac50bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb8656da-2b94-474f-8709-85e0cd7ea903",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f804faa2-206f-4382-8ba3-3280f6b904bb", "AQAAAAIAAYagAAAAEDn3gu6LuIy04X9oW9mKBao5LYs4BmdeCgVwA+qa2mLrwlAarXQZ7lI/aqFKXgGcWw==", "2de874e2-116e-43ce-a3d4-14abd4cacabb" });

            migrationBuilder.AddForeignKey(
                name: "FK_Rates_AspNetUsers_OwnerId",
                table: "Rates",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Rates_TaskId",
                table: "Review",
                column: "TaskId",
                principalTable: "Rates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
