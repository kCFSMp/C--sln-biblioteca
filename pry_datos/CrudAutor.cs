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
    public class CrudAutor
    {
        private SqlConnection con;
        private Conexion conexion = new Conexion();

        public DataTable ListarAutor()
        {
            con = conexion.Conectar();

            String sql = "sp_listar_autor";

            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable tb_autor = new DataTable();

            da.Fill(tb_autor);

            return tb_autor;
        }

        public void RegistrarAutor(Autor autor)
        {
            con = conexion.Conectar();
            con.Open();

            String sql = "sp_registrar_autor";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@cod_autor", SqlDbType.Char, 5).Value = autor.codigo_autor;
            cmd.Parameters.Add("@nom", SqlDbType.VarChar, 15).Value = autor.nombre;
            cmd.Parameters.Add("@ap_paterno", SqlDbType.VarChar, 15).Value = autor.ap_paterno;
            cmd.Parameters.Add("@ap_materno", SqlDbType.VarChar, 15).Value = autor.ap_materno;
            cmd.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = autor.fecha_nacimiento;
            cmd.Parameters.Add("@premios", SqlDbType.Int).Value = autor.numero_premios;
            cmd.Parameters.Add("@autor_codigo", SqlDbType.Char, 5).Value = autor.codigo_pais;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }

            con.Close();

        }

        public void EditarAutor(Autor autor)
        {
            con = conexion.Conectar();
            con.Open();

            String sql = "sp_editar_autor";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@cod_autor", SqlDbType.Char, 5).Value = autor.codigo_autor;
            cmd.Parameters.Add("@nom", SqlDbType.VarChar, 15).Value = autor.nombre;
            cmd.Parameters.Add("@ap_paterno", SqlDbType.VarChar, 15).Value = autor.ap_paterno;
            cmd.Parameters.Add("@ap_materno", SqlDbType.VarChar, 15).Value = autor.ap_materno;
            cmd.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = autor.fecha_nacimiento;
            cmd.Parameters.Add("@premios", SqlDbType.Int).Value = autor.numero_premios;
            cmd.Parameters.Add("@autor_codigo", SqlDbType.Char, 5).Value = autor.codigo_autor;
  
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            con.Close();
        }

        public void BorrarAutor(String codigo)
        {
            con = conexion.Conectar();
            con.Open();

            String sql = "sp_borrar_autor";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@cod_autor", SqlDbType.Char, 5).Value = codigo;


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