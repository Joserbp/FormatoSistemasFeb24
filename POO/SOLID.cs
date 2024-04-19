}using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Factura
    {
        //S - single responsability
            //Unica función 


        // Bajo Acoplamiento
               //Dependencia entre modulos
        // Alta Cohesion
               //Comunicación
               //Estructura interna cada modulo 

        // Pruebas unitarios  --- Falta
        // pruebas modulares / integracion
        // Prueba big bang
        public string RFC { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }

        public void GenerarFactura()
        {
            Cliente.ConsultarCliente();
            Cliente.UpdateCliente();
            Cliente.DeleteCliente();
            Cliente.AgregarCliente();
        }

        public void Consultar()
        {

        }

    }


    //O open / close
    //abierto a extensiones
    //cerrados a modificaciones

    partial class Cliente //Original
    {
        public static void ConsultarCliente()
        {

        }
    }

    partial class Cliente  //Extension
    {
        public static void UpdateCliente()
        {

        }
        public static void DeleteCliente()
        {

        }
    }

    partial class Cliente  //Extension
    {

        public static void AgregarCliente()
        {

        }
    }

    //Inyecccion de dependencia
    //Meterle informacion
    //Compartir funcionales de la clase
    //Necesita de ella para funcionar
    //Requiere
    
    //Tarjeta Banco

    class Tarjeta{
        public string LimiteCredito { get; set; }
        public string NumeroTarjeta { get; set; }
        public Banco _banco { get; }
        public Banco _banco1 { get; set; }

        public readonly Banco _banco2;
        //Contructor
        public Tarjeta(Banco banco) {
            this._banco1 = banco;
        }

        //Metodo
        public void SetBanco(Banco banco){
            this._banco1 = banco;
        }

    }

    class Banco {
        public string Nombre { get; set; }
        public string Fondos { get; set; }
    }

    internal class SOLID
    {
        //Buenas practicas
        //Robusto
        //Organizacion proyecto
        //Estructura


        //L liskov
               //Padre puede ser replazado con los hijos

        //I segracion de interfaces 
                //UI

        //D dependecy




    }
}
