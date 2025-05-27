namespace SolicitudCliente.vista
{
    partial class GUILoteListarFiltro
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
            lblStatus = new Label();
            btnFiltrar = new Button();
            table = new DataGridView();
            btnCerrar = new Button();
            txtValor = new TextBox();
            lblValor = new Label();
            cmbParametro = new ComboBox();
            lblParametros = new Label();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.ForestGreen;
            lblStatus.Location = new Point(696, 58);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(26, 25);
            lblStatus.TabIndex = 42;
            lblStatus.Text = "--";
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.LightSkyBlue;
            btnFiltrar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltrar.Location = new Point(608, 86);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(262, 47);
            btnFiltrar.TabIndex = 41;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // table
            // 
            table.AllowUserToAddRows = false;
            table.AllowUserToDeleteRows = false;
            table.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            table.BackgroundColor = SystemColors.ButtonHighlight;
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table.Location = new Point(12, 156);
            table.MultiSelect = false;
            table.Name = "table";
            table.ReadOnly = true;
            table.RowHeadersWidth = 51;
            table.ScrollBars = ScrollBars.Vertical;
            table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            table.Size = new Size(858, 340);
            table.TabIndex = 40;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.MediumTurquoise;
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(178, 502);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(537, 40);
            btnCerrar.TabIndex = 39;
            btnCerrar.Text = "Volver";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtValor.Location = new Point(272, 97);
            txtValor.Name = "txtValor";
            txtValor.PlaceholderText = "Ingresa el valor a buscar";
            txtValor.Size = new Size(300, 34);
            txtValor.TabIndex = 38;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValor.Location = new Point(272, 66);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(61, 28);
            lblValor.TabIndex = 37;
            lblValor.Text = "Valor:";
            // 
            // cmbParametro
            // 
            cmbParametro.Cursor = Cursors.IBeam;
            cmbParametro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbParametro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbParametro.FormattingEnabled = true;
            cmbParametro.Items.AddRange(new object[] { "[Ninguno]", "Proveedor", "NumLote", "FechaAbaste" });
            cmbParametro.Location = new Point(28, 97);
            cmbParametro.Name = "cmbParametro";
            cmbParametro.Size = new Size(190, 36);
            cmbParametro.TabIndex = 36;
            // 
            // lblParametros
            // 
            lblParametros.AutoSize = true;
            lblParametros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblParametros.Location = new Point(28, 66);
            lblParametros.Name = "lblParametros";
            lblParametros.Size = new Size(62, 28);
            lblParametros.TabIndex = 35;
            lblParametros.Text = "Filtro:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.LightSeaGreen;
            lblTitulo.Location = new Point(178, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(428, 41);
            lblTitulo.TabIndex = 34;
            lblTitulo.Text = "LISTAR LOTES SEGUN FILTRO";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // GUILoteListarFiltro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(lblStatus);
            Controls.Add(btnFiltrar);
            Controls.Add(table);
            Controls.Add(btnCerrar);
            Controls.Add(txtValor);
            Controls.Add(lblValor);
            Controls.Add(cmbParametro);
            Controls.Add(lblParametros);
            Controls.Add(lblTitulo);
            Name = "GUILoteListarFiltro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GUILoteListarFiltro";
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private Button btnFiltrar;
        private DataGridView table;
        private Button btnCerrar;
        private TextBox txtValor;
        private Label lblValor;
        private ComboBox cmbParametro;
        private Label lblParametros;
        private Label lblTitulo;
    }
}