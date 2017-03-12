using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class ProductBll
    {
        private QLBHDataContext _context = new QLBHDataContext();

        public List<SanPham> ProductList()
        {
            return _context.SanPhams.ToList();
        }
    }
}
