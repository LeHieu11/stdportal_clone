using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class AlterDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diem",
                columns: table => new
                {
                    DiemId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SinhVienId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MaMonHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonHocMaMonHoc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TongKet = table.Column<double>(type: "float", nullable: false),
                    QuaTrinh1 = table.Column<double>(type: "float", nullable: false),
                    QuaTrinh2 = table.Column<double>(type: "float", nullable: false),
                    GiuaKy = table.Column<double>(type: "float", nullable: false),
                    CuoiKy = table.Column<double>(type: "float", nullable: false),
                    HocKy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diem", x => x.DiemId);
                    table.ForeignKey(
                        name: "FK_Diem_AspNetUsers_SinhVienId",
                        column: x => x.SinhVienId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Diem_MonHoc_MonHocMaMonHoc",
                        column: x => x.MonHocMaMonHoc,
                        principalTable: "MonHoc",
                        principalColumn: "MaMonHoc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Diem_MonHocMaMonHoc",
                table: "Diem",
                column: "MonHocMaMonHoc");

            migrationBuilder.CreateIndex(
                name: "IX_Diem_SinhVienId",
                table: "Diem",
                column: "SinhVienId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diem");
        }
    }
}
