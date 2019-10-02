using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        #region ATRIBUTOS

        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;
        #endregion


        #region PROPIEDADES

        public abstract float CostoLlamada { get; } //Propiedad de solo lectura abstracta
        public float Duracion { get { return this._duracion; } }
        public string NroDestino { get { return this._nroDestino; } }
        public string NroOrigen { get { return this._nroOrigen; } }
        #endregion


        #region CONSTRUCTORES

        public Llamada(string origen, string destino, float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        }
        #endregion


        #region METODOS
        protected virtual string Mostrar()
        {
            StringBuilder Sb = new StringBuilder();
            Sb.AppendFormat("Origen: {0}", this.NroOrigen);
            Sb.AppendFormat(" - Destino: {0}", this.NroDestino);
            Sb.AppendFormat(" - Duracion: {0}", this.Duracion);
            return Sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            return string.Compare(uno.Duracion.ToString(), dos.Duracion.ToString());
        }
        #endregion


        #region SOBRECARGA DE OPERADORES

        public static bool operator == (Llamada uno, Llamada dos)
        {
            bool retorno = false;
            if(Equals(uno, dos) && uno._nroDestino == dos._nroDestino && uno._nroOrigen == dos._nroOrigen)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Llamada uno, Llamada dos)
        {
            return !(uno == dos);
        }
        #endregion
    }
}
