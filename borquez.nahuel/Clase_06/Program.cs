using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_06.Entidades;

namespace Clase_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;
            Paleta miPaleta = 3;
            ConsoleColor miColor;

            miColor = ConsoleColor.Red;

            Tempera miTempera = new Tempera(miColor,"Gota",10);

            texto = miTempera;//uso el implicit de tempera
            Console.WriteLine(texto);

            miPaleta += miTempera;

            texto = (string)miPaleta;//uso el explicit de paleta
            Console.WriteLine(texto);


            Console.ReadKey();
        }
    }
}
