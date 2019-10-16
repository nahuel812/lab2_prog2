using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_16.Entidades
{
    public class DepositoDeCocinas
    {
        private int _capacidadMaxima;
        private List<Cocina> _lista;

        #region Constructores

        public DepositoDeCocinas(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Cocina>();
        }
        #endregion


        #region Sobrecargas
        
        public static bool operator + (DepositoDeCocinas d,Cocina c)
        {
            bool retorno = false;

            if(d._lista.Count < d._capacidadMaxima)
            {
                if(d._lista.Contains(c) != true)
                {
                    d._lista.Add(c);
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
            }
            return retorno;
        }

        private int GetIndice(Cocina c)
        {
            int i;
            for(i=0 ; i<this._lista.Count ; i++)
            {
                if(this._lista[i] == c)
                {
                    return i;
                }
            }
            i = -1;//no encontro ninguno igual
            return i;
        }

        
        public static bool operator -(DepositoDeCocinas d, Cocina c)
        {
            bool retorno = false;

            //usar getindice, si no lo encuentra nada, si lo encuntra lo saca
            if(d.GetIndice(c) != -1)
            {
                d._lista.Remove(c);
                retorno = true;
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }

        public bool Agregar(Cocina c)
        {
            return (this + c);
        }
        public bool Remover(Cocina c)
        {
            return (this - c);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Capacidad maxia: {0}\nListado de Cocinas:\n", this._capacidadMaxima);
            foreach (Cocina item in this._lista)
            {
                sb.AppendFormat(item.ToString());
            }
            return sb.ToString();
        }
        #endregion
    }
}
