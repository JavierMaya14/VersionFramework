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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Inventario_Click(object sender, EventArgs e)
        {
            Inventario Form = new Inventario(); // declaro un formulario de tipo Inventario
            Form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mantenimiento Form = new Mantenimiento();
            Form.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart(); // Para cerrar sesion
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Capacitación Form = new Capacitación();
            Form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManualesChequeo Form = new ManualesChequeo();
            Form.ShowDialog();

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Indicadores Form = new Indicadores();
            Form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
