using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        private byte nota1;//los atributos privados llevan _ al principio
        private byte nota2;
        private float notaFinal;
        public string nombre;
        public string apellido;
        public int legajo;

        //constructor
        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        //metodos
        public void CalcularFinal()
        {
            this.notaFinal = -1;
            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                Random numeroRandom = new Random();
                //next retorna un doble, lo tengo que castear a float
                this.notaFinal = (float)numeroRandom.Next(1, 10);//al ser un metodo de instancia no puedo hacer random.next
                                                                 //y como parametro recibe entre que valores puede ser el num
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public string Mostrar()
        {
            string retorno = " " + this.legajo.ToString() + "   " + this.apellido + " " + this.nombre + " " + this.nota1 + " " + this.nota2 + "  ";

            if (this.notaFinal == -1)
            {
                retorno += " Alumno desaprobado\n";
            }
            else
            {
                retorno += this.notaFinal + "\n";
            }

            return retorno;

        }
    }
}