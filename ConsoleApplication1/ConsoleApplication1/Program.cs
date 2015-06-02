using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //Console.WriteLine("Hello Gabriel");



           

           /*Console.WriteLine(Result.Calcular(1));
           Console.WriteLine(Result.Calcular(2));
           Console.WriteLine(Result.Calcular(3));
           Console.WriteLine(Result.Calcular(4));
           Console.WriteLine(Result.Calcular(5));
           Console.WriteLine(Result.Calcular(6));
           Console.WriteLine(Result.Calcular(7));
           Console.WriteLine(Result.Calcular(8));
           Console.ReadKey();*/

            Fibonacci MiFibo = new Fibonacci();

            

           /* Console.WriteLine();

            ArrayList MiArray = new ArrayList();
            MiArray.Add(4);
            MiArray.Add(6);
            MiArray.Add(20);
            MiArray.Add(1);
            MiArray.Add(11);
            MiArray.Add(25);

           MiFibo.fiboArrayList(MiArray);
            Console.ReadKey();
            */


            BaseDatos.Numeros num = new BaseDatos.Numeros();

            num.Agregar(1);
            num.Agregar(999);
            num.Agregar(57);


            int cantidad = num.Cantidad();

            //Console.WriteLine("Cantidad = {0}", cantidad);

            CalculoSs.Exeption MaxFibo = new CalculoSs.Exeption();

            MaxFibo.NumMaxFibonacci();

            Console.ReadLine();
        }
    }
}
