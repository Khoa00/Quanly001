using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thuctap01.Models;

namespace Thuctap01.Services
{
    public interface IHethongUudai
    {
        List<HethongModels> GetHeThongAll();
        List<hethonguudaimodel> GetHeThongUudaiAll();
        int AddHeThong(HethongModels hethongModels);
        int AddHeThongUudai(hethonguudaimodel hethonguudaimodels);
        hethonguudaimodel GetHeThongUudai(int id);
        int EditHeThongUudai(int id, hethonguudaimodel hethonguudaimodels);
    }
    public class HethongUudaiSvc: IHethongUudai
    {
        protected DataBaseContext _context;

        public HethongUudaiSvc(DataBaseContext context)
        {
            _context = context;
        }
        public List<HethongModels> GetHeThongAll()
        {
            List<HethongModels> list = new List<HethongModels>();
            list = _context.HethongModels.ToList();
            return list;
        }
        public List<hethonguudaimodel> GetHeThongUudaiAll()
        {
            List<hethonguudaimodel> list = new List<hethonguudaimodel>();
            list = _context.Hethonguudaimodels.ToList();
            return list;
        }
        public int AddHeThong(HethongModels hethongModels)
        {
            int ret = 0;
            try
            {
                _context.Add(hethongModels);
                _context.SaveChanges();
                ret = hethongModels.Matruong;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }
        public int AddHeThongUudai(hethonguudaimodel hethonguudaimodels)
        {
            int ret = 0;
            try
            {
                _context.Add(hethonguudaimodels);
                _context.SaveChanges();
                ret = hethonguudaimodels.Mauudai;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }
        public hethonguudaimodel GetHeThongUudai(int id)
        {
            hethonguudaimodel hethonguudaimodels = null;
            hethonguudaimodels = _context.Hethonguudaimodels.Find(id);
            return hethonguudaimodels;
        }
        public int EditHeThongUudai(int id, hethonguudaimodel hethonguudaimodel)
        {
            int ret = 0;
            try
            {
                hethonguudaimodel _hethonguudaimodel = null;
                _hethonguudaimodel = GetHeThongUudai(id);
                _hethonguudaimodel.Uudai = hethonguudaimodel.Uudai;
                _hethonguudaimodel.Loaiuudai = hethonguudaimodel.Loaiuudai;
                _hethonguudaimodel.Giamhocphi = hethonguudaimodel.Giamhocphi;
                _hethonguudaimodel.Apdung = hethonguudaimodel.Apdung;
                _hethonguudaimodel.Trangthai = hethonguudaimodel.Trangthai;
                _hethonguudaimodel.Batdau =hethonguudaimodel.Batdau;
                _hethonguudaimodel.Ketthuc = hethonguudaimodel.Ketthuc;

                _context.Update(_hethonguudaimodel);
                _context.SaveChanges();
                ret = hethonguudaimodel.Mauudai;
            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }
    }
}
