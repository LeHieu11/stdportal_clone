using API.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.DbContext
{
    public class MyDbContext : IdentityDbContext<SinhVien>
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            
        }

        //List of DBset/table
        public DbSet<ChuongTrinhDaoTaoChiTiet> ChuongTrinhDaoTaoChiTiet { get; set; }
        public DbSet<ChuongTrinhDaoTaoVaNhomMonHoc> ChuongTrinhDaoTaoVaNhomMonHoc { get; set; }
        public DbSet<ChuongTrinhDaoTao> ChuongTrinhDaoTao { get; set; }
        public DbSet<HocPhi> HocPhi { get; set; }
        public DbSet<MonHoc> MonHoc { get; set; }
        public DbSet<NhomMonHocVaMonHoc> NhomMonHocVaMonHoc { get; set; }
        public DbSet<NhomMonHoc> NhomMonHoc { get; set; }
        public DbSet<RangBuocMonHoc> RangBuocMonHoc { get; set; }
        public DbSet<SinhVien> SinhVien{ get; set; }
        public DbSet<SinhVienVaChuongTrinhDaoTao> SinhVienVaChuongTrinhDaoTao { get; set; }
        public DbSet<Diem> Diem { get; set; }
        public DbSet<RangBuocMonHocChiTiet> RangBuocMonHocChiTiet { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
    }
}