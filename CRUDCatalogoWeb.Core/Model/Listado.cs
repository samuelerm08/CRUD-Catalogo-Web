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
        public void Editar(Articulo a)
        {
            Lista[a.ID].Marca = a.Marca;
            Lista[a.ID].Modelo = a.Modelo;
            Lista[a.ID].Descripcion = a.Descripcion;
            Lista[a.ID].Stock = a.Stock;
            Lista[a.ID].Precio = a.Precio;
        }
        private void Reseed()
        {
            var a = new Articulo();
            Lista.ForEach(item => item.ID = Lista.IndexOf(item));
        }
    }
}