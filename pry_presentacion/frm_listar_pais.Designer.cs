namespace pry_presentacion
{
    partial class frm_listar_pais
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
            this.dgv_pais = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pais)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pais
            // 
            this.dgv_pais.AllowUserToAddRows = false;
            this.dgv_pais.AllowUserToDeleteRows = false;
            this.dgv_pais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_pais.Location = new System.Drawing.Point(0, 0);
            this.dgv_pais.Name = "dgv_pais";
            this.dgv_pais.ReadOnly = true;
            this.dgv_pais.Size = new System.Drawing.Size(406, 172);
            this.dgv_pais.TabIndex = 0;
            // 
            // frm_listar_pais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 172);
            this.Controls.Add(this.dgv_pais);
            this.Name = "frm_listar_pais";
            this.Text = "Listar Países";
            this.Load += new System.EventHandler(this.frm_listar_pais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pais;
    }
}