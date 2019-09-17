using System;

namespace Clase_09.Entidades
{
    public class Capitulo
    {
        //instancia(no static)
        private int _numero;
        private string _titulo;
        private int _paginas;

        //de clase(static)
        private static Random generadorDeNumeros;
        private static Random generadorDePaginas;

        //propertys - s/l(solo lectura)
        public int Numero { get { return this._numero; } }
        public string Titulo { get { return this._titulo; } }
        public int Paginas { get { return this._paginas; } }

        //constructores

        //de clase - statico inicializa estaticos
        static Capitulo()
        {
            Capitulo.generadorDeNumeros = new Random();
            Capitulo.generadorDePaginas = new Random();
        }

        //instancia
        private Capitulo(int num, string titulo, int pag)
        {
            this._numero = num;
            this._titulo = titulo;
            this._paginas = pag;
        }

        //sobrecarga operadores

        public static implicit operator Capitulo(string str)
        {
            Capitulo miCapitulo = new Capitulo(generadorDeNumeros.Next(1, 75), str, generadorDePaginas.Next(1, 300));

            return miCapitulo;

        }


        public static bool operator ==(Capitulo capUno, Capitulo capDos)//num son iguales y titulo strin
        {
            bool retorno = false;
            if (capUno._titulo == capDos._titulo && capUno._numero == capDos._numero)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Capitulo capUno, Capitulo capDos)
        {
            return !(capUno == capDos);
        }
    }
}

