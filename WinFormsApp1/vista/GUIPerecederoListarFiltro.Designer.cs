namespace SolicitudCliente.vista
{
    partial class GUIPerecederoListarFiltro
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
            lblParametros = new Label();
            cmbParametro = new ComboBox();
            lblValor = new Label();
            txtValor = new TextBox();
            btnCerrar = new Button();
            table = new DataGridView();
            btnFiltrar = new Button();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.LightSeaGreen;
            lblTitulo.Location = new Point(178, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(544, 41);
            lblTitulo.TabIndex = 25;
            lblTitulo.Text = "LISTAR PERECEDEROS SEGUN FILTRO";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            lblTitulo.Click += lblTitulo_Click;
            // 
            // lblParametros
            // 
            lblParametros.AutoSize = true;
            lblParametros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblParametros.Location = new Point(28, 65);
            lblParametros.Name = "lblParametros";
            lblParametros.Size = new Size(62, 28);
            lblParametros.TabIndex = 26;
            lblParametros.Text = "Filtro:";
            lblParametros.Click += lblParametros_Click;
            // 
            // cmbParametro
            // 
            cmbParametro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbParametro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbParametro.FormattingEnabled = true;
            cmbParametro.Items.AddRange(new object[] { "Nombre", "Código", "Precio", "Cantidad", "Fecha vencimiento" });
            cmbParametro.Location = new Point(28, 96);
            cmbParametro.Name = "cmbParametro";
            cmbParametro.Size = new Size(190, 36);
            cmbParametro.TabIndex = 27;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValor.Location = new Point(272, 65);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(61, 28);
            lblValor.TabIndex = 28;
            lblValor.Text = "Valor:";
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtValor.Location = new Point(272, 96);
            txtValor.Name = "txtValor";
            txtValor.PlaceholderText = "Ingresa el valor a buscar";
            txtValor.Size = new Size(300, 34);
            txtValor.TabIndex = 29;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.MediumTurquoise;
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(178, 501);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(537, 40);
            btnCerrar.TabIndex = 30;
            btnCerrar.Text = "Volver";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // table
            // 
            table.AllowUserToAddRows = false;
            table.AllowUserToDeleteRows = false;
            table.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            table.BackgroundColor = SystemColors.ButtonHighlight;
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table.Location = new Point(12, 155);
            table.MultiSelect = false;
            table.Name = "table";
            table.ReadOnly = true;
            table.RowHeadersWidth = 51;
            table.ScrollBars = ScrollBars.Vertical;
            table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            table.Size = new Size(858, 340);
            table.TabIndex = 31;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.LightSkyBlue;
            btnFiltrar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltrar.Location = new Point(608, 85);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(262, 47);
            btnFiltrar.TabIndex = 32;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // GUIPerecederoListarFiltro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(btnFiltrar);
            Controls.Add(table);
            Controls.Add(btnCerrar);
            Controls.Add(txtValor);
            Controls.Add(lblValor);
            Controls.Add(cmbParametro);
            Controls.Add(lblParametros);
            Controls.Add(lblTitulo);
            Name = "GUIPerecederoListarFiltro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GUIPerecederoListarFiltro";
            Load += GUIPerecederoListarFiltro_Load;
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblParametros;
        private ComboBox cmbParametro;
        private Label lblValor;
        private TextBox txtValor;
        private Button btnCerrar;
        private DataGridView table;
        private Button btnFiltrar;
    }
}