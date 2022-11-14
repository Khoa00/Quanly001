//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Thuctap01.Models;

//namespace Thuctap01.Services
//{
//    public interface ILuong
//    {
//        List<LuongModel>GetLuongAll();
//        int AddLuong(LuongModel luong);
//        LuongModel GetLuong(int id);
//        int Editluong(int id, LuongModel luong);
//    }
//    public class LuongSvc:ILuong
//    {
//        protected DataBaseContext _context;

//        public LuongSvc(DataBaseContext context)
//        {
//            _context = context;
//        }
//        public List<LuongModel> GetLuongAll()
//        {
//            List<LuongModel> list = new List<LuongModel>();
//            list = _context.Luongs.ToList();
//            return list;
//        }
//        public int AddLuong(LuongModel luong)
//        {
//            int ret = 0;
//            try
//            {
//                _context.Add(luong);
//                _context.SaveChanges();
//                ret = luong.IDLuong;
//            }
//            catch
//            {
//                ret = 0;
//            }
//            return ret;
//        }
//        public LuongModel GetLuong(int id)
//        {
//            LuongModel luong = null;
//            luong = _context.Luongs.Find(id);
//            return luong;
//        }

//        public int Editluong(int id, LuongModel luong)
//        {
//            int ret = 0;
//            try
//            {
//                LuongModel _luong = null;
//                _luong = GetLuong(id);
//                _luong.IDLuong = luong.IDLuong;
//                _luong.Loaihopdong = luong.Loaihopdong;
//                _luong.Lươngcoban = luong.Lươngcoban;
//                _luong.Vanbanquyetdinh = luong.Vanbanquyetdinh;
//                _luong.baohiemphaidong = luong.baohiemphaidong;
//                _luong.Ngachhang = luong.Ngachhang;
//                _luong.Bacluong = luong.Bacluong;
//                _luong.Hesoluong = luong.Hesoluong;
//                _luong.Filedinhkem = luong.Filedinhkem;
//                _luong.Ngayapdungngachbac = luong.Ngayapdungngachbac;

//                _context.Update(_luong);
//                _context.SaveChanges();
//                ret = luong.IDLuong;
//            }
//            catch (Exception ex)
//            {
//                ret = 0;
//            }
//            return ret;
//        }
//    }
//}
