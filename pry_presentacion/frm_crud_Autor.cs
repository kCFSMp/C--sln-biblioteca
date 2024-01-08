using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pry_entidad;
using pry_negocio;

namespace pry_presentacion
{
    public partial class frm_crud_Autor : Form
    {
        public frm_crud_Autor()
        {
            InitializeComponent();
        }

        NegocioPais np = new NegocioPais();
        NegocioAutor na = new NegocioAutor();
        int accion = 0;

        private void frm_crud_Autor_Load(object sender, EventArgs e)
        {
            cbo_pais.DataSource = np.ListarPais();
            cbo_pais.ValueMember = "codigo_pais";
            cbo_pais.DisplayMember = "pais";
            cbo_pais.SelectedIndex = -1;

            Listar();
        }


        private void Limpiar()
        {
            txt_codigo.Text = "";
            txt_nombre.Text = "";
            txt_ap_paterno.Text = "";
            txt_ap_materna.Text = "";
            dtp_fecha_nacimiento.Value = Convert.ToDateTime("01/01/2000");
            nud_numero_premios.Value = 0;
            cbo_pais.SelectedIndex = -1;
            txt_codigo.Focus();
        }

        private void Listar()
        {
            dgv_autor.DataSource = na.ListarAutor();
            dgv_autor.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_autor.ClearSelection();
            
            lbl_cantidad.Text= dgv_autor.RowCount.ToString()+ " registros";
        }


        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_codigo.Enabled = true;
            accion = 0;
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
            if (txt_nombre.TextLength == 0)
            {
                MessageBox.Show("Falta ingresar nombre del autor");
                txt_nombre.Focus();
                return;
            }
            if (txt_ap_paterno.TextLength == 0)
            {
                MessageBox.Show("Falta ingresar el apellido paterno");
                txt_ap_paterno.Focus();
                return;
            }
            if (txt_ap_materna.TextLength == 0)
            {
                MessageBox.Show("Falta ingresar el apellido materno");
                txt_ap_materna.Focus();
                return;
            }
            if (cbo_pais.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciones país");
                cbo_pais.Focus();
                return;
            }


            //Crear el objeto autor con los datos formulario
            Autor autor = new Autor();
            autor.codigo_autor= txt_codigo.Text;
            autor.nombre=txt_nombre.Text;
            autor.ap_paterno=txt_ap_paterno.Text;
            autor.ap_materno=txt_ap_materna.Text;
            autor.fecha_nacimiento = Convert.ToDateTime(dtp_fecha_nacimiento.Value);
            autor.numero_premios = Convert.ToInt16(nud_numero_premios.Value);
            autor.codigo_pais=cbo_pais.SelectedValue.ToString();


            String mensaje = "";
            if (accion == 0)
            {
                na.RegistrarAutor(autor);
                mensaje = ("Autor registrado...");
            }else if (accion == 1)
            {
                na.EditarAutor(autor);
                mensaje = ("Autor editado...");
            }

            

            //txt_codigo.Enabled = true;
            Listar();
            MessageBox.Show(mensaje);
            Limpiar();
            accion=0;

        }

        private void dgv_autor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgv_autor.CurrentRow;

            fila.Selected = true;

            txt_codigo.Text = fila.Cells[0].Value.ToString();
            txt_nombre.Text = fila.Cells[1].Value.ToString();
            txt_ap_paterno.Text = fila.Cells[2].Value.ToString();
            txt_ap_materna.Text = fila.Cells[3].Value.ToString();
            dtp_fecha_nacimiento.Value = Convert.ToDateTime(fila.Cells[4].Value);
            nud_numero_premios.Value = Convert.ToInt16(fila.Cells[5].Value);
            cbo_pais.Text = fila.Cells[6].Value.ToString();

            accion = 1;
            txt_codigo.Enabled= false;

        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {

            String mensaje = "Seguro que quieres borrar el autor?";
            DialogResult dr = MessageBox.Show(mensaje, "SENATI",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                if(txt_codigo.Text != "")
                {
                    na.BorrarAutor(txt_codigo.Text);
                    accion = 0;
                    txt_codigo.Enabled= true;
                    Listar();
                    MessageBox.Show("Autor borrado");
                    Limpiar();
                }
            }

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
