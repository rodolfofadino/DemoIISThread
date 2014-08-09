using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace DemoIISThreadAsync.Controllers
{
    public class ExemploController : Controller
    {
        // GET: Exemplo
        public ActionResult Index()
        {
            Thread.Sleep(5000);
            return View();
        }
    }
}