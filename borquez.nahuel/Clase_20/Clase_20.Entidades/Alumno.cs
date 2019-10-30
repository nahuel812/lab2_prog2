using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_20.Entidades
{
    public class Alumno:Persona
    {
        public double nota;

        public Alumno()
        {

        }

        public Alumno(string nombre,string apellido,int edad,double nota):base(nombre,apellido,edad)
        {
            this.nota = nota;
        }

        public override string ToString()
        {
            return String.Format("Nombre: {0} - Apellido: {1} - Edad:{2} - Nota: {0}",base.nombre,base.apellido,base.Edad ,this.nota);
        }
    }
}
