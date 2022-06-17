using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteHN.BL
{
   public  class Contexto: DbContext
    {
        public Contexto(): base("RestauranteHNHNDB")
        {

        }

        public DbSet<Comida> Comidas { get; set; }
     
     }
}
