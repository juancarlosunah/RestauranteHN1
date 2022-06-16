namespace RestauranteHN.BL
{
    public class Producto
    {
        internal int id;

        public Producto()
        {
        }

        public string Descripcion { get; internal set; }
        public int Precio { get; internal set; }
    }
}