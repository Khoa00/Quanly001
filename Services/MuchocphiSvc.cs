using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thuctap01.Models;

namespace Thuctap01.Services
{
    public interface IMuchocphi
    {
        List<MuchocphiModel> GetMuchocphiAll();
        int AddMuchocphi(MuchocphiModel muchocphi);
        MuchocphiModel GetMuchocphi(int id);
        int EditMuchocphi(int id, MuchocphiModel muchocphi);
    }
    public class MuchocphiSvc : IMuchocphi
    {
        protected DataBaseContext _context;

        public MuchocphiSvc(DataBaseContext context)
        {
            _context = context;

        }
        public List<MuchocphiModel> GetMuchocphiAll()
        {
            List<MuchocphiModel> list = new List<MuchocphiModel>();
            list = _context.MuchocphiModels.ToList();
            return list;
        }
        public MuchocphiModel GetMuchocphi(int id)
        {
            MuchocphiModel muchocphi = null;
            muchocphi = _context.MuchocphiModels.Find(id);
            return muchocphi;
        }
        public int AddMuchocphi(MuchocphiModel muchocphi)
        {
            int ret = 0;
            try
            {
                _context.Add(muchocphi);
                _context.SaveChanges();
                ret = muchocphi.Mamonhoc;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }
        public int EditMuchocphi(int id, MuchocphiModel muchocphi)
        {
            int ret = 0;
            try
            {
                MuchocphiModel _muchocphi = null;
                _muchocphi = GetMuchocphi(id);

                _muchocphi.Mamonhoc = muchocphi.Mamonhoc;
                _muchocphi.Monhoc = muchocphi.Monhoc;
                _muchocphi.Khoakhoi = muchocphi.Khoakhoi;
                _muchocphi.ThoiLuong = muchocphi.ThoiLuong;
                _muchocphi.Donvitinh = muchocphi.Donvitinh;
                _muchocphi.mucthu = muchocphi.mucthu;
                _muchocphi.nienkhoa = muchocphi.nienkhoa;
                _muchocphi.Tonghocphi = muchocphi.Tonghocphi;
                _muchocphi.Trangthai = muchocphi.Trangthai;

                _context.Update(_muchocphi);
                _context.SaveChanges();
                ret = muchocphi.Mamonhoc;
            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }
    }
}
