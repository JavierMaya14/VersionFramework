using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace VersionFramework
{
    public class IngresoCorrectivos
    {
        public static int Agregar(Correctivos nCorrectivo)
        {
            int retorno = 0;
            using (SqlConnection Conn = BasesDatos.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(String.Format("Insert into Correctivos(Nombre, No_Serie, Correctivos, Corr_Exitosos) values ('{0}','{1}','{2}','{3}')",
                    nCorrectivo.Nombre, nCorrectivo.No_Serie, nCorrectivo.Corr, nCorrectivo.Corr_Exitosos), Conn);

                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }
        public static int Eliminar(string No_Serie)
        {
            int retorno = 0;
            using (SqlConnection Conn = BasesDatos.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(String.Format("Delete from Correctivos where  No_Serie = '{1}'", No_Serie), Conn);
                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }
    }
}
