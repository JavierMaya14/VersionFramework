using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace VersionFramework
{
    public class Preventivos
    {
        public String Nombre { get; set; }
        public String No_Serie { get; set; }
        public String Último_mto { get; set; }
        public String Próximo_mto { get; set; }
        public String Últ_calibración { get; set; }
        public String Horas_uso { get; set; }
        public String P_o_C { get; set; }
        public String Garantía { get; set; }
        public String Tipo_contrato { get; set; }

        public Preventivos() { }

        public Preventivos(String pNombre, String pNo_Serie, String pÚltimo_mto, String pPróximo_mto, String pÚlt_calibración, String pHoras_uso, String pP_o_C, String pGarantía, String pTipo_contrato) {
            this.Nombre = pNombre;
            this.No_Serie = pNo_Serie;
            this.Último_mto = pÚltimo_mto;
            this.Próximo_mto = pPróximo_mto;
            this.Últ_calibración = pÚlt_calibración;
            this.Horas_uso = pHoras_uso;
            this.P_o_C = pP_o_C;
            this.Garantía = pGarantía;
            this.Tipo_contrato =  pTipo_contrato;

        }

    }
}
