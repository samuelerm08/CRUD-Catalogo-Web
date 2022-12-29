using Microsoft.AspNetCore.Mvc;
using CRUDCatalogoWeb.Model.Core;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDCatalogoWeb.Pages.Articulos
{
    public class DetalleModel : PageModel
    {        
        private readonly Listado Lista;

        public DetalleModel(Listado listado )
        {
            Lista = listado;
        }

        public Articulo? Articulo { get; set; }
        public void OnGet()
        {
            Articulo = Lista.ObtenerUno(Convert.ToInt32(Request.Query["ID"]));
        }        
    }
}
