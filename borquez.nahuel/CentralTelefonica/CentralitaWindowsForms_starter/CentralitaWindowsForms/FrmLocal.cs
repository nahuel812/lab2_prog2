using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace CentralitaWindowsForms
{
    public partial class FrmLocal : Llamada
    {
        private Local nuevaLlamadaLocal;
        public Local Local { get { return this.nuevaLlamadaLocal; } }
        public FrmLocal()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            nuevaLlamadaLocal = new Local(this.textBox1.Text, (float)Convert.ToDouble(this.txtDuracion.Text), this.textBox2.Text, (float)Convert.ToDouble(this.txtCosto.Text));
            DialogResult = DialogResult.OK;
        }
    }
}
