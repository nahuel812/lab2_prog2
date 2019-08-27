using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_04";

            int contadorNumerosPerfectos = 0;
            int acum = 0;
            int i;
            int j;

            while(contadorNumerosPerfectos < 4)
            {
                for(i=0; ; i++)
                {
                    for(j=1;j<i;j++)
                    {
                        if(i % j == 0)
                        {
                            acum = acum + j;
                        }

                    }

                    if (acum == i)
                    {
                        if (contadorNumerosPerfectos == 0)
                        {
                            Console.WriteLine("Los primeros 4 numeros perfectos son: \n");
                        }

                        Console.WriteLine("{0:#,###}", i);
                        contadorNumerosPerfectos++;
                    }

                    acum = 0;
                    i++;
                }
            }

            Console.ReadLine();
        }
    }
}
