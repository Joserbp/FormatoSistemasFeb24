using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Mueble
    {
        protected string Altura { get; set; }  //Private 

        private string Ancho { get; set; }


        public virtual string Desplazar()
        {
            string movimiento = "El mueble se mueve" ;  
            return (movimiento);
        }

    }
}
