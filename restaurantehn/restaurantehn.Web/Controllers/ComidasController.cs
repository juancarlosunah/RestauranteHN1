using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace restaurantehn.Web.Controllers
{
    public class ComidasController : Controller
    {
        // GET: Comidas
        public ActionResult Index()
        {
            var Comidas = new ComidasModel();

            return View();
        }
    }
}