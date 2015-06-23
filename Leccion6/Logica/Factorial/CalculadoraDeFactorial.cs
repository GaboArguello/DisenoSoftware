using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Dividir
{
    public class CalculadoraDeFactorial
    {
        //Ejemplo de factorial correcto
        //fact -100 = 0
        //fact 0 = 0
        //fact 1 = 1 
        

        public int Factorial(int n)
        {
            if (n < 0)  return 1;
            else if (n == 0) return 1;
            else if (n > 1) return n * Factorial(n - 1);
            return 1; 
        }

    }
}
