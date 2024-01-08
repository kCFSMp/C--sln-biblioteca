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
    public class NegocioPais
    {
        private CrudPais cp = new CrudPais();

        public DataTable ListarPais()
        {
            return cp.ListarPais();
        }

        public void RegistrarPais(Pais pais)
        {
            cp.RegistrarPais(pais);
        }
        public void EditarPais(Pais pais)
        {
            cp.EditarPais(pais);
        }
        public void BorrarPais(String codigo)
        {
            cp.BorrarPais(codigo);
        }

    }
}
