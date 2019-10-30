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
                /*
                foreach (Persona item in this.listaAux)
                {
                    lstVisor.Items.Add(item.ToString());
                }
                */
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona(/*params*/);
            frm.StartPosition = FormStartPosition.CenterScreen;

            //implementar
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;

            //implementar
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
