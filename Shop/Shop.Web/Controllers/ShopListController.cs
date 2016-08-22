using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Shop.Web.Controllers
{
    public class ShopListController : Controller
    {
        // GET: ShopList
        public async Task<ActionResult> Shopping()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("http://localhost:14313/api/service");

                return View();
            }
        }

        public string Message()
        {
            return "<h1> shop.kodfest.com </h1>";
        }
    }
}