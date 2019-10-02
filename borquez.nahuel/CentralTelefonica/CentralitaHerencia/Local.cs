using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        #region ATRIBUTOS

        protected float _costo;
        #endregion


        #region PROPIEDADES

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion


        #region CONSTRUCTORES

        public Local(string origen, float duracion, string destino, float costo) : base(origen, destino, duracion)
        {
            this._costo = costo;
        }

        public Local(Llamada unaLlamada, float costo) : this (unaLlamada.NroOrigen, unaLlamada.Duracion, unaLlamada.NroDestino, costo)
        {

        }
        #endregion


        #region METODOS

        protected override string Mostrar()
        {
            StringBuilder Sb = new StringBuilder();
            Sb.AppendFormat(base.Mostrar());
            Sb.AppendFormat(" - Costo LLamada: {0}", this.CostoLlamada);
            return Sb.ToString();
        }

        public bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is Local)
            {
                retorno = true;
            }
            return retorno;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        private float CalcularCosto()
        {
            //locales, costo * duracion
            return this._costo * this._duracion;
        }
        #endregion
    }
}
