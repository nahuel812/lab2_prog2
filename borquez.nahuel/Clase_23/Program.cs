using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Clase_23.Entidades;
//using Entidades.Externa;//dll agregada como referencia
using Entidades.Externa.Sellada; //dll sellada
using Clase_23.EntidadesV2;

namespace Clase_23
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Persona p1 = new Persona("pepe","diaz",43552554);
            
            Console.WriteLine(p1.ObtenerInfo());
            
            Console.ReadKey();
            */

            PersonaExternaSellada persExternaSellada = new PersonaExternaSellada("pedro","perez",55,ESexo.Masculino);

            //Console.WriteLine(Extensora.ObtenerInfo(persExternaSellada));//uso el metodo de extension creado y le paso la personaexternasellada
            //Console.ReadKey();

            //Console.WriteLine(persExternaSellada.ObtenerInfo());
            //Console.ReadKey();

            //if(persExternaSellada.esNulo() == true)
            //{
            //    Console.WriteLine("es nulo");
            //}
            //else
            //{
            //    Console.WriteLine("no es nulo");
            //}
            Persona p1 = new Persona("asdf", "zxcv", 4352345);

            Console.WriteLine(string.Join("\n", p1.ObtenerListadoBD()));
            Console.ReadKey();
        }
    }
}
