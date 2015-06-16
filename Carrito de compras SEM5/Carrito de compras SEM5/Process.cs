using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrito_de_compras_SEM5
{
    class Process
    {
        static void Main(string[] args)
        {

            LogicaDeAplicacion.Carrito Carrito = new LogicaDeAplicacion.Carrito();
            ImprimirCarrito Imprime = new ImprimirCarrito();

            Carrito.AgregarAlCarrito(new Productos(10199, "iPod Touch 64GB", "2015-06-06"));
            Carrito.AgregarAlCarrito(new Productos(13100, "ChromeCast", "2015-03-06"));
            Carrito.AgregarAlCarrito(new Productos(10299, "Laptop HB 256GB", "2015-07-06"));


            Imprime.ImprimeAlCarrito(Carrito.ImprCarrito());

            Imprime.ImprimeProducto(Carrito.BuscarBuscarPorIdentificacion(13100));
            

            Console.ReadKey();

        }
    }
}
