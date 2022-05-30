using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace VersionFramework
{
    public class BasesDatos
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection Conn = new SqlConnection("Data Source=DESKTOP-DD74CTU\\SQLEXPRESS; Initial Catalog=Hospital; Integrated Security=SSPI");
            Conn.Open();

            return Conn;
        }

    }
}
