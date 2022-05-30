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
    public partial class Menu2 : Form
    {
        public Menu2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mantenimiento2 Form = new Mantenimiento2();
            Form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Capacitacion2 Form = new Capacitacion2();
            Form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManualesChequeo Form = new ManualesChequeo();
            Form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
