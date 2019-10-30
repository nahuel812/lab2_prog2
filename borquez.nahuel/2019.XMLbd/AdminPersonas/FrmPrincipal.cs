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

        public FrmPrincipal()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;

            this.lista = new List<Persona>();
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
            catch (Exception)
            {
                throw;
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
            catch(Exception a)
            {
                throw;
            }

            //////con sql

        }


        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisorPersona frm = new frmVisorPersona(this.lista);

            frm.StartPosition = FormStartPosition.CenterScreen;

            //implementar
            
            frm.Show();

            this.lista = frm.Personas;//prop para obtener la lista del visor

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
    }
}
