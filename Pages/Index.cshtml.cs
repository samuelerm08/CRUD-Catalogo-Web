using Microsoft.AspNetCore.Mvc;
using CRUDCatalogoWeb.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDCatalogoWeb.Pages
{
    public class IndexModel : PageModel
    {
        private Listado listado;

        public IndexModel(Listado lista)
        {
            listado = lista;
        }        

        public Listado Lista { get => listado; set => listado = value; }

        public void OnGet()
        {

        }
    }
}