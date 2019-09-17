using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_09.Entidades;

namespace Clase_09
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Capitulo c1 = "Primer capitulo";
            Capitulo c2 = "Segundo capitulo";
            Capitulo c3 = "Tercer capitulo";

            Console.WriteLine(c1.Numero);//para mostrarlo con las prop
            Console.WriteLine(c1.Titulo);
            Console.WriteLine(c1.Paginas);
            //l[2] = c1;
            //Console.Write(l[0]);
            Console.ReadLine();
            */

            //main de prueba
            Libro miLibro = new Libro("C# al descubierto", "Joe Mayo");

            miLibro[0] = "Fundamentos Básicos de C#";
            miLibro[1] = "Cómo comenzar con C#";
            miLibro[2] = "Cómo escribir expresiones con C#";

            miLibro[-1] = "Genero un índice erroneo";
            miLibro[5] = "Genero otro índice erroneo";
            
            Console.WriteLine("Libro:");
            Console.WriteLine("Titulo: {0}", miLibro.Titulo);
            Console.WriteLine("Autor: {0}", miLibro.Autor);
            Console.WriteLine("Cantidad de páginas: {0}", miLibro.CantidadDePaginas);
            
            for (int i = 0; i < miLibro.CantidadDeCapitulos; i++)
            {
                Console.WriteLine("Capitulo {0}: {1} {2}", miLibro[i].Numero, miLibro[i].Titulo, miLibro[i].Paginas);
            }

            Console.ReadLine();
        }
    }
}