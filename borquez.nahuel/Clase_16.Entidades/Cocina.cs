using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_16.Entidades
{
    public class Cocina
    {
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;

        #region Propiedades

        public int Codigo { get { return this._codigo; } }
        public bool EsIndustrial { get { return this._esIndustrial; } }
        public double Precio { get { return this._precio; } }
        #endregion


        #region Constructores

        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._precio = precio;
            this._esIndustrial = esIndustrial;
        }
        #endregion


        #region Sobrecarga

        public static bool operator == (Cocina a, Cocina b)
        {
            bool retorno = false;

            if(a._codigo == b._codigo)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }


        public override string ToString()
        {
            return String.Format("Codigo: {0} - Precio: {1} - Es industrial? {2}\n",this.Codigo,this.Precio,this.EsIndustrial);
        }


        public override bool Equals(object obj)
        {
            bool retorno = false;

            if( obj is Cocina)
            {
                if((Cocina)obj == this)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        #endregion

    }
}
