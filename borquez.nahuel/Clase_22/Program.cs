using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_22.Entidades;

namespace Clase_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado e1 = new Empleado("Juan", "Perez", 123);
            Program prog = new Program();
            
            //e1.limiteSueldo += new LimiteSueldoDelegado(prog.manejadorEventoSueldo);//le asigno al evento el manejador

            //e1.limiteSueldoMejorado += new limiteSueldoMejorado(manejadorEventoSueldoMejorado);

            e1.limiteSueldoMejorado2 += new limiteSueldoMejorado(prog.manejadorEventoSueldoMejorado2);

            e1.Sueldo = 33333;

            Console.WriteLine(e1.ToString());
            Console.ReadKey();

            //e1.limiteSueldo
        }

        public void manejadorEventoSueldo(double sueldo, Empleado emp)
        {
            Console.WriteLine("Sueldo ingresado entre 18k y 30k: ");
            Console.WriteLine(sueldo);
            Console.WriteLine("\nEMPLEADO: ");
            Console.WriteLine(emp.ToString());
            Console.ReadKey();
        }

        public static void manejadorEventoSueldoMejorado(Empleado emp , EmpleadoEventArgs e)
        {
            Console.WriteLine("(static)Sueldo ingresado mayor a 30k:");
            Console.WriteLine(e.ToString());
            Console.WriteLine(emp.ToString());
            Console.ReadKey();

        }

        public void manejadorEventoSueldoMejorado2(Empleado emp, EmpleadoEventArgs e)
        {
            Console.WriteLine("(no static)Sueldo ingresado mayor a 30k:");
            Console.WriteLine(e.ToString());
            Console.WriteLine(emp.ToString());
            Console.ReadKey();
        }
    }
}
