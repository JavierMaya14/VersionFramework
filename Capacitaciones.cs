using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VersionFramework
{
    public class Capacitaciones
    {
        public String Nombre { get; set; }
        public String Modelo { get; set; }
        public String Marca { get; set; }
        public String Fecha_Programada { get; set; }
        public int HorasEstimadas { get; set; }



        public Capacitaciones() { }

        public Capacitaciones(String pNombre, String pModelo, String pMarca, String pFecha_Programada, int pHoras_Estimadas)
        {
            this.Nombre = pNombre;
            this.Modelo = pModelo;
            this.Marca = pMarca;
            this.Fecha_Programada = pFecha_Programada;
            this.HorasEstimadas = pHoras_Estimadas;
        }
    }
}
