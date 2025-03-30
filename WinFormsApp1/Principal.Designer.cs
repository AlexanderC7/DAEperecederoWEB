namespace WinFormsApp1
{
    partial class Perecedero
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
            menuPrincipal = new MenuStrip();
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
            menuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // btnGet
            // 
            btnGet.Location = new Point(508, 147);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(94, 30);
            btnGet.TabIndex = 0;
            btnGet.Text = "Get";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // btnSet
            // 
            btnSet.Location = new Point(508, 197);
            btnSet.Name = "btnSet";
            btnSet.Size = new Size(94, 30);
            btnSet.TabIndex = 1;
            btnSet.Text = "Post";
            btnSet.UseVisualStyleBackColor = true;
            btnSet.Click += btnSet_Click;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(228, 150);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(165, 27);
            txtValue.TabIndex = 2;
            // 
            // menuPrincipal
            // 
            menuPrincipal.BackColor = SystemColors.ControlLight;
            menuPrincipal.Font = new Font("Segoe UI", 12F);
            menuPrincipal.ImageScalingSize = new Size(20, 20);
            menuPrincipal.Items.AddRange(new ToolStripItem[] { menuArchivo, menuAcciones, menuAyuda });
            menuPrincipal.Location = new Point(0, 0);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Size = new Size(882, 36);
            menuPrincipal.TabIndex = 4;
            menuPrincipal.Text = "menuStrip1";
            // 
            // menuArchivo
            // 
            menuArchivo.DropDownItems.AddRange(new ToolStripItem[] { menuItemSalir });
            menuArchivo.Name = "menuArchivo";
            menuArchivo.Size = new Size(93, 32);
            menuArchivo.Text = "Archivo";
            menuArchivo.Click += menuArchivo_Click;
            // 
            // menuItemSalir
            // 
            menuItemSalir.Image = SolicitudCliente.Properties.Resources.icon_salir;
            menuItemSalir.Name = "menuItemSalir";
            menuItemSalir.Size = new Size(224, 32);
            menuItemSalir.Text = "Salir";
            menuItemSalir.Click += menuItemSalir_Click;
            // 
            // menuAcciones
            // 
            menuAcciones.DropDownItems.AddRange(new ToolStripItem[] { menuItemAdicionar, menuItemBuscar, menuItemEliminar, menuItemActualizar, menuItemListar, menuItemListarFiltro });
            menuAcciones.Name = "menuAcciones";
            menuAcciones.Size = new Size(103, 32);
            menuAcciones.Text = "Acciones";
            menuAcciones.Click += toolStripMenuItem1_Click;
            // 
            // menuItemAdicionar
            // 
            menuItemAdicionar.Image = SolicitudCliente.Properties.Resources.icon_agregar;
            menuItemAdicionar.Name = "menuItemAdicionar";
            menuItemAdicionar.Size = new Size(278, 32);
            menuItemAdicionar.Text = "Adicionar";
            menuItemAdicionar.Click += toolStripMenuItem2_Click;
            // 
            // menuItemBuscar
            // 
            menuItemBuscar.Image = SolicitudCliente.Properties.Resources.icon_buscar;
            menuItemBuscar.Name = "menuItemBuscar";
            menuItemBuscar.Size = new Size(278, 32);
            menuItemBuscar.Text = "Buscar según criterio";
            menuItemBuscar.Click += toolStripMenuItem3_Click;
            // 
            // menuItemEliminar
            // 
            menuItemEliminar.Image = SolicitudCliente.Properties.Resources.icon_eliminar;
            menuItemEliminar.Name = "menuItemEliminar";
            menuItemEliminar.Size = new Size(278, 32);
            menuItemEliminar.Text = "Eliminar";
            // 
            // menuItemActualizar
            // 
            menuItemActualizar.Image = SolicitudCliente.Properties.Resources.icon_actualizar_32;
            menuItemActualizar.Name = "menuItemActualizar";
            menuItemActualizar.Size = new Size(278, 32);
            menuItemActualizar.Text = "Actualizar";
            // 
            // menuItemListar
            // 
            menuItemListar.Image = SolicitudCliente.Properties.Resources.icon_listar;
            menuItemListar.Name = "menuItemListar";
            menuItemListar.Size = new Size(278, 32);
            menuItemListar.Text = "Listar";
            // 
            // menuItemListarFiltro
            // 
            menuItemListarFiltro.Image = SolicitudCliente.Properties.Resources.icon_calcular;
            menuItemListarFiltro.Name = "menuItemListarFiltro";
            menuItemListarFiltro.Size = new Size(278, 32);
            menuItemListarFiltro.Text = "Listar según filtro";
            // 
            // menuAyuda
            // 
            menuAyuda.DropDownItems.AddRange(new ToolStripItem[] { menuItemAcercade });
            menuAyuda.Name = "menuAyuda";
            menuAyuda.Size = new Size(82, 32);
            menuAyuda.Text = "Ayuda";
            menuAyuda.Click += menuAyuda_Click;
            // 
            // menuItemAcercade
            // 
            menuItemAcercade.Image = SolicitudCliente.Properties.Resources.icon_info;
            menuItemAcercade.Name = "menuItemAcercade";
            menuItemAcercade.Size = new Size(224, 32);
            menuItemAcercade.Text = "Acerca de";
            menuItemAcercade.Click += acercaDeToolStripMenuItem_Click;
            // 
            // Perecedero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 633);
            Controls.Add(menuPrincipal);
            Controls.Add(txtValue);
            Controls.Add(btnSet);
            Controls.Add(btnGet);
            Font = new Font("Segoe UI", 9F);
            Location = new Point(800, 800);
            MainMenuStrip = menuPrincipal;
            Name = "Perecedero";
            Text = "Principal Perecedero";
            Load += Empleados_Load;
            menuPrincipal.ResumeLayout(false);
            menuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGet;
        private Button btnSet;
        private TextBox txtValue;
        private MenuStrip menuPrincipal;
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
