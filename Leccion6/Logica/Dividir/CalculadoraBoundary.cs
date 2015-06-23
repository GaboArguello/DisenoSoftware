using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Dividir

{
    public class CalculadoraBoundary
    {

        public double ObtenerDivisor()
        {
            Console.WriteLine("Deme el Divisor");
            string divisor = Console.ReadLine();
            double respuesta = double.Parse(divisor);
            return respuesta;
            
        }

        public double OptenerDividendo()
        {
            Console.WriteLine("Deme el Dividendo");
            string dividendo = Console.ReadLine();
            double respuesta = double.Parse(dividendo);
            return respuesta;
        }




        public void MostraResultado(string resultado)
        {
            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}
