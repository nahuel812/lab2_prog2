using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        #region ATRIBUTOS

        private string _apellido;
        private int _legajo;
        private string _nombre;
        private float _nota;
        #endregion

        #region PROPIEDADES
        public string Apellido
        {
            get {return this._apellido; }
            set {this._apellido = value; }
        }

        public int Legajo
        {
            get { return this._legajo; }
            set { this._legajo = value; }
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public float Nota
        {
            get { return this._nota; }
            set { this._nota = value; }
        }
        #endregion


        #region CONSTRUCTORES

        //o sobrecargar un constructor cambiando el orden de los paranm
        public Alumno()
        {
            this._legajo = 0;
            this._nombre = "";
            this._apellido = "";
        }

        public Alumno(int legajo)
        {
            this._legajo = legajo;
        }

        public Alumno(int legajo, string nombre) : this(legajo)
        {
            this._nombre = nombre;
        }
    
        public Alumno(int legajo, string nombre, string apellido) : this(legajo,nombre)
        {
            this._apellido = apellido;
        }
        #endregion

        #region METODOS

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(this.Apellido + ", " + this.Nombre + " - Legajo: " + this.Legajo.ToString() + " - Nota: " + this.Nota.ToString()+"\n");

            return sb.ToString();
        }
        
        public static string Mostrar(Alumno alumno)
        {
            return alumno.Mostrar();//uso la propiedad de lalumno para mostrarse
        }
        #endregion

        #region SOBRECARGAS

        public static bool operator ==(Alumno a1, Alumno a2)
        {
            bool retorno = false;

            if(a1.Legajo == a2.Legajo )
            {
                retorno = true;
            }

            return retorno;
        }
        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }
        #endregion
    }
}
