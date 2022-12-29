using Microsoft.AspNetCore.Mvc;
using CRUDCatalogoWeb.Model.Core;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDCatalogoWeb.Pages
{
    public class IndexModel : PageModel
    {
        public Listado Lista;        

        public IndexModel(Listado lista)
        {
            Lista = lista;
        }                
        public Articulo? Articulo { get; set; }
        public void OnGet()
        {            
        }        
    }
}