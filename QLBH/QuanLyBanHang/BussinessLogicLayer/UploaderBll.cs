using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class UploaderBll
    {
        private QLBHDataContext _context = new QLBHDataContext();

        public bool AddNewFile(string tenThat, string tenFile)
        {
            var upload = new Upload()
            {
                TenFileThat = tenThat,
                TenFile = tenFile
            };
            try
            {
                _context.Uploads.InsertOnSubmit(upload);
                _context.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool DeleteFile(string tenThat)
        {
            try
            {
                _context.Uploads.DeleteOnSubmit(GetFile(tenThat));
                _context.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public Upload GetFile(string tenThat)
        {
            var file = _context.Uploads.Where(f => f.TenFileThat == tenThat).FirstOrDefault();
            return file;
        }
    }
}
