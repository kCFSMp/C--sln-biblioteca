using System;
using System.Windows.Forms;

namespace pry_presentacion
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void btn_pais_Click(object sender, EventArgs e)
        {
            frm_crud_pais f1 = new frm_crud_pais();
            f1.ShowDialog();
        }

        private void btn_autor_Click(object sender, EventArgs e)
        {
            frm_crud_Autor f2 = new frm_crud_Autor();
            f2.ShowDialog();
        }

        private void btn_reporte_autor_Click(object sender, EventArgs e)
        {
            frm_reporte_autor f3 = new frm_reporte_autor();
            f3.ShowDialog();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
