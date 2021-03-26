using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using truYum.Models;

namespace truYum.Controllers
{
    [Authorize]
    public class MenuItemController : Controller
    {
        // GET: MenuItem
        truYumContext db = new truYumContext();
     
        public ActionResult Index()
        {
           
                var list = db.MenuItems.ToList();
                ViewBag.Clist = db.Categories.ToList();
                return View(list);
            
        }

        public ActionResult Create()
        {
            MenuItem menuItem = new MenuItem();

            var list = db.Categories.ToList();
            ViewBag.Catagory = list;

            return View();
        }
        [HttpPost]
        public ActionResult Create(MenuItem menuItem)
        {
            if (ModelState.IsValid)
            {
                db.MenuItems.Add(menuItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                var list = db.Categories.ToList();
                ViewBag.Catagory = list;
                return View();
            }
        }
        public ActionResult Update(int? id)
        {
            MenuItem item = null;
            if (id != null)
            {

                 item = db.MenuItems.Find(id);

               

            }
            var list = db.Categories.ToList();
            ViewBag.Catagory = list;
            return View(item);
        }
        [HttpPost]
        public ActionResult Update(int? id,MenuItem menuItem)
        {
            if (ModelState.IsValid)
            {
                var MenuList = db.MenuItems.Where(x => x.MenuId == id).ToList();
                MenuList.ForEach(x =>
                {
                    x.Name = menuItem.Name;
                    x.FreeDelivery = menuItem.FreeDelivery;
                    x.Price = menuItem.Price;
                    x.Active = menuItem.Active;
                    x.CategoryId = menuItem.CategoryId;
                });
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                var list = db.Categories.ToList();
                ViewBag.Catagory = list;
                return View();
            }
        }
    }
}