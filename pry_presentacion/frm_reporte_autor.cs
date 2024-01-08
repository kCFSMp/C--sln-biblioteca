using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry_presentacion
{
    public partial class frm_reporte_autor : Form
    {
        public frm_reporte_autor()
        {
            InitializeComponent();
        }

        private void frm_reporte_autor1_Load(object sender, EventArgs e)
        {
            ds_autor dsa= new ds_autor();
            ds_autorTableAdapters.DataTable1TableAdapter dta = new ds_autorTableAdapters.DataTable1TableAdapter();
            dta.Fill(dsa.dt_autor);

            cr_autor cra = new cr_autor();
            cra.SetDataSource(dsa);
            crv_autor.ReportSource = cra;
        }
    }
}
