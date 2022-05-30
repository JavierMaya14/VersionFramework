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
    public partial class Mantenimiento : Form
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void Mantenimiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet32.DIBPreventivo_def' Puede moverla o quitarla según sea necesario.
            this.dIBPreventivo_defTableAdapter3.Fill(this.hospitalDataSet32.DIBPreventivo_def);
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet18.Correctivos' Puede moverla o quitarla según sea necesario.
            this.correctivosTableAdapter2.Fill(this.hospitalDataSet18.Correctivos);



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void advancedDataGridView2_FilterStringChanged(object sender, EventArgs e)
        {
            correctivosBindingSource2.Filter = advancedDataGridView2.FilterString;
        }

        private void advancedDataGridView2_SortStringChanged(object sender, EventArgs e)
        {
            correctivosBindingSource2.Sort = advancedDataGridView2.SortString;
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            dIBPreventivodefBindingSource2.Filter = advancedDataGridView1.FilterString;
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            dIBPreventivodefBindingSource2.Sort = advancedDataGridView1.SortString;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Preventivos nuevoPreventivo = new Preventivos();
            nuevoPreventivo.Nombre = txtNombreP.Text;
            nuevoPreventivo.No_Serie = txtSerieP.Text;
            nuevoPreventivo.Último_mto = txtUM.Text;
            nuevoPreventivo.Próximo_mto = txtPM.Text;
            nuevoPreventivo.Últ_calibración = txtUC.Text;
            nuevoPreventivo.Horas_uso = txtHoras.Text;
            nuevoPreventivo.P_o_C = txtPoC.Text;
            nuevoPreventivo.Garantía = txtGarantia.Text;
            nuevoPreventivo.Tipo_contrato = txtTipoC.Text;

            int resultado = IngresoPreventivos.Agregar(nuevoPreventivo);

            if(resultado > 0)
            {
                MessageBox.Show(" Datos guardados correctamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" No se guardaron los datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            txtNombreP.Clear();
            txtSerieP.Clear();
            txtUM.Clear();
            txtPM.Clear();
            txtUC.Clear();
            txtHoras.Clear();
            txtPoC.Clear();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Correctivos nuevoCorrectivo = new Correctivos();
            nuevoCorrectivo.Nombre = txtNombreC.Text;
            nuevoCorrectivo.No_Serie = txtNo_SerieC.Text;
            nuevoCorrectivo.Corr = txtCorr.Text;
            nuevoCorrectivo.Corr_Exitosos = txtCorr_E.Text;

            int resultado = IngresoCorrectivos.Agregar(nuevoCorrectivo);

            if (resultado > 0)
            {
                MessageBox.Show(" Datos guardados correctamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" No se guardaron los datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            txtNombreC.Clear();
            txtNo_SerieC.Clear();
            txtCorr.Clear();
            txtCorr_E.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF | *.pdf";
            axAcroPDF1.src = openFileDialog1.FileName;

        }

        private void ConsultaOS_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF | *.pdf";
            openFileDialog1.ShowDialog();
            axAcroPDF1.src = openFileDialog1.FileName;
            MessageBox.Show("Archivo cargado correctamente");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

    }
}
