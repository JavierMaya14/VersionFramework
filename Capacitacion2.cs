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
    public partial class Capacitacion2 : Form
    {
        public Capacitacion2()
        {
            InitializeComponent();
        }

        private void Capacitacion2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet24.Capacitaciones' Puede moverla o quitarla según sea necesario.
            this.capacitacionesTableAdapter2.Fill(this.hospitalDataSet24.Capacitaciones);
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet23.Capacitaciones' Puede moverla o quitarla según sea necesario.
            this.capacitacionesTableAdapter1.Fill(this.hospitalDataSet23.Capacitaciones);
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet22.Solicitudes_Cap' Puede moverla o quitarla según sea necesario.
            this.solicitudes_CapTableAdapter1.Fill(this.hospitalDataSet22.Solicitudes_Cap);
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet21.Solicitudes_Cap' Puede moverla o quitarla según sea necesario.
            this.solicitudes_CapTableAdapter.Fill(this.hospitalDataSet21.Solicitudes_Cap);
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet20.Capacitaciones' Puede moverla o quitarla según sea necesario.
            this.capacitacionesTableAdapter.Fill(this.hospitalDataSet20.Capacitaciones);

        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            Solicitudes nuevaSolicitud = new Solicitudes();
            nuevaSolicitud.Nombre_del_Equipo = txtNomS.Text;
            nuevaSolicitud.Modelo = txtModeloS.Text;
            nuevaSolicitud.Marca = txtMarcaS.Text;


            int resultado = IngresoSolicitudes.Agregar(nuevaSolicitud);

            if (resultado > 0)
            {
                MessageBox.Show(" Datos guardados correctamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" No se guardaron los datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            txtNomS.Clear();
            txtModeloS.Clear();
            txtMarcaS.Clear();

            this.Hide();
            Capacitacion2 Form = new Capacitacion2();
            Form.ShowDialog();
        }
    }
}
