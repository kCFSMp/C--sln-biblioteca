using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Librerías
using System.Data;
using System.Data.SqlClient;
using pry_entidad;

namespace pry_datos
{
    public class CrudPais
    {
        private SqlConnection con;
        private Conexion conexion = new Conexion();

        public DataTable ListarPais()
        {
            con = conexion.Conectar();
            con.Open();

            String sql = "sp_listar_pais";

            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable tb_pais = new DataTable();

            da.Fill(tb_pais);

            return tb_pais;

            
        }

        public void RegistrarPais(Pais pais)
        {
            con = conexion.Conectar();
            con.Open();

            String sql = "sp_registrar_pais";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@cod", SqlDbType.Char, 5).Value= pais.codigo_pais;
            cmd.Parameters.Add("@nom", SqlDbType.VarChar, 40).Value = pais.pais;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }

            con.Close();

        }

        public void EditarPais(Pais pais)
        {
            con = conexion.Conectar();
            con.Open();

            String sql = "sp_editar_pais";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@cod", SqlDbType.Char, 5).Value = pais.codigo_pais;
            cmd.Parameters.Add("@nom", SqlDbType.VarChar, 40).Value = pais.pais;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            con.Close();

        }

        public void BorrarPais(String codigo)
        {
            con = conexion.Conectar();
            con.Open();

            String sql = "sp_borrar_pais";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@cod", SqlDbType.Char, 5).Value = codigo;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            con.Close();
        }
    }
}
