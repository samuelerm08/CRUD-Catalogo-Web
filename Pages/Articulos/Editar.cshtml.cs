using Microsoft.AspNetCore.Mvc;
using CRUDCatalogoWeb.Model.Core;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDCatalogoWeb.Pages.Articulos
{
    public class EditarModel : PageModel
    {
        private readonly Listado Lista;

        public EditarModel(Listado listado)
        {
            Lista = listado;
        }
        public Articulo? Articulo;
        public void OnGet()
        {
            Articulo = Lista.ObtenerUno(Convert.ToInt32(Request.Query["ID"]));
        }
        public void OnPost()
        {
            Lista.Editar(new Articulo()
            {
                Descripcion = Request.Form["Descripcion"],
                Marca = Request.Form["Marca"],
                Modelo = Request.Form["Modelo"],
                Precio = Request.Form["Precio"],
                Stock = Convert.ToInt16(Request.Form["Stock"])
            });
            Response.Redirect("/");
        }
    }
}
