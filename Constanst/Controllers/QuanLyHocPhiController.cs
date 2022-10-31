using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thuctap01.Models;
using Thuctap01.Services;

namespace Thuctap01.Controllers
{
    public class QuanLyHocPhiController : Controller
    {
        protected DataBaseContext _context;
        private IQuanlyhocphi _quanlyhocphi;
        public QuanLyHocPhiController(DataBaseContext context, IQuanlyhocphi quanlyhocphi)
        {
            _quanlyhocphi = quanlyhocphi;
        }
        public IActionResult Index()
        {
            return View(_quanlyhocphi.GetQuanlyhocphiModelAll());
        }
        public ActionResult Details(int id)
        {
            var muchocphi = _quanlyhocphi.GetQuanlyhocphiModel(id);
            return View(muchocphi);
        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(QuanlyhocphiModel quanlyhocphi)
        {
            try
            {

                _quanlyhocphi.AddQuanlyhocphiModel(quanlyhocphi);
                return RedirectToAction(nameof(Details), new { id = quanlyhocphi.Mahocvien});
                //return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            var quanlyhocphi = _quanlyhocphi.GetQuanlyhocphiModel(id);
            return View(quanlyhocphi);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, QuanlyhocphiModel quanlyhocphi)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _quanlyhocphi.EditQuanlyhocphiModel(id, quanlyhocphi);
                    return RedirectToAction(nameof(Details), new { id = quanlyhocphi.Mahocvien });
                }
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
    }
}
