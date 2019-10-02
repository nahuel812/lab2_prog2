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
    public partial class FrmProvincia : FrmLlamada
    {
        private Provincial nuevaLlamadaProvincia;

        public Provincial Provincia { get { return this.nuevaLlamadaProvincia; } }

        public FrmProvincia()
        {
            InitializeComponent();

            foreach(Franja franjaAux in Enum.GetValues(typeof(Franja)))
            {
                cmbFranja.Items.Add(franjaAux);
            }
            this.cmbFranja.SelectedItem = Franja.Franja_1;
            this.cmbFranja.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        protected override void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            base.miLlamada = new Provincial(this.txtNroOrigen.Text, (Franja)this.cmbFranja.SelectedIndex, Convert.ToSingle(this.txtDuracion.Text), this.txtNroDestino.Text);
            //nuevaLlamadaProvincia = new Provincial(this.txtNroOrigen.Text, (Franja)this.cmbFranja.SelectedIndex, Convert.ToSingle(this.txtDuracion.Text), this.txtNroDestino.Text);

            //guardarlo en el atributo de tipo llamada
            ///base.btnAceptar_Click();//tengo que llamar al base para el dialogresult
            DialogResult = DialogResult.OK;
        }
    }
}
