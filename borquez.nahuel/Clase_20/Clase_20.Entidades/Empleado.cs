using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_20.Entidades
{
    public class Empleado : Persona
    {
        public int legajo;
        public double sueldo;

        public Empleado()
        {

        }

        public Empleado(string nombre,string apellido, int edad,int legajo, double sueldo):base(nombre,apellido,edad) 
        {
            this.legajo = legajo;
            this.sueldo = sueldo;
        }

        public override string ToString()
        {
            return String.Format("Nombre: {0} - Apellido: {1} - Edad: {2} -Legajo: {3} - Sueldo: {4}", base.nombre, base.apellido, base.Edad, this.legajo, this.sueldo);
        }
    }
}
