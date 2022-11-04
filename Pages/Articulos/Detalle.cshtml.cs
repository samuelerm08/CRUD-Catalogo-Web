using Microsoft.AspNetCore.Mvc;
using CRUDCatalogoWeb.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDCatalogoWeb.Pages.Articulos
{
    public class DetalleModel : PageModel
    {
        public Articulo? a;
        private readonly Listado listado;

        public DetalleModel(Listado list)
        {
            listado = list;
        }

        public void OnGet()
        {
            a = listado.VerUno(Convert.ToInt32(Request.Query["id"]));
        }
    }
}
