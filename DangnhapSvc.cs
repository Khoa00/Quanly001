using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thuctap01.Models;

namespace Thuctap01.Services
{
    public interface IDangnhap
    {
    }
    public class DangnhapSvc: IDangnhap
    {
        protected DataBaseContext _context;

        public DangnhapSvc(DataBaseContext context)
        {
            _context = context;

        }
    }
}
