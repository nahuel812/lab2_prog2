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
        private List<Persona> listaAux;

        public frmVisorPersona()
        {
            InitializeComponent();
            listaAux =  new List<Persona>();
            
        }
        
        public frmVisorPersona(List<Persona> l):this()
        {
            this.listaAux = l;
            ActualizarLista();
        }

        public List<Persona> Personas { get { return this.listaAux; } }

    
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            
            
            //implementar
            frm.ShowDialog();
            lstVisor.Items.Clear();

            if(frm.DialogResult == DialogResult.OK)
            {
                listaAux.Add(frm.Persona);
                ActualizarLista();
                
                //bd
                SqlCommand comando = new SqlCommand();
                SqlConnection sql = new SqlConnection(Properties.Settings.Default.conexion);

                sql.Open();
                comando.Connection = sql;

                comando.CommandType = CommandType.Text;

                comando.CommandText = $"INSERT INTO Personas(nombre,apellido,edad) VALUES('{frm.Persona.nombre}','{frm.Persona.apellido}',{frm.Persona.edad})";
                comando.ExecuteNonQuery();
                //TEXTO Q SE LE PASA AL COMMAND TEXT values('COMILLAS SIMPLES EN LOS STRING','APELLIDO',31) // listado dentro de un try catch
                //PROBLEMA: CONCATENAR CADENA..
                
                comando.Connection.Close();
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = this.lstVisor.SelectedIndex;
            if(indice >= 0)
            {
                Persona p = listaAux[indice];
                frmPersona frm = new frmPersona(p);
                frm.StartPosition = FormStartPosition.CenterScreen;

                //implementar
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string consulta = $"UPDATE Personas SET nombre = '{frm.Persona.nombre}',apellido = '{frm.Persona.apellido}',edad = {frm.Persona.edad} where id = {indice+1} ";

                        this.listaAux.Remove(p);
                        this.listaAux.Add(frm.Persona);

                        using (SqlConnection sql = new SqlConnection(Properties.Settings.Default.conexion))
                        {
                            sql.Open();
                            using (SqlCommand command = new SqlCommand())
                            {
                                command.Connection = sql;
                                command.CommandType = CommandType.Text;
                                command.CommandText = consulta;
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message);
                    }
                    this.ActualizarLista();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;

            //implementar
            int indice = this.lstVisor.SelectedIndex;
            
            if (indice >= 0)
            {
                string consulta = $"DELETE FROM Personas WHERE id = {indice + 1}";
                try
                {
                    using (SqlConnection sql = new SqlConnection(Properties.Settings.Default.conexion))
                    {
                        using (SqlCommand sqlCommand = new SqlCommand())
                        {
                            sqlCommand.Connection = sql;
                            sqlCommand.CommandType = CommandType.Text;
                            sqlCommand.CommandText = consulta;
                            sql.Open();
                            sqlCommand.ExecuteNonQuery();
                        }
                    }
                }
                catch(Exception a)
                {
                    MessageBox.Show(a.ToString());
                }
                
                this.listaAux.Remove(listaAux[indice]);
                this.ActualizarLista();
            }
        }

        
        private void ActualizarLista()
        {
            lstVisor.Items.Clear();
            foreach (Persona item in this.listaAux)
            {
                lstVisor.Items.Add(item.ToString());
            }
        }
    }
}
