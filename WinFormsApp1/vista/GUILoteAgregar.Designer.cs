namespace SolicitudCliente.vista
{
    partial class GUILoteAgregar
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
            btnCrear = new Button();
            txtCantidad = new TextBox();
            lblCantidad = new Label();
            dateVencimiento = new DateTimePicker();
            lblCaducidad = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.MediumTurquoise;
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(526, 339);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(240, 40);
            btnCerrar.TabIndex = 25;
            btnCerrar.Text = "Volver";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.LightSalmon;
            btnCrear.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrear.Location = new Point(526, 231);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(240, 60);
            btnCrear.TabIndex = 24;
            btnCrear.Text = "Agregar";
            btnCrear.UseVisualStyleBackColor = false;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCantidad.Location = new Point(119, 440);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(240, 31);
            txtCantidad.TabIndex = 23;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad.ForeColor = Color.SteelBlue;
            lblCantidad.Location = new Point(119, 409);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(220, 28);
            lblCantidad.TabIndex = 22;
            lblCantidad.Text = "Código del perecedero";
            // 
            // dateVencimiento
            // 
            dateVencimiento.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateVencimiento.Format = DateTimePickerFormat.Short;
            dateVencimiento.Location = new Point(119, 324);
            dateVencimiento.Name = "dateVencimiento";
            dateVencimiento.Size = new Size(240, 31);
            dateVencimiento.TabIndex = 21;
            dateVencimiento.Value = new DateTime(2025, 3, 30, 12, 11, 40, 0);
            // 
            // lblCaducidad
            // 
            lblCaducidad.AutoSize = true;
            lblCaducidad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCaducidad.Location = new Point(119, 293);
            lblCaducidad.Name = "lblCaducidad";
            lblCaducidad.Size = new Size(237, 28);
            lblCaducidad.TabIndex = 20;
            lblCaducidad.Text = "Fecha de abastecimiento";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigo.Location = new Point(119, 231);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(240, 31);
            txtCodigo.TabIndex = 17;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(119, 200);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(128, 28);
            lblCodigo.TabIndex = 16;
            lblCodigo.Text = "Número lote";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(119, 151);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(240, 31);
            txtNombre.TabIndex = 15;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(119, 120);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(106, 28);
            lblNombre.TabIndex = 14;
            lblNombre.Text = "Proveedor";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.LightSeaGreen;
            lblTitulo.Location = new Point(262, 38);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(340, 41);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "ASOCIAR NUEVO LOTE";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // GUILoteAgregar
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
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "GUILoteAgregar";
            Text = "GUILoteAgregar";
            Load += GUILoteAgregar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private Button btnCrear;
        private TextBox txtCantidad;
        private Label lblCantidad;
        private DateTimePicker dateVencimiento;
        private Label lblCaducidad;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblTitulo;
    }
}