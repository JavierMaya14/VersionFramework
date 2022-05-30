using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//
namespace VersionFramework
{
    public class IngresoPreventivos
   {
      public static int Agregar(Preventivos nPreventivo) 
        {
            int retorno = 0;
            using (SqlConnection Conn = BasesDatos.ObtenerConexion())
           {
                SqlCommand Comando = new SqlCommand(String.Format("Insert into DIBPreventivo_def(Nombre, No_Serie, Último_mto, Próximo_mto, Últ_calibración, Horas_uso, P_o_C, Garantía, Tipo_contrato) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}', '{8}')",
                    nPreventivo.Nombre, nPreventivo.No_Serie, nPreventivo.Último_mto, nPreventivo.Próximo_mto, nPreventivo.Últ_calibración, nPreventivo.Horas_uso, nPreventivo.P_o_C, nPreventivo.Garantía,
                    nPreventivo.Tipo_contrato), Conn);

                retorno = Comando.ExecuteNonQuery();
           }
            return retorno;
        }

        public static int Eliminar(string No_Serie)
        {
            int retorno = 0;
            using (SqlConnection Conn = BasesDatos.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(String.Format("Delete from DIBPreventivo_def where  No_Serie = '{1}'", No_Serie), Conn);
                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }
    }
}
