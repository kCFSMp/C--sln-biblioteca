namespace pry_presentacion
{
    partial class frm_crud_pais
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.dgv_pais = new System.Windows.Forms.DataGridView();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_grabar = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pais)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRUD PAÍS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "País";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl_cantidad.Location = new System.Drawing.Point(254, 201);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(269, 22);
            this.lbl_cantidad.TabIndex = 3;
            this.lbl_cantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(64, 79);
            this.txt_codigo.MaxLength = 5;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(127, 20);
            this.txt_codigo.TabIndex = 4;
            // 
            // txt_pais
            // 
            this.txt_pais.Location = new System.Drawing.Point(64, 125);
            this.txt_pais.MaxLength = 40;
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.Size = new System.Drawing.Size(127, 20);
            this.txt_pais.TabIndex = 5;
            // 
            // dgv_pais
            // 
            this.dgv_pais.AllowUserToAddRows = false;
            this.dgv_pais.AllowUserToDeleteRows = false;
            this.dgv_pais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pais.Location = new System.Drawing.Point(227, 33);
            this.dgv_pais.Name = "dgv_pais";
            this.dgv_pais.ReadOnly = true;
            this.dgv_pais.Size = new System.Drawing.Size(316, 165);
            this.dgv_pais.TabIndex = 6;
            this.dgv_pais.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pais_CellClick);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(10, 236);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(91, 23);
            this.btn_nuevo.TabIndex = 7;
            this.btn_nuevo.Text = "NUEVO";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_grabar
            // 
            this.btn_grabar.Location = new System.Drawing.Point(117, 236);
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(91, 23);
            this.btn_grabar.TabIndex = 8;
            this.btn_grabar.Text = "GRABAR";
            this.btn_grabar.UseVisualStyleBackColor = true;
            this.btn_grabar.Click += new System.EventHandler(this.btn_grabar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(227, 236);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(90, 23);
            this.btn_borrar.TabIndex = 9;
            this.btn_borrar.Text = "BORRAR";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(455, 236);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(90, 23);
            this.btn_cerrar.TabIndex = 10;
            this.btn_cerrar.Text = "CERRAR";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(141, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Elaborado por: SACA MACHACA CESAR";
            // 
            // frm_crud_pais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 271);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_grabar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.dgv_pais);
            this.Controls.Add(this.txt_pais);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_crud_pais";
            this.Text = "Crud País";
            this.Load += new System.EventHandler(this.frm_crud_pais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_pais;
        private System.Windows.Forms.DataGridView dgv_pais;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_grabar;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label label9;
    }
}