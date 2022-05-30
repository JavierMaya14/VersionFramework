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
    public partial class Mantenimiento2 : Form
    {
        public Mantenimiento2()
        {
            InitializeComponent();
        }

        private void Mantenimiento2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet19.PSPreventivo_Data' Puede moverla o quitarla según sea necesario.
            this.pSPreventivo_DataTableAdapter.Fill(this.hospitalDataSet19.PSPreventivo_Data);
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet18.Correctivos' Puede moverla o quitarla según sea necesario.
            this.correctivosTableAdapter1.Fill(this.hospitalDataSet18.Correctivos);
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet9.Correctivos' Puede moverla o quitarla según sea necesario.
            this.correctivosTableAdapter.Fill(this.hospitalDataSet9.Correctivos);

        }
    }
}
