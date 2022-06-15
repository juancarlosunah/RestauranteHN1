using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using restaurantehn.Web.Models;

namespace restaurantehn.Web.Controllers
{
    public class ComidasController : Controller
    {
        // GET: Comidas
        public ActionResult Index()
        {
           
            var comidas1 = new ProductoModel();
            comidas1.id = 1;
            comidas1.Descripcion = "Sopa de Mondongo";

            var comidas2 = new ProductoModel();
            comidas2.id = 2;
            comidas2.Descripcion = "Baleadas";

            var comidas3 = new ProductoModel();
            comidas3.id = 3;
            comidas3.Descripcion = "Pollo Frito";

            var comidas4 = new ProductoModel();
            comidas4.id = 4;
            comidas4.Descripcion = "Arroz con Pollo";

            var comidas5 = new ProductoModel();
            comidas5.id = 5;
            comidas5.Descripcion = "Carne Asada";

            var listadeComidas = new List<ProductoModel>();
            listadeComidas.Add(comidas1);
            listadeComidas.Add(comidas2);
            listadeComidas.Add(comidas3);
            listadeComidas.Add(comidas4);
            listadeComidas.Add(comidas5);

            return View(listadeComidas);

        }
    }
}