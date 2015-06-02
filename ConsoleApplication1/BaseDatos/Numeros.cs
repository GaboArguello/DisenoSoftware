using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos
{
    public class Numeros
    {

        List<int> Lista = new List<int>();

        int cant = 0;

        public void Agregar(int n)
        {
            Lista.Add(n);
        }

        public int Cantidad()
        {
            foreach (int o in Lista)
	        {
                cant++;
	        }

            return cant;
        }
        
    }
}
