using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thuctap01.Models;

namespace Thuctap01.Services
{
    public interface IQuanlyluong
    {
        List<QuanlyluongModel> GetQuanLyLuongAll();
        int AddQuanLyLuong(QuanlyluongModel quanlyluong);
        QuanlyluongModel GetQuanLyLuong(int id);
        int EditQuanLyLuong(int id, QuanlyluongModel quanlyluong);
    }
    public class QuanlyluongSvc: IQuanlyluong
    {
        protected DataBaseContext _context;

        public QuanlyluongSvc(DataBaseContext context)
        {
            _context = context;
        }
        public List<QuanlyluongModel> GetQuanLyLuongAll()
        {
            List<QuanlyluongModel> list = new List<QuanlyluongModel>();
            list = _context.QuanlyluongModels.ToList();
            return list;
        }
        public int AddQuanLyLuong(QuanlyluongModel quanlyluong)
        {
            int ret = 0;
            try
            {
                _context.Add(quanlyluong);
                _context.SaveChanges();
                ret = quanlyluong.Mabangluong;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }
        public QuanlyluongModel GetQuanLyLuong(int id)
        {
            QuanlyluongModel quanlyluong = null;
            quanlyluong = _context.QuanlyluongModels.Find(id);
            return quanlyluong;
        }
        public int EditQuanLyLuong(int id, QuanlyluongModel quanlyluong)
        {
            int ret = 0;
            try
            {
                QuanlyluongModel _quanlyluong = null;
                _quanlyluong = GetQuanLyLuong(id);

                _quanlyluong.Mabangluong = quanlyluong.Mabangluong;
                _quanlyluong.Tenbangluong = quanlyluong.Tenbangluong;
                _quanlyluong.Kitinhluong = quanlyluong.Kitinhluong;
                _quanlyluong.Tongluongphaichi = quanlyluong.Tongluongphaichi;
                _quanlyluong.Dachiluong = quanlyluong.Dachiluong;
                _quanlyluong.Chuchiluong = quanlyluong.Chuchiluong;
                _quanlyluong.Trangthai = quanlyluong.Trangthai;

                _context.Update(_quanlyluong);
                _context.SaveChanges();
                ret = quanlyluong.Mabangluong;
            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }
    }
}
