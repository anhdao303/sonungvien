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

        public ActionResult getMenu()
        {
            var v = from t in _db.menus
                    where t.hide == true
                    orderby t.order ascending
                    select t;
            return PartialView(v.toList());
        }
    }
}