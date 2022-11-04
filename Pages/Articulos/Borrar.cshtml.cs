using Microsoft.AspNetCore.Mvc;
using CRUDCatalogoWeb.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDCatalogoWeb.Pages.Articulos
{
    public class BorrarModel : PageModel
    {
        public Articulo? a;

        private Listado listado;

        public BorrarModel(Listado list)
        {
            listado = list;
        }

        public Listado Lista { get => listado; set => listado = value; }

        public void OnGet()
        {
            a = Lista.VerUno(Convert.ToInt16(Request.Query["id"]));

        }
    }
}
