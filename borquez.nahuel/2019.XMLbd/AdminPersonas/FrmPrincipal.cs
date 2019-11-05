using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Data.SqlClient;

namespace AdminPersonas
{
    public partial class FrmPrincipal : Form
    {
        private List<Persona> lista;
        //private SqlConnection sql;

        private DataTable tablaPersonas;

        public FrmPrincipal()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;

            this.lista = new List<Persona>();
            //this.sql = new SqlConnection(Properties.Settings.Default.conexion);

            this.tablaPersonas = new DataTable("Personas");//es la representacion en memoria de una porcion o de una tabla completa de base de datos
            //para trabajar de manera local,es independiente
            CargarDataTable();
        }

        //carga la datatable
        private void CargarDataTable()
        {
            try
            {

                SqlConnection sql = new SqlConnection(Properties.Settings.Default.conexion);
                sql.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = sql;

                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT *FROM[personas_bd].[dbo].[personas]";//FROM Personas

                SqlDataReader dataReader;
                //lo inicializo con execute reader
                dataReader = command.ExecuteReader();

                this.tablaPersonas.Load(dataReader);//carga la tabla, le paso el dataReader.
                dataReader.Close();
                //

                sql.Close();
            }
            catch(Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //implementar...
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Persona>));

                this.openFileDialog1.ShowDialog();

                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    this.lista = (List<Persona>)xml.Deserialize(sr);
                }
                
            }
            catch (Exception a )
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void guardarEnArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //implementar...

            //serializar lista de personas
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Persona>));

                this.saveFileDialog1.ShowDialog();
                
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    xml.Serialize(sw, lista);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                //throw;
            }

        }


        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmVisorPersona frm = new frmVisorPersona(this.lista);

                frm.StartPosition = FormStartPosition.CenterScreen;

                //implementar

                frm.Show();

                this.lista = frm.Personas;//prop para obtener la lista del visor

            }
            catch(Exception a)
            {
                MessageBox.Show(a.ToString());
            }
            

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //implementar
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sql = new SqlConnection(Properties.Settings.Default.conexion);//string de conexion a la bd
                sql.Open();
                MessageBox.Show("Exitoso");

                SqlCommand command = new SqlCommand();
                command.Connection = sql;

                command.CommandType = CommandType.Text;

                command.CommandText = "SELECT TOP 1000[id],[nombre],[apellido],[edad]FROM[personas_bd].[dbo].[personas]";//le paso el comando del management
                

                SqlDataReader dataReader;
                //lo inicializo con execute reader
                dataReader = command.ExecuteReader();
                //solo puedo leerlo y seguir 

                while( dataReader.Read() != false)//o null, leo de a uno y lo musetro
                {
                    MessageBox.Show(dataReader[0].ToString() + " " + dataReader[1].ToString());//dataReader[indice o "nombre de columna"].toString() para mostrarlo
                    
                }
                dataReader.Close();//cierro el reader
               
                sql.Close();
            }
            catch(Exception a )
            {
                MessageBox.Show("Algo salio mal");
            }
        }

        private void traerTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sql = new SqlConnection(Properties.Settings.Default.conexion);

                sql.Open();
                MessageBox.Show("EXITO!");
                SqlCommand comando = new SqlCommand();

                comando.Connection = sql;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM[personas_bd].[dbo].[personas]";

                SqlDataReader dataReader = comando.ExecuteReader(); // no se puede hacer busquedas, solo va para adelante, TODOS LOS REGISTROS DE LA BASE DE DATOS VAN A ESTAR EN ESTE OBJETO, PERO SE LE UNA SOLA VEZ
                //EL EXECTUE READER TRAE TODOS LOS DATOS DEL SERVIDOR Y LA IDEA ES RECUPERARLO, PASANDOLE LOS PARAMETROS AL CONSTRUCTOR DE LA LISTA A PARTIR DE LA BASE DE DATOS
                while (dataReader.Read() != false)
                {
                    this.lista.Add(new Persona(dataReader[1].ToString(), dataReader[2].ToString(), Convert.ToInt32(dataReader[3])));

                    MessageBox.Show($"Id: {dataReader[0].ToString()}\nNombre: {dataReader[1].ToString()}\nApellido: {dataReader[2].ToString()}\nEdad: {dataReader[3].ToString()}");
                    /*MessageBox.Show(dataReader[0].ToString()); id
                    MessageBox.Show(dataReader[1].ToString()); nombre
                    MessageBox.Show(dataReader[2].ToString()); apellido
                    MessageBox.Show(dataReader[3].ToString()); edad
                    */
                }

                comando.Connection.Close();
                dataReader.Close();
                sql.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
