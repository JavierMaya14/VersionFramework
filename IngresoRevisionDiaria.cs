using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace VersionFramework
{
    public class IngresoRevisionDiaria
    {
        public static int Agregar(RevisionDiaria nRevisionDiaria)
        {
            int retorno = 0;
            using (SqlConnection Conn = BasesDatos.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(String.Format("Insert into RevisionDiaria(Nombre_del_Equipo) values ('{0}')",
                    nRevisionDiaria.Nombre_del_Equipo), Conn);

                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }
        public static int Eliminar(string Nombre_del_Equipo)
        {
            int retorno = 0;
            using (SqlConnection Conn = BasesDatos.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(String.Format("Delete from RevisionDiaria where  Nombre_del_Equipo = '{0}'", Nombre_del_Equipo), Conn);
                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }
    }
}
