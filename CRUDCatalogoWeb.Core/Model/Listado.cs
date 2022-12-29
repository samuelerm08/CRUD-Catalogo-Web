using System.Collections.Generic;

namespace CRUDCatalogoWeb.Model.Core
{
    public class Listado : IOperations
    {
        private readonly List<Articulo> Lista = new List<Articulo>();

        public List<Articulo> VerTodos()
        {
            return Lista;
        }
        public void Crear(Articulo a)
        {
            Lista.Add(a);
            a.ID = Lista.IndexOf(a);
        }
        public Articulo ObtenerUno(int ID)
        {
            return Lista[ID];
        }
        public void Eliminar(int ID)
        {
            var a = new Articulo();
            Lista.ForEach(item => { if (item.ID == ID) a = item; });
            Lista.Remove(a);
            Reseed();
        }
        public void Editar(int ID, Articulo a)
        {
            Lista[ID].Marca = a.Marca;
            Lista[ID].Modelo = a.Modelo;
            Lista[ID].Descripcion = a.Descripcion;
            Lista[ID].Stock = a.Stock;
            Lista[ID].Precio = a.Precio;
        }
        private void Reseed()
        {
            var a = new Articulo();
            Lista.ForEach(item => item.ID = Lista.IndexOf(item));
        }
    }
}
