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
    public partial class Capacitación : Form
    {
        public Capacitación()
        {
            InitializeComponent();
        }

        private void Capacitación_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet25.Capacitaciones' Puede moverla o quitarla según sea necesario.
            this.capacitacionesTableAdapter1.Fill(this.hospitalDataSet25.Capacitaciones);
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet21.Solicitudes_Cap' Puede moverla o quitarla según sea necesario.
            this.solicitudes_CapTableAdapter.Fill(this.hospitalDataSet21.Solicitudes_Cap);
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet20.Capacitaciones' Puede moverla o quitarla según sea necesario.
            this.capacitacionesTableAdapter.Fill(this.hospitalDataSet20.Capacitaciones);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtClasif_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guardar_Capacitacion_Click(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtSerieI_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreI_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guardar_Capacitacion_Click_1(object sender, EventArgs e)
        {
            Capacitaciones nuevaCapacitacion = new Capacitaciones();
            nuevaCapacitacion.Nombre = txtNomCap.Text;
            nuevaCapacitacion.Modelo = txtModeloCap.Text;
            nuevaCapacitacion.Marca = txtMarcaCap.Text;
            nuevaCapacitacion.Fecha_Programada = txtFecha.Text;
            nuevaCapacitacion.HorasEstimadas = int.Parse(txtHorasEstimadas.Text);

            int resultado = IngresoCapacitaciones.Agregar(nuevaCapacitacion);

            if (resultado > 0)
            {
                MessageBox.Show(" Datos guardados correctamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" No se guardaron los datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            txtNomCap.Clear();
            txtModeloCap.Clear();
            txtMarcaCap.Clear();
            txtFecha.Clear();
            txtHorasEstimadas.Clear()
                ;
            this.Hide();
            Capacitación Form = new Capacitación();
            Form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
