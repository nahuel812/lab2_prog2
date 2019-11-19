using System;
using System.Collections.Generic;
using System.Text;
using Entidades.Externa.Sellada;//agrego la ref de la dll sellada

namespace Clase_23.Entidades
{
    public static class Extensora
    {
        //desarrollo los metodos de extension para poder ver los atributos de la clase sellada
        //todos los metodos deben ser static y public
        
            //esa vinculacion hace que para el tipo que viene despues de this le voy a agregar un metodo de extension que se va
            //a utilizar como de intancia
        public static string ObtenerInfo(this PersonaExternaSellada personaExternaSellada)
        {
            return string.Format("{0} - {1} - {2} - {3} \n",personaExternaSellada.Nombre,personaExternaSellada.Apellido,personaExternaSellada.Edad,personaExternaSellada.Sexo);//no puedo usar this pq es static
        }

        public static bool esNulo(this Object obj)
        {
            bool retorno = false; 
            if (obj != null)
            {
                return retorno;

            }
            else if ( obj == null)
            {
                return retorno;
            }
            return retorno;
        }

        
    }
}
