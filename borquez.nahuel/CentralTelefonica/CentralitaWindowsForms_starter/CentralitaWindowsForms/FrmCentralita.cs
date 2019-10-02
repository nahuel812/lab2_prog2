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

            this.cmbOrdenamiento.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbOrdenamiento.SelectedIndex = 0;
            //this.cmbOrdenamiento.Text = "OrdenarPorDuracion";
            
        }

        private void BtnLocal_Click(object sender, EventArgs e)
        {
            //mediante la propiedad llamada de llamada tomo el dato, frmLlamada.Llamada 
            FrmLocal frmLocal = new FrmLocal();
            frmLocal.ShowDialog();
            if (frmLocal.DialogResult == DialogResult.OK)
            {
                central += frmLocal.Local;
            }
                
            actualizarListado();
        }

        private void BtnProvincia_Click(object sender, EventArgs e)
        {
            FrmProvincia frmProvincia = new FrmProvincia();
            frmProvincia.ShowDialog();
            if (frmProvincia.DialogResult == DialogResult.OK)
            {
                //usar la propiedad del frmllamada
                central += frmProvincia.Provincia;
            }
                
            actualizarListado();
        }

        private void actualizarListado()
        {
            this.lstVisor.Items.Clear();//limpio la lista
            central.OrdenarLLamadas();//ordeno la lista
            for (int i = 0; i < central.Llamadas.Count(); i++)
            {
                lstVisor.Items.Add(central.Llamadas[i]);
            }
        }
    }
}
