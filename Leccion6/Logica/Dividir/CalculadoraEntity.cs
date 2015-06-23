using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Dividir
{
   public class CalculadoraEntity
    {

        /*Ejemplos
         * 2/2 = 1
         * 5/2 = 2.5
         * 1/0 = error
         * 0/4 = 0
         * 2.5/2 = 1.25
         * -2.5/2 = -1.5
         */


        public double Dividir(double n, double m)
        {
            try
            {
                if (m == 0)
                {
                    throw new Exception("Error, el divisor no debe ser cero");

                }
                if (n == 0)
                {
                    return 0;
                }

                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return n / m;
        }

    }
}
