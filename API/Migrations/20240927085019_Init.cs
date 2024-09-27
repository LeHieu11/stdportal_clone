using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChuongTrinhDaoTao",
                columns: table => new
                {
                    ChuongTrinhDaoTaoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HeDaoTao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nganh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChuyenNganh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NienKhoa = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuongTrinhDaoTao", x => x.ChuongTrinhDaoTaoId);
                });

            migrationBuilder.CreateTable(
                name: "HocPhi",
                columns: table => new
                {
                    HocPhiId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NamHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoTien = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocPhi", x => x.HocPhiId);
                });

            migrationBuilder.CreateTable(
                name: "NhomMonHoc",
                columns: table => new
                {
                    NhomMonHocId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenNhom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhomMonHoc", x => x.NhomMonHocId);
                });

            migrationBuilder.CreateTable(
                name: "RangBuocMonHoc",
                columns: table => new
                {
                    RangBuocMonHocId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoaiRangBuoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RangBuocMonHoc", x => x.RangBuocMonHocId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SinhVienVaChuongTrinhDaoTao",
                columns: table => new
                {
                    SinhVienId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ChuongTrinhDaoTaoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhVienVaChuongTrinhDaoTao", x => new { x.SinhVienId, x.ChuongTrinhDaoTaoId });
                    table.ForeignKey(
                        name: "FK_SinhVienVaChuongTrinhDaoTao_AspNetUsers_SinhVienId",
                        column: x => x.SinhVienId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SinhVienVaChuongTrinhDaoTao_ChuongTrinhDaoTao_ChuongTrinhDaoTaoId",
                        column: x => x.ChuongTrinhDaoTaoId,
                        principalTable: "ChuongTrinhDaoTao",
                        principalColumn: "ChuongTrinhDaoTaoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChuongTrinhDaoTaoVaNhomMonHoc",
                columns: table => new
                {
                    ChuongTrinhDaoTaoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NhomMonHocId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuongTrinhDaoTaoVaNhomMonHoc", x => new { x.ChuongTrinhDaoTaoId, x.NhomMonHocId });
                    table.ForeignKey(
                        name: "FK_ChuongTrinhDaoTaoVaNhomMonHoc_ChuongTrinhDaoTao_ChuongTrinhDaoTaoId",
                        column: x => x.ChuongTrinhDaoTaoId,
                        principalTable: "ChuongTrinhDaoTao",
                        principalColumn: "ChuongTrinhDaoTaoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChuongTrinhDaoTaoVaNhomMonHoc_NhomMonHoc_NhomMonHocId",
                        column: x => x.NhomMonHocId,
                        principalTable: "NhomMonHoc",
                        principalColumn: "NhomMonHocId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonHoc",
                columns: table => new
                {
                    MaMonHoc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenMonHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TinChi = table.Column<int>(type: "int", nullable: false),
                    TinChiLyThuyet = table.Column<int>(type: "int", nullable: false),
                    TinChiThucHanh = table.Column<int>(type: "int", nullable: false),
                    RangBuocMonHocId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonHoc", x => x.MaMonHoc);
                    table.ForeignKey(
                        name: "FK_MonHoc_RangBuocMonHoc_RangBuocMonHocId",
                        column: x => x.RangBuocMonHocId,
                        principalTable: "RangBuocMonHoc",
                        principalColumn: "RangBuocMonHocId");
                });

            migrationBuilder.CreateTable(
                name: "ChuongTrinhDaoTaoChiTiet",
                columns: table => new
                {
                    ChuongTrinhDaoTaoChiTietId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HocKy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChuongTrinhDaoTaoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MonHocMaMonHoc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HocPhiId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuongTrinhDaoTaoChiTiet", x => x.ChuongTrinhDaoTaoChiTietId);
                    table.ForeignKey(
                        name: "FK_ChuongTrinhDaoTaoChiTiet_ChuongTrinhDaoTao_ChuongTrinhDaoTaoId",
                        column: x => x.ChuongTrinhDaoTaoId,
                        principalTable: "ChuongTrinhDaoTao",
                        principalColumn: "ChuongTrinhDaoTaoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChuongTrinhDaoTaoChiTiet_HocPhi_HocPhiId",
                        column: x => x.HocPhiId,
                        principalTable: "HocPhi",
                        principalColumn: "HocPhiId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChuongTrinhDaoTaoChiTiet_MonHoc_MonHocMaMonHoc",
                        column: x => x.MonHocMaMonHoc,
                        principalTable: "MonHoc",
                        principalColumn: "MaMonHoc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Diem",
                columns: table => new
                {
                    DiemId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SinhVienId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MonHocMaMonHoc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TongKet = table.Column<double>(type: "float", nullable: false),
                    QuaTrinh1 = table.Column<double>(type: "float", nullable: false),
                    QuaTrinh2 = table.Column<double>(type: "float", nullable: false),
                    GiuaKy = table.Column<double>(type: "float", nullable: false),
                    CuoiKy = table.Column<double>(type: "float", nullable: false),
                    HocKy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Diem_MonHoc_MonHocMaMonHoc",
                        column: x => x.MonHocMaMonHoc,
                        principalTable: "MonHoc",
                        principalColumn: "MaMonHoc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NhomMonHocVaMonHoc",
                columns: table => new
                {
                    NhomMonHocId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaMonHoc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhomMonHocVaMonHoc", x => new { x.NhomMonHocId, x.MaMonHoc });
                    table.ForeignKey(
                        name: "FK_NhomMonHocVaMonHoc_MonHoc_MaMonHoc",
                        column: x => x.MaMonHoc,
                        principalTable: "MonHoc",
                        principalColumn: "MaMonHoc",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NhomMonHocVaMonHoc_NhomMonHoc_NhomMonHocId",
                        column: x => x.NhomMonHocId,
                        principalTable: "NhomMonHoc",
                        principalColumn: "NhomMonHocId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RangBuocMonHocChiTiet",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RangBuocMonHocId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MonHocMaMonHoc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RangBuocMonHocChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RangBuocMonHocChiTiet_MonHoc_MonHocMaMonHoc",
                        column: x => x.MonHocMaMonHoc,
                        principalTable: "MonHoc",
                        principalColumn: "MaMonHoc",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RangBuocMonHocChiTiet_RangBuocMonHoc_RangBuocMonHocId",
                        column: x => x.RangBuocMonHocId,
                        principalTable: "RangBuocMonHoc",
                        principalColumn: "RangBuocMonHocId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ChuongTrinhDaoTao",
                columns: new[] { "ChuongTrinhDaoTaoId", "ChuyenNganh", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "HeDaoTao", "IsActive", "IsDelete", "LastUpdatedBy", "LastUpdatedTime", "Nganh", "NienKhoa" },
                values: new object[,]
                {
                    { "fvcnt", "Web", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 845, DateTimeKind.Unspecified).AddTicks(6826), new TimeSpan(0, 7, 0, 0, 0)), "", null, "Đại học", true, false, "", null, "Web", 2020 },
                    { "lsucp", "Usability", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 845, DateTimeKind.Unspecified).AddTicks(5117), new TimeSpan(0, 7, 0, 0, 0)), "", null, "Đại học", true, false, "", null, "Usability", 2017 },
                    { "xozxj", "Branding", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 845, DateTimeKind.Unspecified).AddTicks(6871), new TimeSpan(0, 7, 0, 0, 0)), "", null, "Đại học", true, false, "", null, "Branding", 2019 }
                });

            migrationBuilder.InsertData(
                table: "HocPhi",
                columns: new[] { "HocPhiId", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "IsActive", "IsDelete", "LastUpdatedBy", "LastUpdatedTime", "NamHoc", "SoTien" },
                values: new object[,]
                {
                    { "brfxh", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(4079), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2015-2016", 4285444 },
                    { "drgrh", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(3988), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2019-2020", 3392455 },
                    { "fjlsk", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(3838), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2015-2016", 4753994 },
                    { "ghrmm", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(4006), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2019-2020", 4434875 },
                    { "gnmim", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(3913), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2019-2020", 3956874 },
                    { "grzqc", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(4012), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2016-2017", 2219423 },
                    { "gtnlj", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(3982), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2016-2017", 4539435 },
                    { "ihfro", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(3994), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2016-2017", 1757378 },
                    { "jcezo", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(3958), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2017-2018", 1897735 },
                    { "jpeic", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(3976), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2015-2016", 2851970 },
                    { "kbbid", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(1578), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2017-2018", 4992744 },
                    { "lwdvn", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(3885), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2019-2020", 3434411 },
                    { "mwrxp", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(3900), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2015-2016", 4004908 },
                    { "niuks", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(4087), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2019-2020", 4113887 },
                    { "oxesh", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(3951), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2018-2019", 1178039 },
                    { "peoyu", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(4106), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2019-2020", 3728433 },
                    { "prmuo", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(3926), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2019-2020", 4509581 },
                    { "prpom", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(3963), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2015-2016", 1970671 },
                    { "qmacp", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(4094), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2019-2020", 2529264 },
                    { "qwilm", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(3907), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2018-2019", 2763478 },
                    { "qxgii", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(4100), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2018-2019", 3241740 },
                    { "stkda", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(4018), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2017-2018", 1211992 },
                    { "tjync", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(3893), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2017-2018", 2199818 },
                    { "uymhk", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(4000), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2018-2019", 4042485 },
                    { "vvmty", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(3970), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2018-2019", 3119215 },
                    { "vwvxq", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(3933), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2020-2021", 1898070 },
                    { "wnyhp", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(3939), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2015-2016", 3734406 },
                    { "xtcny", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(3945), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2016-2017", 3062534 },
                    { "xzgwd", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(4113), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2019-2020", 4103978 },
                    { "yiydl", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 843, DateTimeKind.Unspecified).AddTicks(3920), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2015-2016", 4938698 }
                });

            migrationBuilder.InsertData(
                table: "MonHoc",
                columns: new[] { "MaMonHoc", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "IsActive", "IsDelete", "LastUpdatedBy", "LastUpdatedTime", "MoTa", "RangBuocMonHocId", "TenMonHoc", "TinChi", "TinChiLyThuyet", "TinChiThucHanh" },
                values: new object[,]
                {
                    { "aqhpq", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 840, DateTimeKind.Unspecified).AddTicks(458), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Mua lầu thương anh chỉ tím thuê. Khoan kim nha trời cái hương áo bè chín đánh. Giày thương năm cửa bốn đạp bạn xe ghế. Ruộng quê á hết hàng tám khoảng phá lầu bàn. Hết thuê tui vàng may gì năm nha đâu nghỉ. Ghế mướn tím.\n\nMua bốn đâu đá quần ừ. Ruộng á ừ phá cái anh được giết leo khâu. Ghế ừ tô đã xuồng nhà hai. Tôi ba xuồng ừ. Chỉ không chìm hết đâu giày biết á. Đạp chỉ bạn tô lỗi con á thương kim ác.\n\nVẽ mười vá quần yêu. Quê ờ giết bàn biển. Khâu mây leo.", null, "Customer Communications Supervisor", 4, 3, 1 },
                    { "aqjww", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 840, DateTimeKind.Unspecified).AddTicks(3663), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Nghỉ anh hương lầu yêu mượn tủ không quần. Em việc cái. Biết được khoan chín vàng.\n\nQuần thuyền trời hết đập nước anh trăng bạn. Chín gió hương hàng đạp thế tím. Giết hàng xuồng ờ hết mây anh chìm.\n\nĐánh mướn ghét em. Gì ờ ghét. Ghét hóa làm yêu ác. Gì giày trăng tủ. Gì đá khâu làm.", null, "Senior Web Executive", 5, 4, 1 },
                    { "awmwx", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 839, DateTimeKind.Unspecified).AddTicks(4710), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Con chết vẽ biển khoảng ác nón đập mua. Làm mây kim một tô nhà gió. Tám được mua quê áo. Tôi nước dép viết năm hàng bè.\n\nTôi leo được ba thì xe hết bàn gió. Cái đồng bảy lầu. Ghế nghỉ mây bảy.\n\nLàm chìm đạp ác thế bơi. Vàng đâu bạn. Dép hương hương.", null, "Future Markets Strategist", 3, 3, 0 },
                    { "cqsnz", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 840, DateTimeKind.Unspecified).AddTicks(2637), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Vẽ đá cái giày mây sáu mười á. Xanh thôi đồng đồng xuồng tàu vàng năm. Con vá thì khâu thuyền dép leo đâu khoảng. Phá đã biển đang đã mười bốn cái. Việc chết vá khoan tôi quần.\n\nThuyền thuyền một hai. Vẽ thì cái. Con tô đồng. Vẽ bàn đồng.\n\nTím ờ bơi ờ ghét bè mua tám. Biển ba khâu giày con hàng giết ruộng ờ mây. Mua độc ghét. Mướn lầu em bè cái nón trăng. Nước đánh đỏ một hết chín lỗi biển.", null, "Direct Solutions Specialist", 3, 3, 0 },
                    { "eaveh", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 839, DateTimeKind.Unspecified).AddTicks(8739), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Phá mượn viết khâu hai xe xe. Anh biển quê trời nghỉ khoan đánh khoan hết sáu. Bốn hết tui nón độc không bạn hết. Hóa đá thế mười.\n\nChỉ cửa đỏ tôi đỏ trăng yêu viết ghế. Thích tô mây ba thôi nước biết vẽ nha. Thích mượn hóa bè áo vàng đâu gió thương nước. Vá may không. Hàng hàng khoảng.\n\nÁo thế núi khâu tôi thuyền không. Bốn bảy được leo núi đang biển con bốn nón. Một tủ đang gì.", null, "Corporate Tactics Planner", 5, 5, 0 },
                    { "eqopu", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 840, DateTimeKind.Unspecified).AddTicks(1149), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Nha đạp sáu bàn đang. Trăng núi khoảng ừ chỉ. Chín núi thế được ờ ngọt yêu. Vá đã á hóa ghế tím nghỉ đánh. Tủ nghỉ hết nước máy hết mướn nha kim gió. Giết đâu khoan nón đồng thế hàng đồng.\n\nMây cửa nghỉ yêu ác ghế trăng nghỉ. Em gió ba hết đá bơi. Khoảng đá đập đỏ xe bảy.\n\nHết tủ quần nhà giết giày. Đạp thích đạp ruộng vá ngọt dép nha. Sáu thuê tủ. Anh biển tui ba.", null, "Customer Research Architect", 5, 3, 2 },
                    { "feakz", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 840, DateTimeKind.Unspecified).AddTicks(4413), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Em tủ leo ba làm lỗi tôi vá. Đá mua tui. Chín hai chỉ ờ mây năm đã nhà độc kim. Lầu năm vàng. May khâu giày hết bàn nha việc nón. Trăng ruộng ruộng.\n\nKhoan làm ờ trời việc chín. Nhà thôi xe. Núi nha xanh trăng nước đập hai anh vàng. Thôi sáu thì trăng bảy leo ghế nước chỉ chỉ.\n\nBiết việc hàng vá mướn. Năm mướn nhà tím thương yêu. Khoảng hết xanh chết nước đập.", null, "Dynamic Metrics Representative", 5, 4, 1 },
                    { "fnseb", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 839, DateTimeKind.Unspecified).AddTicks(9563), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Em quần nón tôi ghét giày anh. Áo thì lỗi khoan. Gì áo bè tủ thuyền ghế hàng thế xe.\n\nChìm giết hết gió được đâu kim bè. Ghét đập yêu tui một tôi khâu năm mua. Là xanh hương năm á đã việc. Hết nghỉ núi trời. Vá mây thôi biển nhà thuyền ừ đạp thuê áo. Nhà hàng núi.\n\nTui ừ tui là xanh đạp hết viết đánh thuyền. Viết vá may mướn chết. Thôi tủ khoan con. Đã trời đồng. Đã bàn áo lỗi thôi độc áo tủ thuyền. Cửa vá mây gió.", null, "Chief Response Representative", 4, 4, 0 },
                    { "gfvda", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 839, DateTimeKind.Unspecified).AddTicks(8429), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Gió anh ngọt thương vàng khoan. Tàu bảy không ghế đã việc. Con lầu quê hết đánh hương chết ghét. Trời á khoảng. Vẽ hàng đã không đập cửa năm thôi phá cửa. Chín tím thích hết xanh ờ máy dép.\n\nThế viết đập. Gió nha gió áo ác nước hết. Vàng hết ngọt. Lỗi xe bàn tui nghỉ ờ vá đồng. Máy leo đánh yêu bạn.\n\nĐồng biết mười tám xe. Hàng vàng đá đâu trời bơi. Viết ờ tủ giết con. Khâu ác á ghế đánh yêu thích thôi mướn.", null, "Product Research Agent", 3, 3, 0 },
                    { "gjdje", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 839, DateTimeKind.Unspecified).AddTicks(6353), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Ghét bàn cửa đập ngọt mượn tô gì gì xe. Kim lầu chìm viết mướn mây. Bàn khoảng mượn. Thế mượn độc lầu đang. Yêu ác máy sáu núi.\n\nHàng tô gì độc xuồng nghỉ mười không em trời. Hết hết chỉ tím thuyền ba em chín. Đâu leo độc sáu.\n\nRuộng một hết thì giết may tô thế cửa. Quần sáu khoảng đồng nón xuồng ghế độc. Thế thương làm bạn. Lỗi bè vàng ác.", null, "Dynamic Identity Liaison", 5, 4, 1 },
                    { "hekvj", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 840, DateTimeKind.Unspecified).AddTicks(2935), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Ruộng được ác năm nón quần đạp. Anh bốn gió. Hàng ngọt yêu gì máy biết làm.\n\nEm đồng hóa bơi tui vá nha đập ác vá. Đang không anh thôi thì anh ừ. Tàu viết ngọt ừ.\n\nNón thích nón thương ruộng gió đập tím chết. Ba biết tám độc giết bàn em. Vàng ghét bè. Cái đánh nước.", null, "Regional Intranet Analyst", 5, 3, 2 },
                    { "hpvsj", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 840, DateTimeKind.Unspecified).AddTicks(4178), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Hết không cửa tím đâu hóa. Xuồng sáu hương hết trời thì lỗi con. Mười lầu khoan. Em đâu leo mua tím yêu giày.\n\nNha anh đánh việc giày. Bốn xe bảy ghế biết mượn vẽ nhà. Bè biển thương thương độc. Thích xuồng mượn xuồng thế cửa biết đá. Kim trăng lầu gì phá việc.\n\nMượn khoan tủ giết. Bảy vẽ bốn bàn khoảng leo núi hóa. Em thôi ghét được tui may anh.", null, "Global Functionality Analyst", 4, 3, 1 },
                    { "hzgkx", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 839, DateTimeKind.Unspecified).AddTicks(5751), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Xuồng vàng tám khoan. Đỏ yêu ghế bốn bảy vẽ đồng đạp. Ghế nghỉ gió một đồng đồng nha một lầu. Ngọt hai việc giết tím bạn đang đâu.\n\nNha là lỗi thích đánh đâu lỗi được. Viết bốn ghét thuê con tím chín đồng xanh độc. Nha dép xe tui việc áo xuồng bè. Ác tám thế chết đã. Á khâu xuồng đá bốn thuê máy chỉ đang khoan. Giày đã ruộng giết vẽ gì mua một xe.\n\nKim đạp ba. Hương bơi quê thương mướn đỏ mượn giày. Tàu leo em phá nhà nước thích hóa. Thích ba bốn.", null, "International Operations Consultant", 5, 4, 1 },
                    { "ipvkq", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 840, DateTimeKind.Unspecified).AddTicks(2017), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Ba ừ đang khâu giết năm mười chìm may đánh. Tủ đỏ ghét con đồng nha tô ba. Bè thuyền chết biển hết trăng bàn tám nhà.\n\nChết gió thuê mây. Chỉ ờ em quê biết khoảng đỏ xanh. Vàng vá lầu tô ba trăng thuyền ác nón. Khoảng vàng chín cửa vá mười tô cửa tím bảy. Được đạp vá hết đánh hương đạp thế mười. Ghế bảy thuyền chìm cửa á nước khâu khoảng.\n\nHóa năm thuê. Khâu độc trăng thì. Lầu giày gì ruộng tui đá chín thuê quần hóa. Trời con thế. Một con ghét.", null, "Principal Quality Assistant", 3, 3, 0 },
                    { "jodzw", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 839, DateTimeKind.Unspecified).AddTicks(9005), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Đang phá ờ giày khoan lỗi tủ trời nghỉ đá. Thế bàn cái. Chín tô ghế bốn ba tô ghế tô khoan viết. Ác bè ghế lầu gì được. Hương nha khâu quần chết hai.\n\nQuê viết là bơi hàng nhà mua bè thế. Khoan xe một con. Ghế dép làm ruộng.\n\nÁ lỗi mây được nón đã nước. Ghế được nha hai thích chỉ đập hóa. Em cửa em á lỗi hết vàng đánh lỗi thôi. Đá năm khoảng ờ trời vàng em gió chết xe. Bạn năm nghỉ vẽ tui được lỗi anh bè lầu. Sáu cái ngọt quần là tô đánh đồng khoảng gió.", null, "Internal Usability Representative", 4, 3, 1 },
                    { "moore", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 840, DateTimeKind.Unspecified).AddTicks(2336), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Hương nước hương vàng cái tàu hết. Á mua lầu quê viết thì đánh ghét sáu bạn. Không ừ việc. Đâu đang bạn đã hóa gió.\n\nHương ruộng á tím khâu phá máy. Nha thuê đá tàu áo là. Quê nghỉ ác. Biết ờ mướn hóa khoảng xe thì giết. Đập hóa ác á leo mây ghét ừ tui.\n\nThì sáu biển thuyền trời bàn leo máy trời. Dép dép đập đá ghét ngọt đánh leo lỗi ác. Ờ ba tô máy. Thế mượn mười thì con con bàn leo. Chín leo xe ruộng mua khoan lỗi ừ hóa. Vàng quần thương thôi gì em ác chết.", null, "Dynamic Identity Planner", 3, 3, 0 },
                    { "ofpvt", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 840, DateTimeKind.Unspecified).AddTicks(3868), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Ghế may đỏ ừ làm con thì. Tôi viết đánh. Sáu hết bè. Thế khâu đang mua giết đánh quê khoảng áo. Viết chín ờ. Khâu nón nghỉ bàn một viết độc phá đập.\n\nThế ghét bạn làm lỗi. Tô khoan hết may ác tủ đang tui. Hàng ghét đập khoan cái đang vá nước. Tô ghét đạp viết tím ba trăng đã thuyền.\n\nBa quần đang đã ruộng ghế. Chỉ bạn giết độc đã. Bốn giày chín. Chết nón ba ruộng hàng đập tôi đã may năm. Thì lầu độc thì đạp vá.", null, "Customer Metrics Assistant", 4, 4, 0 },
                    { "qilwy", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 839, DateTimeKind.Unspecified).AddTicks(7189), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Trời bè cửa. Khoan máy khoan khâu được. Chìm tàu cái. Tô thì mây xuồng hết hóa. Leo hết núi thích hàng gì đá kim một ừ. Tui đang cửa xe leo đánh cửa cái.\n\nChín mướn xuồng nhà ờ. Hương giày bàn thì xanh đỏ phá thì. Đạp ghét bốn hóa lỗi mua quần chín làm. Yêu thì tui bạn đánh nhà thế.\n\nBơi núi thôi khoan tím vá vàng đập. Đang phá mượn mây đỏ đá sáu. Không đạp tô đang đá gì giết tôi thôi. Lỗi cửa không nước anh thuyền mây.", null, "Global Data Producer", 3, 3, 0 },
                    { "rvkbh", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 840, DateTimeKind.Unspecified).AddTicks(4691), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Đồng vàng nón chìm á không tàu thế quê. Leo tô đạp leo mua. Gì hàng khoan đỏ quê sáu đá mây lầu. Ừ bạn đang thế khoan gió đã.\n\nNúi ghét ghét tám. Là khâu thích biết bơi biển phá thuyền mây. Vẽ vàng xe thế ừ chết. Thôi nước khoảng leo xanh xe mua hết nón.\n\nVàng vẽ lỗi. Thôi tám bơi giày. Cửa ba bàn xe. Mua em ba gió đạp đang bơi. Gì nước việc núi biết cái.", null, "Chief Integration Director", 5, 4, 1 },
                    { "svxwo", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 839, DateTimeKind.Unspecified).AddTicks(7735), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Thôi yêu thương bảy gì ác một. Con ác nha tủ. Hai hàng ba.\n\nKhoảng tui cái đạp nghỉ quê. Cái một bàn. Hết nước làm tím. Khoảng khâu thương biết ngọt khoan. Tôi dép một đã bàn. Trăng hương hàng mướn cái đập giết khâu.\n\nỪ ba không tủ quê. Mướn con năm. Ghét đánh may áo nghỉ một. Áo thôi bảy hương vá á. Khoảng ruộng trời biết áo. Ruộng tàu tôi dép.", null, "Customer Paradigm Specialist", 5, 5, 0 },
                    { "tmmyv", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 840, DateTimeKind.Unspecified).AddTicks(3451), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Hết lỗi tàu. Chết thế con cửa. Nha trời tàu trăng á quê con đỏ hương cửa.\n\nĐạp khâu áo. Đã là trăng mua tàu vẽ gì. Thích lầu quần tám viết.\n\nKhoảng tím năm tôi tám chín. Nón biết đỏ kim bè đánh bàn mười yêu. Biết khâu hóa. Ruộng vá đâu. Giày khâu nha việc đập tím việc ừ tôi trời. Thích dép thuyền.", null, "District Solutions Designer", 4, 4, 0 },
                    { "tswcu", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 840, DateTimeKind.Unspecified).AddTicks(3126), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Xe đập mua. Thế yêu nha không đã leo đá thích tôi. Thuê mua đồng biết xe nhà mười khâu thuyền kim. Gió hết giày.\n\nBốn vẽ mười á đập xe tôi một đá. Vẽ gì bè sáu hàng may. Á bạn may kim. Thích biển núi vẽ em tôi đạp nước leo. Tui ác dép bốn tàu ba đập quê ghế.\n\nYêu quần mượn không hai leo. Giết quần bàn thì con tím hương. Quê quê á hết thì ờ nhà gió thương em. Ác chỉ nghỉ gì tủ á quê ghét bạn bơi.", null, "Senior Operations Analyst", 5, 3, 2 },
                    { "ttruf", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 840, DateTimeKind.Unspecified).AddTicks(147), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Đánh tủ việc tám. Vàng mây ruộng đang tủ mướn máy hết. Không núi một kim thế lỗi kim vẽ một tám. Nón tôi tám đánh kim đồng sáu. Mười kim khoảng nón thuyền dép. Hàng bốn là biển sáu bàn là chìm hai.\n\nKhoan khoan mua thế đồng á. Sáu chỉ ghét tàu may bơi. Kim yêu quần một thương hai nha nhà chết con. Máy nghỉ khoảng hết xe viết nha. Là xe mướn. Được gió lỗi á bàn.\n\nKhâu ba núi thuyền giày thích mua tui thương đâu. Mây á trời khoan độc tô được. May á bảy giết. Hết thích thôi tám cái.", null, "Legacy Operations Technician", 3, 3, 0 },
                    { "ttymw", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 839, DateTimeKind.Unspecified).AddTicks(8172), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Núi ruộng biển mười bạn thương bạn ghét. Dép xanh phá hóa trăng đỏ hàng ừ chìm. Vá lỗi không tui hương thuê hóa. Vẽ tàu làm không gì chìm cửa.\n\nCửa ghét nghỉ. Năm leo xuồng tủ bơi bàn yêu. Yêu được việc ác mây một đang. Nón chết ba ruộng nghỉ. Giày trời ừ biển khâu. Xe việc tô.\n\nDép hai viết bơi nón. Xe áo cái. Xanh hết bốn gì tám ác một kim thì.", null, "Dynamic Security Associate", 4, 4, 0 },
                    { "tvyrd", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 840, DateTimeKind.Unspecified).AddTicks(1439), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Vẽ giết thương. Đang nón quê nha leo chín. Áo hương tô xe mướn khâu. Bạn vẽ năm giày ghét.\n\nÁc tô mướn áo hết xuồng xe cửa. Quê chết bảy thì chìm không biết đánh ba. Gì bốn yêu. Áo trăng hết nước quê leo đâu vá đâu. Việc thôi bè việc bảy đang tím.\n\nGì trăng leo xuồng núi giết không tui ba ác. Tủ hết nghỉ sáu. Đánh tàu bè mượn hết lỗi nha yêu. Nghỉ ờ quần viết ghế cái khoảng ruộng bảy trời. Mây áo hàng may ruộng quần viết gì bè.", null, "Direct Program Planner", 5, 4, 1 },
                    { "tzyok", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 839, DateTimeKind.Unspecified).AddTicks(9876), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Ác mướn đập tôi nón ờ. Cửa xanh không hàng. May yêu anh mướn. Cửa ba nước hết.\n\nLeo biển trăng ghế bàn. Đạp trời giết. Chín được là năm anh. Sáu trăng leo em gì. Đỏ ba vẽ nước đá đã không.\n\nLeo mây tím thương độc. Chết quê mua đâu ờ giày đồng thuê dép bơi. Ghét nghỉ nước xuồng thương vẽ. Lỗi đâu trời đập cửa chín thích thương áo. Dép đâu chết ừ bạn mây tô yêu một đâu.", null, "Dynamic Assurance Liaison", 3, 3, 0 },
                    { "wjssz", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 840, DateTimeKind.Unspecified).AddTicks(4926), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Con nước áo ghét viết độc ừ thế hai bơi. Được ba đỏ. Giết leo quần đang ba gì mười mua nha đập.\n\nKhoan đâu bảy khâu bè lầu giết. Được áo khâu mười yêu đập không đánh bốn là. Đồng tím viết thương bốn. Chín ờ áo anh nha tím. Tô một cái.\n\nHết leo bàn gì. Làm bơi nón máy nón kim đánh áo. Tàu giày không. Viết gió nước khoan núi. Con may mua bàn khoan. Trăng năm em vá dép khâu nón mây.", null, "Global Program Developer", 4, 4, 0 },
                    { "xawjt", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 839, DateTimeKind.Unspecified).AddTicks(9369), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Chìm á độc ba mượn chín được. Nón thích vẽ hương đỏ. Biển ba anh khoan đánh yêu ờ kim việc.\n\nBiết tàu chỉ thì một phá quần. Trời trăng thương mượn nước bảy đạp hết anh. Tàu là hương thế.\n\nNúi mười biển núi đạp tím. Đánh nha hết ác biển tui. Trời được thuê.", null, "Product Quality Executive", 3, 3, 0 },
                    { "xbzts", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 840, DateTimeKind.Unspecified).AddTicks(805), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Một mượn nhà tím khoan hết ba quê. Vẽ khoan thuê thì biển tám bảy. Giết đập giết xuồng ghét không nước á chết thế. Bạn gì bè em một chìm áo đập thích. Nước bàn nón bốn tám ác.\n\nThì gió tím nha đánh may chín trời. Mua chìm tám thuyền leo ờ. Chín đỏ sáu. Đồng núi mướn nghỉ chết. Nhà xanh năm hết vá thôi kim bốn hàng chín. Năm bảy viết hết tím ờ.\n\nLeo tôi thế thương kim mượn bốn leo ừ làm. Làm chín mười. Thuyền xuồng thích em vàng dép gì anh. Thuyền thuê mây tủ ruộng ruộng đã. Chín em mây hương phá năm anh.", null, "District Integration Agent", 3, 3, 0 },
                    { "ywzvt", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 840, DateTimeKind.Unspecified).AddTicks(1698), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Ruộng tui đập thuê tàu đánh vàng chỉ viết. Nước xe gì hàng. Trăng đã đồng gió ghét kim. Hương quần vẽ tôi. Bạn xe tôi sáu ừ xe nón. Khoan tàu đạp.\n\nThế chín tui đập trăng ngọt. Mua giày vá giày con núi. Đá cái cái. Ác anh hàng ác sáu. May một trăng xuồng máy thuê hết dép tủ.\n\nLầu hết thích mượn việc anh anh máy mượn. Gió một nước cửa mướn được thuê ác. Một xe tàu bốn đã em.", null, "Central Factors Designer", 5, 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "ChuongTrinhDaoTaoChiTiet",
                columns: new[] { "ChuongTrinhDaoTaoChiTietId", "ChuongTrinhDaoTaoId", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "HocKy", "HocPhiId", "IsActive", "IsDelete", "LastUpdatedBy", "LastUpdatedTime", "MonHocMaMonHoc" },
                values: new object[,]
                {
                    { "ctsdy", "xozxj", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1363), new TimeSpan(0, 7, 0, 0, 0)), "", null, "7", "uymhk", true, false, "", null, "tswcu" },
                    { "dqprv", "fvcnt", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1271), new TimeSpan(0, 7, 0, 0, 0)), "", null, "6", "ghrmm", true, false, "", null, "ofpvt" },
                    { "dskkr", "fvcnt", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1328), new TimeSpan(0, 7, 0, 0, 0)), "", null, "4", "qwilm", true, false, "", null, "moore" },
                    { "dvgyu", "fvcnt", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1251), new TimeSpan(0, 7, 0, 0, 0)), "", null, "8", "qxgii", true, false, "", null, "jodzw" },
                    { "eegih", "fvcnt", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(759), new TimeSpan(0, 7, 0, 0, 0)), "", null, "7", "ihfro", true, false, "", null, "eaveh" },
                    { "fnsfz", "fvcnt", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1371), new TimeSpan(0, 7, 0, 0, 0)), "", null, "3", "uymhk", true, false, "", null, "xbzts" },
                    { "fyggh", "xozxj", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1169), new TimeSpan(0, 7, 0, 0, 0)), "", null, "6", "qmacp", true, false, "", null, "ywzvt" },
                    { "fzwud", "lsucp", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1261), new TimeSpan(0, 7, 0, 0, 0)), "", null, "1", "jcezo", true, false, "", null, "gjdje" },
                    { "itwnj", "xozxj", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1319), new TimeSpan(0, 7, 0, 0, 0)), "", null, "5", "brfxh", true, false, "", null, "jodzw" },
                    { "jghnf", "lsucp", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1296), new TimeSpan(0, 7, 0, 0, 0)), "", null, "7", "wnyhp", true, false, "", null, "moore" },
                    { "jhzov", "xozxj", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1312), new TimeSpan(0, 7, 0, 0, 0)), "", null, "1", "grzqc", true, false, "", null, "feakz" },
                    { "jwxop", "xozxj", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1450), new TimeSpan(0, 7, 0, 0, 0)), "", null, "1", "gnmim", true, false, "", null, "tmmyv" },
                    { "jynig", "lsucp", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 7, 0, 0, 0)), "", null, "7", "gtnlj", true, false, "", null, "aqjww" },
                    { "kgpsk", "xozxj", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1351), new TimeSpan(0, 7, 0, 0, 0)), "", null, "2", "qxgii", true, false, "", null, "xawjt" },
                    { "lfzzb", "fvcnt", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1221), new TimeSpan(0, 7, 0, 0, 0)), "", null, "3", "brfxh", true, false, "", null, "eqopu" },
                    { "lpyuc", "fvcnt", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1335), new TimeSpan(0, 7, 0, 0, 0)), "", null, "7", "kbbid", true, false, "", null, "rvkbh" },
                    { "mvoas", "fvcnt", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1395), new TimeSpan(0, 7, 0, 0, 0)), "", null, "8", "gtnlj", true, false, "", null, "jodzw" },
                    { "nbvye", "lsucp", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1387), new TimeSpan(0, 7, 0, 0, 0)), "", null, "2", "qwilm", true, false, "", null, "tvyrd" },
                    { "ncfyt", "lsucp", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1230), new TimeSpan(0, 7, 0, 0, 0)), "", null, "7", "mwrxp", true, false, "", null, "tmmyv" },
                    { "nhdxu", "lsucp", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1344), new TimeSpan(0, 7, 0, 0, 0)), "", null, "8", "wnyhp", true, false, "", null, "rvkbh" },
                    { "nirpm", "fvcnt", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1157), new TimeSpan(0, 7, 0, 0, 0)), "", null, "7", "xtcny", true, false, "", null, "hpvsj" },
                    { "oihal", "xozxj", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1182), new TimeSpan(0, 7, 0, 0, 0)), "", null, "6", "prmuo", true, false, "", null, "fnseb" },
                    { "orvzm", "xozxj", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1137), new TimeSpan(0, 7, 0, 0, 0)), "", null, "4", "lwdvn", true, false, "", null, "feakz" },
                    { "tiycb", "xozxj", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1379), new TimeSpan(0, 7, 0, 0, 0)), "", null, "4", "xzgwd", true, false, "", null, "gjdje" },
                    { "tnvor", "fvcnt", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1287), new TimeSpan(0, 7, 0, 0, 0)), "", null, "6", "mwrxp", true, false, "", null, "tswcu" },
                    { "urnhx", "fvcnt", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1240), new TimeSpan(0, 7, 0, 0, 0)), "", null, "2", "niuks", true, false, "", null, "hekvj" },
                    { "vniyi", "xozxj", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1281), new TimeSpan(0, 7, 0, 0, 0)), "", null, "3", "vvmty", true, false, "", null, "hpvsj" },
                    { "vyjjo", "xozxj", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1210), new TimeSpan(0, 7, 0, 0, 0)), "", null, "3", "vwvxq", true, false, "", null, "aqhpq" },
                    { "yiokj", "lsucp", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1440), new TimeSpan(0, 7, 0, 0, 0)), "", null, "7", "jpeic", true, false, "", null, "tzyok" },
                    { "zytes", "xozxj", "", new DateTimeOffset(new DateTime(2024, 9, 27, 15, 50, 18, 848, DateTimeKind.Unspecified).AddTicks(1305), new TimeSpan(0, 7, 0, 0, 0)), "", null, "6", "qwilm", true, false, "", null, "aqhpq" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ChuongTrinhDaoTaoChiTiet_ChuongTrinhDaoTaoId",
                table: "ChuongTrinhDaoTaoChiTiet",
                column: "ChuongTrinhDaoTaoId");

            migrationBuilder.CreateIndex(
                name: "IX_ChuongTrinhDaoTaoChiTiet_HocPhiId",
                table: "ChuongTrinhDaoTaoChiTiet",
                column: "HocPhiId");

            migrationBuilder.CreateIndex(
                name: "IX_ChuongTrinhDaoTaoChiTiet_MonHocMaMonHoc",
                table: "ChuongTrinhDaoTaoChiTiet",
                column: "MonHocMaMonHoc");

            migrationBuilder.CreateIndex(
                name: "IX_ChuongTrinhDaoTaoVaNhomMonHoc_NhomMonHocId",
                table: "ChuongTrinhDaoTaoVaNhomMonHoc",
                column: "NhomMonHocId");

            migrationBuilder.CreateIndex(
                name: "IX_Diem_MonHocMaMonHoc",
                table: "Diem",
                column: "MonHocMaMonHoc");

            migrationBuilder.CreateIndex(
                name: "IX_Diem_SinhVienId",
                table: "Diem",
                column: "SinhVienId");

            migrationBuilder.CreateIndex(
                name: "IX_MonHoc_RangBuocMonHocId",
                table: "MonHoc",
                column: "RangBuocMonHocId");

            migrationBuilder.CreateIndex(
                name: "IX_NhomMonHocVaMonHoc_MaMonHoc",
                table: "NhomMonHocVaMonHoc",
                column: "MaMonHoc");

            migrationBuilder.CreateIndex(
                name: "IX_RangBuocMonHocChiTiet_MonHocMaMonHoc",
                table: "RangBuocMonHocChiTiet",
                column: "MonHocMaMonHoc");

            migrationBuilder.CreateIndex(
                name: "IX_RangBuocMonHocChiTiet_RangBuocMonHocId",
                table: "RangBuocMonHocChiTiet",
                column: "RangBuocMonHocId");

            migrationBuilder.CreateIndex(
                name: "IX_SinhVienVaChuongTrinhDaoTao_ChuongTrinhDaoTaoId",
                table: "SinhVienVaChuongTrinhDaoTao",
                column: "ChuongTrinhDaoTaoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ChuongTrinhDaoTaoChiTiet");

            migrationBuilder.DropTable(
                name: "ChuongTrinhDaoTaoVaNhomMonHoc");

            migrationBuilder.DropTable(
                name: "Diem");

            migrationBuilder.DropTable(
                name: "NhomMonHocVaMonHoc");

            migrationBuilder.DropTable(
                name: "RangBuocMonHocChiTiet");

            migrationBuilder.DropTable(
                name: "SinhVienVaChuongTrinhDaoTao");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "HocPhi");

            migrationBuilder.DropTable(
                name: "NhomMonHoc");

            migrationBuilder.DropTable(
                name: "MonHoc");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ChuongTrinhDaoTao");

            migrationBuilder.DropTable(
                name: "RangBuocMonHoc");
        }
    }
}
