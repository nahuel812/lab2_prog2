using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_06.Entidades;

namespace Clase_07.WindowsForm
{
    public partial class Form1 : Form
    {
        Paleta miPaleta = 5;
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer=true;//Indica que el formulario es un contendedor para MDI(multiples formularios secundarios)
            this.WindowState = FormWindowState.Maximized;//Formulario maximizado
            this.groupBox1.Visible = false;//Se muestra o no el "atributo" groupBox.
        }

        private void crearPaletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.miPaleta = 5;
            this.groupBox1.Visible = true;//Hago visible el groupBox
            MessageBox.Show("Fueron creadas 5 Paletas");

            this.crearPaletaToolStripMenuItem.Enabled = false;//Deshabilita el poder seguir creando mas paletas para no pisarlas.
        }

        private void temperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TemperaForm FrmTempera = new TemperaForm();//creo el from de temperas.
            FrmTempera.ShowDialog();//Muestro el form de tempera y hasta que no se cierre la ventana no avanza el programa
            
            //Pregunto si ha cargado algun dato. (Al presionar boton Aceptar)
            if (FrmTempera.DialogResult == DialogResult.OK)
            {
                //uso la property para traer los datos de tempera
                miPaleta += FrmTempera.MiTempera;
                //this.lstPaleta.Items.Add((string)miPaleta);//Agrega a la listBox un item/los muestro en la lstbox           
                
                for(int i = 0;i<miPaleta.PropCantidad;i++)
                {
                    if(!Object.Equals(miPaleta[i],null))
                    {
                        this.lstPaleta.Items.Add((string)miPaleta[i]);
                    }
                    
                }
            }
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            TemperaForm FrmTempera = new TemperaForm();
            FrmTempera.ShowDialog();
            
            if (FrmTempera.DialogResult == DialogResult.OK)
            {
                //uso la property para traer los datos de tempera
                miPaleta += FrmTempera.MiTempera;
                //this.lstPaleta.Items.Add((string)miPaleta);//Agrega a la listBox un item/los muestro en la lstbox           

                //refresco la lista
                this.lstPaleta.Items.Clear();
                for (int i = 0; i < miPaleta.PropCantidad; i++)
                {
                    if (!Object.Equals(miPaleta[i], null))
                    {
                        this.lstPaleta.Items.Add((string)miPaleta[i]);
                    }
                }
            }

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            TemperaForm FrmTempera = new TemperaForm();
            FrmTempera.ShowDialog();
            
            
            if (FrmTempera.DialogResult == DialogResult.OK)
            {
                miPaleta -= FrmTempera.MiTempera;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice;
            indice = this.lstPaleta.SelectedIndex;

            TemperaForm formTempera = new TemperaForm(miPaleta[indice]);
            formTempera.ShowDialog();
            if (formTempera.DialogResult == DialogResult.OK)
            {
                miPaleta[indice] = formTempera.MiTempera;//seteo en el indice de la tempera los nuevos valoers

                //refresco la listbox
                this.lstPaleta.Items.Clear();
                for (int i = 0; i < miPaleta.PropCantidad; i++)
                {
                    if (!Object.Equals(miPaleta[i], null))
                    {
                        this.lstPaleta.Items.Add((string)miPaleta[i]);
                    }
                }
            }
        }
    }
}
