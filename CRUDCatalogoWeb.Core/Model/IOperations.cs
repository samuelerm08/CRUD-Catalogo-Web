using System.Collections.Generic;

namespace CRUDCatalogoWeb.Model.Core
{
    public interface IOperations
    {
        List<Articulo> VerTodos();

        Articulo ObtenerUno(int ID);

        void Crear(Articulo a);
        
        void Editar(int ID, Articulo a);
        
        void Eliminar(int ID);                
    }
}
