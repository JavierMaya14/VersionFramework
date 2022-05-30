using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionFramework
{
    public class Solicitudes
    {
        public String Nombre_del_Equipo { get; set; }
        public String Modelo { get; set; }
        public String Marca { get; set; }


        public Solicitudes() { }

        public Solicitudes(String pNombre, String pModelo, String pMarca)
        {
            this.Nombre_del_Equipo = pNombre;
            this.Modelo = pModelo;
            this.Marca = pMarca;
        }
    }
}
