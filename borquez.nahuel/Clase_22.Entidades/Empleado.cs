using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_22.Entidades
{
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private int legajo;
        private double sueldo;

        public event LimiteSueldoDelegado limiteSueldo;

        public event limiteSueldoMejorado limiteSueldoMejorado;

        public event limiteSueldoMejorado limiteSueldoMejorado2;

        public Empleado(string nom, string apell, int legaj)
        {
            this.nombre = nom;
            this.apellido = apell;
            this.legajo = legaj;

        }

        #region Propiedades

        public string Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                this.nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }

            set
            {
                this.apellido = value;
            }
        }

        public int Legajo
        {
            get
            {
                return this.legajo;
            }

            set
            {
                this.legajo = value;
            }
        }

        public double Sueldo
        {
            get
            {
                return this.sueldo;
            }

            set
            {
                if (value > 18000 && value < 29999)
                {
                    this.limiteSueldo(value, this);//le paso al evento los valores
                }
                else if (value > 30000)
                {
                    this.limiteSueldoMejorado(this, new EmpleadoEventArgs() );
                }
                else
                {
                    this.sueldo = value;
                }
                
            }
        }
        #endregion

        public override string ToString()
        {
            /*
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("",);

            return sb.ToString();
            */
            return String.Format("Nombre: {0} - Apellido: {1} - Legajo: {2} - Sueldo: {3}\n",this.nombre,this.apellido,this.legajo,this.sueldo);
        }

        
        

    }
}
