using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thuctap01.Models;

namespace Thuctap01.Services
{
    public interface IQuanlyhocphi
    {
        List<QuanlyhocphiModel> GetQuanlyhocphiAll();
        int AddQuanlyhocphi(QuanlyhocphiModel quanlyhocphi);
        QuanlyhocphiModel GetQuanlyhocphi(int id);
        int EditQuanlyhocphi(int id, QuanlyhocphiModel quanlyhocphi);
    }
    public class QuanlyhocphiSvc : IQuanlyhocphi
    {
        protected DataBaseContext _context;

        public QuanlyhocphiSvc(DataBaseContext context)
        {
            _context = context;
        }
        public List<QuanlyhocphiModel> GetQuanlyhocphiAll()
        {
            List<QuanlyhocphiModel> list = new List<QuanlyhocphiModel>();
            list = _context.QuanyhocphiModels.ToList();
            return list;
        }
       
        public int AddQuanlyhocphi(QuanlyhocphiModel quanlyhocphi)
        {
            int ret = 0;
            try
            {
                _context.Add(quanlyhocphi);
                _context.SaveChanges();
                ret = quanlyhocphi.Mahocvien;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }
        public QuanlyhocphiModel GetQuanlyhocphi(int id)
        {
            QuanlyhocphiModel quanlyhocphi = null;
            quanlyhocphi = _context.QuanyhocphiModels.Find(id);
            return quanlyhocphi;
        }
        public int EditQuanlyhocphi(int id, QuanlyhocphiModel quanlyhocphi)
        {
            int ret = 0;
            try
            {
                QuanlyhocphiModel _quanlyhocphi = null;
                _quanlyhocphi = GetQuanlyhocphi(id);

                _quanlyhocphi.Mahocvien = quanlyhocphi.Mahocvien;
                _quanlyhocphi.Tenhocvien = quanlyhocphi.Tenhocvien;
                _quanlyhocphi.lop = quanlyhocphi.lop;
                _quanlyhocphi.nienkhoa = quanlyhocphi.nienkhoa;
                _quanlyhocphi.Khoakhoi = quanlyhocphi.Khoakhoi;                
                _quanlyhocphi.Doituong = quanlyhocphi.Doituong;
                _quanlyhocphi.DienThoai = quanlyhocphi.DienThoai;
                _quanlyhocphi.NgayNhapHoc = quanlyhocphi.NgayNhapHoc;
                _quanlyhocphi.Hocphi = quanlyhocphi.Hocphi;
                //_quanlyhocphi.Tonghocphi = quanlyhocphi.Tonghocphi;
                _quanlyhocphi.Trangthai = quanlyhocphi.Trangthai;
                _quanlyhocphi.Thucthu = quanlyhocphi.Thucthu;
                _quanlyhocphi.Ngaythu = quanlyhocphi.Ngaythu;

                _context.Update(_quanlyhocphi);
                _context.SaveChanges();
                ret = quanlyhocphi.Mahocvien;
            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }
    }
}
