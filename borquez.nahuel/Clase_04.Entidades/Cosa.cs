using System;

namespace Clase_04.Entidades
{
    public class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;

        public string Mostrar()
        {
            return " " + this.entero.ToString() + "-" + cadena + "-" + fecha.ToString() + "\n";
        }

        //metodo con sobrecarga 
        public void EstablecerValor(int entero)
        {
            this.entero = entero;
        }
        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }
        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }

        //sobrecarga de constructor, 
        public Cosa()
        {
            this.entero = -1;
            this.cadena = "sin valor";
            this.fecha = DateTime.Now;
        }
        public Cosa(string str):this()//reutilizo el constructor de arriba
        {
            this.cadena = str;
        }
        public Cosa(string str, DateTime dat):this(str)
        {
            this.fecha = dat;

        }
        public Cosa(string str, DateTime dat, int ent):this(str,dat)
        {
            this.entero = ent;
        }
    }
}
