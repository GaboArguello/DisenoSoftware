using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica.Dividir;
using Aplicacion.Factorial;

namespace InterfazDeUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        CalculadoraDeFactorial miCalculadora = new CalculadoraDeFactorial();
                        CalculadoraEntity miCalculadoraNormal = new CalculadoraEntity();
                        CoordinadoraDeFactorial miCoordinadora = new CoordinadoraDeFactorial();



                        Console.WriteLine(miCalculadora.Factorial(-2));
                        Console.WriteLine(miCalculadoraNormal.Dividir(1,0));
            
                        */

           
            


            CalculadoraController laControladora = new CalculadoraController();
            laControladora.CoordineLaDivision();

            


        }
    }
}
