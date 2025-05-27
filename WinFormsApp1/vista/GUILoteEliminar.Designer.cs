namespace SolicitudCliente.vista
{
    partial class GUILoteEliminar
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
            txtValorNum = new TextBox();
            cmbParametro2 = new ComboBox();
            txtValorCod = new TextBox();
            cmbParametro1 = new ComboBox();
            lblEstadoConsulta = new Label();
            panelResultados = new Panel();
            dateAbastecimiento = new DateTimePicker();
            lblAbastecimmiento = new Label();
            txtCodigo = new TextBox();
            lblCodigoPerecedero = new Label();
            txtNum = new TextBox();
            lblNumLote = new Label();
            txtProveedor = new TextBox();
            lbProveedor = new Label();
            btnCerrar = new Button();
            btnConsultar = new Button();
            lblValor = new Label();
            lblParametros = new Label();
            lblTitulo = new Label();
            btnEliminar = new Button();
            panelResultados.SuspendLayout();
            SuspendLayout();
            // 
            // txtValorNum
            // 
            txtValorNum.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtValorNum.Location = new Point(416, 136);
            txtValorNum.Name = "txtValorNum";
            txtValorNum.PlaceholderText = "Ingresa el valor a buscar";
            txtValorNum.Size = new Size(300, 34);
            txtValorNum.TabIndex = 57;
            // 
            // cmbParametro2
            // 
            cmbParametro2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbParametro2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbParametro2.FormattingEnabled = true;
            cmbParametro2.Items.AddRange(new object[] { "Num. Lote" });
            cmbParametro2.Location = new Point(182, 134);
            cmbParametro2.Name = "cmbParametro2";
            cmbParametro2.Size = new Size(190, 36);
            cmbParametro2.TabIndex = 56;
            // 
            // txtValorCod
            // 
            txtValorCod.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtValorCod.Location = new Point(416, 92);
            txtValorCod.Name = "txtValorCod";
            txtValorCod.PlaceholderText = "Ingresa el valor a buscar";
            txtValorCod.Size = new Size(300, 34);
            txtValorCod.TabIndex = 55;
            // 
            // cmbParametro1
            // 
            cmbParametro1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbParametro1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbParametro1.FormattingEnabled = true;
            cmbParametro1.Items.AddRange(new object[] { "Cod. Perecedero" });
            cmbParametro1.Location = new Point(182, 92);
            cmbParametro1.Name = "cmbParametro1";
            cmbParametro1.Size = new Size(190, 36);
            cmbParametro1.TabIndex = 54;
            // 
            // lblEstadoConsulta
            // 
            lblEstadoConsulta.AutoSize = true;
            lblEstadoConsulta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstadoConsulta.ForeColor = Color.IndianRed;
            lblEstadoConsulta.Location = new Point(384, 268);
            lblEstadoConsulta.Name = "lblEstadoConsulta";
            lblEstadoConsulta.Size = new Size(134, 28);
            lblEstadoConsulta.TabIndex = 49;
            lblEstadoConsulta.Text = "Sin resultados";
            lblEstadoConsulta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelResultados
            // 
            panelResultados.BackColor = SystemColors.ControlLight;
            panelResultados.Controls.Add(dateAbastecimiento);
            panelResultados.Controls.Add(lblAbastecimmiento);
            panelResultados.Controls.Add(txtCodigo);
            panelResultados.Controls.Add(lblCodigoPerecedero);
            panelResultados.Controls.Add(txtNum);
            panelResultados.Controls.Add(lblNumLote);
            panelResultados.Controls.Add(txtProveedor);
            panelResultados.Controls.Add(lbProveedor);
            panelResultados.Location = new Point(29, 298);
            panelResultados.Name = "panelResultados";
            panelResultados.Size = new Size(828, 191);
            panelResultados.TabIndex = 53;
            // 
            // dateAbastecimiento
            // 
            dateAbastecimiento.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateAbastecimiento.Format = DateTimePickerFormat.Short;
            dateAbastecimiento.Location = new Point(438, 72);
            dateAbastecimiento.Name = "dateAbastecimiento";
            dateAbastecimiento.Size = new Size(240, 31);
            dateAbastecimiento.TabIndex = 17;
            dateAbastecimiento.Value = new DateTime(2025, 3, 30, 12, 11, 40, 0);
            // 
            // lblAbastecimmiento
            // 
            lblAbastecimmiento.AutoSize = true;
            lblAbastecimmiento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAbastecimmiento.Location = new Point(438, 41);
            lblAbastecimmiento.Name = "lblAbastecimmiento";
            lblAbastecimmiento.Size = new Size(237, 28);
            lblAbastecimmiento.TabIndex = 16;
            lblAbastecimmiento.Text = "Fecha de abastecimiento";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigo.Location = new Point(438, 153);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(240, 31);
            txtCodigo.TabIndex = 14;
            // 
            // lblCodigoPerecedero
            // 
            lblCodigoPerecedero.AutoSize = true;
            lblCodigoPerecedero.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigoPerecedero.Location = new Point(438, 122);
            lblCodigoPerecedero.Name = "lblCodigoPerecedero";
            lblCodigoPerecedero.Size = new Size(186, 28);
            lblCodigoPerecedero.TabIndex = 13;
            lblCodigoPerecedero.Text = "Codigo perecedero";
            // 
            // txtNum
            // 
            txtNum.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNum.Location = new Point(161, 152);
            txtNum.Name = "txtNum";
            txtNum.ReadOnly = true;
            txtNum.Size = new Size(240, 31);
            txtNum.TabIndex = 8;
            // 
            // lblNumLote
            // 
            lblNumLote.AutoSize = true;
            lblNumLote.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumLote.Location = new Point(161, 121);
            lblNumLote.Name = "lblNumLote";
            lblNumLote.Size = new Size(128, 28);
            lblNumLote.TabIndex = 7;
            lblNumLote.Text = "Número lote";
            // 
            // txtProveedor
            // 
            txtProveedor.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProveedor.Location = new Point(161, 72);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(240, 31);
            txtProveedor.TabIndex = 6;
            // 
            // lbProveedor
            // 
            lbProveedor.AutoSize = true;
            lbProveedor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProveedor.Location = new Point(161, 41);
            lbProveedor.Name = "lbProveedor";
            lbProveedor.Size = new Size(106, 28);
            lbProveedor.TabIndex = 5;
            lbProveedor.Text = "Proveedor";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.MediumTurquoise;
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(182, 225);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(537, 40);
            btnCerrar.TabIndex = 52;
            btnCerrar.Text = "Volver";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.LightSalmon;
            btnConsultar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.Location = new Point(182, 179);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(537, 40);
            btnConsultar.TabIndex = 51;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValor.Location = new Point(419, 61);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(61, 28);
            lblValor.TabIndex = 50;
            lblValor.Text = "Valor:";
            // 
            // lblParametros
            // 
            lblParametros.AutoSize = true;
            lblParametros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblParametros.Location = new Point(182, 61);
            lblParametros.Name = "lblParametros";
            lblParametros.Size = new Size(106, 28);
            lblParametros.TabIndex = 48;
            lblParametros.Text = "Parámetro:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.LightSeaGreen;
            lblTitulo.Location = new Point(295, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(334, 41);
            lblTitulo.TabIndex = 47;
            lblTitulo.Text = "ACTUALIZAR UN LOTE";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.LightCoral;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminar.Location = new Point(182, 495);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(537, 50);
            btnEliminar.TabIndex = 58;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // GUILoteEliminar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(btnEliminar);
            Controls.Add(txtValorNum);
            Controls.Add(cmbParametro2);
            Controls.Add(txtValorCod);
            Controls.Add(cmbParametro1);
            Controls.Add(lblEstadoConsulta);
            Controls.Add(panelResultados);
            Controls.Add(btnCerrar);
            Controls.Add(btnConsultar);
            Controls.Add(lblValor);
            Controls.Add(lblParametros);
            Controls.Add(lblTitulo);
            Name = "GUILoteEliminar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GUILoteEliminarcs";
            panelResultados.ResumeLayout(false);
            panelResultados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValorNum;
        private ComboBox cmbParametro2;
        private TextBox txtValorCod;
        private ComboBox cmbParametro1;
        private Label lblEstadoConsulta;
        private Panel panelResultados;
        private DateTimePicker dateAbastecimiento;
        private Label lblAbastecimmiento;
        private TextBox txtCodigo;
        private Label lblCodigoPerecedero;
        private TextBox txtNum;
        private Label lblNumLote;
        private TextBox txtProveedor;
        private Label lbProveedor;
        private Button btnCerrar;
        private Button btnConsultar;
        private Label lblValor;
        private Label lblParametros;
        private Label lblTitulo;
        private Button btnEliminar;
    }
}