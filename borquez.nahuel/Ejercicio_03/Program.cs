using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_03";

            int numeroIngresado;
            int i;
            int j;
            int contador=0;


            Console.WriteLine("Ingrese un numero: ");

            numeroIngresado = int.Parse(Console.ReadLine());

            if(numeroIngresado <= 1)
            {
                Console.WriteLine("Numeros debajo de 1 y 1 no son considerados primos.");
            }

            for(i=2; i < numeroIngresado; i++)
            {
                for(j=1; j<=i ; j++)
                {
                    if(i % j == 0)//si el resto es 0 sumo el contador
                    {
                        contador++;
                    }
                }

                if (contador == 2)
                {
                    Console.WriteLine("{0:#,###.00}", i);
                }

                contador = 0;
            }

            Console.ReadLine();
        }
    }
}
