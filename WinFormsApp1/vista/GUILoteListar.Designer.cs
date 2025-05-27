namespace SolicitudCliente.vista
{
    partial class GUILoteListar
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
            btnCerrar = new Button();
            lblStatus = new Label();
            table = new DataGridView();
            btnListar = new Button();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.MediumTurquoise;
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(167, 502);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(537, 40);
            btnCerrar.TabIndex = 34;
            btnCerrar.Text = "Volver";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.ForestGreen;
            lblStatus.Location = new Point(403, 408);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(28, 28);
            lblStatus.TabIndex = 33;
            lblStatus.Text = "--";
            // 
            // table
            // 
            table.AllowUserToAddRows = false;
            table.AllowUserToDeleteRows = false;
            table.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            table.BackgroundColor = SystemColors.ButtonHighlight;
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table.Location = new Point(25, 65);
            table.MultiSelect = false;
            table.Name = "table";
            table.ReadOnly = true;
            table.RowHeadersWidth = 51;
            table.ScrollBars = ScrollBars.Vertical;
            table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            table.Size = new Size(833, 340);
            table.TabIndex = 32;
            // 
            // btnListar
            // 
            btnListar.BackColor = Color.LightSalmon;
            btnListar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListar.Location = new Point(167, 441);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(537, 50);
            btnListar.TabIndex = 31;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.LightSeaGreen;
            lblTitulo.Location = new Point(238, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(322, 41);
            lblTitulo.TabIndex = 30;
            lblTitulo.Text = "LISTAR TODOS LOTES";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // GUILoteListar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(btnCerrar);
            Controls.Add(lblStatus);
            Controls.Add(table);
            Controls.Add(btnListar);
            Controls.Add(lblTitulo);
            Name = "GUILoteListar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GUILoteListar";
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private Label lblStatus;
        private DataGridView table;
        private Button btnListar;
        private Label lblTitulo;
    }
}