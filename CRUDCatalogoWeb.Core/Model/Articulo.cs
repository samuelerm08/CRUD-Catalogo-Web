namespace CRUDCatalogoWeb.Model.Core
{
    public class Articulo
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Precio { get; set; }
        public int Stock { get; set; }
    }
}
