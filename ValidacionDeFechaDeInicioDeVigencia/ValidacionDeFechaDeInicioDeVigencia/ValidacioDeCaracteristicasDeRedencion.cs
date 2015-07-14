using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacionDeFechaDeInicioDeVigencia
{
    class ValidacioDeCaracteristicasDeRedencion
    {

        public Boolean LasCaracteristicasDeRedencionConValidas(Boolean permiteRedencion, 
            double comision, int diasMinimosDeRetencion)
        {
            Boolean sonValidasLasCaracteristicasDeRedencion = false;

            if (permiteRedencion.Equals(false) && comision.Equals(0) && diasMinimosDeRetencion.Equals(0))
            {
                sonValidasLasCaracteristicasDeRedencion = true;
            }
            else if (permiteRedencion.Equals(true) && comision > 0 && diasMinimosDeRetencion > 0)
            {
                sonValidasLasCaracteristicasDeRedencion = true;
            }
           
                      
            return sonValidasLasCaracteristicasDeRedencion;
        }

    }
}
