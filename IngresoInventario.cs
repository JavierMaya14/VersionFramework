using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace VersionFramework
{
    public class IngresoInventario
    {
        public static int Agregar(ClaseInventario nInventario)
        {
            int retorno = 0;
            using (SqlConnection Conn = BasesDatos.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(String.Format("Insert into Inventario_def(Nombre, No_Serie, Modelo, Marca, Clasificación, Estado_Actual) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
                    nInventario.Nombre, nInventario.No_Serie, nInventario.Modelo, nInventario.Marca, nInventario.Estado_Actual), Conn);

                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }

        public static int Eliminar(string No_Serie)
        {
            int retorno = 0;
            using (SqlConnection Conn = BasesDatos.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(String.Format("Delete from Inventario_def where  No_Serie = '{1}'", No_Serie), Conn);
                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }
    }
}
