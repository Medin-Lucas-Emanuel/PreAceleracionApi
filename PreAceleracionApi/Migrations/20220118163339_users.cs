using Microsoft.EntityFrameworkCore.Migrations;

namespace PreAceleracionApi.Migrations
{
    public partial class users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_User_usuarioid",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_User_usuarioid",
                table: "Post");

            migrationBuilder.RenameColumn(
                name: "usuarioid",
                table: "Post",
                newName: "userid");

            migrationBuilder.RenameIndex(
                name: "IX_Post_usuarioid",
                table: "Post",
                newName: "IX_Post_userid");

            migrationBuilder.RenameColumn(
                name: "usuarioid",
                table: "Comment",
                newName: "userid");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_usuarioid",
                table: "Comment",
                newName: "IX_Comment_userid");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_User_userid",
                table: "Comment",
                column: "userid",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_User_userid",
                table: "Post",
                column: "userid",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_User_userid",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_User_userid",
                table: "Post");

            migrationBuilder.RenameColumn(
                name: "userid",
                table: "Post",
                newName: "usuarioid");

            migrationBuilder.RenameIndex(
                name: "IX_Post_userid",
                table: "Post",
                newName: "IX_Post_usuarioid");

            migrationBuilder.RenameColumn(
                name: "userid",
                table: "Comment",
                newName: "usuarioid");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_userid",
                table: "Comment",
                newName: "IX_Comment_usuarioid");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_User_usuarioid",
                table: "Comment",
                column: "usuarioid",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_User_usuarioid",
                table: "Post",
                column: "usuarioid",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
