using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DemoWebApiConnectDb.Models
{
    public class LoaiSanPham
    {
        [Key]
        public int MaLoaiSP { get; set; }

        public string TenLoaiSP { get; set; }

        public int MaLoai_Cha { get; set; }

        public ICollection<SanPham> SanPham { get; set; }
    }
}
