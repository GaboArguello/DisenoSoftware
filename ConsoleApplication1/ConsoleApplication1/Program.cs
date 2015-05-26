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
            


            Fibonacci Result = new Fibonacci();

           /*Console.WriteLine(Result.Calcular(1));
           Console.WriteLine(Result.Calcular(2));
           Console.WriteLine(Result.Calcular(3));
           Console.WriteLine(Result.Calcular(4));
           Console.WriteLine(Result.Calcular(5));
           Console.WriteLine(Result.Calcular(6));
           Console.WriteLine(Result.Calcular(7));
           Console.WriteLine(Result.Calcular(8));
           Console.ReadKey();*/


            Console.WriteLine();

            ArrayList MiArray = new ArrayList();
            MiArray.Add(4);
            MiArray.Add(6);
            MiArray.Add(20);
            MiArray.Add(1);
            MiArray.Add(11);
            MiArray.Add(25);

            Result.fiboArrayList(MiArray);
            Console.ReadKey();

            

        }
    }
}
