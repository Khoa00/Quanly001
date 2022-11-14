using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thuctap01.Models;
using Thuctap01.Services;

namespace Thuctap01.Constanst.Controllers
{
    public class ThongbaoController : Controller
    {
        protected DataBaseContext _context;
        private IThongbao _Thongbao;
        public ThongbaoController(DataBaseContext context, IThongbao thongbao)
        {
            _Thongbao = thongbao;
        }
        public IActionResult Index()
        {
            return View(_Thongbao.GetThongbaoAll());
        }
        public ActionResult Details(int id)
        {
            var thongbao = _Thongbao.GetThongbao(id);
            return View(thongbao);
        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ThongbaoModel thongbao)
        {
            try
            {

                _Thongbao.AddThongbao(thongbao);
                return RedirectToAction(nameof(Details), new { id = thongbao.Matieude });
                //return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            var thongbao = _Thongbao.GetThongbao(id);
            return View(thongbao);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ThongbaoModel thongbao)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _Thongbao.EditThongbao(id, thongbao);
                    return RedirectToAction(nameof(Details), new { id = thongbao.Matieude });
                }
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
    }
}
