using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clase_23.Entidades
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int dni;

        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        //Si quiero ver los atributos por fuera de la clase
        // #1 - Propiedad - (s/l)
        // #2 - Getters ( -> metodo, prop. s/l)

        public string Nombre { get { return this.nombre; } }
        public string Apellido { get { return this.apellido; } }
        public int DNI { get { return this.dni; } }

        public string ObtenerInfo()
        {
            return string.Format("{0} {1} {2}\n",this.nombre,this.apellido,this.dni);
        }
        
    }
}
