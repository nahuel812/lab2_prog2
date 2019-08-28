using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int edad = 19;
            string nombre = "Nahuel";
            string apellido;
            //titulo de la consola
            Console.WriteLine("Hola mundo C#\n");//imprimo en la consola
            Console.ReadLine();//pausa en la consola hasta que presiono una tecla

            Console.WriteLine("Su nombre es: {0} y tiene: {1}", nombre, edad);//las "mascaras" se hacen con {} y el indice de la variable
            Console.ReadKey();

            Console.WriteLine("Ingrese su apellido: ");//pido el apellido
            apellido = Console.ReadLine();//leo el apellido y lo guardo en apellido
            Console.WriteLine("Su apellido es: {0}", apellido);//muestro el apellido
            Console.ReadLine();
            

            int edad;
            Console.WriteLine("Ingrese su edad:");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("edad: {0}", edad);
            Console.ReadLine();
            */

            int num;
            int acum = 0;
            int maximo= 0;
            int minimo=0;
            float promedio;
            int i;

            Console.Title = "Ejercicio 1";

            for(i=0;i<5;i++)
            {
                Console.WriteLine("Ingrese un numero:");
                num = int.Parse(Console.ReadLine());

                if(i==0)
                {
                    maximo = num;
                    minimo = num;
                }
                else if(num<minimo)
                {
                    minimo = num;
                }
                else if(num>maximo)
                {
                    maximo = num;
                }
                acum = acum + num;
            }

            promedio = (float)acum / i;

            Console.WriteLine("El minimo es: {0}",minimo);
            Console.WriteLine("El maximo es: {0}", maximo);
            Console.WriteLine("El promedio es: {0}", promedio);
            Console.ReadKey();

        }
    }
}
