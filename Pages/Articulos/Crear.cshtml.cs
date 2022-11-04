using Microsoft.AspNetCore.Mvc;
using CRUDCatalogoWeb.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDCatalogoWeb.Pages.Articulos
{
    public class CrearModel : PageModel
    {
        private Listado listado;

        public CrearModel(Listado listado)
        {
            this.listado = listado;
        }

        public Listado Lista { get => this.listado; set => this.listado = value; }

        public Articulo? articulo;

        public void OnGet()
        {
        }
    }
}
