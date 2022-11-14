using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thuctap01.Models;

namespace Thuctap01.Services
{
    public interface IThongbao
    {
        List<ThongbaoModel> GetThongbaoAll();
        int AddThongbao(ThongbaoModel thongbao);
        ThongbaoModel GetThongbao(int id);
        int EditThongbao(int id, ThongbaoModel thongbao);
    }
    public class ThongbaoSvc: IThongbao
    {
        protected DataBaseContext _context;

        public ThongbaoSvc(DataBaseContext context)
        {
            _context = context;
        }
        public List<ThongbaoModel> GetThongbaoAll()
        {
            List<ThongbaoModel> list = new List<ThongbaoModel>();
            list = _context.ThongbaoModels.ToList();
            return list;
        }
        public int AddThongbao(ThongbaoModel thongbao)
        {
            int ret = 0;
            try
            {
                _context.Add(thongbao);
                _context.SaveChanges();
                ret = thongbao.Matieude;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }
        public ThongbaoModel GetThongbao(int id)
        {
            ThongbaoModel thongbao = null;
            thongbao = _context.ThongbaoModels.Find(id);
            return thongbao;
        }

        public int EditThongbao(int id, ThongbaoModel thongbao)
        {
            int ret = 0;
            try
            {
                ThongbaoModel _thongbao = null;
                _thongbao = GetThongbao(id);
                _thongbao.Matieude = thongbao.Matieude;
                _thongbao.tieude = thongbao.tieude;

                _thongbao.Nguoinhan = thongbao.Nguoinhan;
                _thongbao.hinhthucgui = thongbao.hinhthucgui;
                _thongbao.Filedinhkem = thongbao.Filedinhkem;
                _thongbao.ImageFile = thongbao.ImageFile;
                _thongbao.Ngaygui = thongbao.Ngaygui;
                _thongbao.Gionhan = thongbao.Gionhan; 

                _context.Update(_thongbao);
                _context.SaveChanges();
                ret = thongbao.Matieude;
            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }
    }
}
