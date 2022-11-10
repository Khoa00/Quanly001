using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thuctap01.Models;

namespace Thuctap01.Services
{
    public interface IThongbao
    {
        List<ThongbaoModel> GetLuongAll();
    }
    public class ThongbaoSvc: IThongbao
    {
        protected DataBaseContext _context;

        public ThongbaoSvc(DataBaseContext context)
        {
            _context = context;
        }
        public List<ThongbaoModel> GetLuongAll()
        {
            List<ThongbaoModel> list = new List<ThongbaoModel>();
            list = _context.ThongbaoModels.ToList();
            return list;
        }
    }
}
