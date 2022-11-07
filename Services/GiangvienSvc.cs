using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thuctap01.Models;

namespace Thuctap01.Services
{
    public interface IGiangvien
    {
        List<GiangvienModel> GetgiangvienModelAll();
        int AddGiangvienModel(GiangvienModel giangvien);
        GiangvienModel GetgiangvienModel(int id);
        int EditgiangvienModel(int id, GiangvienModel giangvien);
    }
    public class GiangvienSvc : IGiangvien      
    {
        protected DataBaseContext _context;

        public GiangvienSvc(DataBaseContext context)
        {
            _context = context;
        }
        public List<GiangvienModel> GetgiangvienModelAll()
        {
            List<GiangvienModel> list = new List<GiangvienModel>();
            list = _context.GiangvienModels.ToList();
            return list;
        }
        public int AddGiangvienModel(GiangvienModel giangvien)
        {
            int ret = 0;
            try
            {
                _context.Add(giangvien);
                _context.SaveChanges();
                ret = giangvien.Magiangvien;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }
        public GiangvienModel GetgiangvienModel(int id)
        {
            GiangvienModel giangvien = null;
            giangvien = _context.GiangvienModels.Find(id);
            return giangvien;
        }        
        public int EditgiangvienModel(int id, GiangvienModel giangvien)
        {
            int ret = 0;
            try
            {
                GiangvienModel _giangvien = null;
                _giangvien = GetgiangvienModel(id);

                _giangvien.Magiangvien = giangvien.Magiangvien;
                _giangvien.Hovaten = giangvien.Hovaten;
                _giangvien.Gioitinh = giangvien.Gioitinh;
                _giangvien.NgaySinh = giangvien.NgaySinh;
                _giangvien.SoCMND = giangvien.SoCMND;
                _giangvien.Ngaycap = giangvien.Ngaycap;
                _giangvien.Noicap = giangvien.Noicap;
                _giangvien.Diachi = giangvien.Diachi;
                _giangvien.BHXH = giangvien.BHXH;
                _giangvien.Trinhdodaotao = giangvien.Trinhdodaotao;
                _giangvien.Chucvu = giangvien.Chucvu;
                _giangvien.Trangthai = giangvien.Trangthai;
                _giangvien.manghach = giangvien.manghach;
                _giangvien.Nghiphep = giangvien.Nghiphep;
                _giangvien.Loaihopdong = giangvien.Loaihopdong;
                _giangvien.Tobomon = giangvien.Tobomon;
                _giangvien.Vanbanquyetdinh = giangvien.Vanbanquyetdinh;
                _giangvien.Ngayapdungchucvu = giangvien.Ngayapdungchucvu;
                _giangvien.Ngaybatdaulamviec = giangvien.Ngaybatdaulamviec;


                _context.Update(_giangvien);
                _context.SaveChanges();
                ret = giangvien.Magiangvien;
            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }
    }
}

