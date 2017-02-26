using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
