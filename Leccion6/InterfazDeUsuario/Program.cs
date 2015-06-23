using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica.Factorial;
using Aplicacion.Factorial;

namespace InterfazDeUsuario
{
    class Program
    {
        static void Main(string[] args)
        {

            CalculadoraDeFactorial miCalculadora = new CalculadoraDeFactorial();
            CalculadoraNormal miCalculadoraNormal = new CalculadoraNormal();
            CoordinadoraDeFactorial miCoordinadora = new CoordinadoraDeFactorial();



            Console.WriteLine(miCalculadora.Factorial(-2));
            Console.WriteLine(miCalculadoraNormal.Dividir(1,0));
            

            Console.ReadKey();

        }
    }
}
