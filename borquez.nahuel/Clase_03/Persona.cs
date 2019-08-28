using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    class Persona
    {
        //atributos no estaticos
        public string nombre;
        public string apellido;
        public int dni;

        public Persona(string nombre, string apellido, int dni)//constructor 
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public string Mostrar()
        {
            //al no ser atributos estaticos uso this
            return this.nombre + " " + this.apellido + " " + this.dni + "\n"; 
        }
    }
}
