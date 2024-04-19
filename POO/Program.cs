using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factorial(5);

            Banco banco = new Banco();
            banco.Nombre = "BancoDigis/Risosu";
            Tarjeta tarjeta = new Tarjeta(banco);


            //Por propiedad
            tarjeta._banco1 = banco;

        }
        public void funcion()
        {

        }

        public static int Factorial(int numero){
            //5*4*3*2*1//Bandera cuando llego 1
            if(numero == 1)
            {
                return 1;
            }
            int resultado = numero * Factorial(numero - 1);

            return resultado;
        }
    }
}
