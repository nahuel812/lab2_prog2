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
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Data.SqlClient;

namespace AdminPersonas
{
    public partial class FrmPrincipal : Form
    {
        private List<Persona> lista;
        private Persona miPersona;
        DataTable tablaPersonas;
        SqlDataAdapter da;
        SqlConnection conexion;

        public FrmPrincipal()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.tablaPersonas = new DataTable("Persona");
            this.lista = new List<Persona>();
            this.conexion = new SqlConnection(Properties.Settings.Default.conexion);
            this.da = new SqlDataAdapter("SELECT * FROM[personas_bd].[dbo].[personas]",conexion);
            this.CargarDataTable();
        }

        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string path = this.openFileDialog1.FileName;

            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Persona>));
                StreamReader sr1 = new StreamReader(path);
                this.lista=(List<Persona>)xml.Deserialize(sr1);
                sr1.Close();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void guardarEnArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            this.saveFileDialog1.ShowDialog();
            //this.saveFileDialog1.InitialDirectory
            string path = this.saveFileDialog1.FileName;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Persona>));
                StreamWriter sr1 = new StreamWriter(path);
                xml.Serialize(sr1, lista);
                sr1.Close();
                
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisorPersona frm = new frmVisorPersona(this.lista);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            this.lista = frm.listaPersonas;


            
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                conexion.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conexion;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT TOP 1000[id],[nombre],[apellido],[edad]FROM[personas_bd].[dbo].[personas]";
                this.da.Fill(this.tablaPersonas);
                MessageBox.Show("OK");
                SqlDataReader data = command.ExecuteReader();
                while (data.Read()!=false)
                {

                    MessageBox.Show(data["id"].ToString()+" " +data["nombre"].ToString() + " " + data["apellido"].ToString() + " " + data["edad"].ToString());
                }
                data.Close();
                conexion.Close();


            }
            catch(Exception exep)
            {
                MessageBox.Show(exep.Message);


            }
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void traerTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lista.Clear();
            try
            {
                
                SqlCommand cmb = new SqlCommand();
                cmb.Connection = conexion;
                cmb.CommandType = CommandType.Text;
                cmb.CommandText = "SELECT * FROM[personas_bd].[dbo].[personas]";
                this.da.Fill(this.tablaPersonas);
                SqlDataReader data = cmb.ExecuteReader();
                while (data.Read() != false)
                {
                    this.miPersona = new Persona(data["nombre"].ToString(), data["apellido"].ToString(), int.Parse(data["edad"].ToString()));
                    this.lista.Add(miPersona);
                }
                data.Close();
                conexion.Close();
                MessageBox.Show("CARGA EXITOSA");
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }
        private void CargarDataTable()
        {
            
            try
            {

                SqlCommand cmb = new SqlCommand();
                
                cmb.CommandType = CommandType.Text;
                cmb.CommandText = "SELECT * FROM[personas_bd].[dbo].[personas]";
                this.da.Fill(this.tablaPersonas);
                this.da.InsertCommand = new SqlCommand("INSERT INTO Personas VALUES(@p1,@p2,@p3)", conexion);
                this.da.UpdateCommand = new SqlCommand("UPDATE Personas SET nombre=@p1,apellido=@p2,edad=@p3 WHERE id=@p0",conexion);
                this.da.DeleteCommand = new SqlCommand("DELETE FROM Personas WHERE id=@p0 ",conexion);

                da.DeleteCommand.Parameters.Add("@p0", SqlDbType.Int, 10, "id");

                da.InsertCommand.Parameters.Add("@p1", SqlDbType.VarChar, 50, "nombre");
                da.InsertCommand.Parameters.Add("@p2", SqlDbType.VarChar, 50, "apellido");
                da.InsertCommand.Parameters.Add("@p3", SqlDbType.Int, 10, "edad");

                da.UpdateCommand.Parameters.Add("@p0", SqlDbType.Int, 10, "id");
                da.UpdateCommand.Parameters.Add("@p1", SqlDbType.VarChar, 50, "nombre");
                da.UpdateCommand.Parameters.Add("@p2", SqlDbType.VarChar, 50, "apellido");
                da.UpdateCommand.Parameters.Add("@p3", SqlDbType.Int, 10, "edad");



            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void visualizarTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVisorDataTable frm = new FrmVisorDataTable(this.tablaPersonas);
            frm.ShowDialog();
            this.tablaPersonas = frm.DATA;
        }

        private void sincronizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {


                da.Update(this.tablaPersonas);
                MessageBox.Show("SINCRONIZO CORRECTAMENTE");
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
