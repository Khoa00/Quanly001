using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thuctap01.Models;

namespace Thuctap01.Services
{
    public interface IGiangvien
    {
    }
    public class GiangvienSvc:IGiangvien    
    {
        protected DataBaseContext _context;

        public GiangvienSvc(DataBaseContext context)
        {
            _context = context;

        }
    }
}
