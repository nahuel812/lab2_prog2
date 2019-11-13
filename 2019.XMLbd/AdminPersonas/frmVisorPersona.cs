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
using System.Data.SqlClient;

namespace AdminPersonas
{
    public partial class frmVisorPersona : Form
    {
        private List<Persona> lista;
        public List<Persona> listaPersonas { get {return this.lista; } }
        public frmVisorPersona()
        {
            
            InitializeComponent();
            this.lista = new List<Persona>();
        }
        public frmVisorPersona(List<Persona> lista):this()
        {
            this.lista = lista;
            ActualizarLista();
        }

        protected virtual void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if(frm.DialogResult==DialogResult.OK)
            {
                this.lista.Add(frm.Persona);
                try
                {
                    SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
                    conexion.Open();
                    SqlCommand cmb = new SqlCommand();
                    cmb.Connection = conexion;
                    cmb.CommandType = CommandType.Text;
                    cmb.CommandText = "INSERT INTO Personas(nombre,apellido,edad)VALUES('"+ frm.Persona.nombre+"','"+frm.Persona.apellido+"',"+frm.Persona.edad+")";
                    cmb.ExecuteNonQuery();
                    conexion.Close();
                }
                catch(Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
            ActualizarLista();

            

        }

        protected virtual void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = this.lstVisor.SelectedIndex;
            frmPersona frm = new frmPersona(this.lista[indice]);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if(frm.DialogResult==DialogResult.OK)
            {
                this.lista[indice] = frm.Persona;
                try
                {


                    SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
                    conexion.Open();
                    SqlCommand cmb = new SqlCommand();
                    cmb.Connection = conexion;
                    cmb.CommandType = CommandType.Text;
                    cmb.CommandText = "UPDATE Personas SET nombre='" + frm.Persona.nombre + "',apellido='" + frm.Persona.apellido + "',edad=" + frm.Persona.edad+ "WHERE id=" + (indice + 1);
                    cmb.ExecuteNonQuery();
                    conexion.Close();
                }
                catch(Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }


            }
            ActualizarLista();
            
        }

        protected virtual void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = this.lstVisor.SelectedIndex;
            //frmPersona frm = new frmPersona();
            //frm.StartPosition = FormStartPosition.CenterScreen;
            this.lista.RemoveAt(indice);
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
                conexion.Open();
                SqlCommand cmb = new SqlCommand();
                cmb.Connection = conexion;
                cmb.CommandType = CommandType.Text;
                cmb.CommandText = "DELETE FROM Personas WHERE nombre='" + this.lista[indice].nombre+"'";
                cmb.ExecuteNonQuery();
                conexion.Close();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            ActualizarLista();

            
        }
        protected virtual void ActualizarLista()
        {
            lstVisor.Items.Clear();
            foreach (Persona item in this.lista)
            {
                lstVisor.Items.Add(item.ToString());
            }

        }
   
  }
}
