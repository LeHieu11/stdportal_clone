using API.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Bogus;

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
            
            // Seeding MonHoc data
            var monHocFaker = new Faker<MonHoc>("vi")
                .RuleFor(mh => mh.MaMonHoc, f => f.Random.String2(5))
                .RuleFor(mh => mh.TenMonHoc, f => f.Name.JobTitle())
                .RuleFor(mh => mh.MoTa, f => f.Lorem.Paragraphs())
                .RuleFor(mh => mh.TinChi, f => f.Random.Int(3, 5))
                .RuleFor(mh => mh.TinChiLyThuyet, (f, mh) => f.Random.Int(3, mh.TinChi))
                .RuleFor(mh => mh.TinChiThucHanh, (f, mh) => mh.TinChi - mh.TinChiLyThuyet);
            
            var MonHocs = monHocFaker.Generate(30);
            modelBuilder.Entity<MonHoc>().HasData(MonHocs);

            // Seeding HocPhi data
            var hocPhiFaker = new Faker<HocPhi>("vi")
                .RuleFor(hp => hp.HocPhiId, f => f.Random.String2(5))
                .RuleFor(hp => hp.NamHoc, f => 
                    {
                        var namHoc = f.Random.Int(2015, 2020);
                        return $"{namHoc}-{namHoc + 1}";
                    })
                .RuleFor(hp => hp.SoTien, f => f.Random.Int(1000000, 5000000));

            var HocPhis = hocPhiFaker.Generate(30); 
            modelBuilder.Entity<HocPhi>().HasData(HocPhis);

            // Seeding CTDT data
            var CTDTFaker = new Faker<ChuongTrinhDaoTao>("vi")
                .RuleFor(ctdt => ctdt.ChuongTrinhDaoTaoId, f => f.Random.String2(5))
                .RuleFor(ctdt => ctdt.HeDaoTao, f => "Đại học")
                .RuleFor(ctdt => ctdt.Nganh, f => f.Name.JobArea())
                .RuleFor(ctdt => ctdt.ChuyenNganh, (f, ctdt) => ctdt.Nganh)
                .RuleFor(ctdt => ctdt.NienKhoa, f => f.Random.Int(2015, 2020));

            var CTDTs = CTDTFaker.Generate(3);
            modelBuilder.Entity<ChuongTrinhDaoTao>().HasData(CTDTs);

            // Seeding CTDTchitiet data
            var CTDTCTFaker = new Faker<ChuongTrinhDaoTaoChiTiet>("vi")
                .RuleFor(ctdtct => ctdtct.ChuongTrinhDaoTaoChiTietId, f => f.Random.String2(5))
                .RuleFor(ctdtct => ctdtct.HocKy, f => f.Random.Int(1, 8).ToString())
                .RuleFor(ctdtct => ctdtct.ChuongTrinhDaoTaoId, f => f.PickRandom(CTDTs).ChuongTrinhDaoTaoId)
                .RuleFor(ctdtct => ctdtct.MonHocMaMonHoc, f => f.PickRandom(MonHocs).MaMonHoc)
                .RuleFor(ctdtct => ctdtct.HocPhiId, f => f.PickRandom(HocPhis).HocPhiId);

            var CTDTCTs = CTDTCTFaker.Generate(30);
            modelBuilder.Entity<ChuongTrinhDaoTaoChiTiet>().HasData(CTDTCTs);
        }
    }
}