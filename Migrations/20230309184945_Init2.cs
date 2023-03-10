using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace huigma.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Folders_Folders_FolderId",
                table: "Folders");

            migrationBuilder.RenameColumn(
                name: "FolderId",
                table: "Folders",
                newName: "ParentFolder");

            migrationBuilder.RenameIndex(
                name: "IX_Folders_FolderId",
                table: "Folders",
                newName: "IX_Folders_ParentFolder");

            migrationBuilder.AddForeignKey(
                name: "FK_Folders_Folders_ParentFolder",
                table: "Folders",
                column: "ParentFolder",
                principalTable: "Folders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Folders_Folders_ParentFolder",
                table: "Folders");

            migrationBuilder.RenameColumn(
                name: "ParentFolder",
                table: "Folders",
                newName: "FolderId");

            migrationBuilder.RenameIndex(
                name: "IX_Folders_ParentFolder",
                table: "Folders",
                newName: "IX_Folders_FolderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Folders_Folders_FolderId",
                table: "Folders",
                column: "FolderId",
                principalTable: "Folders",
                principalColumn: "Id");
        }
    }
}
