using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using pry_negocio;

namespace pry_presentacion
{
    public partial class frm_listar_pais : Form
    {
        public frm_listar_pais()
        {
            InitializeComponent();
        }

        private void frm_listar_pais_Load(object sender, EventArgs e)
        {
            NegocioPais np = new NegocioPais();

            dgv_pais.DataSource = np.ListarPais();
        }

        
    }
}
