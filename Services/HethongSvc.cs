using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thuctap01.Models;

namespace Thuctap01.Services
{
    public interface IHethong
    {
        //List<HethongModels> GetLuongAll();
    }
    public class HethongSvc: IHethong
    {
        protected DataBaseContext _context;

        public HethongSvc(DataBaseContext context)
        {
            _context = context;
        }
        //public List<HethongModels> GetLuongAll()
        //{
        //    List<HethongModels> list = new List<HethongModels>();
        //    list = _context.He.ToList();
        //    return list;
        //}
    }
}
