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
                    { "bauih", "Security", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 800, DateTimeKind.Unspecified).AddTicks(6625), new TimeSpan(0, 7, 0, 0, 0)), "", null, "Đại học", true, false, "", null, "Security", 2020 },
                    { "slrxs", "Creative", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 800, DateTimeKind.Unspecified).AddTicks(6586), new TimeSpan(0, 7, 0, 0, 0)), "", null, "Đại học", true, false, "", null, "Creative", 2020 },
                    { "uafub", "Tactics", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 800, DateTimeKind.Unspecified).AddTicks(5486), new TimeSpan(0, 7, 0, 0, 0)), "", null, "Đại học", true, false, "", null, "Tactics", 2020 }
                });

            migrationBuilder.InsertData(
                table: "HocPhi",
                columns: new[] { "HocPhiId", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "IsActive", "IsDelete", "LastUpdatedBy", "LastUpdatedTime", "NamHoc", "SoTien" },
                values: new object[,]
                {
                    { "aaxwt", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3258), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2019-2020", 4057955 },
                    { "afyzm", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3322), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2019-2020", 4377116 },
                    { "bhtyl", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3270), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2020-2021", 1624935 },
                    { "ccdwy", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3305), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2019-2020", 4304969 },
                    { "fnuek", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3224), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2019-2020", 2902579 },
                    { "gqqkk", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3218), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2019-2020", 3978023 },
                    { "hcxyn", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3148), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2015-2016", 1546980 },
                    { "hktja", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3282), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2017-2018", 4254557 },
                    { "hmtmu", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3161), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2020-2021", 1537950 },
                    { "ikkxs", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3277), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2017-2018", 1179586 },
                    { "ivfsh", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3333), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2017-2018", 2875859 },
                    { "iwkyk", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3184), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2016-2017", 3923107 },
                    { "jlvty", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3189), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2018-2019", 2677817 },
                    { "ldxdb", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3316), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2016-2017", 2836721 },
                    { "ldymi", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3310), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2017-2018", 2757751 },
                    { "mdppc", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3114), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2018-2019", 2481079 },
                    { "nslxr", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(1193), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2016-2017", 3530693 },
                    { "oghtx", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3172), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2019-2020", 3465595 },
                    { "oitov", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3213), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2017-2018", 2436822 },
                    { "oksnk", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3167), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2016-2017", 2725602 },
                    { "pftkp", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3155), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2015-2016", 2533190 },
                    { "qpbev", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3299), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2017-2018", 4490920 },
                    { "qtqjd", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3207), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2018-2019", 1703222 },
                    { "sfolp", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3201), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2020-2021", 4833443 },
                    { "tbasf", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3178), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2016-2017", 4040382 },
                    { "vfvoj", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3288), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2019-2020", 4523655 },
                    { "vndql", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3264), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2018-2019", 1971288 },
                    { "vznjh", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3327), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2020-2021", 4748683 },
                    { "weuoh", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3294), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2017-2018", 2866170 },
                    { "xdrja", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 799, DateTimeKind.Unspecified).AddTicks(3196), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "2019-2020", 2905855 }
                });

            migrationBuilder.InsertData(
                table: "MonHoc",
                columns: new[] { "MaMonHoc", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "IsActive", "IsDelete", "LastUpdatedBy", "LastUpdatedTime", "MoTa", "RangBuocMonHocId", "TenMonHoc", "TinChi", "TinChiLyThuyet", "TinChiThucHanh" },
                values: new object[,]
                {
                    { "acprp", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(4844), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Bốn em thôi tám cái được may ba ghét. Ờ cái xe ba đang tàu nghỉ lầu xe ba. Giày xuồng vàng nhà. Một con nha mướn bơi ác đá đập lỗi.\n\nViệc đã phá một. Thì yêu hai mua. Mây bàn giết bốn gió leo khâu đỏ.\n\nMua lỗi chết hóa là một. Ngọt xe một bảy ngọt. Bạn là độc vàng mây không. Mười sáu là khoảng việc em thích nhà. Khoan mượn mua viết kim sáu con em tàu.", null, "Global Intranet Producer", 5, 5, 0 },
                    { "cwesk", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(5534), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Vàng thì leo may. Giày mướn khoan nha đồng. Đồng bàn làm nón một thương bảy. Con trời ghế ruộng. Mướn đã ngọt trăng biết biết. Giày khoan máy vàng chìm hai đã vá.\n\nThì được được đánh phá đánh quê tím. Khâu ngọt đạp ba chín làm. Gió trời quần nghỉ giày bạn đang đồng. Tô ruộng xanh tím đạp hết đồng làm vá. Được áo bơi đá chín tàu đạp trời. Con một bơi bơi là mua ừ.\n\nMướn em không khoan. Đã biết ờ leo ngọt sáu được. Xanh chín á tàu. Khoan thì không ngọt khâu. Đã biển xanh biết.", null, "Global Intranet Liaison", 3, 3, 0 },
                    { "cwxik", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Làm giày nha hai nước tủ nón chỉ mua. Hết lỗi vá vá đập chìm. Anh viết làm nhà đã hai con nghỉ ghét.\n\nQuê tôi bơi bàn tôi. Gì khoảng hóa hóa. Tám gió khâu thế ruộng nước. Nước mua tô thuyền gió viết vá khâu.\n\nLeo tám thôi cái xuồng mây thôi ghế. Mây thuyền giết trăng xe đâu ừ dép độc nhà. Ba gió tô mượn hóa chìm xe.", null, "Lead Factors Architect", 3, 3, 0 },
                    { "eamyl", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(3611), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Không đỏ mua em quê tôi tàu. Được thì đồng chỉ ghế lầu ác. Thuyền đã chỉ ba. Máy lỗi tô đang đồng xe vá.\n\nLeo đá khoan đập đỏ ác. Làm chìm đã leo chín tàu bạn kim chín áo. May chín thôi máy thì việc giết con ừ. Hết không bơi trời xuồng việc mười. Phá bạn chỉ hàng. Kim cửa hết hết đánh thích máy ghế bốn mượn.\n\nXanh nghỉ ghế viết đạp nhà trời ruộng. Quần cái tui hết thế may áo thế thế. Mười đánh nghỉ may tui. Tím gì ruộng mây thì độc thích cửa quê nghỉ.", null, "Dynamic Mobility Administrator", 3, 3, 0 },
                    { "edisx", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(1375), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Máy cửa giết may hai. Con ba lầu tím chết ngọt leo đồng chìm. Chìm phá thương hết cửa. Sáu giày yêu mây hương. Hàng bạn ghế thì. Ừ bảy may đá.\n\nThuyền vẽ bơi. Cửa bơi sáu. Cái độc thuê ba lầu hương dép áo xe. Hết giày khâu lầu vẽ bốn đá tôi thôi.\n\nMay con sáu xuồng đã viết cái bơi áo. Đập khoảng chín tui. Đâu nghỉ bốn xanh tô. Đỏ trời tôi hóa thì chìm tím ghét ác.", null, "Internal Marketing Coordinator", 3, 3, 0 },
                    { "euhpn", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(1190), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Đã việc thương tàu gì viết. Máy chết hương. Á thuyền thuyền quê thôi.\n\nGiày hai hết vàng một ác mua khoảng ghế. Biết dép lầu ngọt. Được tủ may ừ. Đâu nón xe.\n\nBàn đâu là mua. Thôi chín áo thôi xanh. Quần nón xanh hai vẽ lỗi chín đá á. Hết tám một. Tàu thương nhà bảy máy thương đá.", null, "Investor Marketing Manager", 3, 3, 0 },
                    { "fflgp", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(5806), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Gì nha thôi bạn nghỉ ừ khâu. Ác quần mười giày cửa làm. Con ghét đồng leo thôi thôi tủ bàn. Ghế thôi nghỉ quê kim làm. Cửa ghế mướn ruộng thì mượn con trời thôi làm.\n\nVẽ ừ vá độc một ba nghỉ áo quê sáu. Thương tôi vẽ làm. Hóa đánh nón không bơi anh đã xuồng. Ghế tủ một thuê lỗi đạp chín bàn độc giày. Viết bàn trời tủ bè biết độc dép. Giết cửa khoan thế.\n\nNước khâu mây đá biết biết kim. Phá tôi quần được khâu hai. Bàn ác tô thuyền. Khoảng hai ờ may đánh mượn làm. Thế cửa bảy thì thuyền tôi. Thương cửa mua lầu á ờ mây mua.", null, "Corporate Program Technician", 4, 4, 0 },
                    { "fmhmw", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(3871), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Trời áo khoan giày vẽ mây tủ ừ chín bạn. Thích nước ba mây lầu đạp. Nghỉ ngọt đang lỗi thuyền thương nhà tôi tám.\n\nXe hai không vá chìm gì. Nón gì nước tô tui đá. Ừ nhà tám ừ ờ hóa. Tím cái tô biển. Ruộng hương mướn gì khâu biết.\n\nMây sáu nghỉ viết. Áo thuyền khoảng làm con thương không mây bạn khâu. Trời dép đồng thuyền. Việc trăng làm đang đá quần vá vẽ đập hết.", null, "District Markets Consultant", 5, 3, 2 },
                    { "gzgzu", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(2066), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Tô thuê mướn trăng quê. Gì hương cửa vàng khoan bàn xe sáu. Bè máy đồng chìm đỏ thôi nghỉ. Thuyền đá ừ núi nha bàn. Khoan tàu ghét con bạn hết khoan mướn.\n\nMua mua hết tủ. Cửa năm nhà độc bàn là. Nón thương đánh khoan trời đâu.\n\nLà anh vá đang nón. Yêu con biết bè. Lầu biển được. Bảy bảy xuồng thuê trời leo hết. Leo yêu hàng tui. Thôi ác biển khoảng vàng đập bơi vàng.", null, "National Solutions Technician", 4, 4, 0 },
                    { "hlcun", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(7468), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Cái khoảng hóa đá tủ hai. Kim hương thuê á ruộng leo đã. Bơi thuê bè mua. Vàng bốn thích. Tím á xanh hai núi được thôi áo việc.\n\nMay làm chỉ hết lỗi. Chỉ may hết hàng. Mướn áo hết tám thôi. Nón mua độc leo yêu.\n\nLà ừ tô ruộng áo sáu một mua. Bốn vá gì trời mướn mướn tô. Việc mướn hóa mây làm năm mười.", null, "District Program Planner", 4, 3, 1 },
                    { "jxlrb", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(1592), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Trăng đá biển yêu nhà ruộng. Xuồng tô bè giày lỗi thuê hết xe đồng chìm. Biển cái ba thích tôi. Xuồng vàng bơi viết.\n\nÁc làm đập. Mướn đang á máy. Hết thế thì lỗi.\n\nYêu bàn máy. Mướn biển nha hết áo ngọt. Ghế việc ừ khoan ừ lầu hàng chín. Mười đỏ khâu núi cái nha ừ thì xe.", null, "International Applications Administrator", 3, 3, 0 },
                    { "kwoaw", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(6652), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Mười nghỉ biển cái. Ác thế ờ hàng tám bảy lỗi. Thương đồng làm. Xanh thuyền đang quê gió vẽ trăng hai đỏ. Biển đánh nha chìm viết vàng mười nước đập một. Bốn nghỉ đang giết máy hương.\n\nNón thôi ác. Làm hết đã tủ không chín yêu. Dép giết khoan bơi tôi. Lầu bàn yêu yêu trời thích. Mượn ghế đang mượn áo ừ đập ờ. Nha mượn áo việc đánh ừ đồng phá đồng.\n\nThì đâu chỉ đập. Con bơi ngọt đang kim. Leo hai thôi đâu thế mướn khoan ngọt thuê. Đánh trăng nhà chín chết hóa nhà ngọt.", null, "Legacy Interactions Director", 5, 3, 2 },
                    { "lxkxb", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(2511), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Tàu thương gì mười thế quần. Khoảng giết hai trời khâu đang tím đá. Khâu đánh lỗi lầu đạp. Đang ghế chết là phá đang ghế ba. Vá đá chỉ hết bảy độc bạn đang.\n\nĐánh mướn tàu thuyền đánh kim đá giết là đã. Mướn độc xuồng yêu được biết hết giết hóa. Tui đánh thuyền bàn được khoảng vẽ hàng trăng.\n\nQuần nha quê tám nha đâu gì. Tui đập may bảy mười mướn chỉ hương trăng. Bạn bạn giết đạp dép xe á mua đồng. Thì thế đánh lầu.", null, "Future Accountability Analyst", 3, 3, 0 },
                    { "nsqnb", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(6105), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Áo thuê đánh núi con ờ được. Viết khoảng hết không. Xe hàng anh sáu vàng quê tôi thì á á. Thế khoảng ờ khâu. Ruộng tui ba con khoan là giết.\n\nQuần viết chết yêu. Thế biết thôi trời. Trời nhà ác vá trời nón việc quê chết. Đá dép tui ghét nghỉ ác chín tám quần. Đá khoảng áo ờ con phá vẽ quần ghét. Trăng ghét ghế thích phá mướn ừ năm con.\n\nMướn bạn trăng đánh xe không. Lầu máy đá giày đạp ừ xuồng ghế ruộng. Máy xe nhà quê. Bảy dép biết. Xuồng quần lầu hóa gió đập á.", null, "Human Research Liaison", 5, 4, 1 },
                    { "qybaj", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(2988), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Ngọt ruộng lầu sáu kim ngọt. Đạp cái hai mượn á hai. Nha độc giày một. Việc hết việc lỗi mướn bè. Vẽ núi trời lỗi sáu áo sáu. Đỏ gì em độc đâu đánh thì ruộng.\n\nÁ leo biết thôi lỗi đâu. Thế vá vẽ hương độc thuyền. Trời máy không viết lầu chỉ. Đá yêu xe tủ cái trăng nón đá đá ác. Là lỗi hết việc không.\n\nNón chìm tôi hương tím hóa khâu thương thuê dép. Sáu á bạn chín thuê ba may hai độc bàn. Tím lỗi chỉ khoan leo. Đỏ cái bơi sáu á đâu trăng đang.", null, "Regional Creative Associate", 3, 3, 0 },
                    { "sccta", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(2282), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Vàng khoan hóa khoan bơi hai tôi bốn làm thế. Nước xe thôi việc. Dép hết quần độc kim phá vá. Chìm ừ ác thuê. Mua thì mượn máy độc là ờ hóa thế. Bàn đang đã phá khâu thì nha chín.\n\nChìm tôi giết hàng khâu. Em là sáu nghỉ ờ cửa nghỉ ghế đang máy. Bạn trăng tím. Ruộng khoan đỏ leo đập ruộng thích.\n\nXe thì vẽ biết tím biển. Biển không gì. Khoảng em nón. Khoan thuyền ờ mua.", null, "International Communications Associate", 5, 5, 0 },
                    { "sdpgk", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(3435), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Thích dép mua. Giết đánh thích xanh nghỉ phá. Ừ thì tám.\n\nMáy thì không hóa khoan đạp may. Máy vá khâu hết. Độc tôi cửa hết giày hóa chỉ. Viết hết thích thương.\n\nKhông leo nước xe mây tủ thương. Thuyền tôi vẽ đã. Nón chỉ một bè đang gì bơi chìm á. Anh đã khâu tui tô ờ xe việc.", null, "Customer Accountability Liaison", 5, 4, 1 },
                    { "tmmnc", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Vàng mượn giết bạn trăng ừ. Giết ác kim không đã thuê khâu. Anh tàu núi ác ừ xuồng núi bè làm. Biển dép mượn. Em vàng thôi máy xanh trăng tàu ừ đỏ.\n\nLeo không chìm tủ dép tàu mua đang. Cửa tàu nước khâu trời anh. Hết mượn vẽ ngọt. Đã xe trời thì đập thôi lỗi. Bơi gì nha không máy mượn mây tím.\n\nỜ độc chìm giày em nha. Khoảng ờ gì đâu chết đỏ. Không đánh ngọt hết mướn khâu hóa mượn á. Ừ mây may việc tám mười. Anh ngọt mây làm đã độc tủ. Mượn tám đánh bè yêu dép tủ bạn.", null, "Global Implementation Engineer", 3, 3, 0 },
                    { "tojev", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(6953), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Gió tui thế nha. Ghét ác đã đỏ con ghét đá bốn. Biển ruộng gió. Gió ờ thuyền ác.\n\nBa con tàu nha may thương bạn được thế đồng. Tui hàng đập gì hóa là tôi là. Ba vẽ thế được.\n\nMây ba biển thế trời hàng hết. Đã lỗi là tô việc ừ ờ bơi thương. Khoảng chín ba. Là lỗi bè.", null, "Forward Branding Associate", 5, 3, 2 },
                    { "vcoef", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(671), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Ác quần bàn khoan ghế đỏ yêu vẽ quần. Á áo gì hàng tím. Xe ác á tô vẽ vàng đập khoảng. Thế cái mượn yêu bơi nhà em.\n\nYêu là khoảng tím. Em chìm nhà khoảng chết. May may em. Phá nha bạn. Tủ xe leo ác chỉ ghế anh khoảng núi dép.\n\nChỉ thế á hương đã quần lỗi con dép. Bơi đồng đỏ giày thế nghỉ núi tàu. Mượn hương con chín anh yêu. Xe thuyền bè đỏ dép mua lầu yêu vá. Á tủ chỉ bảy trời.", null, "Direct Tactics Coordinator", 4, 3, 1 },
                    { "vtzht", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(4344), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Đập giày mười vá núi thuê ừ xe tủ đang. Á quê khoảng tám đá khoan ác hai em. Đâu thôi làm. Mua việc tủ mướn nước đánh trăng. Tám một thích quần đập làm biển em mây.\n\nBiết ngọt bảy nhà chỉ á đâu. Lầu xe gì đâu việc thôi bảy nha. Lỗi viết nghỉ quần năm được hương gió. Á ruộng biển ngọt xanh hết.\n\nBa em mười hết may đã cửa chín cửa một. Không tím phá hết được bơi trời tui thương. Phá mướn khoảng đỏ đã là tôi chỉ con em. Gì hóa may chỉ đồng ruộng em. Ghế tô xuồng ngọt yêu tôi đang lỗi.", null, "Future Data Analyst", 4, 3, 1 },
                    { "wckpd", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(949), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Núi ba hết là hai. Độc mười mười đập. Thích được mua đỏ. Tím xanh nhà nón đập. Tám kim thế mây giày không bảy quê mây.\n\nKhoảng cái tím tím bốn nha ba ừ. Thế máy gì ruộng vá bè con hương hai thì. Gió đồng cửa.\n\nHết tôi xuồng em quê. Bàn đâu được thuê tui bạn đồng lầu. Bốn yêu xuồng khâu cái hương. Hết khoan nghỉ hết giết bàn.", null, "International Identity Associate", 4, 3, 1 },
                    { "woatt", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(5267), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Bốn phá hương đâu là đập quần ngọt. Bè vá hàng bè đạp. Khoảng con đập biển trăng. Giết việc em thì giết thì thôi dép. Đạp ba viết đồng biển đỏ khoảng ngọt lỗi. Thuê hết vàng kim đã ghét.\n\nAnh chìm tàu bàn chìm làm. Tím ghét chết tui đập ờ. Khoan thôi máy đập con nghỉ đã. Vá thì khoảng mây đập hóa em một lỗi bạn. Tủ đã đá dép hương hai.\n\nỜ quê ác đạp con. Kim tôi sáu sáu xe ghế. Đánh bè xanh xanh khoảng bơi đá may thì kim. Nha bè mây thôi hàng khoan chết nước ngọt mướn.", null, "District Configuration Supervisor", 4, 4, 0 },
                    { "xafhp", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(7227), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Bàn đá kim mây phá nha vá thì năm xanh. Nghỉ ừ đá độc dép khâu nón trăng hương đạp. Nón bàn đập gì khâu trăng tui chìm tủ. Hết đỏ núi. Năm yêu tôi lỗi thương mười ghế xanh chỉ á.\n\nỪ giết chết. Hương khoảng bốn. Làm đạp lầu khoan trăng máy độc. Tô chết làm cửa cửa.\n\nBa tui vàng thuyền trời một hóa hai nước. Hàng vẽ yêu ờ biển bảy đá đỏ. Bảy ba ờ gì đá. Dép con sáu thuê khoảng leo bè chỉ vẽ.", null, "District Research Planner", 3, 3, 0 },
                    { "xfltv", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(2733), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Mây chìm đạp nón đạp không. Đâu quần trăng. Đánh ngọt làm hương. Làm khoảng mượn phá là cái ghét quê đồng hóa. Leo thôi núi đánh biển thương ruộng tôi.\n\nÁ cửa tô sáu bơi ngọt bảy nha. Máy đang nghỉ ờ hàng giết đánh gió. Chín tàu cái bơi hương trời tôi thế. Gì dép quần hóa. Tô lỗi đỏ biển vá thích núi anh hết thương.\n\nỜ đỏ đang chìm bạn đá thôi hóa kim. Chìm chết máy giày. Con tàu kim. Bè đang nghỉ nghỉ ừ tám đâu.", null, "Dynamic Implementation Facilitator", 3, 3, 0 },
                    { "xfwwm", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(6433), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Chín bạn phá mướn khoảng. Trăng thì tui đạp mướn nhà một. Đá biển kim độc chỉ đạp việc đã ngọt tủ. Mây mướn quần khoảng xuồng áo á tủ.\n\nĐạp biển được. Làm khoảng biển. Tui xanh yêu đồng chết cửa đập tím vẽ. May mua năm ngọt cửa ghét biết nón.\n\nTô hóa tôi ba. Xanh tủ nhà đánh hóa. Bàn khoan em mướn khoảng mượn tám. Tô ruộng lỗi tím.", null, "Investor Applications Supervisor", 3, 3, 0 },
                    { "xgjli", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(4615), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Viết tàu tàu trời đạp viết làm đánh. Á máy khâu. Cửa ghế chỉ tím xuồng bàn giày. Xanh đồng giết đập ruộng nón ngọt. Ngọt đang chìm thế sáu ngọt khoảng viết. Độc vàng ác quê ba nón quê.\n\nNha tôi đâu thương anh độc nón tôi cửa. Thích được bè khâu độc chỉ tô trời chín. Ruộng nước đỏ á tủ bạn.\n\nĐồng mượn giết trăng bè đánh may. Xe trời hương hết ờ đâu quê nghỉ. Mây lầu đồng trời giết dép bơi tui xe. Ngọt tàu hết không xe.", null, "Direct Factors Specialist", 5, 4, 1 },
                    { "xutvn", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(4078), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Đánh dép may cửa ghế quần biển. Bốn ác xe được bảy đạp con may tám áo. Đồng ừ nhà bàn đồng ừ xuồng đánh nha quê. Bơi hương biển nghỉ nhà yêu.\n\nThì bè phá. Bè độc nước ác yêu mây á. Đạp bơi thuyền cửa yêu khoảng đánh cái. Thương thế tui mây mượn khâu ghét tô ờ độc. Đang đánh mua quê. Ruộng con anh nón xuồng hết.\n\nLỗi chết biết tủ đánh được mười em thì hương. Đạp chết hàng cửa bạn vẽ. Sáu đã em là bảy đánh anh. Mười áo cái leo khoan bè.", null, "Dynamic Division Planner", 5, 5, 0 },
                    { "yrjem", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 797, DateTimeKind.Unspecified).AddTicks(5071), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Tím phá mây dép. Quần biển viết thích. Quê biết chín đã đập thuyền tui hương thế lầu. Cửa hết không thích núi hai đâu gió hai á. Thuê biển đã áo ngọt chết.\n\nXe ờ xe. Bạn cửa thôi chín hương việc lỗi. Hai leo anh tủ bàn quê không phá tô.\n\nGiày ờ tủ chết gió nước hàng đang. Quê xuồng áo hai đã sáu quần hết thích trăng. Nước năm ngọt thì hai xe. Nhà đập xanh.", null, "Forward Response Administrator", 4, 4, 0 },
                    { "zrubd", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 796, DateTimeKind.Unspecified).AddTicks(9900), new TimeSpan(0, 7, 0, 0, 0)), "", null, true, false, "", null, "Núi đá quê bàn. Ruộng mướn vá. Vẽ quần đồng đá cửa làm em. Áo thôi một hương mượn. Chín hết núi đánh thì trời tô mượn. Bè đã phá thuê mượn.\n\nGiày giày đang làm sáu được xe. Nhà viết hương trời chìm con ghét mây khoảng con. Ngọt hóa hàng tím vẽ thì mướn. Tàu ghế bốn thuyền trăng đá.\n\nĐộc lỗi áo bảy dép hai. Phá ghét may tám á đang thuê cái tôi bàn. Nha mây khâu anh.", null, "Principal Interactions Designer", 4, 4, 0 }
                });

            migrationBuilder.InsertData(
                table: "ChuongTrinhDaoTaoChiTiet",
                columns: new[] { "ChuongTrinhDaoTaoChiTietId", "ChuongTrinhDaoTaoId", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "HocKy", "HocPhiId", "IsActive", "IsDelete", "LastUpdatedBy", "LastUpdatedTime", "MonHocMaMonHoc" },
                values: new object[,]
                {
                    { "apolk", "bauih", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9230), new TimeSpan(0, 7, 0, 0, 0)), "", null, "7", "qtqjd", true, false, "", null, "zrubd" },
                    { "arnxj", "uafub", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9149), new TimeSpan(0, 7, 0, 0, 0)), "", null, "7", "qpbev", true, false, "", null, "lxkxb" },
                    { "awxsy", "slrxs", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(8844), new TimeSpan(0, 7, 0, 0, 0)), "", null, "3", "ldymi", true, false, "", null, "hlcun" },
                    { "boiog", "bauih", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9284), new TimeSpan(0, 7, 0, 0, 0)), "", null, "6", "ldxdb", true, false, "", null, "edisx" },
                    { "dfdoc", "uafub", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9221), new TimeSpan(0, 7, 0, 0, 0)), "", null, "1", "ikkxs", true, false, "", null, "nsqnb" },
                    { "eeufj", "slrxs", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9260), new TimeSpan(0, 7, 0, 0, 0)), "", null, "7", "oksnk", true, false, "", null, "kwoaw" },
                    { "fjull", "uafub", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9368), new TimeSpan(0, 7, 0, 0, 0)), "", null, "6", "bhtyl", true, false, "", null, "sdpgk" },
                    { "gcypa", "slrxs", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9128), new TimeSpan(0, 7, 0, 0, 0)), "", null, "7", "oghtx", true, false, "", null, "cwxik" },
                    { "kfzgp", "uafub", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9377), new TimeSpan(0, 7, 0, 0, 0)), "", null, "4", "nslxr", true, false, "", null, "zrubd" },
                    { "lvkqe", "uafub", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9141), new TimeSpan(0, 7, 0, 0, 0)), "", null, "2", "oksnk", true, false, "", null, "cwxik" },
                    { "mseze", "bauih", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9246), new TimeSpan(0, 7, 0, 0, 0)), "", null, "6", "sfolp", true, false, "", null, "xgjli" },
                    { "nmssb", "uafub", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9385), new TimeSpan(0, 7, 0, 0, 0)), "", null, "4", "oitov", true, false, "", null, "edisx" },
                    { "nplmr", "bauih", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9238), new TimeSpan(0, 7, 0, 0, 0)), "", null, "6", "ccdwy", true, false, "", null, "euhpn" },
                    { "nrgms", "slrxs", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9313), new TimeSpan(0, 7, 0, 0, 0)), "", null, "6", "tbasf", true, false, "", null, "wckpd" },
                    { "nseub", "slrxs", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9360), new TimeSpan(0, 7, 0, 0, 0)), "", null, "3", "ikkxs", true, false, "", null, "edisx" },
                    { "nyxam", "bauih", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9270), new TimeSpan(0, 7, 0, 0, 0)), "", null, "2", "weuoh", true, false, "", null, "vcoef" },
                    { "pvjpy", "bauih", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9344), new TimeSpan(0, 7, 0, 0, 0)), "", null, "8", "aaxwt", true, false, "", null, "gzgzu" },
                    { "rizgq", "uafub", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9211), new TimeSpan(0, 7, 0, 0, 0)), "", null, "8", "weuoh", true, false, "", null, "woatt" },
                    { "rjned", "uafub", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9110), new TimeSpan(0, 7, 0, 0, 0)), "", null, "3", "hmtmu", true, false, "", null, "eamyl" },
                    { "rwqta", "slrxs", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9299), new TimeSpan(0, 7, 0, 0, 0)), "", null, "7", "tbasf", true, false, "", null, "kwoaw" },
                    { "scxmd", "uafub", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9292), new TimeSpan(0, 7, 0, 0, 0)), "", null, "6", "mdppc", true, false, "", null, "nsqnb" },
                    { "srzfp", "bauih", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9305), new TimeSpan(0, 7, 0, 0, 0)), "", null, "1", "oghtx", true, false, "", null, "wckpd" },
                    { "stiko", "bauih", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9172), new TimeSpan(0, 7, 0, 0, 0)), "", null, "2", "iwkyk", true, false, "", null, "euhpn" },
                    { "tciqx", "slrxs", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9352), new TimeSpan(0, 7, 0, 0, 0)), "", null, "4", "xdrja", true, false, "", null, "zrubd" },
                    { "uggxo", "uafub", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9181), new TimeSpan(0, 7, 0, 0, 0)), "", null, "6", "mdppc", true, false, "", null, "sccta" },
                    { "wsuuj", "bauih", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9191), new TimeSpan(0, 7, 0, 0, 0)), "", null, "1", "afyzm", true, false, "", null, "vtzht" },
                    { "wzent", "slrxs", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9277), new TimeSpan(0, 7, 0, 0, 0)), "", null, "6", "qpbev", true, false, "", null, "zrubd" },
                    { "yfptb", "bauih", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9253), new TimeSpan(0, 7, 0, 0, 0)), "", null, "3", "gqqkk", true, false, "", null, "hlcun" },
                    { "ygsxc", "uafub", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9203), new TimeSpan(0, 7, 0, 0, 0)), "", null, "8", "fnuek", true, false, "", null, "xafhp" },
                    { "ysgqk", "uafub", "", new DateTimeOffset(new DateTime(2024, 9, 27, 21, 10, 51, 801, DateTimeKind.Unspecified).AddTicks(9162), new TimeSpan(0, 7, 0, 0, 0)), "", null, "2", "fnuek", true, false, "", null, "jxlrb" }
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
