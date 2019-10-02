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
    public partial class FrmLocal : FrmLlamada
    {
        private Local nuevaLlamadaLocal;

        public Local Local { get { return this.nuevaLlamadaLocal; } }

        public FrmLocal()
        {
            InitializeComponent();
        }

        protected override void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            base.miLlamada = new Local(this.txtNroOrigen.Text, Convert.ToSingle(this.txtDuracion.Text), this.txtNroDestino.Text, Convert.ToSingle(this.txtCosto.Text));
            //nuevaLlamadaLocal = new Local(this.txtNroOrigen.Text, Convert.ToSingle(this.txtDuracion.Text), this.txtNroDestino.Text, Convert.ToSingle(this.txtCosto.Text));

            //base.btnAceptar_Click();//lamar al base para el dialogresult
            DialogResult = DialogResult.OK;
        }
    }
}
