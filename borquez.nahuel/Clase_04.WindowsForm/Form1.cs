using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_04.Entidades;

namespace Clase_04.WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnCrear_Click(object sender, EventArgs e)
        {
            int entero;
            string cadena;
            DateTime fecha;

            entero = int.Parse(this.txtEntero.Text);
            cadena = this.txtCadena.Text;
            fecha = Convert.ToDateTime(this.txtFecha.Text);

            Cosa cosaUno = new Cosa(cadena,fecha,entero);

            MessageBox.Show(cosaUno.Mostrar());

            //agrego la listbox
            lstLista.Items.Add(cosaUno.Mostrar());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }
    }
}
