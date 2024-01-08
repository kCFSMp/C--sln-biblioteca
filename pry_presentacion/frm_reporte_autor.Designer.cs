namespace pry_presentacion
{
    partial class frm_reporte_autor
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
            this.crv_autor = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_autor
            // 
            this.crv_autor.ActiveViewIndex = -1;
            this.crv_autor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_autor.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_autor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_autor.Location = new System.Drawing.Point(0, 0);
            this.crv_autor.Name = "crv_autor";
            this.crv_autor.Size = new System.Drawing.Size(734, 450);
            this.crv_autor.TabIndex = 0;
            this.crv_autor.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_reporte_autor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.crv_autor);
            this.Name = "frm_reporte_autor";
            this.Text = "frm_reporte_autor";
            this.Load += new System.EventHandler(this.frm_reporte_autor1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_autor;
    }
}