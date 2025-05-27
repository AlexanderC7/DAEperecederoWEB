namespace SolicitudCliente.vista
{
    partial class GUILoteBuscar
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
            panelResultados = new Panel();
            dateAbastecimiento = new DateTimePicker();
            lblAbastecimiento = new Label();
            txtCodigo = new TextBox();
            lblCode = new Label();
            txtNum = new TextBox();
            lblNum = new Label();
            txtProveedor = new TextBox();
            lblProveedor = new Label();
            lblEstadoConsulta = new Label();
            btnCerrar = new Button();
            btnConsultar = new Button();
            lblValor = new Label();
            txtValorCod = new TextBox();
            lblParametros = new Label();
            cmbParametro1 = new ComboBox();
            lblTitulo = new Label();
            cmbParametro2 = new ComboBox();
            txtValorNum = new TextBox();
            panelResultados.SuspendLayout();
            SuspendLayout();
            // 
            // panelResultados
            // 
            panelResultados.BackColor = SystemColors.ControlLight;
            panelResultados.Controls.Add(dateAbastecimiento);
            panelResultados.Controls.Add(lblAbastecimiento);
            panelResultados.Controls.Add(txtCodigo);
            panelResultados.Controls.Add(lblCode);
            panelResultados.Controls.Add(txtNum);
            panelResultados.Controls.Add(lblNum);
            panelResultados.Controls.Add(txtProveedor);
            panelResultados.Controls.Add(lblProveedor);
            panelResultados.Location = new Point(27, 344);
            panelResultados.Name = "panelResultados";
            panelResultados.Size = new Size(828, 198);
            panelResultados.TabIndex = 24;
            // 
            // dateAbastecimiento
            // 
            dateAbastecimiento.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateAbastecimiento.Format = DateTimePickerFormat.Short;
            dateAbastecimiento.Location = new Point(421, 66);
            dateAbastecimiento.Name = "dateAbastecimiento";
            dateAbastecimiento.Size = new Size(240, 31);
            dateAbastecimiento.TabIndex = 17;
            dateAbastecimiento.Value = new DateTime(2025, 3, 30, 12, 11, 40, 0);
            // 
            // lblAbastecimiento
            // 
            lblAbastecimiento.AutoSize = true;
            lblAbastecimiento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAbastecimiento.Location = new Point(421, 35);
            lblAbastecimiento.Name = "lblAbastecimiento";
            lblAbastecimiento.Size = new Size(237, 28);
            lblAbastecimiento.TabIndex = 16;
            lblAbastecimiento.Text = "Fecha de abastecimiento";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigo.Location = new Point(421, 149);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(240, 31);
            txtCodigo.TabIndex = 14;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCode.Location = new Point(421, 118);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(186, 28);
            lblCode.TabIndex = 13;
            lblCode.Text = "Codigo perecedero";
            // 
            // txtNum
            // 
            txtNum.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNum.Location = new Point(144, 148);
            txtNum.Name = "txtNum";
            txtNum.ReadOnly = true;
            txtNum.Size = new Size(240, 31);
            txtNum.TabIndex = 8;
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNum.Location = new Point(144, 117);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(128, 28);
            lblNum.TabIndex = 7;
            lblNum.Text = "Número lote";
            // 
            // txtProveedor
            // 
            txtProveedor.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProveedor.Location = new Point(144, 68);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.ReadOnly = true;
            txtProveedor.Size = new Size(240, 31);
            txtProveedor.TabIndex = 6;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProveedor.Location = new Point(144, 37);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(106, 28);
            lblProveedor.TabIndex = 5;
            lblProveedor.Text = "Proveedor";
            // 
            // lblEstadoConsulta
            // 
            lblEstadoConsulta.AutoSize = true;
            lblEstadoConsulta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstadoConsulta.ForeColor = Color.IndianRed;
            lblEstadoConsulta.Location = new Point(365, 310);
            lblEstadoConsulta.Name = "lblEstadoConsulta";
            lblEstadoConsulta.Size = new Size(134, 28);
            lblEstadoConsulta.TabIndex = 23;
            lblEstadoConsulta.Text = "Sin resultados";
            lblEstadoConsulta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.MediumTurquoise;
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(168, 264);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(537, 40);
            btnCerrar.TabIndex = 22;
            btnCerrar.Text = "Volver";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.LightSalmon;
            btnConsultar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.Location = new Point(168, 208);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(537, 50);
            btnConsultar.TabIndex = 21;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValor.Location = new Point(405, 64);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(61, 28);
            lblValor.TabIndex = 20;
            lblValor.Text = "Valor:";
            // 
            // txtValorCod
            // 
            txtValorCod.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtValorCod.Location = new Point(405, 99);
            txtValorCod.Name = "txtValorCod";
            txtValorCod.PlaceholderText = "Ingresa el valor a buscar";
            txtValorCod.Size = new Size(300, 34);
            txtValorCod.TabIndex = 19;
            // 
            // lblParametros
            // 
            lblParametros.AutoSize = true;
            lblParametros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblParametros.Location = new Point(168, 64);
            lblParametros.Name = "lblParametros";
            lblParametros.Size = new Size(106, 28);
            lblParametros.TabIndex = 18;
            lblParametros.Text = "Parámetro:";
            // 
            // cmbParametro1
            // 
            cmbParametro1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbParametro1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbParametro1.FormattingEnabled = true;
            cmbParametro1.Items.AddRange(new object[] { "Cod. Perecedero" });
            cmbParametro1.Location = new Point(171, 99);
            cmbParametro1.Name = "cmbParametro1";
            cmbParametro1.Size = new Size(190, 36);
            cmbParametro1.TabIndex = 17;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.LightSeaGreen;
            lblTitulo.Location = new Point(272, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(304, 41);
            lblTitulo.TabIndex = 16;
            lblTitulo.Text = "BÚSQUEDA DE LOTE";
            // 
            // cmbParametro2
            // 
            cmbParametro2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbParametro2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbParametro2.FormattingEnabled = true;
            cmbParametro2.Items.AddRange(new object[] { "Num. Lote" });
            cmbParametro2.Location = new Point(171, 141);
            cmbParametro2.Name = "cmbParametro2";
            cmbParametro2.Size = new Size(190, 36);
            cmbParametro2.TabIndex = 25;
            // 
            // txtValorNum
            // 
            txtValorNum.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtValorNum.Location = new Point(405, 143);
            txtValorNum.Name = "txtValorNum";
            txtValorNum.PlaceholderText = "Ingresa el valor a buscar";
            txtValorNum.Size = new Size(300, 34);
            txtValorNum.TabIndex = 26;
            // 
            // GUILoteBuscar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(txtValorNum);
            Controls.Add(cmbParametro2);
            Controls.Add(panelResultados);
            Controls.Add(lblEstadoConsulta);
            Controls.Add(btnCerrar);
            Controls.Add(btnConsultar);
            Controls.Add(lblValor);
            Controls.Add(txtValorCod);
            Controls.Add(lblParametros);
            Controls.Add(cmbParametro1);
            Controls.Add(lblTitulo);
            Name = "GUILoteBuscar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GUILoteBuscar";
            panelResultados.ResumeLayout(false);
            panelResultados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelResultados;
        private DateTimePicker dateAbastecimiento;
        private Label lblAbastecimiento;
        private TextBox txtCodigo;
        private Label lblCode;
        private TextBox txtNum;
        private Label lblNum;
        private TextBox txtProveedor;
        private Label lblProveedor;
        private Label lblEstadoConsulta;
        private Button btnCerrar;
        private Button btnConsultar;
        private Label lblValor;
        private TextBox txtValorCod;
        private Label lblParametros;
        private ComboBox cmbParametro1;
        private Label lblTitulo;
        private ComboBox cmbParametro2;
        private TextBox txtValorNum;
    }
}