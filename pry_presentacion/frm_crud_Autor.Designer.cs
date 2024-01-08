namespace pry_presentacion
{
    partial class frm_crud_Autor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_grabar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.dgv_autor = new System.Windows.Forms.DataGridView();
            this.txt_ap_paterno = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ap_materna = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.nud_numero_premios = new System.Windows.Forms.NumericUpDown();
            this.cbo_pais = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_autor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_numero_premios)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(833, 330);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(96, 25);
            this.btn_salir.TabIndex = 21;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(591, 330);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(96, 25);
            this.btn_borrar.TabIndex = 20;
            this.btn_borrar.Text = "BORRAR";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_grabar
            // 
            this.btn_grabar.Location = new System.Drawing.Point(263, 330);
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(96, 25);
            this.btn_grabar.TabIndex = 19;
            this.btn_grabar.Text = "GRABAR";
            this.btn_grabar.UseVisualStyleBackColor = true;
            this.btn_grabar.Click += new System.EventHandler(this.btn_grabar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(49, 330);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(96, 25);
            this.btn_nuevo.TabIndex = 18;
            this.btn_nuevo.Text = "NUEVO";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // dgv_autor
            // 
            this.dgv_autor.AllowUserToAddRows = false;
            this.dgv_autor.AllowUserToDeleteRows = false;
            this.dgv_autor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_autor.Location = new System.Drawing.Point(451, 65);
            this.dgv_autor.Name = "dgv_autor";
            this.dgv_autor.ReadOnly = true;
            this.dgv_autor.Size = new System.Drawing.Size(478, 203);
            this.dgv_autor.TabIndex = 17;
            this.dgv_autor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_autor_CellClick);
            // 
            // txt_ap_paterno
            // 
            this.txt_ap_paterno.Location = new System.Drawing.Point(209, 142);
            this.txt_ap_paterno.MaxLength = 15;
            this.txt_ap_paterno.Name = "txt_ap_paterno";
            this.txt_ap_paterno.Size = new System.Drawing.Size(200, 20);
            this.txt_ap_paterno.TabIndex = 16;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(209, 105);
            this.txt_nombre.MaxLength = 15;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(200, 20);
            this.txt_nombre.TabIndex = 15;
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.BackColor = System.Drawing.Color.Silver;
            this.lbl_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.ForeColor = System.Drawing.Color.Black;
            this.lbl_cantidad.Location = new System.Drawing.Point(451, 271);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(478, 24);
            this.lbl_cantidad.TabIndex = 14;
            this.lbl_cantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Apellido Paterno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "CRUD AUTOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "País";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Apellido Materno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Número de premios";
            // 
            // txt_ap_materna
            // 
            this.txt_ap_materna.Location = new System.Drawing.Point(210, 177);
            this.txt_ap_materna.MaxLength = 15;
            this.txt_ap_materna.Name = "txt_ap_materna";
            this.txt_ap_materna.Size = new System.Drawing.Size(200, 20);
            this.txt_ap_materna.TabIndex = 26;
            // 
            // txt_codigo
            // 
            this.txt_codigo.AllowDrop = true;
            this.txt_codigo.Location = new System.Drawing.Point(209, 65);
            this.txt_codigo.MaxLength = 5;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(200, 20);
            this.txt_codigo.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Código";
            // 
            // dtp_fecha_nacimiento
            // 
            this.dtp_fecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_nacimiento.Location = new System.Drawing.Point(209, 217);
            this.dtp_fecha_nacimiento.Name = "dtp_fecha_nacimiento";
            this.dtp_fecha_nacimiento.Size = new System.Drawing.Size(201, 20);
            this.dtp_fecha_nacimiento.TabIndex = 32;
            this.dtp_fecha_nacimiento.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // nud_numero_premios
            // 
            this.nud_numero_premios.Location = new System.Drawing.Point(209, 253);
            this.nud_numero_premios.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_numero_premios.Name = "nud_numero_premios";
            this.nud_numero_premios.Size = new System.Drawing.Size(200, 20);
            this.nud_numero_premios.TabIndex = 33;
            // 
            // cbo_pais
            // 
            this.cbo_pais.FormattingEnabled = true;
            this.cbo_pais.Location = new System.Drawing.Point(209, 289);
            this.cbo_pais.Name = "cbo_pais";
            this.cbo_pais.Size = new System.Drawing.Size(200, 21);
            this.cbo_pais.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Elaborado por: SACA MACHACA CESAR";
            // 
            // frm_crud_Autor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 372);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbo_pais);
            this.Controls.Add(this.nud_numero_premios);
            this.Controls.Add(this.dtp_fecha_nacimiento);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_ap_materna);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_grabar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.dgv_autor);
            this.Controls.Add(this.txt_ap_paterno);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_crud_Autor";
            this.Text = "frm_crud_Autor";
            this.Load += new System.EventHandler(this.frm_crud_Autor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_autor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_numero_premios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_grabar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.DataGridView dgv_autor;
        private System.Windows.Forms.TextBox txt_ap_paterno;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ap_materna;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_fecha_nacimiento;
        private System.Windows.Forms.NumericUpDown nud_numero_premios;
        private System.Windows.Forms.ComboBox cbo_pais;
        private System.Windows.Forms.Label label9;
    }
}