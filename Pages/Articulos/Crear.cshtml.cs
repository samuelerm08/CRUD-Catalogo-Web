using Microsoft.AspNetCore.Mvc;
using CRUDCatalogoWeb.Model.Core;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDCatalogoWeb.Pages.Articulos
{
    public class CrearModel : PageModel
    {
        private readonly Listado Lista;

        public CrearModel(Listado listado)
        {
            Lista = listado;
        }
        public Articulo? Articulo { get; set; }
        public void OnGet() { }        

        public void OnPost()
        {
            Lista.Crear(new Articulo()
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
