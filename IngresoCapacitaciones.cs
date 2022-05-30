using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace VersionFramework
{
    public class IngresoCapacitaciones
    {
        public static int Agregar(Capacitaciones nCapacitacion)
        {
            int retorno = 0;
            using (SqlConnection Conn = BasesDatos.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(String.Format("Insert into Capacitaciones(Nombre_del_Equipo, Modelo, Marca, Fecha_Programada, Horas_Estimadas) values ('{0}','{1}','{2}','{3}', '{4}')",
                    nCapacitacion.Nombre, nCapacitacion.Modelo, nCapacitacion.Marca, nCapacitacion.Fecha_Programada, nCapacitacion.HorasEstimadas), Conn);

                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }

        public static int Eliminar(string Modelo)
        {
            int retorno = 0;
            using (SqlConnection Conn = BasesDatos.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(String.Format("Delete from Capacitaciones where  Modelo = '{1}'", Modelo), Conn);
                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }
    }

}


