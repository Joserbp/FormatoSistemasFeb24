using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Silla : Mueble
    {
        //mover
        //material
        public string Color { get; set; }
        private string  Tamanio  { get; set; }
        
        public Silla()
        {
            
        }

        public Silla(string Color)
        {
            this.Color = Color;
        }

        public Silla(string Color, string Tamanio)
        {
            this.Color = Color;
            this.Tamanio = Tamanio;
        }

        public override string Desplazar()
        {
            Altura = "Grande";
            Tamanio = "Grande";
           // Ancho = "";
            Console.WriteLine("-------------------------");
            Console.WriteLine(base.Desplazar());
            string movimiento = "La silla se mueve";
            int x = 1;
            int suma = 1 + 100;
            Console.WriteLine(suma);
            return (movimiento);
        }


        public void Girar()
        {

        }

        public void deslizar()
        {

        }
    }
}
