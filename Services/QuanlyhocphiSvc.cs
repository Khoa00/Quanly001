using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thuctap01.Models;

namespace Thuctap01.Services
{
    public interface IQuanlyhocphi
    {
        List<QuanlyhocphiModel> GetQuanlyhocphiModelAll();
        int AddQuanlyhocphiModel(QuanlyhocphiModel quanlyhocphi);
        QuanlyhocphiModel GetQuanlyhocphiModel(int id);
        int EditQuanlyhocphiModel(int id, QuanlyhocphiModel quanlyhocphi);
    }
    public class QuanlyhocphiSvc : IQuanlyhocphi
    {
            protected DataBaseContext _context;

            public QuanlyhocphiSvc(DataBaseContext context)
            {
                _context = context;
            }
        public List<QuanlyhocphiModel> GetQuanlyhocphiModelAll()
        {
            List<QuanlyhocphiModel> list = new List<QuanlyhocphiModel>();
            list = _context.QuanyhocphiModelss.ToList();
            return list;
        }
        public QuanlyhocphiModel GetQuanlyhocphiModel(int id)
        {
            QuanlyhocphiModel quanlyhocphi = null;
            quanlyhocphi = _context.QuanyhocphiModelss.Find(id);
            return quanlyhocphi;
        }
        public int AddQuanlyhocphiModel(QuanlyhocphiModel quanlyhocphi)
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
        public int EditQuanlyhocphiModel(int id, QuanlyhocphiModel quanlyhocphi)
        {
            int ret = 0;
            try
            {
                QuanlyhocphiModel _quanlyhocphi = null;
                _quanlyhocphi = GetQuanlyhocphiModel(id);

                _quanlyhocphi.Mahocvien = quanlyhocphi.Mahocvien;
                _quanlyhocphi.Tenhocvien = quanlyhocphi.Tenhocvien;
                _quanlyhocphi.lop = quanlyhocphi.lop;
                _quanlyhocphi.Khoakhoi = quanlyhocphi.Khoakhoi;
                
                _quanlyhocphi.Doituong = quanlyhocphi.Doituong;
                _quanlyhocphi.DienThoai = quanlyhocphi.DienThoai;
                _quanlyhocphi.NgayNhapHoc = quanlyhocphi.NgayNhapHoc;
                _quanlyhocphi.Hocphi = quanlyhocphi.Hocphi;
                _quanlyhocphi.Tonghocphi = quanlyhocphi.Tonghocphi;
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
