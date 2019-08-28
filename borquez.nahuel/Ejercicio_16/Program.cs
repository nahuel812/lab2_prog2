using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_16";

            Alumno alumnoUno = new Alumno("nahuel", "borquez", 1);
            Alumno alumnoDos = new Alumno("pedro", "diaz", 2);
            Alumno alumnoTres = new Alumno("mario", "perez", 3);

            alumnoUno.Estudiar(8, 8);
            alumnoDos.Estudiar(4, 4);
            alumnoTres.Estudiar(2, 3);

            alumnoUno.CalcularFinal();
            alumnoDos.CalcularFinal();
            alumnoTres.CalcularFinal();

            Console.WriteLine(alumnoUno.Mostrar());
            Console.WriteLine(alumnoDos.Mostrar());
            Console.WriteLine(alumnoTres.Mostrar());

            Console.ReadLine();
        }
    }
}