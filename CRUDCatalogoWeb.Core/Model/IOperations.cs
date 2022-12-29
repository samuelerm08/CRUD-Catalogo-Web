using System.Collections.Generic;

namespace CRUDCatalogoWeb.Model.Core
{
    public interface IOperations
    {
        List<Articulo> VerTodos();

        Articulo ObtenerUno(int ID);

        void Crear(Articulo a);
        
        void Editar(Articulo a);
        
        void Eliminar(int id);                
    }
}
