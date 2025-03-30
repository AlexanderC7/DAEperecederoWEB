namespace SolicitudCliente
{
    partial class PerecederoAgregar
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            lblCaducidad = new Label();
            dateVencimiento = new DateTimePicker();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.LightSeaGreen;
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(465, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "AGREGAR NUEVO PERECEDERO";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(49, 74);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(49, 97);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(240, 27);
            txtNombre.TabIndex = 2;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(49, 154);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 20);
            lblCodigo.TabIndex = 3;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(49, 177);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(240, 27);
            txtCodigo.TabIndex = 4;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(49, 242);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(49, 265);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(240, 27);
            txtPrecio.TabIndex = 6;
            // 
            // lblCaducidad
            // 
            lblCaducidad.AutoSize = true;
            lblCaducidad.Location = new Point(49, 326);
            lblCaducidad.Name = "lblCaducidad";
            lblCaducidad.Size = new Size(153, 20);
            lblCaducidad.TabIndex = 7;
            lblCaducidad.Text = "Fecha de vencimiento";
            // 
            // dateVencimiento
            // 
            dateVencimiento.Format = DateTimePickerFormat.Short;
            dateVencimiento.Location = new Point(49, 349);
            dateVencimiento.Name = "dateVencimiento";
            dateVencimiento.Size = new Size(240, 27);
            dateVencimiento.TabIndex = 8;
            dateVencimiento.Value = new DateTime(2025, 3, 30, 12, 11, 40, 0);
            dateVencimiento.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(49, 411);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(69, 20);
            lblCantidad.TabIndex = 9;
            lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(49, 434);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(240, 27);
            txtCantidad.TabIndex = 10;
            // 
            // PerecederoAgregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(dateVencimiento);
            Controls.Add(lblCaducidad);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "PerecederoAgregar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PerecederoAgregar";
            Load += PerecederoAgregar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Label lblCaducidad;
        private DateTimePicker dateVencimiento;
        private Label lblCantidad;
        private TextBox txtCantidad;
    }
}