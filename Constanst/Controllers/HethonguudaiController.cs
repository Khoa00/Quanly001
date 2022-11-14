using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thuctap01.Models;
using Thuctap01.Services;

namespace Thuctap01.Constanst.Controllers
{
    public class HethonguudaiController : Controller
    {
        protected DataBaseContext _context;
        private IHethong _hethong;
        private IHethongUudai _hethongUudai;
        public HethonguudaiController(DataBaseContext context, IHethongUudai hethongUudai, IHethong hethong)
        {
            _hethongUudai = hethongUudai;
            _hethong = hethong;
        }
        public IActionResult Caidatquanlyhocphi()
        {
            return View();
        }
        public IActionResult Caidatquanlyluong()
        {
            return View();
        }
        public IActionResult Indexhethong()
        {
            return View(_hethongUudai.GetHeThongAll());
        }
        public IActionResult Index()
        {
            return View(_hethongUudai.GetHeThongUudaiAll());
        }
        public ActionResult Details(int id)
        {
            var hethonguudai = _hethongUudai.GetHeThongUudai(id);
            return View(hethonguudai);
        }
        public ActionResult Createhethong()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Createhethong(HethongModels hethongModels)
        {
            try
            {

                _hethongUudai.AddHeThong(hethongModels);
                return RedirectToAction(nameof(Details), new { id = hethongModels.Matruong });
                //return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(hethonguudaimodel hethonguudai)
        {
            try
            {

                _hethongUudai.AddHeThongUudai(hethonguudai);
                return RedirectToAction(nameof(Details), new { id = hethonguudai.Mauudai });
                //return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            var hethonguudai = _hethongUudai.GetHeThongUudai(id);
            return View(hethonguudai);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, hethonguudaimodel hethonguudai)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _hethongUudai.EditHeThongUudai(id, hethonguudai);
                    return RedirectToAction(nameof(Details), new { id = hethonguudai.Mauudai });
                }
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
        
    }
}
