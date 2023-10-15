using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DreamerStore.Models;

namespace DreamerStore.Controllers
{
    public class TempController : Controller
    {
        DreamerStoreEntities _db = new DreamerStoreEntities();
        // GET: Temp
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetMenu()
        {
            var v = from t in _db.Menus
                    where t.Hide == true
                    orderby t.Order ascending
                    select t;
            return PartialView(v.ToList());
        }
    }
}