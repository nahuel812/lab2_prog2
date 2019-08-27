using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        byte nota1;
        byte nota2;
        float notaFinal;
        public string nombre;
        public string apellido;
        public int legajo;

        Random numeroRandom = new Random();
        //constructor
        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        //metodos
        void CalcularFinal()
        {
            this.notaFinal = -1;
            if(this.nota1 >= 4 && this.nota2 >= 4)
            {
                  //next retorna un doble, lo tengo que castear a float
                this.notaFinal = numeroRandom.Next(1,10);//al ser un metodo de instancia no puedo hacer random.next
                  //y como parametro recibe entre que valores puede ser el num
            }
        }

        void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        string Mostrar()
        {
            if(this.notaFinal != -1)
            {
                return this.nombre + " " + this.apellido + " " + this.legajo + " " + this.nota1 + " " + this.nota2 + " " + this.notaFinal + " \n"; 
            }
            else
            {
                return "Alumno desaprobado";
            }
              
        }
    }
}
