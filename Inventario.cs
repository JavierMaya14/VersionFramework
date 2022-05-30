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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet13.Inventario_Def' Puede moverla o quitarla según sea necesario.
            this.inventario_DefTableAdapter.Fill(this.hospitalDataSet13.Inventario_Def);
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet8.Inventario_4' Puede moverla o quitarla según sea necesario.
            this.inventario_DefTableAdapter.Fill(this.hospitalDataSet13.Inventario_Def);


        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            inventarioDefBindingSource.Filter = advancedDataGridView1.FilterString;
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            inventarioDefBindingSource.Sort = advancedDataGridView1.SortString;
        }

        private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void advancedDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // numero de serie para eliminar
            txtEliminarNo_Serie.Text = advancedDataGridView1.CurrentCell.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mantenimiento Form = new Mantenimiento();
            Form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClaseInventario nuevoEquipo = new ClaseInventario();
            nuevoEquipo.Nombre = txtNombreI.Text;
            nuevoEquipo.No_Serie = txtSerieI.Text;
            nuevoEquipo.Modelo = txtModelo.Text;
            nuevoEquipo.Marca = txtMarca.Text;
            nuevoEquipo.Clasificación = txtClasif.Text;
            nuevoEquipo.Estado_Actual = txtEstado.Text;

            int resultado = IngresoInventario.Agregar(nuevoEquipo);

            if (resultado > 0)
            {
                MessageBox.Show(" Datos guardados correctamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" No se guardaron los datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            txtNombreI.Clear();
            txtSerieI.Clear();
            txtModelo.Clear();
            txtMarca.Clear();
            txtClasif.Clear();
            txtEstado.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        //    if (MessageBox.Show("¿Seguro que desea eliminar el objeto de la tabla?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //       int resultado = IngresoInventario.Eliminar(txtEliminarNo_Serie.Text);

        }
    }
}
