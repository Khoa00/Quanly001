using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thuctap01.Models;
using Thuctap01.Services;

namespace Thuctap01.Constanst.Controllers
{
    public class QuanlyluongController : Controller
    {
        protected DataBaseContext _context;
        private IQuanlyluong _quanlyluong;
        public QuanlyluongController(DataBaseContext context, IQuanlyluong quanlyluong)
        {
            _quanlyluong = quanlyluong;
        }
        
        public IActionResult Index()
        {
            return View(_quanlyluong.GetQuanLyLuongAll());
        }
        public ActionResult Details(int id)
        {
            var muchocphi = _quanlyluong.GetQuanLyLuong(id);
            return View(muchocphi);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(QuanlyluongModel quanlyluong)
        {
            try
            {

                _quanlyluong.AddQuanLyLuong(quanlyluong);
                return RedirectToAction(nameof(Details), new { id = quanlyluong.Mabangluong });
                //return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            var quanlyluong = _quanlyluong.GetQuanLyLuong(id);
            return View(quanlyluong);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, QuanlyluongModel quanlyluong)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _quanlyluong.EditQuanLyLuong(id, quanlyluong);
                    return RedirectToAction(nameof(Details), new { id = quanlyluong.Mabangluong });
                }
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
    }
}
