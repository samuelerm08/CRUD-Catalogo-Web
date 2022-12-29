using Microsoft.AspNetCore.Mvc;
using CRUDCatalogoWeb.Model.Core;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDCatalogoWeb.Pages.Articulos
{
    public class BorrarModel : PageModel
    {        
        private readonly Listado Lista;

        public BorrarModel(Listado listado)
        {
            Lista = listado;
        }        
        public void OnGet()
        {
            Lista.Eliminar(Convert.ToInt16(Request.Query["ID"]));
            Response.Redirect("/");
        }        
    }
}

