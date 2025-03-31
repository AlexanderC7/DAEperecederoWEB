namespace SolicitudCliente
{
    partial class GUIPerecederoBuscar
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
            cmbParametro = new ComboBox();
            lblParametros = new Label();
            txtValor = new TextBox();
            lblValor = new Label();
            btnConsultar = new Button();
            btnCerrar = new Button();
            lblEstadoConsulta = new Label();
            panelResultados = new Panel();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtCantidad = new TextBox();
            lblCantidad = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            dateVencimiento = new DateTimePicker();
            lblCaducidad = new Label();
            panelResultados.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.LightSeaGreen;
            lblTitulo.Location = new Point(227, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(420, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "BÚSQUEDA DE PERECEDERO";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // cmbParametro
            // 
            cmbParametro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbParametro.FormattingEnabled = true;
            cmbParametro.Items.AddRange(new object[] { "Nombre", "Código", "Precio", "Cantidad", "Fecha vencimiento" });
            cmbParametro.Location = new Point(164, 109);
            cmbParametro.Name = "cmbParametro";
            cmbParametro.Size = new Size(180, 36);
            cmbParametro.TabIndex = 2;
            // 
            // lblParametros
            // 
            lblParametros.AutoSize = true;
            lblParametros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblParametros.Location = new Point(164, 76);
            lblParametros.Name = "lblParametros";
            lblParametros.Size = new Size(106, 28);
            lblParametros.TabIndex = 3;
            lblParametros.Text = "Parámetro:";
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtValor.Location = new Point(401, 111);
            txtValor.Name = "txtValor";
            txtValor.PlaceholderText = "Ingresa el valor a buscar";
            txtValor.Size = new Size(300, 34);
            txtValor.TabIndex = 4;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValor.Location = new Point(401, 76);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(61, 28);
            lblValor.TabIndex = 5;
            lblValor.Text = "Valor:";
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.LightSalmon;
            btnConsultar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.Location = new Point(164, 161);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(537, 50);
            btnConsultar.TabIndex = 6;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.MediumTurquoise;
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(164, 217);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(537, 40);
            btnCerrar.TabIndex = 13;
            btnCerrar.Text = "Volver";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblEstadoConsulta
            // 
            lblEstadoConsulta.AutoSize = true;
            lblEstadoConsulta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstadoConsulta.ForeColor = Color.IndianRed;
            lblEstadoConsulta.Location = new Point(361, 277);
            lblEstadoConsulta.Name = "lblEstadoConsulta";
            lblEstadoConsulta.Size = new Size(134, 28);
            lblEstadoConsulta.TabIndex = 14;
            lblEstadoConsulta.Text = "Sin resultados";
            lblEstadoConsulta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelResultados
            // 
            panelResultados.BackColor = SystemColors.ControlLight;
            panelResultados.Controls.Add(dateVencimiento);
            panelResultados.Controls.Add(lblCaducidad);
            panelResultados.Controls.Add(txtCantidad);
            panelResultados.Controls.Add(lblCantidad);
            panelResultados.Controls.Add(txtPrecio);
            panelResultados.Controls.Add(lblPrecio);
            panelResultados.Controls.Add(txtCodigo);
            panelResultados.Controls.Add(lblCodigo);
            panelResultados.Controls.Add(txtNombre);
            panelResultados.Controls.Add(lblNombre);
            panelResultados.Location = new Point(23, 318);
            panelResultados.Name = "panelResultados";
            panelResultados.Size = new Size(828, 223);
            panelResultados.TabIndex = 15;
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigo.Location = new Point(32, 153);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(240, 31);
            txtCodigo.TabIndex = 8;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(32, 122);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(77, 28);
            lblCodigo.TabIndex = 7;
            lblCodigo.Text = "Código";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(32, 73);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(240, 31);
            txtNombre.TabIndex = 6;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(32, 42);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(87, 28);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCantidad.Location = new Point(309, 154);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(240, 31);
            txtCantidad.TabIndex = 14;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(309, 123);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(92, 28);
            lblCantidad.TabIndex = 13;
            lblCantidad.Text = "Cantidad";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(309, 73);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(240, 31);
            txtPrecio.TabIndex = 12;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(309, 42);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(68, 28);
            lblPrecio.TabIndex = 11;
            lblPrecio.Text = "Precio";
            // 
            // dateVencimiento
            // 
            dateVencimiento.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateVencimiento.Format = DateTimePickerFormat.Short;
            dateVencimiento.Location = new Point(573, 73);
            dateVencimiento.Name = "dateVencimiento";
            dateVencimiento.Size = new Size(240, 31);
            dateVencimiento.TabIndex = 17;
            dateVencimiento.Value = new DateTime(2025, 3, 30, 12, 11, 40, 0);
            // 
            // lblCaducidad
            // 
            lblCaducidad.AutoSize = true;
            lblCaducidad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCaducidad.Location = new Point(573, 42);
            lblCaducidad.Name = "lblCaducidad";
            lblCaducidad.Size = new Size(211, 28);
            lblCaducidad.TabIndex = 16;
            lblCaducidad.Text = "Fecha de vencimiento";
            // 
            // GUIPerecederoBuscar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(panelResultados);
            Controls.Add(lblEstadoConsulta);
            Controls.Add(btnCerrar);
            Controls.Add(btnConsultar);
            Controls.Add(lblValor);
            Controls.Add(txtValor);
            Controls.Add(lblParametros);
            Controls.Add(cmbParametro);
            Controls.Add(lblTitulo);
            Name = "GUIPerecederoBuscar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GUIPerecederoBuscar";
            Load += GUIPerecederoBuscar_Load;
            panelResultados.ResumeLayout(false);
            panelResultados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private ComboBox cmbParametro;
        private Label lblParametros;
        private TextBox txtValor;
        private Label lblValor;
        private Button btnConsultar;
        private Button btnCerrar;
        private Label lblEstadoConsulta;
        private Panel panelResultados;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtCantidad;
        private Label lblCantidad;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private DateTimePicker dateVencimiento;
        private Label lblCaducidad;
    }
}