using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thuctap01.Models;

namespace Thuctap01.Services
{
    public interface ILichsunghiphep
    {
        List<LichsunghiphepModel> GetLuongAll();
    }
    public class LichsunghiphepSvc: ILichsunghiphep
    {
        protected DataBaseContext _context;

        public LichsunghiphepSvc(DataBaseContext context)
        {
            _context = context;
        }
        public List<LichsunghiphepModel> GetLuongAll()
        {
            List<LichsunghiphepModel> list = new List<LichsunghiphepModel>();
            list = _context.LichsunghiphepModels.ToList();
            return list;
        }
    }
}
