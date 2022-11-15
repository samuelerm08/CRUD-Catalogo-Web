namespace CRUDCatalogoWeb.Model
{
    public class Listado : ILista
    {
        private List<Articulo> listado = new List<Articulo>();

        //Read All Method
        public List<Articulo> VerTodos()
        {
            return listado;
        }

        //Read One Method
        public Articulo VerUno(int id)
        {
            return listado[id];
        }

        //Create Items Method
        public void Crear(Articulo a)
        {
            listado.Add(a);
            a.id = listado.IndexOf(a);
        }

        //Modify Items Method (Executing)
        public void Editar(Articulo a)
        {
            listado[a.id].marca = a.marca;
            listado[a.id].modelo = a.modelo;
            listado[a.id].descripcion = a.descripcion;
            listado[a.id].precio = a.precio;
            listado[a.id].stock = a.stock;
        }

        //Delete Items Method
        public void Eliminar(int id)
        {
            Articulo a = listado[id];

            listado.Remove(a);

            Refresh();
        }

        //List Feedback Method
        private void Refresh()
        {
            //Run the list finding the item for
            foreach (var item in listado)
            {
                //Found it. Now it matches w/ the Item index of the list
                item.id = listado.IndexOf(item);
            }
        }
    }
}
