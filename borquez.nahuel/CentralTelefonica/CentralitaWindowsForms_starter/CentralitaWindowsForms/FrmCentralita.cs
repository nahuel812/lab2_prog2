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
    public partial class FrmCentralita : Form
    {
        Centralita central = new Centralita("Telefonica");
        public FrmCentralita()
        {
            InitializeComponent();
            this.cboOrdenamiento.Text = "OrdenarPorDuracion";
        }

        private void BtnLocal_Click(object sender, EventArgs e)
        {
            FrmLocal frmLocal = new FrmLocal();
            frmLocal.ShowDialog();
            if (frmLocal.DialogResult == DialogResult.OK)
                central += frmLocal.Local;
            actualizarListado();
        }

        private void BtnProvincia_Click(object sender, EventArgs e)
        {
            FrmProvincia frmProvincia = new FrmProvincia();
            frmProvincia.ShowDialog();
            if (frmProvincia.DialogResult == DialogResult.OK)
                central += frmProvincia.Provincia;
            actualizarListado();
        }

        private void actualizarListado()
        {
            this.lstVisor.Items.Clear();
            central.OrdenarLLamadas();
            for (int i = 0; i < central.Llamadas.Count(); i++)
            {
                lstVisor.Items.Add(central.Llamadas[i]);
            }
        }
    }
}
