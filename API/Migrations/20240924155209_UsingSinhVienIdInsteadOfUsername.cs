using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class UsingSinhVienIdInsteadOfUsername : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diem_AspNetUsers_SinhVienId",
                table: "Diem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SinhVienVaChuongTrinhDaoTao",
                table: "SinhVienVaChuongTrinhDaoTao");

            migrationBuilder.DropIndex(
                name: "IX_SinhVienVaChuongTrinhDaoTao_SinhVienId",
                table: "SinhVienVaChuongTrinhDaoTao");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "SinhVienVaChuongTrinhDaoTao");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Diem");

            migrationBuilder.AlterColumn<string>(
                name: "SinhVienId",
                table: "Diem",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SinhVienVaChuongTrinhDaoTao",
                table: "SinhVienVaChuongTrinhDaoTao",
                columns: new[] { "SinhVienId", "ChuongTrinhDaoTaoId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Diem_AspNetUsers_SinhVienId",
                table: "Diem",
                column: "SinhVienId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diem_AspNetUsers_SinhVienId",
                table: "Diem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SinhVienVaChuongTrinhDaoTao",
                table: "SinhVienVaChuongTrinhDaoTao");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "SinhVienVaChuongTrinhDaoTao",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "SinhVienId",
                table: "Diem",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Diem",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SinhVienVaChuongTrinhDaoTao",
                table: "SinhVienVaChuongTrinhDaoTao",
                columns: new[] { "UserName", "ChuongTrinhDaoTaoId" });

            migrationBuilder.CreateIndex(
                name: "IX_SinhVienVaChuongTrinhDaoTao_SinhVienId",
                table: "SinhVienVaChuongTrinhDaoTao",
                column: "SinhVienId");

            migrationBuilder.AddForeignKey(
                name: "FK_Diem_AspNetUsers_SinhVienId",
                table: "Diem",
                column: "SinhVienId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
