using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Work_Tool.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigrationAfterBranch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Topic_Label__LabelId",
                table: "Topic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Label_",
                table: "Label_");

            migrationBuilder.RenameTable(
                name: "Label_",
                newName: "Label");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Ideas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndData",
                table: "Ideas",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LabelId",
                table: "Ideas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Ideas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ProgettoId",
                table: "Ideas",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartingData",
                table: "Ideas",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StattusTask",
                table: "Ideas",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "TimeSpan",
                table: "Ideas",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Label",
                table: "Label",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Progetto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LabelId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    StarData = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EstimatedEnd = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RollingTime = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    Progress = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Progetto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Progetto_Label_LabelId",
                        column: x => x.LabelId,
                        principalTable: "Label",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ideas_LabelId",
                table: "Ideas",
                column: "LabelId");

            migrationBuilder.CreateIndex(
                name: "IX_Ideas_ProgettoId",
                table: "Ideas",
                column: "ProgettoId");

            migrationBuilder.CreateIndex(
                name: "IX_Progetto_LabelId",
                table: "Progetto",
                column: "LabelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ideas_Label_LabelId",
                table: "Ideas",
                column: "LabelId",
                principalTable: "Label",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ideas_Progetto_ProgettoId",
                table: "Ideas",
                column: "ProgettoId",
                principalTable: "Progetto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Topic_Label_LabelId",
                table: "Topic",
                column: "LabelId",
                principalTable: "Label",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ideas_Label_LabelId",
                table: "Ideas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ideas_Progetto_ProgettoId",
                table: "Ideas");

            migrationBuilder.DropForeignKey(
                name: "FK_Topic_Label_LabelId",
                table: "Topic");

            migrationBuilder.DropTable(
                name: "Progetto");

            migrationBuilder.DropIndex(
                name: "IX_Ideas_LabelId",
                table: "Ideas");

            migrationBuilder.DropIndex(
                name: "IX_Ideas_ProgettoId",
                table: "Ideas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Label",
                table: "Label");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Ideas");

            migrationBuilder.DropColumn(
                name: "EndData",
                table: "Ideas");

            migrationBuilder.DropColumn(
                name: "LabelId",
                table: "Ideas");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Ideas");

            migrationBuilder.DropColumn(
                name: "ProgettoId",
                table: "Ideas");

            migrationBuilder.DropColumn(
                name: "StartingData",
                table: "Ideas");

            migrationBuilder.DropColumn(
                name: "StattusTask",
                table: "Ideas");

            migrationBuilder.DropColumn(
                name: "TimeSpan",
                table: "Ideas");

            migrationBuilder.RenameTable(
                name: "Label",
                newName: "Label_");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Label_",
                table: "Label_",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Topic_Label__LabelId",
                table: "Topic",
                column: "LabelId",
                principalTable: "Label_",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
