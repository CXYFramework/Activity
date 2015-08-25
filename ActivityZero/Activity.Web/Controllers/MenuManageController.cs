using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abp.Web.Mvc.Controllers;
using Activity.MenuApp;

namespace Activity.Web.Controllers
{
    public class MenuManageController : Controller
    {
        private IMenuAppService _menuService;

        public MenuManageController(IMenuAppService menuAppService)
        {
            this._menuService = menuAppService;
        }
        // GET: MenuManage
        public ActionResult Index()
        {

            return View();
        }

        public JsonResult MenuData()
        {
            return Json(_menuService.GetAllMenus(),JsonRequestBehavior.AllowGet);
        }

        // GET: MenuManage/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MenuManage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MenuManage/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MenuManage/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MenuManage/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MenuManage/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MenuManage/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
