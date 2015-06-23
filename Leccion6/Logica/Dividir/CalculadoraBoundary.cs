using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Dividir

{
    public class CalculadoraBoundary
    {

        public string ObtenerDivisor()
        {
            Console.WriteLine("Deme el Divisor");
            string divisor = Console.ReadLine();

            if (divisor.Contains("."))
            {
                
            }

            double respuesta = double.Parse(divisor);
           
            
        }

        public string OptenerDividendo()
        {
            Console.WriteLine("Deme el Dividendo");
            string dividendo = Console.ReadLine();
            double respuesta = double.Parse(dividendo);
            
        }




        public void MostraResultado(string resultado)
        {
            Console.WriteLine("El resultado es: ");
            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}
