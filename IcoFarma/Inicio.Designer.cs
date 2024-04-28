namespace IcoFarma
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.btnUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.btnMantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.btnCategoria = new FontAwesome.Sharp.IconMenuItem();
            this.btnProductos = new FontAwesome.Sharp.IconMenuItem();
            this.btnNegocio = new FontAwesome.Sharp.IconMenuItem();
            this.btnCompras = new FontAwesome.Sharp.IconMenuItem();
            this.btnRegistrarCompra = new FontAwesome.Sharp.IconMenuItem();
            this.btnVerDetalle = new FontAwesome.Sharp.IconMenuItem();
            this.btnVentas = new FontAwesome.Sharp.IconMenuItem();
            this.btnRegistrar = new FontAwesome.Sharp.IconMenuItem();
            this.btnDetalle = new FontAwesome.Sharp.IconMenuItem();
            this.btnClientes = new FontAwesome.Sharp.IconMenuItem();
            this.btnProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.btnReportes = new FontAwesome.Sharp.IconMenuItem();
            this.btnrcompras = new FontAwesome.Sharp.IconMenuItem();
            this.btnrventas = new FontAwesome.Sharp.IconMenuItem();
            this.MenuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblUsu = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUsuarios,
            this.btnMantenedor,
            this.btnCompras,
            this.btnVentas,
            this.btnClientes,
            this.btnProveedores,
            this.btnReportes});
            this.Menu.Location = new System.Drawing.Point(0, 77);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.Menu.Size = new System.Drawing.Size(1904, 73);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.AutoSize = false;
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            this.btnUsuarios.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(86)))), ((int)(((byte)(77)))));
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 50;
            this.btnUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(122, 69);
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click_1);
            // 
            // btnMantenedor
            // 
            this.btnMantenedor.AutoSize = false;
            this.btnMantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCategoria,
            this.btnProductos,
            this.btnNegocio});
            this.btnMantenedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMantenedor.IconChar = FontAwesome.Sharp.IconChar.Medkit;
            this.btnMantenedor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(86)))), ((int)(((byte)(77)))));
            this.btnMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMantenedor.IconSize = 50;
            this.btnMantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMantenedor.Name = "btnMantenedor";
            this.btnMantenedor.Size = new System.Drawing.Size(122, 69);
            this.btnMantenedor.Text = "Mantenedor";
            this.btnMantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMantenedor.Click += new System.EventHandler(this.btnMantenedor_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCategoria.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.btnCategoria.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(86)))), ((int)(((byte)(77)))));
            this.btnCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(184, 26);
            this.btnCategoria.Text = "Categoria";
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnProductos.IconChar = FontAwesome.Sharp.IconChar.Pills;
            this.btnProductos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(86)))), ((int)(((byte)(77)))));
            this.btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(184, 26);
            this.btnProductos.Text = "Producto";
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnNegocio
            // 
            this.btnNegocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNegocio.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.btnNegocio.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(86)))), ((int)(((byte)(77)))));
            this.btnNegocio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNegocio.Name = "btnNegocio";
            this.btnNegocio.Size = new System.Drawing.Size(184, 26);
            this.btnNegocio.Text = "Negocio";
            this.btnNegocio.Click += new System.EventHandler(this.btnNegocio_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.AutoSize = false;
            this.btnCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRegistrarCompra,
            this.btnVerDetalle});
            this.btnCompras.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCompras.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnCompras.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(86)))), ((int)(((byte)(77)))));
            this.btnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompras.IconSize = 50;
            this.btnCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(122, 69);
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnRegistrarCompra
            // 
            this.btnRegistrarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnRegistrarCompra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnRegistrarCompra.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(86)))), ((int)(((byte)(77)))));
            this.btnRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarCompra.Name = "btnRegistrarCompra";
            this.btnRegistrarCompra.Size = new System.Drawing.Size(184, 26);
            this.btnRegistrarCompra.Text = "Registrar";
            this.btnRegistrarCompra.Click += new System.EventHandler(this.btnRegistrarCompra_Click);
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnVerDetalle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerDetalle.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnVerDetalle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(86)))), ((int)(((byte)(77)))));
            this.btnVerDetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(184, 26);
            this.btnVerDetalle.Text = "Ver Detalle";
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.AutoSize = false;
            this.btnVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRegistrar,
            this.btnDetalle});
            this.btnVentas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.btnVentas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(86)))), ((int)(((byte)(77)))));
            this.btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentas.IconSize = 50;
            this.btnVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(122, 69);
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnRegistrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(86)))), ((int)(((byte)(77)))));
            this.btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(184, 26);
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDetalle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDetalle.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnDetalle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(86)))), ((int)(((byte)(77)))));
            this.btnDetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(184, 26);
            this.btnDetalle.Text = "Ver Detalle";
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.AutoSize = false;
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.UserInjured;
            this.btnClientes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(86)))), ((int)(((byte)(77)))));
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.IconSize = 50;
            this.btnClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(80, 69);
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.AutoSize = false;
            this.btnProveedores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnProveedores.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(86)))), ((int)(((byte)(77)))));
            this.btnProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProveedores.IconSize = 50;
            this.btnProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(152, 69);
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.AutoSize = false;
            this.btnReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnrcompras,
            this.btnrventas});
            this.btnReportes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReportes.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btnReportes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(86)))), ((int)(((byte)(77)))));
            this.btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportes.IconSize = 50;
            this.btnReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(122, 69);
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnrcompras
            // 
            this.btnrcompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnrcompras.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnrcompras.IconChar = FontAwesome.Sharp.IconChar.ChartArea;
            this.btnrcompras.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(86)))), ((int)(((byte)(77)))));
            this.btnrcompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnrcompras.Name = "btnrcompras";
            this.btnrcompras.Size = new System.Drawing.Size(184, 26);
            this.btnrcompras.Text = "Reporte Compras";
            this.btnrcompras.Click += new System.EventHandler(this.btnrcompras_Click);
            // 
            // btnrventas
            // 
            this.btnrventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnrventas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnrventas.IconChar = FontAwesome.Sharp.IconChar.ChartArea;
            this.btnrventas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(86)))), ((int)(((byte)(77)))));
            this.btnrventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnrventas.Name = "btnrventas";
            this.btnrventas.Size = new System.Drawing.Size(184, 26);
            this.btnrventas.Text = "Reporte Ventas";
            this.btnrventas.Click += new System.EventHandler(this.btnrventas_Click);
            // 
            // MenuTitulo
            // 
            this.MenuTitulo.AutoSize = false;
            this.MenuTitulo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.MenuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuTitulo.Location = new System.Drawing.Point(0, 0);
            this.MenuTitulo.Name = "MenuTitulo";
            this.MenuTitulo.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MenuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuTitulo.Size = new System.Drawing.Size(1904, 77);
            this.MenuTitulo.TabIndex = 1;
            this.MenuTitulo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuTitulo_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Rockwell Extra Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(83, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "ICOSISTEMA";
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 150);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1904, 891);
            this.Contenedor.TabIndex = 4;
            this.Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Contenedor_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.BackgroundImage = global::IcoFarma.Properties.Resources.lg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1742, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 77);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Location = new System.Drawing.Point(1634, 30);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(102, 22);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "lblUsuario";
            // 
            // lblUsu
            // 
            this.lblUsu.AutoSize = true;
            this.lblUsu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblUsu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsu.Location = new System.Drawing.Point(1549, 30);
            this.lblUsu.Name = "lblUsu";
            this.lblUsu.Size = new System.Drawing.Size(86, 22);
            this.lblUsu.TabIndex = 5;
            this.lblUsu.Text = "Usuario:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox2.BackgroundImage = global::IcoFarma.Properties.Resources.logo1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(14, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 65);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblUsu);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.MenuTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inicio_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Inicio_FormClosed);
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private new System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.MenuStrip MenuTitulo;
        private FontAwesome.Sharp.IconMenuItem btnUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconMenuItem btnMantenedor;
        private FontAwesome.Sharp.IconMenuItem btnVentas;
        private FontAwesome.Sharp.IconMenuItem btnCompras;
        private FontAwesome.Sharp.IconMenuItem btnClientes;
        private FontAwesome.Sharp.IconMenuItem btnProveedores;
        private FontAwesome.Sharp.IconMenuItem btnReportes;
        private System.Windows.Forms.Panel Contenedor;
        private FontAwesome.Sharp.IconMenuItem btnCategoria;
        private FontAwesome.Sharp.IconMenuItem btnProductos;
        private FontAwesome.Sharp.IconMenuItem btnRegistrar;
        private FontAwesome.Sharp.IconMenuItem btnDetalle;
        private FontAwesome.Sharp.IconMenuItem btnRegistrarCompra;
        private FontAwesome.Sharp.IconMenuItem btnVerDetalle;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblUsu;
        private FontAwesome.Sharp.IconMenuItem btnNegocio;
        private FontAwesome.Sharp.IconMenuItem btnrcompras;
        private FontAwesome.Sharp.IconMenuItem btnrventas;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}