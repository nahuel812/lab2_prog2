using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        #region Atributos

        private List<Llamada> _listaLlamada;
        protected string _razonSocial;

        #endregion


        #region PORPIEDADES

        public float GananciaPorLocal
        {
            get
            {
                return this.CalcularGanancia(ETipoLlamada.Local);
            }
        }
        public float GananciaPorProvincia
        {
            get
            {
                return this.CalcularGanancia(ETipoLlamada.Provincial);
            }
        }
        public float GananciaTotal
        {
            get
            {
                return this.CalcularGanancia(ETipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return this._listaLlamada;
            }
        }
        #endregion


        #region CONSTRUCTORES

        public Centralita()
        {
            this._listaLlamada = new List<Llamada>();

        }
        public Centralita(string nombreEmpresa) : this()
        {
            this._razonSocial = nombreEmpresa;
        }
        #endregion


        #region METODOS

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.Llamadas.Add(nuevaLlamada);
        }

        public float CalcularGanancia(ETipoLlamada tipo)
        {
            float acumulador = 0;
            foreach(Llamada aux in this._listaLlamada)
            {
                if (tipo is ETipoLlamada.Local && aux is Local)
                {
                    acumulador += ((Local)aux).CostoLlamada;
                }
                else if (tipo is ETipoLlamada.Provincial && aux is Provincial)
                {
                    acumulador += ((Provincial)aux).CostoLlamada;
                }
                else if (tipo is ETipoLlamada.Todas)
                {
                    if (aux is Local)
                    {
                        acumulador += ((Local)aux).CostoLlamada;
                    }
                    else if(aux is Provincial)
                    {
                        acumulador += ((Provincial)aux).CostoLlamada;
                    }
                }
            }
            return acumulador;
        }

        public void OrdenarLLamadas()
        {
            this._listaLlamada.Sort(Llamada.OrdenarPorDuracion);
        }
        #endregion


        #region SOBRECARGA DE OPERADORES

        public static bool operator == (Centralita central, Llamada nuevaLlamada)
        {
            bool retorno = false;
            if (!Object.Equals(central, null) && !Object.Equals(nuevaLlamada, null))
            {
                foreach(Llamada aux in central.Llamadas)
                {
                    if(aux == nuevaLlamada)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }
        public static bool operator != (Centralita central, Llamada nuevaLlamada)
        {
            return !(central == nuevaLlamada);
        }
        public static Centralita operator +(Centralita central, Llamada nuevaLlamada)
        {
            if (central != nuevaLlamada)
            {
                central.AgregarLlamada(nuevaLlamada);
            }
            else
            {
                Console.WriteLine("La llamada ya esta en la central\n");
            }
            return central;
        }
        #endregion

        
        #region SOBREESCRITURA
        
        public override string ToString()
        {
            StringBuilder Sb = new StringBuilder();
            foreach(Llamada aux in this.Llamadas)
            {
                if (aux is Local)
                {
                    Sb.AppendLine(((Local)aux).ToString());
                }
                else if (aux is Provincial)
                {
                    Sb.AppendLine(((Provincial)aux).ToString());
                }
            }
            return Sb.ToString();
        }
        #endregion
    }
}
