using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thuctap01.Models;
using Thuctap01.Services;

namespace Thuctap01.Controllers
{
    public class MucHocPhiController : Controller
    {
        protected DataBaseContext _context;
        private IMuchocphi _Muchocphi;
        public MucHocPhiController(DataBaseContext context, IMuchocphi muchocphi)
        {
             _Muchocphi = muchocphi;
        }
        public IActionResult Index()
        {
            return View(_Muchocphi.GetMuchocphiAll());
        }
        public ActionResult Details(int id)
        {
            var muchocphi = _Muchocphi.GetMuchocphi(id);
            return View(muchocphi);
        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MuchocphiModel muchocphi)
        {
            try
            {

                _Muchocphi.AddMuchocphi(muchocphi);
                return RedirectToAction(nameof(Details), new { id = muchocphi.Mamonhoc });
                //return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            var muchocphi = _Muchocphi.GetMuchocphi(id);
            return View(muchocphi);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MuchocphiModel muchocphi)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _Muchocphi.EditMuchocphi(id, muchocphi);
                    return RedirectToAction(nameof(Details), new { id = muchocphi.Mamonhoc });
                }
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Thuhocphi()
        {
            return View();
        }
    }
}
