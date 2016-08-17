using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Web.Controllers
{
    public class ShopListController : Controller
    {
        // GET: ShopList
        public ActionResult Shopping()
        {
            return View();
        }

        public string Message()
        {
            return "<h1> shop.kodfest.com </h1>";
        }
    }
}