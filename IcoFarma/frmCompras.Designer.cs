namespace IcoFarma
{
    partial class frmCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            this.label3 = new System.Windows.Forms.Label();
            this.cbotipodocumento = new Siticone.UI.WinForms.SiticoneRoundedComboBox();
            this.txtfecha = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombreproveedor = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.txtidproveedor = new System.Windows.Forms.TextBox();
            this.txtdocproveedor = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.btnbuscarproveedor = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.txtcantidad = new Siticone.UI.WinForms.SiticoneRoundedNumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtprecioventa = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.txtproducto = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.txtpreciocompra = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.buscarproducto = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.txtcodproducto = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.txttotalpagar = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.dgvdata = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnregistrar = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.label10 = new System.Windows.Forms.Label();
            this.btnagregarproducto = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.label6 = new System.Windows.Forms.Label();
            this.siticoneGroupBox1 = new Siticone.UI.WinForms.SiticoneGroupBox();
            this.siticoneGroupBox2 = new Siticone.UI.WinForms.SiticoneGroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.siticoneGroupBox3 = new Siticone.UI.WinForms.SiticoneGroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.siticoneGroupBox1.SuspendLayout();
            this.siticoneGroupBox2.SuspendLayout();
            this.siticoneGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Documento:";
            // 
            // cbotipodocumento
            // 
            this.cbotipodocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.cbotipodocumento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.cbotipodocumento.BorderThickness = 2;
            this.cbotipodocumento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbotipodocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipodocumento.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbotipodocumento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbotipodocumento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbotipodocumento.ForeColor = System.Drawing.Color.White;
            this.cbotipodocumento.FormattingEnabled = true;
            this.cbotipodocumento.HoveredState.Parent = this.cbotipodocumento;
            this.cbotipodocumento.ItemHeight = 30;
            this.cbotipodocumento.ItemsAppearance.Parent = this.cbotipodocumento;
            this.cbotipodocumento.Location = new System.Drawing.Point(238, 46);
            this.cbotipodocumento.Name = "cbotipodocumento";
            this.cbotipodocumento.ShadowDecoration.Parent = this.cbotipodocumento;
            this.cbotipodocumento.Size = new System.Drawing.Size(208, 36);
            this.cbotipodocumento.TabIndex = 173;
            // 
            // txtfecha
            // 
            this.txtfecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtfecha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.txtfecha.BorderThickness = 2;
            this.txtfecha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfecha.DefaultText = "";
            this.txtfecha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtfecha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtfecha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfecha.DisabledState.Parent = this.txtfecha;
            this.txtfecha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfecha.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtfecha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfecha.FocusedState.Parent = this.txtfecha;
            this.txtfecha.ForeColor = System.Drawing.Color.White;
            this.txtfecha.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfecha.HoveredState.Parent = this.txtfecha;
            this.txtfecha.Location = new System.Drawing.Point(13, 49);
            this.txtfecha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.PasswordChar = '\0';
            this.txtfecha.PlaceholderText = "";
            this.txtfecha.SelectedText = "";
            this.txtfecha.ShadowDecoration.Parent = this.txtfecha;
            this.txtfecha.Size = new System.Drawing.Size(185, 33);
            this.txtfecha.TabIndex = 173;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(38, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Registrar Compra:";
            // 
            // txtnombreproveedor
            // 
            this.txtnombreproveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtnombreproveedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.txtnombreproveedor.BorderThickness = 2;
            this.txtnombreproveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombreproveedor.DefaultText = "";
            this.txtnombreproveedor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnombreproveedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnombreproveedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnombreproveedor.DisabledState.Parent = this.txtnombreproveedor;
            this.txtnombreproveedor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnombreproveedor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtnombreproveedor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnombreproveedor.FocusedState.Parent = this.txtnombreproveedor;
            this.txtnombreproveedor.ForeColor = System.Drawing.Color.White;
            this.txtnombreproveedor.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnombreproveedor.HoveredState.Parent = this.txtnombreproveedor;
            this.txtnombreproveedor.Location = new System.Drawing.Point(248, 44);
            this.txtnombreproveedor.Margin = new System.Windows.Forms.Padding(6);
            this.txtnombreproveedor.Name = "txtnombreproveedor";
            this.txtnombreproveedor.PasswordChar = '\0';
            this.txtnombreproveedor.PlaceholderText = "Razon Social";
            this.txtnombreproveedor.SelectedText = "";
            this.txtnombreproveedor.ShadowDecoration.Parent = this.txtnombreproveedor;
            this.txtnombreproveedor.Size = new System.Drawing.Size(254, 37);
            this.txtnombreproveedor.TabIndex = 174;
            // 
            // txtidproveedor
            // 
            this.txtidproveedor.Location = new System.Drawing.Point(476, 5);
            this.txtidproveedor.Name = "txtidproveedor";
            this.txtidproveedor.Size = new System.Drawing.Size(26, 23);
            this.txtidproveedor.TabIndex = 101;
            this.txtidproveedor.Text = "0";
            this.txtidproveedor.Visible = false;
            // 
            // txtdocproveedor
            // 
            this.txtdocproveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtdocproveedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.txtdocproveedor.BorderThickness = 2;
            this.txtdocproveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdocproveedor.DefaultText = "";
            this.txtdocproveedor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdocproveedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdocproveedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdocproveedor.DisabledState.Parent = this.txtdocproveedor;
            this.txtdocproveedor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdocproveedor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtdocproveedor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdocproveedor.FocusedState.Parent = this.txtdocproveedor;
            this.txtdocproveedor.ForeColor = System.Drawing.Color.White;
            this.txtdocproveedor.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdocproveedor.HoveredState.Parent = this.txtdocproveedor;
            this.txtdocproveedor.Location = new System.Drawing.Point(13, 45);
            this.txtdocproveedor.Margin = new System.Windows.Forms.Padding(6);
            this.txtdocproveedor.Name = "txtdocproveedor";
            this.txtdocproveedor.PasswordChar = '\0';
            this.txtdocproveedor.PlaceholderText = "Nro Documento";
            this.txtdocproveedor.SelectedText = "";
            this.txtdocproveedor.ShadowDecoration.Parent = this.txtdocproveedor;
            this.txtdocproveedor.Size = new System.Drawing.Size(174, 36);
            this.txtdocproveedor.TabIndex = 174;
            // 
            // btnbuscarproveedor
            // 
            this.btnbuscarproveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnbuscarproveedor.CheckedState.Parent = this.btnbuscarproveedor;
            this.btnbuscarproveedor.CustomImages.Parent = this.btnbuscarproveedor;
            this.btnbuscarproveedor.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnbuscarproveedor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnbuscarproveedor.ForeColor = System.Drawing.Color.White;
            this.btnbuscarproveedor.HoveredState.Parent = this.btnbuscarproveedor;
            this.btnbuscarproveedor.Image = global::IcoFarma.Properties.Resources.Search;
            this.btnbuscarproveedor.Location = new System.Drawing.Point(196, 45);
            this.btnbuscarproveedor.Name = "btnbuscarproveedor";
            this.btnbuscarproveedor.ShadowDecoration.Parent = this.btnbuscarproveedor;
            this.btnbuscarproveedor.Size = new System.Drawing.Size(43, 36);
            this.btnbuscarproveedor.TabIndex = 169;
            this.btnbuscarproveedor.Click += new System.EventHandler(this.btnbuscarproveedor_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtcantidad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.txtcantidad.BorderThickness = 2;
            this.txtcantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcantidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcantidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcantidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcantidad.DisabledState.Parent = this.txtcantidad;
            this.txtcantidad.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.txtcantidad.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.txtcantidad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtcantidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcantidad.FocusedState.Parent = this.txtcantidad;
            this.txtcantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.ForeColor = System.Drawing.Color.White;
            this.txtcantidad.Location = new System.Drawing.Point(702, 45);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.ShadowDecoration.Parent = this.txtcantidad;
            this.txtcantidad.Size = new System.Drawing.Size(102, 33);
            this.txtcantidad.TabIndex = 176;
            this.txtcantidad.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(699, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 106;
            this.label11.Text = "Cantidad:";
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtprecioventa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.txtprecioventa.BorderThickness = 2;
            this.txtprecioventa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprecioventa.DefaultText = "";
            this.txtprecioventa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtprecioventa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtprecioventa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprecioventa.DisabledState.Parent = this.txtprecioventa;
            this.txtprecioventa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprecioventa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtprecioventa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprecioventa.FocusedState.Parent = this.txtprecioventa;
            this.txtprecioventa.ForeColor = System.Drawing.Color.White;
            this.txtprecioventa.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprecioventa.HoveredState.Parent = this.txtprecioventa;
            this.txtprecioventa.Location = new System.Drawing.Point(569, 45);
            this.txtprecioventa.Margin = new System.Windows.Forms.Padding(5);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.PasswordChar = '\0';
            this.txtprecioventa.PlaceholderText = "Precio Venta";
            this.txtprecioventa.SelectedText = "";
            this.txtprecioventa.ShadowDecoration.Parent = this.txtprecioventa;
            this.txtprecioventa.Size = new System.Drawing.Size(122, 33);
            this.txtprecioventa.TabIndex = 177;
            this.txtprecioventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecioventa_KeyPress);
            // 
            // txtproducto
            // 
            this.txtproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtproducto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.txtproducto.BorderThickness = 2;
            this.txtproducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtproducto.DefaultText = "";
            this.txtproducto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtproducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtproducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtproducto.DisabledState.Parent = this.txtproducto;
            this.txtproducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtproducto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtproducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtproducto.FocusedState.Parent = this.txtproducto;
            this.txtproducto.ForeColor = System.Drawing.Color.White;
            this.txtproducto.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtproducto.HoveredState.Parent = this.txtproducto;
            this.txtproducto.Location = new System.Drawing.Point(246, 45);
            this.txtproducto.Margin = new System.Windows.Forms.Padding(5);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.PasswordChar = '\0';
            this.txtproducto.PlaceholderText = "Producto";
            this.txtproducto.SelectedText = "";
            this.txtproducto.ShadowDecoration.Parent = this.txtproducto;
            this.txtproducto.Size = new System.Drawing.Size(159, 33);
            this.txtproducto.TabIndex = 174;
            // 
            // txtpreciocompra
            // 
            this.txtpreciocompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtpreciocompra.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.txtpreciocompra.BorderThickness = 2;
            this.txtpreciocompra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpreciocompra.DefaultText = "";
            this.txtpreciocompra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpreciocompra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpreciocompra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpreciocompra.DisabledState.Parent = this.txtpreciocompra;
            this.txtpreciocompra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpreciocompra.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtpreciocompra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpreciocompra.FocusedState.Parent = this.txtpreciocompra;
            this.txtpreciocompra.ForeColor = System.Drawing.Color.White;
            this.txtpreciocompra.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpreciocompra.HoveredState.Parent = this.txtpreciocompra;
            this.txtpreciocompra.Location = new System.Drawing.Point(425, 45);
            this.txtpreciocompra.Margin = new System.Windows.Forms.Padding(5);
            this.txtpreciocompra.Name = "txtpreciocompra";
            this.txtpreciocompra.PasswordChar = '\0';
            this.txtpreciocompra.PlaceholderText = "Precio Compra";
            this.txtpreciocompra.SelectedText = "";
            this.txtpreciocompra.ShadowDecoration.Parent = this.txtpreciocompra;
            this.txtpreciocompra.Size = new System.Drawing.Size(134, 33);
            this.txtpreciocompra.TabIndex = 176;
            this.txtpreciocompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpreciocompra_KeyPress);
            // 
            // buscarproducto
            // 
            this.buscarproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.buscarproducto.CheckedState.Parent = this.buscarproducto;
            this.buscarproducto.CustomImages.Parent = this.buscarproducto;
            this.buscarproducto.FillColor = System.Drawing.Color.RoyalBlue;
            this.buscarproducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buscarproducto.ForeColor = System.Drawing.Color.White;
            this.buscarproducto.HoveredState.Parent = this.buscarproducto;
            this.buscarproducto.Image = global::IcoFarma.Properties.Resources.Search;
            this.buscarproducto.Location = new System.Drawing.Point(197, 45);
            this.buscarproducto.Name = "buscarproducto";
            this.buscarproducto.ShadowDecoration.Parent = this.buscarproducto;
            this.buscarproducto.Size = new System.Drawing.Size(41, 33);
            this.buscarproducto.TabIndex = 175;
            this.buscarproducto.Click += new System.EventHandler(this.buscarproducto_Click);
            // 
            // txtcodproducto
            // 
            this.txtcodproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtcodproducto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.txtcodproducto.BorderThickness = 2;
            this.txtcodproducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcodproducto.DefaultText = "";
            this.txtcodproducto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcodproducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcodproducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcodproducto.DisabledState.Parent = this.txtcodproducto;
            this.txtcodproducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcodproducto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtcodproducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcodproducto.FocusedState.Parent = this.txtcodproducto;
            this.txtcodproducto.ForeColor = System.Drawing.Color.White;
            this.txtcodproducto.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcodproducto.HoveredState.Parent = this.txtcodproducto;
            this.txtcodproducto.Location = new System.Drawing.Point(13, 46);
            this.txtcodproducto.Margin = new System.Windows.Forms.Padding(5);
            this.txtcodproducto.Name = "txtcodproducto";
            this.txtcodproducto.PasswordChar = '\0';
            this.txtcodproducto.PlaceholderText = "Cod. Producto";
            this.txtcodproducto.SelectedText = "";
            this.txtcodproducto.ShadowDecoration.Parent = this.txtcodproducto;
            this.txtcodproducto.Size = new System.Drawing.Size(169, 33);
            this.txtcodproducto.TabIndex = 174;
            this.txtcodproducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodproducto_KeyDown);
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(858, 46);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(26, 23);
            this.txtidproducto.TabIndex = 101;
            this.txtidproducto.Text = "0";
            this.txtidproducto.Visible = false;
            // 
            // txttotalpagar
            // 
            this.txttotalpagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txttotalpagar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.txttotalpagar.BorderThickness = 2;
            this.txttotalpagar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttotalpagar.DefaultText = "0";
            this.txttotalpagar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttotalpagar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttotalpagar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttotalpagar.DisabledState.Parent = this.txttotalpagar;
            this.txttotalpagar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttotalpagar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txttotalpagar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttotalpagar.FocusedState.Parent = this.txttotalpagar;
            this.txttotalpagar.ForeColor = System.Drawing.Color.White;
            this.txttotalpagar.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttotalpagar.HoveredState.Parent = this.txttotalpagar;
            this.txttotalpagar.Location = new System.Drawing.Point(997, 726);
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.PasswordChar = '\0';
            this.txttotalpagar.PlaceholderText = "";
            this.txttotalpagar.SelectedText = "";
            this.txttotalpagar.ShadowDecoration.Parent = this.txttotalpagar;
            this.txttotalpagar.Size = new System.Drawing.Size(217, 36);
            this.txttotalpagar.TabIndex = 168;
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dgvdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.ColumnHeadersHeight = 50;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal,
            this.btneliminar});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdata.DoubleBuffered = true;
            this.dgvdata.EnableHeadersVisualStyles = false;
            this.dgvdata.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dgvdata.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.dgvdata.HeaderForeColor = System.Drawing.Color.White;
            this.dgvdata.Location = new System.Drawing.Point(42, 259);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvdata.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvdata.RowTemplate.DividerHeight = 1;
            this.dgvdata.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.Size = new System.Drawing.Size(899, 566);
            this.dgvdata.TabIndex = 170;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Visible = false;
            // 
            // Producto
            // 
            this.Producto.FillWeight = 83.89366F;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 150;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.Width = 150;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 150;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Width = 150;
            // 
            // btneliminar
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btneliminar.DefaultCellStyle = dataGridViewCellStyle3;
            this.btneliminar.FillWeight = 57.07051F;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneliminar.HeaderText = "";
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btneliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btneliminar.Width = 25;
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnregistrar.CheckedState.Parent = this.btnregistrar;
            this.btnregistrar.CustomImages.Parent = this.btnregistrar;
            this.btnregistrar.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnregistrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnregistrar.ForeColor = System.Drawing.Color.White;
            this.btnregistrar.HoveredState.Parent = this.btnregistrar;
            this.btnregistrar.Image = global::IcoFarma.Properties.Resources.Price_Tag;
            this.btnregistrar.Location = new System.Drawing.Point(997, 768);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.ShadowDecoration.Parent = this.btnregistrar;
            this.btnregistrar.Size = new System.Drawing.Size(217, 36);
            this.btnregistrar.TabIndex = 171;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(985, 694);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 172;
            this.label10.Text = "Total a pagar:";
            // 
            // btnagregarproducto
            // 
            this.btnagregarproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnagregarproducto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.btnagregarproducto.CheckedState.Parent = this.btnagregarproducto;
            this.btnagregarproducto.CustomImages.Parent = this.btnagregarproducto;
            this.btnagregarproducto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnagregarproducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnagregarproducto.ForeColor = System.Drawing.Color.Black;
            this.btnagregarproducto.HoveredState.Parent = this.btnagregarproducto;
            this.btnagregarproducto.Image = global::IcoFarma.Properties.Resources.Add1;
            this.btnagregarproducto.ImageSize = new System.Drawing.Size(70, 70);
            this.btnagregarproducto.Location = new System.Drawing.Point(947, 149);
            this.btnagregarproducto.Name = "btnagregarproducto";
            this.btnagregarproducto.ShadowDecoration.Parent = this.btnagregarproducto;
            this.btnagregarproducto.Size = new System.Drawing.Size(94, 87);
            this.btnagregarproducto.TabIndex = 175;
            this.btnagregarproducto.Click += new System.EventHandler(this.btnagregarproducto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(10, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 15);
            this.label6.TabIndex = 195;
            this.label6.Text = "Informacion Compra:";
            // 
            // siticoneGroupBox1
            // 
            this.siticoneGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.siticoneGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.siticoneGroupBox1.BorderRadius = 2;
            this.siticoneGroupBox1.Controls.Add(this.label3);
            this.siticoneGroupBox1.Controls.Add(this.label6);
            this.siticoneGroupBox1.Controls.Add(this.cbotipodocumento);
            this.siticoneGroupBox1.Controls.Add(this.label2);
            this.siticoneGroupBox1.Controls.Add(this.txtfecha);
            this.siticoneGroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.siticoneGroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.siticoneGroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.siticoneGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox1.ForeColor = System.Drawing.Color.White;
            this.siticoneGroupBox1.Location = new System.Drawing.Point(40, 49);
            this.siticoneGroupBox1.Name = "siticoneGroupBox1";
            this.siticoneGroupBox1.ShadowDecoration.Parent = this.siticoneGroupBox1;
            this.siticoneGroupBox1.Size = new System.Drawing.Size(482, 89);
            this.siticoneGroupBox1.TabIndex = 199;
            // 
            // siticoneGroupBox2
            // 
            this.siticoneGroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.siticoneGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.siticoneGroupBox2.BorderRadius = 2;
            this.siticoneGroupBox2.Controls.Add(this.label14);
            this.siticoneGroupBox2.Controls.Add(this.label13);
            this.siticoneGroupBox2.Controls.Add(this.txtidproveedor);
            this.siticoneGroupBox2.Controls.Add(this.txtnombreproveedor);
            this.siticoneGroupBox2.Controls.Add(this.label5);
            this.siticoneGroupBox2.Controls.Add(this.txtdocproveedor);
            this.siticoneGroupBox2.Controls.Add(this.btnbuscarproveedor);
            this.siticoneGroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.siticoneGroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.siticoneGroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.siticoneGroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox2.ForeColor = System.Drawing.Color.White;
            this.siticoneGroupBox2.Location = new System.Drawing.Point(533, 49);
            this.siticoneGroupBox2.Name = "siticoneGroupBox2";
            this.siticoneGroupBox2.ShadowDecoration.Parent = this.siticoneGroupBox2;
            this.siticoneGroupBox2.Size = new System.Drawing.Size(508, 89);
            this.siticoneGroupBox2.TabIndex = 200;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(245, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 15);
            this.label14.TabIndex = 201;
            this.label14.Text = "Razon Social:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 15);
            this.label13.TabIndex = 200;
            this.label13.Text = "Nro Documento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(10, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 15);
            this.label5.TabIndex = 195;
            this.label5.Text = "Informacion Proveedor:";
            // 
            // siticoneGroupBox3
            // 
            this.siticoneGroupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.siticoneGroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.siticoneGroupBox3.BorderRadius = 2;
            this.siticoneGroupBox3.Controls.Add(this.label12);
            this.siticoneGroupBox3.Controls.Add(this.label9);
            this.siticoneGroupBox3.Controls.Add(this.label8);
            this.siticoneGroupBox3.Controls.Add(this.label7);
            this.siticoneGroupBox3.Controls.Add(this.txtidproducto);
            this.siticoneGroupBox3.Controls.Add(this.label11);
            this.siticoneGroupBox3.Controls.Add(this.txtcantidad);
            this.siticoneGroupBox3.Controls.Add(this.label4);
            this.siticoneGroupBox3.Controls.Add(this.txtcodproducto);
            this.siticoneGroupBox3.Controls.Add(this.txtprecioventa);
            this.siticoneGroupBox3.Controls.Add(this.buscarproducto);
            this.siticoneGroupBox3.Controls.Add(this.txtpreciocompra);
            this.siticoneGroupBox3.Controls.Add(this.txtproducto);
            this.siticoneGroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.siticoneGroupBox3.CustomBorderThickness = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.siticoneGroupBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.siticoneGroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox3.ForeColor = System.Drawing.Color.White;
            this.siticoneGroupBox3.Location = new System.Drawing.Point(42, 149);
            this.siticoneGroupBox3.Name = "siticoneGroupBox3";
            this.siticoneGroupBox3.ShadowDecoration.Parent = this.siticoneGroupBox3;
            this.siticoneGroupBox3.Size = new System.Drawing.Size(899, 89);
            this.siticoneGroupBox3.TabIndex = 201;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(566, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 15);
            this.label12.TabIndex = 199;
            this.label12.Text = "Precio Venta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(422, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 15);
            this.label9.TabIndex = 198;
            this.label9.Text = "Precio Compra:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 197;
            this.label8.Text = "Producto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 196;
            this.label7.Text = "Cod. Producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(10, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 15);
            this.label4.TabIndex = 195;
            this.label4.Text = "Informacion del Producto:";
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1888, 852);
            this.Controls.Add(this.siticoneGroupBox3);
            this.Controls.Add(this.siticoneGroupBox2);
            this.Controls.Add(this.siticoneGroupBox1);
            this.Controls.Add(this.btnagregarproducto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.txttotalpagar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCompras";
            this.Text = "frmCompras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.siticoneGroupBox1.ResumeLayout(false);
            this.siticoneGroupBox1.PerformLayout();
            this.siticoneGroupBox2.ResumeLayout(false);
            this.siticoneGroupBox2.PerformLayout();
            this.siticoneGroupBox3.ResumeLayout(false);
            this.siticoneGroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidproveedor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtidproducto;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txttotalpagar;
        private Siticone.UI.WinForms.SiticoneRoundedButton btnbuscarproveedor;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvdata;
        private Siticone.UI.WinForms.SiticoneRoundedButton btnregistrar;
        private System.Windows.Forms.Label label10;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtfecha;
        private Siticone.UI.WinForms.SiticoneRoundedComboBox cbotipodocumento;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtdocproveedor;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtnombreproveedor;
        private Siticone.UI.WinForms.SiticoneRoundedButton btnagregarproducto;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtproducto;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtpreciocompra;
        private Siticone.UI.WinForms.SiticoneRoundedButton buscarproducto;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtcodproducto;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtprecioventa;
        private Siticone.UI.WinForms.SiticoneRoundedNumericUpDown txtcantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
        private System.Windows.Forms.Label label6;
        private Siticone.UI.WinForms.SiticoneGroupBox siticoneGroupBox1;
        private Siticone.UI.WinForms.SiticoneGroupBox siticoneGroupBox2;
        private Siticone.UI.WinForms.SiticoneGroupBox siticoneGroupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}