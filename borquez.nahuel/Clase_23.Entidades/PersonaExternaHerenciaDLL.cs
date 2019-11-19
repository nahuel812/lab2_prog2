using System;
using System.Collections.Generic;
using System.Text;
using Entidades.Externa;

namespace Clase_23.Entidades
{
    public class PersonaExternaHerenciaDLL : PersonaExterna
    {
        public PersonaExternaHerenciaDLL(string nombre, string apellido, int edad, ESexo sexo) : base(nombre,apellido,edad,sexo)
        {

        }

        public string Nombre { get { return this._nombre; } }
        public string Apellido { get { return this._apellido; } }
        public int Edad { get { return this._edad; } }
        public ESexo Sexo { get { return this._sexo; } }

    }
}
