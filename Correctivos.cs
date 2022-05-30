using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionFramework
{
    public class Correctivos
    {
        public String Nombre { get; set; }
        public String No_Serie { get; set; }
        public String Corr { get; set; }
        public String Corr_Exitosos{ get; set; }
  

        public Correctivos() { }

        public Correctivos(String pNombre, String pNo_Serie, String pCorr, String pCorr_E)
        {
            this.Nombre = pNombre;
            this.No_Serie = pNo_Serie;
            this.Corr = pCorr;
            this.Corr_Exitosos = pCorr_E;

        }
    }
}
