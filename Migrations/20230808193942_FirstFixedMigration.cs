using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Work_Tool.Migrations
{
    /// <inheritdoc />
    public partial class FirstFixedMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TF",
                table: "TF");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Serie",
                table: "Serie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Indi",
                table: "Indi");

            migrationBuilder.RenameTable(
                name: "TF",
                newName: "Ideas");

            migrationBuilder.RenameTable(
                name: "Serie",
                newName: "ToDoItem");

            migrationBuilder.RenameTable(
                name: "Indi",
                newName: "Topic");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ideas",
                table: "Ideas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDoItem",
                table: "ToDoItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Topic",
                table: "Topic",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Topic",
                table: "Topic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDoItem",
                table: "ToDoItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ideas",
                table: "Ideas");

            migrationBuilder.RenameTable(
                name: "Topic",
                newName: "Indi");

            migrationBuilder.RenameTable(
                name: "ToDoItem",
                newName: "Serie");

            migrationBuilder.RenameTable(
                name: "Ideas",
                newName: "TF");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Indi",
                table: "Indi",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Serie",
                table: "Serie",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TF",
                table: "TF",
                column: "Id");
        }
    }
}
