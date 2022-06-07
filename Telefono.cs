using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    class Telefono
    {
        // Constructor

        public Telefono(string modelo, string marca) 
        {
            this.modelo = modelo;
            this.marca = marca; 
        }


        // Atributos / Miembros SAMSUNG

        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperador;


       // Propiedades MOTOROLA
       
        public string Modelo2
        {
            get { return modelo; }
            set {

                if (value == "motorola")
                    {
                        modelo = value;
                    } else

                    do
                        {
                          Console.WriteLine("NO TENEMOS EN STOCK DE ESA MARCA");
                          Console.WriteLine("Desea comprar otro telefono de otroa marca");
                          Modelo2 = Console.ReadLine();

                    } while (value == "motorola");

                         
                 }
        }



       // Propiedades SAMSUNG

        public string Modelo
        {
          get {return modelo;}
        }
        

        public string Marca
        {
          get { return marca;}
        }

        public string NumeroTelefonico
        {
          get {return numeroTelefonico;}
          set {numeroTelefonico = value;}
        }

        public int CodigoOperador
        {
            get {return codigoOperador;}
            set {

                if (value > 0 && value <= 3)
                {

                    Console.WriteLine(">> CODIDO CORRECTO >>");
                    codigoOperador = value;

                } else
                        
                  do
                    {
                        Console.WriteLine("ERROR");

                        Console.WriteLine("MARQUE EL CODIGO DE OPERADOR (1,2,3) ADENTRO");

                        CodigoOperador = int.Parse(Console.ReadLine());

                    } while (value > 0 && value <= 3);
                   
                     codigoOperador = value;
                }
        }

        public string Llamar ()
        {
            return ">> Realizando llamada >>";
        }

        public string Llamar(string contacto)
        {
            return ">> Conectando con " + contacto + "...";
        }
    }
}
