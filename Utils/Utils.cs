using ProductoAplicacion.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoAplicacion.Utils
{
    class Utils
    {
        public static ObservableCollection<Producto> listaProducto = new ObservableCollection<Producto>()
        {
            new Producto()
            {
                IdProducto = 1,
                Nombre = "Prod1",
                Descripcion = "Desc1",
                Cantidad = 1
            },
            new Producto()
            {
                IdProducto = 2,
                Nombre = "Prod2",
                Descripcion = "Desc2",
                Cantidad = 2
            },
            new Producto()
            {
                IdProducto = 3,
                Nombre = "Prod3",
                Descripcion = "Desc3",
                Cantidad = 3
            },
            new Producto()
            {
                IdProducto = 4,
                Nombre = "Prod4",
                Descripcion = "Desc4",
                Cantidad = 4
            },
        };
    }
}
