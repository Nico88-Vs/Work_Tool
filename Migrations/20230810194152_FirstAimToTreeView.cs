using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Work_Tool.Migrations
{
    /// <inheritdoc />
    public partial class FirstAimToTreeView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Topic",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "LabelId",
                table: "Topic",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Topic",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                table: "Topic",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Label_",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ambit = table.Column<string>(type: "TEXT", nullable: false),
                    LabelColor = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Label_", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Topic_LabelId",
                table: "Topic",
                column: "LabelId");

            migrationBuilder.CreateIndex(
                name: "IX_Topic_TopicId",
                table: "Topic",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Topic_Label__LabelId",
                table: "Topic",
                column: "LabelId",
                principalTable: "Label_",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Topic_Topic_TopicId",
                table: "Topic",
                column: "TopicId",
                principalTable: "Topic",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Topic_Label__LabelId",
                table: "Topic");

            migrationBuilder.DropForeignKey(
                name: "FK_Topic_Topic_TopicId",
                table: "Topic");

            migrationBuilder.DropTable(
                name: "Label_");

            migrationBuilder.DropIndex(
                name: "IX_Topic_LabelId",
                table: "Topic");

            migrationBuilder.DropIndex(
                name: "IX_Topic_TopicId",
                table: "Topic");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Topic");

            migrationBuilder.DropColumn(
                name: "LabelId",
                table: "Topic");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Topic");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "Topic");
        }
    }
}
