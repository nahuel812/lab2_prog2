using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_10.WindowsForm
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCatedra formCatedra = new FrmCatedra();//nueva instancia del formulario catedra
            formCatedra.ShowDialog();//muestro el forulario

        }
    }
}
