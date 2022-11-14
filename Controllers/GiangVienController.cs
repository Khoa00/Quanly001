using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thuctap01.Models;
using Thuctap01.Services;

namespace Thuctap01.Constanst.Controllers
{
    public class GiangVienController : Controller
    {
        protected DataBaseContext _context;
        private IGiangvien _giangvien;
        public GiangVienController(DataBaseContext context, IGiangvien giangvien)
        {
            _giangvien = giangvien;
        }
        public IActionResult Index()
        {
            return View(_giangvien.GetgiangvienModelAll());
        }
        public ActionResult Details(int id)
        {
            var giangvien = _giangvien.GetgiangvienModel(id);
            return View(giangvien);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GiangvienModel giangvien)
        {
            try
            {

                _giangvien.AddGiangvienModel(giangvien);
                return RedirectToAction(nameof(Details), new { id = giangvien.Magiangvien });
                //return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            var giangvien = _giangvien.GetgiangvienModel(id);
            return View(giangvien);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, GiangvienModel giangvien)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _giangvien.EditgiangvienModel(id, giangvien);
                    return RedirectToAction(nameof(Details), new { id = giangvien.Magiangvien });
                }
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Lichsugiangvien()
        {
            return View();
        }
        public IActionResult Bangchamcong()
        {
            return View();
        }
        public IActionResult Danhsachnghiphep()
        {
            return View();
        }
    }   
}
