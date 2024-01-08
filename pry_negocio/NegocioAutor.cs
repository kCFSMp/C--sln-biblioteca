using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using pry_datos;
using pry_entidad;

namespace pry_negocio
{
    public class NegocioAutor
    {
        private CrudAutor ca = new CrudAutor();

        public DataTable ListarAutor()
        {
            return ca.ListarAutor();
        }

        public void RegistrarAutor(Autor autor)
        {
            ca.RegistrarAutor(autor);
        }
        public void EditarAutor(Autor autor)
        {
            ca.EditarAutor(autor);
        }
        public void BorrarAutor(String codigo)
        {
            ca.BorrarAutor(codigo);
        }
    }
}
