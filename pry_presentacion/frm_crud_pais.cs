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
using pry_entidad;

namespace pry_presentacion
{
    public partial class frm_crud_pais : Form
    {
        public frm_crud_pais()
        {
            InitializeComponent();
        }

        private NegocioPais np = new NegocioPais();
        private String accion = "r";

        private void frm_crud_pais_Load(object sender, EventArgs e)
        {
            Listar();
        }


        private void Listar()
        {
            dgv_pais.DataSource = np.ListarPais();
            dgv_pais.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgv_pais.Rows[0].Selected = false;

            int num_reg = dgv_pais.Rows.Count;
            lbl_cantidad.Text = "Existen " + num_reg.ToString() + " registros";
        }


        private void Limpiar()
        {
            txt_codigo.Text = "";
            txt_pais.Text = "";

            txt_codigo.Focus();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_codigo.Enabled = true;
            accion = "r";
            
            Limpiar();
            
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text.Length == 0)
            {
                MessageBox.Show("Falta ingresar código");
                txt_codigo.Focus();
                return;
            }
            if (txt_pais.TextLength == 0)
            {
                MessageBox.Show("Falta ingresar nombre de país");
                txt_pais.Focus();
                return;
            }

            //Instancia la entidad
            Pais pais = new Pais();
            pais.codigo_pais = txt_codigo.Text;
            pais.pais = txt_pais.Text;

            String mensaje = "";
            if (accion == "r")
            {
                np.RegistrarPais(pais);
                mensaje= ("País registrado...");
            }else if (accion == "e")
            {
                np.EditarPais(pais);
                mensaje = ("País editado...");
            }

            accion="r";

            txt_codigo.Enabled =true;

            Listar();
            MessageBox.Show(mensaje);
            Limpiar();
        }

        private void dgv_pais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_pais.CurrentRow.Selected = true;
            txt_codigo.Text= dgv_pais.CurrentRow.Cells[0].Value.ToString();
            txt_pais.Text = dgv_pais.CurrentRow.Cells[1].Value.ToString();

            txt_codigo.Enabled = false;

            accion = "e";
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            String mensaje = "¿Seguro que quieres borrar el país?";

            DialogResult dr = MessageBox.Show(mensaje, "SENATI",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                if (txt_codigo.Text != "")
                {
                    np.BorrarPais(txt_codigo.Text);

                    accion = "r";
                    txt_codigo.Enabled =true;
                    Listar();
                    MessageBox.Show("Pais borrado");
                    Limpiar();
                }
                
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
