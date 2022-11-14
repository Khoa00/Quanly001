//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Thuctap01.Models;

//namespace Thuctap01.Services
//{
//    public interface IDanhmuchopdong
//    {
//        List<DanhmuchopdongModel> GetDanhmuchopdongAll();
//        DanhmuchopdongModel GetDanhmuchopdong(int id);
//    }
//    public class DanhmuchopdongSvc:IDanhmuchopdong
//    {
//        protected DataBaseContext _context;

//        public DanhmuchopdongSvc(DataBaseContext context)
//        {
//            _context = context;
//        }
//        public List<DanhmuchopdongModel> GetDanhmuchopdongAll()
//        {
//            List<DanhmuchopdongModel> list = new List<DanhmuchopdongModel>();
//            list = _context.DanhmuchopdongModels.ToList();
//            return list;
//        }
//        public DanhmuchopdongModel GetDanhmuchopdong(int id)
//        {
//            DanhmuchopdongModel danhmuchopdongModel = null;
//            danhmuchopdongModel = _context.DanhmuchopdongModel.Find(id);
//            return danhmuchopdongModel;
//        }
//    }
//}
