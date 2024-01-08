namespace pry_presentacion
{
    partial class frm_principal
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
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_reporte_autor = new System.Windows.Forms.Button();
            this.btn_autor = new System.Windows.Forms.Button();
            this.btn_pais = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(18, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mantenimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(18, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reporte";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Red;
            this.btn_cerrar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.Location = new System.Drawing.Point(438, 351);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 33);
            this.btn_cerrar.TabIndex = 7;
            this.btn_cerrar.Text = "CERRAR";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "SISTEMA DE BIBLIOTECA";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::pry_presentacion.Properties.Resources.senati_logo;
            this.pictureBox2.Location = new System.Drawing.Point(16, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btn_reporte_autor
            // 
            this.btn_reporte_autor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_reporte_autor.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reporte_autor.Image = global::pry_presentacion.Properties.Resources.autorPais_G;
            this.btn_reporte_autor.Location = new System.Drawing.Point(174, 273);
            this.btn_reporte_autor.Name = "btn_reporte_autor";
            this.btn_reporte_autor.Size = new System.Drawing.Size(173, 59);
            this.btn_reporte_autor.TabIndex = 4;
            this.btn_reporte_autor.Text = "Autores por País";
            this.btn_reporte_autor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reporte_autor.UseVisualStyleBackColor = false;
            this.btn_reporte_autor.Click += new System.EventHandler(this.btn_reporte_autor_Click);
            // 
            // btn_autor
            // 
            this.btn_autor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_autor.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_autor.Image = global::pry_presentacion.Properties.Resources.autor;
            this.btn_autor.Location = new System.Drawing.Point(365, 131);
            this.btn_autor.Name = "btn_autor";
            this.btn_autor.Size = new System.Drawing.Size(111, 69);
            this.btn_autor.TabIndex = 3;
            this.btn_autor.Text = "AUTOR";
            this.btn_autor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_autor.UseVisualStyleBackColor = false;
            this.btn_autor.Click += new System.EventHandler(this.btn_autor_Click);
            // 
            // btn_pais
            // 
            this.btn_pais.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_pais.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pais.Image = global::pry_presentacion.Properties.Resources.environment_120736;
            this.btn_pais.Location = new System.Drawing.Point(50, 129);
            this.btn_pais.Name = "btn_pais";
            this.btn_pais.Size = new System.Drawing.Size(107, 71);
            this.btn_pais.TabIndex = 2;
            this.btn_pais.Text = "PAÍS";
            this.btn_pais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_pais.UseVisualStyleBackColor = false;
            this.btn_pais.Click += new System.EventHandler(this.btn_pais_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Elaborado por: SACA MACHACA CESAR";
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 387);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_reporte_autor);
            this.Controls.Add(this.btn_autor);
            this.Controls.Add(this.btn_pais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_pais;
        private System.Windows.Forms.Button btn_autor;
        private System.Windows.Forms.Button btn_reporte_autor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
    }
}