using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using restaurantehn.Web;
using RestauranteHN.BL;

namespace restaurantehn.Web.Controllers
{
    public class ComidasController : Controller
    {
        private object listadeComidas;

        // GET: Comidas
        public ActionResult Index()
        {
            var comidasBL = new ComidasBL();
            var listadeProductos = comidasBL.ObtenerComidas();

            return View(listadeComidas);

        }

        private ActionResult View(object listadeComidas)
        {
            throw new NotImplementedException();
        }
    }
}