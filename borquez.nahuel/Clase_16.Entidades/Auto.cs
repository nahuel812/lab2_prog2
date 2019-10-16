using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_16.Entidades
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public string Color { get { return this._color; } }
        public string Marca { get { return this._marca; } }

        #region Constructor
        
        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }
        #endregion

        #region Sobrecargas

        public static bool operator ==(Auto a, Auto b)
        {
            bool retorno = false;
            if(a._marca == b._marca && a._color == b._color)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if(obj is Auto)
            {
                if((Auto)obj == this)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public override string ToString()
        {
            return String.Format("Marca: {0} - Color: {1}\n",this.Marca,this.Color);
        }
        #endregion
    }
}
