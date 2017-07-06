using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ChatApp.Controllers
{
    public class ChatController : Controller
    {
        // GET: Chat
        [HttpPost]
        public ActionResult Index(int channel)
        {
            if(Session["ID_Channel"].ToString()==channel.ToString())
            {
                ViewBag.ID_channel = channel;
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public ActionResult OutChannel()
        {
            Session["ID_Channel"] = "";
            return Redirect("/");
        }
    }
}