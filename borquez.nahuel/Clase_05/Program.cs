using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_05.Entidades;

namespace Clase_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta tintaUno = new Tinta();
            
            string texto = (string)tintaUno;
            Console.WriteLine(texto);

            Console.WriteLine(Tinta.Mostrar(tintaUno));


            //Pluma plumaCero = new Pluma();//necesito verificar que al pasarle null no se rompa
            //Pluma plumaUno = new Pluma("Pepito");//lo mismo que el de arriba
            Pluma plumaDos = new Pluma("Marcelo", tintaUno);
            Pluma plumaTres = new Pluma("Pepito",tintaUno,4);

            //las dos formas que puedo sumarle al usar la sobrecarga de operador +
            /*
            plumaUno = plumaUno + tintaUno;
            plumaUno += tintaUno;
            
            texto = (string)plumaUno;//uso el implicit 
            Console.WriteLine(texto);
            */
            texto = (string)plumaDos;
            Console.WriteLine(texto);
            
            texto = (string)plumaTres;
            Console.WriteLine(texto);


            Console.ReadKey();
        }
    }
}
