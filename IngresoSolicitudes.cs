using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace VersionFramework
{
    public class IngresoSolicitudes
    {
        public static int Agregar(Solicitudes nSolicitud)
        {
            int retorno = 0;
            using (SqlConnection Conn = BasesDatos.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(String.Format("Insert into Solicitudes_Cap(Nombre_del_Equipo, Modelo, Marca) values ('{0}', '{1}','{2}')",
                    nSolicitud.Nombre_del_Equipo, nSolicitud.Modelo, nSolicitud.Marca), Conn);

                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }
        // Para que el ingeniero elimine las solicitudes
        public static int Eliminar(string Modelo)
        {
            int retorno = 0;
            using (SqlConnection Conn = BasesDatos.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(String.Format("Delete from Solicitudes_Cap where  Modelo = '{1}'", Modelo), Conn);
                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }
    }
}
