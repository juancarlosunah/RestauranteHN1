using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteHN.BL
{
    public class ComidasBL
    {
        public List<Comida> ObtenerComidas()
        {
            var comidas1 = new Producto();
            comidas1.id = 1;
            comidas1.Descripcion = "Sopa de Mondongo";
            comidas1.Precio = 180;

            var comidas2 = new Producto();
            comidas2.id = 2;
            comidas2.Descripcion = "Baleadas";
            comidas2.Precio = 15;

            var comidas3 = new Producto();
            comidas3.id = 3;
            comidas3.Descripcion = "Pollo Frito";
            comidas3.Precio = 60;

            var comidas4 = new Producto();
            comidas4.id = 4;
            comidas4.Descripcion = "Arroz con Pollo";
            comidas4.Precio = 45;

            var comidas5 = new Producto();
            comidas5.id = 5;
            comidas5.Descripcion = "Carne Asada";
            comidas5.Precio = 120;

            var listadeComidas = new List<Producto>();
            listadeComidas.Add(comidas1);
            listadeComidas.Add(comidas2);
            listadeComidas.Add(comidas3);
            listadeComidas.Add(comidas4);
            listadeComidas.Add(comidas5);

            return listadeComidas;
        }
    }
}
