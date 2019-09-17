using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_09.Entidades
{
    public class Libro
    {
        private string _titulo;
        private string _autor;
        private List<Capitulo> capitulos;//genero un generico tipo list

        //propiedades S/L(solo lectura)
        public string Titulo { get { return this._titulo; } }
        public string Autor { get { return this._autor; } }


        //porpiedad que devuelve cantidad de paginas,  contar sus paginas por capitulos, acumularlas y luego retornar
        public int CantidadDePaginas
        {
            get
            {
                int cantTotalPaginas = 0;
                foreach (Capitulo cap in this.capitulos)//por cada capitulo en capitulos, le sumo su cant de paginas
                {
                    cantTotalPaginas += cap.Paginas;
                }

                return cantTotalPaginas;
            }
        }

        //porpiedad que devuelve cantidad capitulos
        public int CantidadDeCapitulos
        {
            get
            {
                int cantTotalCapitulos = 0;
                foreach (Capitulo cap in this.capitulos)
                {
                    cantTotalCapitulos += 1;
                }
                return cantTotalCapitulos;
            }
        }

        //constructor
        public Libro(string titulo, string autor)
        {
            this._titulo = titulo;
            this._autor = autor;

            //creo los capitulos
            this.capitulos = new List<Capitulo>();//creo un LIST(coleccion generica) de capitulos que es mi type
        }


        //indexador, lectura y escritura
        //get: -el indice del capitulo supera los limites retorno null
        //     -si es un indice valido retorno el capitulo en dicha posicion
        //     
        //set: -si el indice no esta en el rango, lo agrego como elemento nuevo con add
        //     -si es un indice inferior a 0 no hago a nada, y si es entre 0 y el rango limite remplazo en esa posicion
        public Capitulo this[int index]
        {
            get
            {
                if (index < 0 || index > this.capitulos.Count)//si se sale del rango retorno null
                {
                    return null;
                }
                else
                {
                    //si esta en el rango retorno el capitulo en el indice
                    return this.capitulos[index];
                }
                /* return the specified index here */
            }

            set
            {
                if (index >= this.capitulos.Count)//si el indice es mayor lo agrego
                {
                    this.capitulos.Add(value);
                }
                else if (index < 0)//validacion del indice < 0 (no hago nada)
                {

                }
                else
                {
                    //si esta en el rango lo seteo en el indice
                    this.capitulos[index] = value;
                }
                /* set the specified index to value here */
            }
        }

    }
}
