namespace SolicitudCliente
{
    partial class GUIPerecederoAgregar
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
            btnCrear = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.LightSeaGreen;
            lblTitulo.Location = new Point(211, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(465, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "AGREGAR NUEVO PERECEDERO";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(114, 89);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(87, 28);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(114, 120);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(240, 31);
            txtNombre.TabIndex = 2;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(114, 169);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(77, 28);
            lblCodigo.TabIndex = 3;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigo.Location = new Point(114, 200);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(240, 31);
            txtCodigo.TabIndex = 4;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(114, 257);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(68, 28);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(114, 288);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(240, 31);
            txtPrecio.TabIndex = 6;
            // 
            // lblCaducidad
            // 
            lblCaducidad.AutoSize = true;
            lblCaducidad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCaducidad.Location = new Point(114, 419);
            lblCaducidad.Name = "lblCaducidad";
            lblCaducidad.Size = new Size(211, 28);
            lblCaducidad.TabIndex = 7;
            lblCaducidad.Text = "Fecha de vencimiento";
            // 
            // dateVencimiento
            // 
            dateVencimiento.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateVencimiento.Format = DateTimePickerFormat.Short;
            dateVencimiento.Location = new Point(114, 450);
            dateVencimiento.Name = "dateVencimiento";
            dateVencimiento.Size = new Size(240, 31);
            dateVencimiento.TabIndex = 8;
            dateVencimiento.Value = new DateTime(2025, 3, 30, 12, 11, 40, 0);
            dateVencimiento.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(114, 338);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(92, 28);
            lblCantidad.TabIndex = 9;
            lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCantidad.Location = new Point(114, 369);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(240, 31);
            txtCantidad.TabIndex = 10;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.LightSalmon;
            btnCrear.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrear.Location = new Point(518, 238);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(240, 60);
            btnCrear.TabIndex = 11;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Teal;
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(518, 346);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(240, 40);
            btnCerrar.TabIndex = 12;
            btnCerrar.Text = "Volver";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // PerecederoAgregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(btnCerrar);
            Controls.Add(btnCrear);
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
        private Button btnCrear;
        private Button btnCerrar;
    }
}