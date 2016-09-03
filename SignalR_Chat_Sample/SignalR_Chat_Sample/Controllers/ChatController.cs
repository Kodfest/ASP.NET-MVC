using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalR_Chat_Sample.Controllers
{
    public class ChatController : Controller
    {
        // GET: Chat
        public ActionResult Friend()
        {
            return View();
        }
    }
}