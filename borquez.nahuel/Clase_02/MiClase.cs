using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    public class MiClase
    {
        //ATRIBUTOS DE MICLASE
        public static string nombre = "Nahuel";
        public static int edad;
        

        //METODOS DE MICLASE
        public static void MostrarEdad()
        {
            Console.WriteLine("La edad es:{0}", MiClase.edad);

        }
 
        public static string RetornarNombre()
        {
            return MiClase.nombre;
        }

        public static bool CompararNombres(string nombre)
        {
            if(MiClase.nombre == nombre)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
