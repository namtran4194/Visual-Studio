using System;
using System.Data.Entity;

namespace DemoWebApiConnectDb.Models
{
    public class DbLazadaContext : DbContext
    {
        public DbLazadaContext(String chuoiKetNoi) : base(chuoiKetNoi) { }

        public DbSet<LoaiSanPham> tbLoaiSanPham { get; set; }

        public DbSet<SanPham> tbSanPham { get; set; }
    }
}
