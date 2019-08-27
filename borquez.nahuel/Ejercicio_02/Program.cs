using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_02";

            int numero;
            string aux;
            double cuadrado=0;
            double cubo=0;


            Console.WriteLine("Ingrese un numero: ");
            aux = Console.ReadLine();

            numero = int.Parse(aux);

            if(numero < 0)
            {
                Console.WriteLine("Error, reingrese el numero.");

            }
            else
            {
                //calculo el cuadrado y el cubo con math.pow
                cuadrado = Math.Pow(numero,2);
                cubo = Math.Pow(numero,3);
            }

            Console.WriteLine("El numero elegido es: {0:#,###.00}", numero);
            Console.WriteLine("El cuadrado es : {0:#,###.00}", cuadrado);
            Console.WriteLine("El cubo es : {0:#,###.00}", cubo);
            Console.ReadKey();
        }
    }
}
