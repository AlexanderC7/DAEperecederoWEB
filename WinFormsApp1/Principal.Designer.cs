namespace WinFormsApp1
{
    partial class Empleados
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGet = new Button();
            btnSet = new Button();
            txtValue = new TextBox();
            menuStrip1 = new MenuStrip();
            menuArchivo = new ToolStripMenuItem();
            menuItemSalir = new ToolStripMenuItem();
            menuAcciones = new ToolStripMenuItem();
            menuItemAdicionar = new ToolStripMenuItem();
            menuItemBuscar = new ToolStripMenuItem();
            menuItemEliminar = new ToolStripMenuItem();
            menuItemActualizar = new ToolStripMenuItem();
            menuItemListar = new ToolStripMenuItem();
            menuItemListarFiltro = new ToolStripMenuItem();
            menuAyuda = new ToolStripMenuItem();
            menuItemAcercade = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGet
            // 
            btnGet.Location = new Point(508, 147);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(94, 29);
            btnGet.TabIndex = 0;
            btnGet.Text = "Get";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // btnSet
            // 
            btnSet.Location = new Point(508, 197);
            btnSet.Name = "btnSet";
            btnSet.Size = new Size(94, 29);
            btnSet.TabIndex = 1;
            btnSet.Text = "Post";
            btnSet.UseVisualStyleBackColor = true;
            btnSet.Click += btnSet_Click;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(228, 149);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(165, 27);
            txtValue.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuArchivo, menuAcciones, menuAyuda });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuArchivo
            // 
            menuArchivo.DropDownItems.AddRange(new ToolStripItem[] { menuItemSalir });
            menuArchivo.Name = "menuArchivo";
            menuArchivo.Size = new Size(73, 24);
            menuArchivo.Text = "Archivo";
            menuArchivo.Click += menuArchivo_Click;
            // 
            // menuItemSalir
            // 
            menuItemSalir.Image = SolicitudCliente.Properties.Resources.icon_salir;
            menuItemSalir.Name = "menuItemSalir";
            menuItemSalir.Size = new Size(224, 26);
            menuItemSalir.Text = "Salir";
            // 
            // menuAcciones
            // 
            menuAcciones.DropDownItems.AddRange(new ToolStripItem[] { menuItemAdicionar, menuItemBuscar, menuItemEliminar, menuItemActualizar, menuItemListar, menuItemListarFiltro });
            menuAcciones.Name = "menuAcciones";
            menuAcciones.Size = new Size(82, 24);
            menuAcciones.Text = "Acciones";
            menuAcciones.Click += toolStripMenuItem1_Click;
            // 
            // menuItemAdicionar
            // 
            menuItemAdicionar.Image = SolicitudCliente.Properties.Resources.icon_agregar;
            menuItemAdicionar.Name = "menuItemAdicionar";
            menuItemAdicionar.Size = new Size(229, 26);
            menuItemAdicionar.Text = "Adicionar";
            menuItemAdicionar.Click += toolStripMenuItem2_Click;
            // 
            // menuItemBuscar
            // 
            menuItemBuscar.Image = SolicitudCliente.Properties.Resources.icon_buscar;
            menuItemBuscar.Name = "menuItemBuscar";
            menuItemBuscar.Size = new Size(229, 26);
            menuItemBuscar.Text = "Buscar según criterio";
            menuItemBuscar.Click += toolStripMenuItem3_Click;
            // 
            // menuItemEliminar
            // 
            menuItemEliminar.Image = SolicitudCliente.Properties.Resources.icon_eliminar;
            menuItemEliminar.Name = "menuItemEliminar";
            menuItemEliminar.Size = new Size(229, 26);
            menuItemEliminar.Text = "Eliminar";
            // 
            // menuItemActualizar
            // 
            menuItemActualizar.Image = SolicitudCliente.Properties.Resources.icon_actualizar_32;
            menuItemActualizar.Name = "menuItemActualizar";
            menuItemActualizar.Size = new Size(229, 26);
            menuItemActualizar.Text = "Actualizar";
            // 
            // menuItemListar
            // 
            menuItemListar.Image = SolicitudCliente.Properties.Resources.icon_listar;
            menuItemListar.Name = "menuItemListar";
            menuItemListar.Size = new Size(229, 26);
            menuItemListar.Text = "Listar";
            // 
            // menuItemListarFiltro
            // 
            menuItemListarFiltro.Image = SolicitudCliente.Properties.Resources.icon_calcular;
            menuItemListarFiltro.Name = "menuItemListarFiltro";
            menuItemListarFiltro.Size = new Size(229, 26);
            menuItemListarFiltro.Text = "Listar según filtro";
            // 
            // menuAyuda
            // 
            menuAyuda.DropDownItems.AddRange(new ToolStripItem[] { menuItemAcercade });
            menuAyuda.Name = "menuAyuda";
            menuAyuda.Size = new Size(65, 24);
            menuAyuda.Text = "Ayuda";
            menuAyuda.Click += menuAyuda_Click;
            // 
            // menuItemAcercade
            // 
            menuItemAcercade.Image = SolicitudCliente.Properties.Resources.icon_info;
            menuItemAcercade.Name = "menuItemAcercade";
            menuItemAcercade.Size = new Size(224, 26);
            menuItemAcercade.Text = "Acerca de";
            menuItemAcercade.Click += acercaDeToolStripMenuItem_Click;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(txtValue);
            Controls.Add(btnSet);
            Controls.Add(btnGet);
            MainMenuStrip = menuStrip1;
            Name = "Empleados";
            Text = "Principal Perecedero";
            Load += Empleados_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGet;
        private Button btnSet;
        private TextBox txtValue;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuAcciones;
        private ToolStripMenuItem menuItemAdicionar;
        private ToolStripMenuItem menuItemBuscar;
        private ToolStripMenuItem menuArchivo;
        private ToolStripMenuItem menuItemSalir;
        private ToolStripMenuItem menuItemEliminar;
        private ToolStripMenuItem menuItemActualizar;
        private ToolStripMenuItem menuItemListar;
        private ToolStripMenuItem menuItemListarFiltro;
        private ToolStripMenuItem menuAyuda;
        private ToolStripMenuItem menuItemAcercade;
    }
}
