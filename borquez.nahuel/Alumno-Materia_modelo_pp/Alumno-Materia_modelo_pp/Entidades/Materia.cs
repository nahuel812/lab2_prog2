using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Materia
    {
        #region ATRIBUTOS

        private List<Alumno> _alumnos;
        private EMateria _nombre;
        private static Random _notaParaUnAlumno;
        #endregion


        #region PROPIEDADES

        public List<Alumno> Alumnos
        {
            get
            {
                return this._alumnos;
            }

            set
            {
                this._alumnos = value;
            }
        }

        public EMateria Nombre
        {
            get
            {
                return this._nombre;
            }

            set
            {
                this._nombre = value;
            }
        }
        #endregion

        #region CONSTRUCTORES

        private Materia()
        {
            _alumnos = new List<Alumno>();

        }

        private Materia(EMateria nombre) : this()
        {
            this._nombre = nombre;
        }

        static Materia()
        {
            _notaParaUnAlumno = new Random();
        }
        #endregion


        #region METODOS

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            //sb.AppendLine("\nMateria: " + this.Nombre);
            sb.AppendFormat("\nMateria: {0} \n", this.Nombre);

            sb.AppendFormat("***********************\n");
            sb.AppendFormat("********ALUMNOS********\n");
            
            foreach (Alumno alumnoAux in this.Alumnos)
            {
                sb.AppendLine(Alumno.Mostrar(alumnoAux));//muestro el alumno con su metodo de mostrar que recibe un alumno
            }
            return sb.ToString();
        }

        public void CalificarAlumnos()
        {
            foreach (Alumno alumnoAux in this.Alumnos)
            {
                alumnoAux.Nota = _notaParaUnAlumno.Next(1,10);
            }
        }
        #endregion

        #region SOBRECARGAS

        public static implicit operator Materia(EMateria nombre)
        {
            return new Materia(nombre);
        }
        

        public static implicit operator float(Materia m)
        {
            float acum = 0;
            float promedioTotal;

            foreach (Alumno alumnoAux in m.Alumnos)
            {
                acum += alumnoAux.Nota;
            }
            promedioTotal = acum / m.Alumnos.Count;

            return promedioTotal;
        }


        public static explicit operator string(Materia materia)
        {

            return materia.Mostrar() +"\n";
        }

        public static bool operator ==(Materia m, Alumno a)
        {
            bool retorno = false;

            foreach (Alumno alumnoAux in m.Alumnos)
            {
                if(alumnoAux == a)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Materia m, Alumno a)
        {
            return !(m == a);
        }
        

        public static Materia operator +(Materia m, Alumno a)
        {
            if(m == a)
            {
                Console.WriteLine("El alumno ya esta en la materia {0}!!!",m.Nombre);
                return m;
            }
            else
            {
                m.Alumnos.Add(a);
                Console.WriteLine("Se agrego el alumno a la materia {0}!!!", m.Nombre);
            }

            return m;
        }
        
        public static Materia operator -(Materia m, Alumno a)
        {
            if (m == a)
            {
                m.Alumnos.Remove(a);
                Console.WriteLine("Se quito el alumno a la materia {0}!!!", m.Nombre);
            }
            else
            {
                Console.WriteLine("El alumno no esta en la materia {0}!!!", m.Nombre);
                return m;
            }

            return m;
        }

        #endregion

    }
}
