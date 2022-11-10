using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thuctap01.Models;

namespace Thuctap01.Services
{
    public interface IHethongUudai
    {
        //List<HethongModels> GetLuongAll();
    }
    public class HethongUudaiSvc:IHethongUudai
    {
        protected DataBaseContext _context;

        public HethongUudaiSvc(DataBaseContext context)
        {
            _context = context;
        }
    }
}
