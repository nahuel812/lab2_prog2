using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_16.Entidades
{
    public class Deposito<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public Deposito(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<T>();
        }


        #region Sobrecargas 
        public static bool operator +(Deposito<T> d, T a)
        {
            bool retorno = false;

            if (d._lista.Count < d._capacidadMaxima)
            {
                if (d._lista.Contains(a) != true)
                {
                    d._lista.Add(a);
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
            }
            return retorno;
        }

        private int GetIndice(T a)
        {
            int i;
            for (i = 0; i < this._lista.Count; i++)
            {
                
                if(a.Equals(this._lista[i]))
                {
                    return i;
                }
            }
            i = -1;//no encontro ninguno igual
            return i;
        }


        public static bool operator -(Deposito<T> d, T a)
        {
            bool retorno = false;

            //usar getindice, si no lo encuentra nada, si lo encuntra lo saca
            if (d.GetIndice(a) != -1)
            {
                d._lista.Remove(a);
                retorno = true;
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }

        public bool Agregar(T a)
        {
            return (this + a);
        }
        public bool Remover(T a)
        {
            return (this - a);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            //typeof para T
            sb.AppendFormat("Capacidad maxia: {0}\nListado de Cocinas:\n", this._capacidadMaxima);
            foreach(T item in this._lista)
            {
                sb.AppendFormat(item.ToString());//usar typeof( T ) para poder mostrarlo
            }
            return sb.ToString();
        }
        #endregion
    }
}
