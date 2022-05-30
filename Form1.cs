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
    public partial class Form1 : Form
    {

        // Creacion de usuario y contrase;a
        string Usuario1 = "DIB";
        string Contraseña1 = "IBM2022";

        string Usuario2 = "PSalud";
        string Contraseña2 = "Hospital2022";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text != Usuario1 && txtUsuario.Text != Usuario2 ) || (txtContrasena.Text != Contraseña1 && txtContrasena.Text != Contraseña2))
            {

                if (txtUsuario.Text != Usuario1 && txtUsuario.Text != Usuario2)
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("Usuario incorrecto");
                    txtUsuario.Clear();
                    txtUsuario.Focus();
                    return;
                }

                else if (txtContrasena.Text != Contraseña1 && txtContrasena.Text != Contraseña2)
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("Contraseña incorrecta");
                    txtContrasena.Clear();
                    txtContrasena.Focus();
                    return;
                }

            }

            else
            {
                if (txtUsuario.Text == Usuario1 && txtContrasena.Text == Contraseña1)
                {
                    // Si ambas, usuario y contrasena son correctas
                    // Menu del 
                    this.Hide();
                    Menu Form = new Menu();
                    Form.ShowDialog();
                    txtUsuario.Clear();
                    txtContrasena.Clear();
                }

                if (txtUsuario.Text == Usuario2 && txtContrasena.Text == Contraseña2)
                {
                    // Si ambas, usuario y contrasena son correctas
                    // Menu del personal de salud
                    this.Hide();
                    Menu2 Form = new Menu2();
                    Form.ShowDialog();
                    this.Close();
                    txtUsuario.Clear();
                    txtContrasena.Clear();
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res;
            System.Media.SystemSounds.Hand.Play();
            res = MessageBox.Show("¿Quieres salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }

            else
            {
                this.Show();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
