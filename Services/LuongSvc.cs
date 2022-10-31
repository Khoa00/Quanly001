using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thuctap01.Models;

namespace Thuctap01.Services
{
    public interface ILuong
    {
    }
    public class LuongSvc : ILuong
    {
        protected DataBaseContext _context;

        public LuongSvc(DataBaseContext context)
        {
            _context = context;
        }
    }
}
