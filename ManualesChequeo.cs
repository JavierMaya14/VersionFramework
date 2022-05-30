using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VersionFramework
{
    public partial class ManualesChequeo : Form
    {
        public ManualesChequeo()
        {
            InitializeComponent();
            fechaHoy.Text = DateTime.Today.ToString("MM/dd/yyyy");
        }
        private void FechaHoy()
        {
            fechaHoy.Text = DateTime.Today.ToString();
        }
        private void btnManuales_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "PDF | *.pdf";
            openFileDialog2.ShowDialog();
            axAcroPDF2.src = openFileDialog2.FileName;
            MessageBox.Show("Archivo cargado correctamente");
        }

        private void tablaRevision_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fechaHoy_Click(object sender, EventArgs e)
        {
            fechaHoy.Text = DateTime.Today.ToString("MM/dd/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RevisionDiaria nuevoAparato= new RevisionDiaria();
            nuevoAparato.Nombre_del_Equipo = txtRevision.Text;

            int resultado = IngresoRevisionDiaria.Agregar(nuevoAparato);

            if (resultado > 0)
            {
                MessageBox.Show(" Datos guardados correctamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" No se guardaron los datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            txtRevision.Clear();
            this.Hide();
            ManualesChequeo Form = new ManualesChequeo();
            Form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int check = 0;
            for (int i = 0; i < revisionD.RowCount; i++)
            {
                if (tablaRevision.GetItemChecked(i) == true)
                    check = check + 1;
            }

            if(check == revisionD.RowCount)
                MessageBox.Show(" Revisión diaria completa");
            else
                MessageBox.Show(" Revisión diaria incompleta");
        }

        private void ManualesChequeo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet27.RevisionDiaria' Puede moverla o quitarla según sea necesario.
            this.revisionDiariaTableAdapter1.Fill(this.hospitalDataSet27.RevisionDiaria);
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet26.RevisionDiaria' Puede moverla o quitarla según sea necesario.
            this.revisionDiariaTableAdapter.Fill(this.hospitalDataSet26.RevisionDiaria);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < revisionD.RowCount; i++)
            {
                tablaRevision.Items.Add(revisionD.Rows[i].Cells[0].Value.ToString());
            }
        }
    }
}
