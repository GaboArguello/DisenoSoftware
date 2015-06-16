using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrito_de_compras_SEM5
{
    class ImprimirCarrito
    {
        public void ImprimeAlCarrito(List<Productos> productos)
        {
            Console.WriteLine(" Contenidos del carrito de compras:");
            Console.WriteLine("***********************************");
            foreach (Productos producto in productos)
            {
                Console.WriteLine("Identificador: {0}", producto.Id);
                Console.WriteLine("Nombre: {0}", producto.nombre);
                Console.WriteLine("Fecha: {0}", producto.fecha);
                Console.WriteLine("***********************************"); 
            }
           
        }

        public void ImprimeProducto(Productos producto)
        {
            Console.WriteLine("Producto buscado: ");
            Console.WriteLine("***********************************");
            Console.WriteLine("Identificador: {0}", producto.Id);
            Console.WriteLine("Nombre: {0}", producto.nombre);
            Console.WriteLine("Fecha: {0}", producto.fecha);
        }
    }
}
