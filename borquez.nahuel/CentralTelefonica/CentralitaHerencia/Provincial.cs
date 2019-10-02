using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        #region ATRIBUTOS

        protected Franja _franjaHoraria;
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

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(origen, destino, duracion)
        {
            this._franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja, Llamada unaLlamada) : this (unaLlamada.NroOrigen, miFranja, unaLlamada.Duracion, unaLlamada.NroDestino)
        {

        }
        #endregion


        #region METODOS

        protected override string Mostrar()
        {
            StringBuilder Sb = new StringBuilder();
            Sb.AppendFormat(base.Mostrar());
            Sb.AppendFormat(" - Franja Horaria: {0}", this._franjaHoraria);
            Sb.AppendFormat(" - Costo Llamada: {0}", this.CostoLlamada);
            return Sb.ToString();
        }
        public bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Provincial)
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
            //provinciales, franja * duracion
            float retorno = 0;
            switch (_franjaHoraria)
            {
                case (Franja.Franja_1):
                    retorno = (float)(0.99 * this.Duracion);
                    break;
                case (Franja.Franja_2):
                    retorno = (float)(1.25 * this.Duracion);
                    break;
                case (Franja.Franja_3):
                    retorno = (float)(0.66 * this.Duracion);
                    break;
            }
            return retorno;
        }
        #endregion
    }
}
