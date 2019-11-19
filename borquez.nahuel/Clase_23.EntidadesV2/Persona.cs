using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;

namespace Clase_23.EntidadesV2
{
    public class Persona
    {
        public List<Persona> listaPersona = new List<Persona>();

        protected string nombre;
        protected string apellido;
        protected int dni;

        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

            //Si quiero ver los atributos por fuera de la clase
            // #1 - Propiedad - (s/l)
            // #2 - Getters ( -> metodo, prop. s/l)

        public string Nombre { get { return this.nombre; } }
        public string Apellido { get { return this.apellido; } }
        public int DNI { get { return this.dni; } }

        public string ObtenerInfo()
        {
            return string.Format("{0} - {1} - {2}\n", this.nombre, this.apellido, this.dni);
        }

            //conecta la bd, por cada registro genera un obj por cada obj a la lista y luego retornar la lista, nulo si no se pudo conectar o no hay info
        public List<Persona> ObtenerListadoBD()
        {
            try
            {
                SqlConnection sql = new SqlConnection(Properties.Settings.Default.conexion);
                sql.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = sql;

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT TOP 1000 [nombre],[apellido],[edad] FROM[persona].[dbo].[persona_bd]";

                SqlDataReader dataReader = command.ExecuteReader();

                while(dataReader.Read())
                {
                    listaPersona.Add(new Persona(dataReader[0].ToString(), dataReader[1].ToString(), Convert.ToInt32(dataReader[2])));
                    
                }
                return listaPersona;

            }
            catch(Exception a)
            {
                return null;
            }
                
        }

        public override string ToString()
        {
            return this.ObtenerInfo();
        }
    }
    
}
