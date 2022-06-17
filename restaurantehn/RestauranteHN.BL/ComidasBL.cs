using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteHN.BL
{
    public class ComidasBL
    {
        Contexto _contexto;

        public ComidasBL()
        {
            _contexto = new Contexto();
        }

        public List<Comida> ObtenerComidas()
        {
           
            return _contexto.Comidas.ToList();
        }
    }
}
