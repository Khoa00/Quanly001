using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thuctap01.Models;

namespace Thuctap01.Services
{
    public interface IThongbaodagui
    {
        //List<HethongModels> GetLuongAll();
    }
    public class ThongbaodaguiSvc: IThongbaodagui
    {
        protected DataBaseContext _context;

        public ThongbaodaguiSvc(DataBaseContext context)
        {
            _context = context;
        }
    }
}
