using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class Select2TestController : Controller
    {
        // GET: Select2
        public ActionResult Index()
        {
            List<SelectListItem> itemsToDisplay =
                new List<SelectListItem>
                { new SelectListItem { Text = "$250-Initial Fee", Value ="1"},
                  new SelectListItem { Text = "$600-security fee", Value="2"}
                };
            ViewBag.Exercises = itemsToDisplay;
            return View();
        }
    }
}