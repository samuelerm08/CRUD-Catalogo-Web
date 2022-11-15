namespace CRUDCatalogoWeb.Model
{
    public interface IOperations
    {
        public List<Articulo> VerTodos();
        
        public Articulo VerUno(int id);
        
        public void Crear(Articulo a);
        
        public void Editar(Articulo a);
        
        public void Eliminar(int id);                
    }
}
