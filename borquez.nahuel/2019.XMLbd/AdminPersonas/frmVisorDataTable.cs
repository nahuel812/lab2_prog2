using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AdminPersonas
{
    public partial class frmVisorDataTable : frmVisorPersona
    {
        protected DataTable dataTable;

        public frmVisorDataTable(DataTable dt)
        {
            InitializeComponent();

            this.dataTable = dt;
            DataRow row;

            for(int i=0;i<dataTable.Rows.Count;i++)
            {
                row = dataTable.Rows[i];
                this.lstVisor.Items.Add(row["id"].ToString() + " - " + row["nombre"].ToString() + " - " + row["apellido"].ToString() + " - " + row["edad"].ToString());
            }
            
        }

        public DataTable DataTable { get { return this.dataTable; } }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            frmPersona frmPers = new frmPersona();

            frmPers.ShowDialog();

            if(frmPers.DialogResult == DialogResult.OK)
            {

                DataRow row = dataTable.NewRow();

                row["nombre"] = frmPers.Persona.nombre;
                row["apellido"] = frmPers.Persona.apellido;

                DataTable.Rows.Add(row);
                
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            DataRow datoFila = this.dataTable.Rows[this.lstVisor.SelectedIndex];

            frmPersona frmPers = new frmPersona(new Entidades.Persona(datoFila["nombre"].ToString(), datoFila["apellido"].ToString(), Convert.ToInt32( datoFila["edad"].ToString() ) ) );
            frmPers.ShowDialog();

            if(frmPers.DialogResult == DialogResult.OK)
            {
                datoFila["nombre"] = frmPers.Persona.nombre;
                datoFila["apellido"] = frmPers.Persona.apellido;
                datoFila["edad"] = frmPers.Persona.edad;

            }
            this.RefrescarLista();
        }

        protected void RefrescarLista()
        {
            this.lstVisor.Items.Clear();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                this.lstVisor.Items.Add(String.Format("{0} - {1} - {2} - {3}", dataTable.Rows[i][dataTable.Columns[0]], dataTable.Rows[i][dataTable.Columns[1]], dataTable.Rows[i][dataTable.Columns[2]], dataTable.Rows[i][dataTable.Columns[3]]));
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if(lstVisor.SelectedIndex >= 0)
            {
                DataRow fila = this.dataTable.Rows[this.lstVisor.SelectedIndex];//tomo la fila en el indice slecionado

                fila.Delete();//borro la fila

                this.RefrescarLista();//actualizo la lista
            }

        }
    }
}
