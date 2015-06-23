using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Dividir
{
    public class CalculadoraController
    {
        public void CoordineLaDivision()
        {
            CalculadoraBoundary elLimite = new CalculadoraBoundary();
            string resultadoString;
            try
            {

                string dividendo = elLimite.OptenerDividendo();

                if (dividendo.Contains("."))
                {
                    
                }
                else
                {
                    double respuesta = double.
                }

                string divisor = elLimite.ObtenerDivisor();

                CalculadoraEntity laCalculadora = new CalculadoraEntity();
                double resultado = laCalculadora.Dividir(dividendo, divisor);
                resultadoString = resultado.ToString();
            
            
            }
            catch (Exception)
            {
                
                resultadoString = "Error";
            }

            elLimite.MostraResultado(resultadoString);

            
        }


    }
}
