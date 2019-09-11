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
    public partial class TemperaForm : Form
    {
        Tempera auxTempera;

        //creo una property solo lectura, devuelve una tempera
        public Tempera MiTempera { get { return this.auxTempera;} }  

        public TemperaForm()
        {
            InitializeComponent();

            foreach (ConsoleColor c in Enum.GetValues(typeof(ConsoleColor)))//Foreach de los colores de ConsoleColor
            {
                this.cmbColor.Items.Add(c);//Agrega los items que toma en ConsoleColor "c".
            }
            
            StartPosition = FormStartPosition.CenterScreen;//Inicializa formulario en el medio de la pantalla.
            this.cmbColor.SelectedItem = ConsoleColor.Magenta;//Selecciona por default el color que le pase
            this.cmbColor.DropDownStyle = ComboBoxStyle.DropDownList;//La lista del comboBox NO se puede editar.
        }

        public TemperaForm(Tempera temperaUno): this()
        {
            string marca=temperaUno.propTemperaMarca;
            int cant=temperaUno.propTemperaCant;
            ConsoleColor color=temperaUno.propTemperaColor;

            this.txtMarca.Text = marca;
            this.txtCant.Text = cant.ToString();
            this.cmbColor.SelectedItem = color ;


        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string auxCadena;
            int auxNumero;
            ConsoleColor auxColor;

            auxNumero = int.Parse(this.txtCant.Text);
            auxCadena = this.txtMarca.Text;
            auxColor = (ConsoleColor)this.cmbColor.SelectedItem;//Me devuelve el item seleccionado del comboBox, lo casteo a consolecolor.

            this.auxTempera = new Tempera(auxColor, auxCadena, auxNumero);//Le paso al contructor los atributos   
            
            MessageBox.Show(auxTempera);
            
            //Cambia el valor por defecto del boton. DialorResult.OK/Cancel/Etc.
            this.DialogResult = DialogResult.OK;//Cambia valor del formulario modal. Y automaticamente se cierra.
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;//Luego de presionar el boton cambia el dialogResult.Cancel.
        }
    }
}
