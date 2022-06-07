using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {

            Telefono t1 = new Telefono( "iphone 12", "Apple");
            Telefono t2= new Telefono("Samsung" , "dns");
           
            Console.WriteLine("La marca del telefono es : " + t1.Marca);
            Console.WriteLine("El modelo nuevo es : " + t1.Modelo);

            Console.WriteLine("MARQUE EL CODIGO DE OPERADOR PARA INGRESAR (1,2,3)");
            t1.CodigoOperador = int.Parse(Console.ReadLine());

            Console.WriteLine(t1.Llamar());
            Console.WriteLine(t1.Llamar("DIOS"));

            Console.WriteLine("¿Desea probar otra marca de teléfono? Escriba la palabra samsung o omotorola..");
            t2.Modelo2 = Console.ReadLine();
            Console.WriteLine("Usted puede acceder a los nuevos teléfos de 5G de : " + t2.Modelo2);

            Console.ReadKey();

        }
    }
}
