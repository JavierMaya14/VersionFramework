using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionFramework
{
    public class ClaseInventario
    {
        public String Nombre { get; set; }
        public String No_Serie { get; set; }
        public String Modelo { get; set; }
        public String Marca { get; set; }
        public String Clasificación { get; set; }
        public String Estado_Actual { get; set; }



        public ClaseInventario() { }

        public ClaseInventario(String pNombre, String pNo_Serie, String pModelo, String pMarca, String pClasificación, String pEstado_Actual)
        {
            this.Nombre = pNombre;
            this.No_Serie = pNo_Serie;
            this.Modelo = pModelo;
            this.Marca = pMarca;
            this.Clasificación = pClasificación;
            this.Estado_Actual = pEstado_Actual;

        }
    }
}
