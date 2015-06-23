using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public class Productos
    {

      

       public Productos(int Id, String nombre, String fecha)
       {
           this.Id = Id;
           this.nombre = nombre;
           this.fecha = fecha;
       }


        public int Id { get; set; }
        public String nombre { get; set; }
        public String fecha { get; set; }

    }

