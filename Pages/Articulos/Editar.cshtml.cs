using Microsoft.AspNetCore.Mvc;
using CRUDCatalogoWeb.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDCatalogoWeb.Pages.Articulos
{
    public class EditarModel : PageModel
    {
        public Articulo? a;
        private Listado listado;

        public EditarModel(Listado listado)
        {
            this.listado = listado;
        }

        public Listado Lista { get => this.listado; set => this.listado = value; }

        public void OnGet()
        {
            a = listado.VerUno(Convert.ToInt16(Request.Query["id"]));
        }
    }
}
