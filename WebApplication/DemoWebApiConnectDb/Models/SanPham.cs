using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemoWebApiConnectDb.Models
{
    public class SanPham
    {
        [Key]
        public int MaSP { get; set; }

        public string TenSP { get; set; }

        public int MaLoaiSP { get; set; }

        [ForeignKey("MaLoaiSP")]
        public LoaiSanPham LoaiSanPham { get; set; }
    }
}
