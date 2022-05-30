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
    public partial class Indicadores : Form
    {
        public Indicadores()
        {
            InitializeComponent();
        }

        private void indCorrectivos_MouseEnter(object sender, EventArgs e)
        {
            ind1.Visible = true;
        }

        private void indCorrectivos_MouseLeave(object sender, EventArgs e)
        {
            ind1.Visible = false;
        }

        private void indMedicion_MouseEnter(object sender, EventArgs e)
        {
            ind2.Visible = true;
        }

        private void indMedicion_MouseLeave(object sender, EventArgs e)
        {
            ind2.Visible = false;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Indicadores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet31.Inventario_Def' Puede moverla o quitarla según sea necesario.
            this.inventario_DefTableAdapter.Fill(this.hospitalDataSet31.Inventario_Def);
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet30.DIBPreventivo_def' Puede moverla o quitarla según sea necesario.
            this.dIBPreventivo_defTableAdapter.Fill(this.hospitalDataSet30.DIBPreventivo_def);
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet29.Preventivo' Puede moverla o quitarla según sea necesario.
            this.preventivoTableAdapter.Fill(this.hospitalDataSet29.Preventivo);
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet28.Correctivos' Puede moverla o quitarla según sea necesario.
            this.correctivosTableAdapter.Fill(this.hospitalDataSet28.Correctivos);


            // Periodos anteriores
            chartCorrectivos.Series["Efectividad"].Points.AddXY("2016-2017", 87);
            chartCorrectivos.Series["Efectividad"].Points.AddXY("2017-2018", 80);
            chartCorrectivos.Series["Efectividad"].Points.AddXY("2018-2019", 70);
            chartCorrectivos.Series["Efectividad"].Points.AddXY("2019-2020", 49);
            chartCorrectivos.Series["Efectividad"].Points.AddXY("2020-2021", 87);
            // Periodo actual
            float cR = 0;
            float cE = 0;
            for (int i = 0; i < tablaCorrectivos.RowCount; i++)
            {
                cR = Convert.ToInt32(tablaCorrectivos.Rows[i].Cells[2].Value) + cR;
                cE = Convert.ToInt32(tablaCorrectivos.Rows[i].Cells[3].Value) + cE;
            }
            double prom = (cE / cR) * 100;
            prom = (double)decimal.Round((decimal)prom, 2);
            chartCorrectivos.Series["Efectividad"].Points.AddXY("2021-2022", prom);


            // Periodos anteriores de Calibracion
            chartCalibracion.Series["Cumplimiento"].Points.AddXY("2016-2017", 80);
            chartCalibracion.Series["Cumplimiento"].Points.AddXY("2017-2018", 70);
            chartCalibracion.Series["Cumplimiento"].Points.AddXY("2018-2019", 91);
            chartCalibracion.Series["Cumplimiento"].Points.AddXY("2019-2020", 70);
            chartCalibracion.Series["Cumplimiento"].Points.AddXY("2020-2021", 88);
            // Periodo actual
            float eC = tablaCali.RowCount;
            float eR = tablaCali.RowCount;

            string str1 = "No";
            string str2 = "NO REQUIERE";
            for (int i = 0; i < tablaCali.RowCount; i++)
            {
                if (str1.Equals(tablaCali.Rows[i].Cells[4].Value) || str2.Equals(tablaCali.Rows[i].Cells[4].Value))
                {
                    eC = eC - 1;
                }
                if (str1.Equals(tablaCali.Rows[i].Cells[4].Value))
                {
                    eR = eR - 1;
                }
            }

            // Promedio
            double pCal = (eC / eR) * 100;
            pCal = (double)decimal.Round((decimal)pCal, 2);
            chartCalibracion.Series["Cumplimiento"].Points.AddXY("2021-2022", pCal);

            // Ultima grafica
            // Periodo actual
            float eF = tablaInv.RowCount; // En funcionamiento
            float eN = 0; // No funcionando

            string str3 = "ES";
            string str4 = "FS";
            for (int i = 0; i < tablaInv.RowCount; i++)
            {
                if (str4.Equals(tablaInv.Rows[i].Cells[5].Value))
                {
                    eF = eF - 1;
                }
            }

            float n = tablaInv.RowCount;
            eN = n - eF;


            // Promedio
            double pF = (eF / n) * 100;
            double pNF = (eN / n) * 100;
            pF = (double)decimal.Round((decimal)pF, 2);
            pNF = (double)decimal.Round((decimal)pNF, 2);
            chartEstado.Series["Porcentajes"].Points.AddXY("En funcionamiento", pF);
            chartEstado.Series["Porcentajes"].Points.AddXY("Fuera de servicio", pNF);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            ind3.Visible = true;
            ind4.Visible = true;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            ind3.Visible = false;
            ind4.Visible = false;
        }
    }
}
