using DataAccessLayer;
using System.Linq;
namespace BussinessLogicLayer
{
    public class ProductTypeBll
    {
        private QLBHDataContext _context = new QLBHDataContext();

        public LoaiSanPham GetProduct(int code)
        {
            return _context.LoaiSanPhams.Where(p => p.Ma == code).FirstOrDefault();
        }
    }
}
