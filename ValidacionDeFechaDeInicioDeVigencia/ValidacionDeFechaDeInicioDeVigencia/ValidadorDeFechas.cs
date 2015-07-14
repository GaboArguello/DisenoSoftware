using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacionDeFechaDeInicioDeVigencia
{
    public class ValidadorDeFechas
    {
        public Boolean LaFechaDeVigenciaEsValida(DateTime fechaDeVigencia, DateTime fechaDeRegistro)
        {
            Boolean laFechaEsValida = false;

            if (fechaDeVigencia >= fechaDeRegistro)
            {
                laFechaEsValida = true;
            }

            return laFechaEsValida;
        }
    }
}
