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
            menuPrincipal = new MenuStrip();
            menuArchivo = new ToolStripMenuItem();
            menuItemSalir = new ToolStripMenuItem();
            menuPerecedero = new ToolStripMenuItem();
            menuItemAdicionar = new ToolStripMenuItem();
            menuItemBuscar = new ToolStripMenuItem();
            menuItemEliminar = new ToolStripMenuItem();
            menuItemActualizar = new ToolStripMenuItem();
            menuItemListar = new ToolStripMenuItem();
            menuItemListarFiltro = new ToolStripMenuItem();
            menuAyuda = new ToolStripMenuItem();
            menuItemAcercade = new ToolStripMenuItem();
            lblTitulo = new Label();
            lblTituloTienda = new Label();
            menuLote = new ToolStripMenuItem();
            menuItemLoteAdicionar = new ToolStripMenuItem();
            menuItemLoteBuscar = new ToolStripMenuItem();
            menuItemLoteEliminar = new ToolStripMenuItem();
            menuItemLoteActualizar = new ToolStripMenuItem();
            menuItemLoteListar = new ToolStripMenuItem();
            menuItemLoteListarFiltro = new ToolStripMenuItem();
            menuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuPrincipal
            // 
            menuPrincipal.BackColor = SystemColors.ControlLight;
            menuPrincipal.Font = new Font("Segoe UI", 12F);
            menuPrincipal.ImageScalingSize = new Size(20, 20);
            menuPrincipal.Items.AddRange(new ToolStripItem[] { menuArchivo, menuPerecedero, menuLote, menuAyuda });
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
            menuItemSalir.Size = new Size(136, 32);
            menuItemSalir.Text = "Salir";
            menuItemSalir.Click += menuItemSalir_Click;
            // 
            // menuPerecedero
            // 
            menuPerecedero.DropDownItems.AddRange(new ToolStripItem[] { menuItemAdicionar, menuItemBuscar, menuItemEliminar, menuItemActualizar, menuItemListar, menuItemListarFiltro });
            menuPerecedero.Name = "menuPerecedero";
            menuPerecedero.Size = new Size(123, 32);
            menuPerecedero.Text = "Perecedero";
            menuPerecedero.Click += menuAcciones_Click;
            // 
            // menuItemAdicionar
            // 
            menuItemAdicionar.Image = SolicitudCliente.Properties.Resources.icon_agregar;
            menuItemAdicionar.Name = "menuItemAdicionar";
            menuItemAdicionar.Size = new Size(278, 32);
            menuItemAdicionar.Text = "Adicionar";
            menuItemAdicionar.Click += menuItemAdicionar_Click;
            // 
            // menuItemBuscar
            // 
            menuItemBuscar.Image = SolicitudCliente.Properties.Resources.icon_buscar;
            menuItemBuscar.Name = "menuItemBuscar";
            menuItemBuscar.Size = new Size(278, 32);
            menuItemBuscar.Text = "Buscar según criterio";
            menuItemBuscar.Click += menuItemBuscar_Click;
            // 
            // menuItemEliminar
            // 
            menuItemEliminar.Image = SolicitudCliente.Properties.Resources.icon_eliminar;
            menuItemEliminar.Name = "menuItemEliminar";
            menuItemEliminar.Size = new Size(278, 32);
            menuItemEliminar.Text = "Eliminar";
            menuItemEliminar.Click += menuItemEliminar_Click;
            // 
            // menuItemActualizar
            // 
            menuItemActualizar.Image = SolicitudCliente.Properties.Resources.icon_actualizar_32;
            menuItemActualizar.Name = "menuItemActualizar";
            menuItemActualizar.Size = new Size(278, 32);
            menuItemActualizar.Text = "Actualizar";
            menuItemActualizar.Click += menuItemActualizar_Click;
            // 
            // menuItemListar
            // 
            menuItemListar.Image = SolicitudCliente.Properties.Resources.icon_listar;
            menuItemListar.Name = "menuItemListar";
            menuItemListar.Size = new Size(278, 32);
            menuItemListar.Text = "Listar";
            menuItemListar.Click += menuItemListar_Click;
            // 
            // menuItemListarFiltro
            // 
            menuItemListarFiltro.Image = SolicitudCliente.Properties.Resources.icon_calcular;
            menuItemListarFiltro.Name = "menuItemListarFiltro";
            menuItemListarFiltro.Size = new Size(278, 32);
            menuItemListarFiltro.Text = "Listar según filtro";
            menuItemListarFiltro.Click += menuItemListarFiltro_Click;
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
            menuItemAcercade.Click += menuItemAcercade_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.LightSeaGreen;
            lblTitulo.Location = new Point(90, 235);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(678, 81);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Productos Perecederos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Click += label1_Click;
            // 
            // lblTituloTienda
            // 
            lblTituloTienda.AutoSize = true;
            lblTituloTienda.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTituloTienda.ForeColor = Color.LightSalmon;
            lblTituloTienda.Location = new Point(331, 316);
            lblTituloTienda.Name = "lblTituloTienda";
            lblTituloTienda.Size = new Size(437, 31);
            lblTituloTienda.TabIndex = 6;
            lblTituloTienda.Text = "Supermercado \"Dónde los electrónicos\"";
            lblTituloTienda.Click += label1_Click_1;
            // 
            // menuLote
            // 
            menuLote.DropDownItems.AddRange(new ToolStripItem[] { menuItemLoteAdicionar, menuItemLoteBuscar, menuItemLoteEliminar, menuItemLoteActualizar, menuItemLoteListar, menuItemLoteListarFiltro });
            menuLote.Name = "menuLote";
            menuLote.Size = new Size(123, 32);
            menuLote.Text = "Perecedero";
            // 
            // menuItemLoteAdicionar
            // 
            menuItemLoteAdicionar.Image = SolicitudCliente.Properties.Resources.icon_agregar;
            menuItemLoteAdicionar.Name = "menuItemLoteAdicionar";
            menuItemLoteAdicionar.Size = new Size(278, 32);
            menuItemLoteAdicionar.Text = "Adicionar";
            // 
            // menuItemLoteBuscar
            // 
            menuItemLoteBuscar.Image = SolicitudCliente.Properties.Resources.icon_buscar;
            menuItemLoteBuscar.Name = "menuItemLoteBuscar";
            menuItemLoteBuscar.Size = new Size(278, 32);
            menuItemLoteBuscar.Text = "Buscar según criterio";
            // 
            // menuItemLoteEliminar
            // 
            menuItemLoteEliminar.Image = SolicitudCliente.Properties.Resources.icon_eliminar;
            menuItemLoteEliminar.Name = "menuItemLoteEliminar";
            menuItemLoteEliminar.Size = new Size(278, 32);
            menuItemLoteEliminar.Text = "Eliminar";
            // 
            // menuItemLoteActualizar
            // 
            menuItemLoteActualizar.Image = SolicitudCliente.Properties.Resources.icon_actualizar_32;
            menuItemLoteActualizar.Name = "menuItemLoteActualizar";
            menuItemLoteActualizar.Size = new Size(278, 32);
            menuItemLoteActualizar.Text = "Actualizar";
            // 
            // menuItemLoteListar
            // 
            menuItemLoteListar.Image = SolicitudCliente.Properties.Resources.icon_listar;
            menuItemLoteListar.Name = "menuItemLoteListar";
            menuItemLoteListar.Size = new Size(278, 32);
            menuItemLoteListar.Text = "Listar";
            // 
            // menuItemLoteListarFiltro
            // 
            menuItemLoteListarFiltro.Image = SolicitudCliente.Properties.Resources.icon_calcular;
            menuItemLoteListarFiltro.Name = "menuItemLoteListarFiltro";
            menuItemLoteListarFiltro.Size = new Size(278, 32);
            menuItemLoteListarFiltro.Text = "Listar según filtro";
            // 
            // Perecedero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(lblTituloTienda);
            Controls.Add(lblTitulo);
            Controls.Add(menuPrincipal);
            Font = new Font("Segoe UI", 9F);
            Location = new Point(900, 800);
            MainMenuStrip = menuPrincipal;
            Name = "Perecedero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal Perecedero";
            Load += Perecedero_Load;
            menuPrincipal.ResumeLayout(false);
            menuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuPrincipal;
        private ToolStripMenuItem menuPerecedero;
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
        private Label lblTitulo;
        private Label lblTituloTienda;
        private ToolStripMenuItem menuLote;
        private ToolStripMenuItem menuItemLoteAdicionar;
        private ToolStripMenuItem menuItemLoteBuscar;
        private ToolStripMenuItem menuItemLoteEliminar;
        private ToolStripMenuItem menuItemLoteActualizar;
        private ToolStripMenuItem menuItemLoteListar;
        private ToolStripMenuItem menuItemLoteListarFiltro;
    }
}
