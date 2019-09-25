using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10.Entidades
{
    public class Alumno
    {
        #region atributos
        protected string apellido;
        protected ETipoExamen examen;
        protected int legajo;
        protected string nombre;
        #endregion

        #region propiedades
        public string Apellido { get { return this.apellido; } }
        public ETipoExamen Examen { get { return this.examen; } }
        public int Legajo { get { return this.legajo; } }
        public string Nombre { get { return this.nombre; } }
        #endregion

        public Alumno(string nombre, string apellido, int legajo, ETipoExamen examen)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.examen = examen;
        }

        public static string Mostrar(Alumno alumnoUno)
        {
            /*
            //con string builder
            StringBuilder alumnoSb = new StringBuilder();
            alumnoSb.AppendFormat("Nombre: {0}", alumnoUno.Nombre);
            alumnoSb.AppendFormat(" - Apellido: {0}", alumnoUno.Apellido);
            alumnoSb.AppendFormat(" - Legajo: {0}", alumnoUno.Legajo);
            alumnoSb.AppendFormat(" - Examen: {0}", alumnoUno.Examen);
            return alumnoSb.ToString();
            */
            return "Nombre: " + alumnoUno.nombre + " Apellido: " + alumnoUno.apellido + " Legajo: " + alumnoUno.legajo + " Examen: " + alumnoUno.examen;
        }

        //sobrecarga del ToString
        public override string ToString()
        {
            return Alumno.Mostrar(this);//llama al mostrar de alumno y muestra el elem
        }

        public static bool operator ==(Alumno alumnoUno, Alumno alumnoDos)
        {
            bool retorno = false;
            if (!Object.Equals(alumnoUno, null) && !Object.Equals(alumnoDos, null))
            {
                if (alumnoUno.Legajo == alumnoDos.Legajo)
                {
                    retorno = true;
                } 
            }
            return retorno;
        }
        public static bool operator !=(Alumno alumnoUno, Alumno alumnoDos)
        {
            return !(alumnoUno == alumnoDos);
        }

        //APELLIDO
        public static int OrdenarPorApellidoAsc(Alumno alumnoUno, Alumno alumnoDos)
        {
            return string.Compare(alumnoUno.apellido, alumnoDos.apellido);
        }
        public static int OrdenarPorApellidoDesc(Alumno alumnoUno, Alumno alumnoDos)
        {
            return OrdenarPorApellidoAsc(alumnoUno, alumnoDos) * -1;
        }
        
        //LEGAJO
        public static int OrdenarPorLegajoAsc(Alumno alumnoUno, Alumno alumnoDos)
        {
            return string.Compare(alumnoUno.Legajo.ToString(), alumnoDos.Legajo.ToString());
        }
        public static int OrdenarPorLegajoDesc(Alumno alumnoUno, Alumno alumnoDos)
        {
            return OrdenarPorLegajoAsc(alumnoUno, alumnoDos) * -1;
        }


    }
}
