using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agregar las librerías para SQL
using System.Data.SqlClient;
using System.Configuration;

namespace pry_datos
{
    public class Conexion
    {
        // Método Conectar
        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn_biblioteca"].ConnectionString);

            return cn;
        }
    }
}
