namespace SolicitudCliente
{
    partial class GUIPerecederoListar
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
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.LightSeaGreen;
            lblTitulo.Location = new Point(204, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(438, 41);
            lblTitulo.TabIndex = 24;
            lblTitulo.Text = "LISTAR TODOS PERECEDEROS";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // GUIPerecederoListar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(lblTitulo);
            Name = "GUIPerecederoListar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GUIPerecederoListar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
    }
}