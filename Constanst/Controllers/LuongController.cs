//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Thuctap01.Models;
//using Thuctap01.Services;

//namespace Thuctap01.Constanst.Controllers
//{
//    public class LuongController : Controller
//    {
//        protected DataBaseContext _context;
//        private ILuong _luong;
//        public LuongController(DataBaseContext context, ILuong luong)
//        {
//            _luong = luong;
//        }
//        public IActionResult Index()
//        {
//            return View(_luong.GetLuongAll());
//        }
//        public ActionResult Details(int id)
//        {
//            var luong = _luong.GetLuong(id);
//            return View(luong);
//        }
//        public ActionResult Create()
//        {

//            return View();
//        }
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create(LuongModel luong)
//        {
//            try
//            {

//                _luong.AddLuong(luong);
//                return RedirectToAction(nameof(Details), new { id = luong.IDLuong });
//                //return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }
//        public ActionResult Edit(int id)
//        {
//            var luong = _luong.GetLuong(id);
//            return View(luong);
//        }
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit(int id, LuongModel luong)
//        {
//            try
//            {
//                if (ModelState.IsValid)
//                {
//                    _luong.Editluong(id, luong);
//                    return RedirectToAction(nameof(Details), new { id = luong.IDLuong });
//                }
//            }
//            catch
//            {

//            }
//            return RedirectToAction(nameof(Index));
//        }
//        public IActionResult Tonghopluong()
//        {
//            return View();
//        }
//        public IActionResult Baocaochiluong()
//        {
//            return View();
//        }
//    }
//}
