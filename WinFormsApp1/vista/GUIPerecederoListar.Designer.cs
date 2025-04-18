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
            btnListar = new Button();
            table = new DataGridView();
            lblStatus = new Label();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.LightSeaGreen;
            lblTitulo.Location = new Point(237, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(438, 41);
            lblTitulo.TabIndex = 24;
            lblTitulo.Text = "LISTAR TODOS PERECEDEROS";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnListar
            // 
            btnListar.BackColor = Color.LightSalmon;
            btnListar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListar.Location = new Point(166, 440);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(537, 50);
            btnListar.TabIndex = 26;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = false;
            btnListar.Click += btnListar_Click;
            // 
            // table
            // 
            table.AllowUserToAddRows = false;
            table.AllowUserToDeleteRows = false;
            table.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            table.BackgroundColor = SystemColors.ButtonHighlight;
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table.Location = new Point(24, 64);
            table.MultiSelect = false;
            table.Name = "table";
            table.ReadOnly = true;
            table.RowHeadersWidth = 51;
            table.ScrollBars = ScrollBars.Vertical;
            table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            table.Size = new Size(833, 340);
            table.TabIndex = 27;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.ForestGreen;
            lblStatus.Location = new Point(402, 407);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(28, 28);
            lblStatus.TabIndex = 28;
            lblStatus.Text = "--";
            lblStatus.Click += label1_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.MediumTurquoise;
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(166, 501);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(537, 40);
            btnCerrar.TabIndex = 29;
            btnCerrar.Text = "Volver";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // GUIPerecederoListar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(btnCerrar);
            Controls.Add(lblStatus);
            Controls.Add(table);
            Controls.Add(btnListar);
            Controls.Add(lblTitulo);
            Name = "GUIPerecederoListar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GUIPerecederoListar";
            Load += GUIPerecederoListar_Load_1;
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnListar;
        private DataGridView table;
        private Label lblStatus;
        private Button btnCerrar;
    }
}