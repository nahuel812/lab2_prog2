using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_10.Entidades
{
    public class Catedra
    {
        private List<Alumno> alumnos;

        public List<Alumno> Alumnos { get { return this.alumnos; } }

        public Catedra()
        {
            this.alumnos = new List<Alumno>();
        }

        #region Sobrecargas

        public static bool operator ==(Catedra catedra, Alumno alumno)
        {
            bool retorno = false;
            if (!Object.Equals(catedra, null) && !Object.Equals(alumno, null))
            {
                foreach (Alumno aux in catedra.alumnos)
                {
                    if (aux == alumno)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }
        public static bool operator !=(Catedra catedra, Alumno alumno)
        {
            return !(catedra == alumno);
        }

        public static bool operator +(Catedra catedra, Alumno alumno)
        {
            bool retorno = false;
            if (catedra != alumno)
            {
                catedra.alumnos.Add(alumno);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator -(Catedra catedra, Alumno alumno)
        {
            bool retorno = false;
            if (catedra == alumno)
            {
                catedra.alumnos.Remove(alumno);
                retorno = true;
            }
            return retorno;
        }
        
        public static int operator |(Alumno alumno, Catedra catedra)
        {
            int indice = -1;
            if (catedra == alumno)
            {
                indice = catedra.alumnos.IndexOf(alumno);
            }
            return indice;
        }
    }
    #endregion
}