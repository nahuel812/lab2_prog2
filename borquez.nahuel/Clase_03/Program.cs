using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona MiPersona = new Persona("nahuel","borquez",42340058); ; //mi nueva instancia
            /*
            MiPersona.nombre = "nahuel";
            MiPersona.apellido = "borquez";
            MiPersona.dni = 42340058;
            */
            Console.WriteLine(MiPersona.Mostrar()); //uso el metodo mostrar de mi clase persona
            Console.ReadLine();

            Persona OtraPersona = new Persona("mario","perez",5666343);
            /*
            OtraPersona.nombre = "mario";
            OtraPersona.apellido = "perez";
            OtraPersona.dni = 45534455;
            */
            Console.WriteLine(OtraPersona.Mostrar());
            Console.ReadLine();
        }
    }
}
