using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_04.Entidades;//agrego el using para solamente escribir "cosa."

namespace Clase_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa cosa1 = new Cosa();
            Cosa cosa2 = new Cosa("pedro");
            Cosa cosa3 = new Cosa("juan", DateTime.Now);
            Cosa cosa4 = new Cosa("pablo", DateTime.Now, 812);

            //con los metodos puedo hacer validaciones dentro
            cosa1.EstablecerValor(12);
            cosa1.EstablecerValor("pepe");
            cosa1.EstablecerValor(DateTime.Now);

            Console.WriteLine(cosa1.Mostrar());
            Console.WriteLine(cosa2.Mostrar());
            Console.WriteLine(cosa3.Mostrar());
            Console.WriteLine(cosa4.Mostrar());
            Console.ReadLine();
        }
    }
}
