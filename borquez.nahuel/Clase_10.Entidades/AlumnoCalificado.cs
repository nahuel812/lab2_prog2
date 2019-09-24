using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_10.Entidades
{
    public class AlumnoCalificado:Alumno
    {
        protected double nota;

        public double Nota { get { return this.nota; } }

        public AlumnoCalificado(Alumno alumno, double nota) : base(alumno.Nombre, alumno.Apellido, alumno.Legajo, alumno.Examen)
        {
            this.nota = nota;
        }

        public AlumnoCalificado(string nombre, string apellido, int legajo, ETipoExamen examen, double nota): this(new Alumno(nombre, apellido, legajo, examen), nota)
        {
            
        }

        public string Mostrar()
        {
            return Alumno.Mostrar(this) + " - Nota:" + this.Nota.ToString()+ "\n";
        }
    }
}
