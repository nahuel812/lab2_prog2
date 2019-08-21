using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_02.Entidades;//agrego un using de clase02 entidades para usar solo "Sello"

namespace Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            MiClase.edad = 19;
            string nombre;

            MiClase.MostrarEdad();

            nombre = MiClase.RetornarNombre();

            Console.WriteLine("Nombre:{0}\n", nombre);


            Console.WriteLine("Comparando nombres..");
            if(MiClase.CompararNombres("Nahuel"))
            {
                Console.WriteLine("Es verdadero");
            }
            else
            {
                Console.WriteLine("Es falso");
            }
            
            //para usar el MiClase de mi libreria primero pongo el namespace de la clase de la libreria.
            Console.WriteLine("Nombre de la otra libreria: {0}",MiLibreria.MiClase.MostrarNombre());

            Console.ReadLine();
            */

            //usando la clase sello del otro proyecto

            Console.WriteLine("{0}", Sello.Imprimir());//muestro
            Console.ReadLine();

            Sello.Borrar();//borro
            Console.ReadLine();

            Console.WriteLine("{0}", Sello.Imprimir());//muestro el borrado
            Console.ReadLine();

            Sello.mensaje = "Cambie el color";//pongo un nuevo msj

            Sello.color = ConsoleColor.Red;//elijo el color

            Sello.ImprimirEnColor();//imprimo en color
            Console.ReadLine();

            Console.WriteLine("Tendria que estar en Gris");
            Console.ReadLine();

        }
    }
}
