using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pry_entidad
{
    public class Autor
    {
        public String codigo_autor { get; set; }
        public String nombre { get; set; }
        public String ap_paterno { get; set; }
        public String ap_materno { get; set; }

        public DateTime fecha_nacimiento { get; set; }
        public int numero_premios { get; set; }
        public string codigo_pais { get; set; }

        public String Completo()
        {
            return this.nombre + " " + this.ap_paterno + " " + this.ap_materno;
        }
    }
}
