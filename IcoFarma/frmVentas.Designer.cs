namespace IcoFarma
{
    partial class frmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbotipodocumento = new Siticone.UI.WinForms.SiticoneRoundedComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombrecliente = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.txtdocumentocliente = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.btnbuscarclick = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.txtcantidad = new Siticone.UI.WinForms.SiticoneRoundedNumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtstock = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.txtproducto = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.txtprecio = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.buscarproducto = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.txtcodproducto = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.btnagregarproducto = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.dgvdata = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txttotalpagar = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.btnregistrar = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtpagocon = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcambio = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneGroupBox3 = new Siticone.UI.WinForms.SiticoneGroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtfecha = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneGroupBox1 = new Siticone.UI.WinForms.SiticoneGroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.siticoneGroupBox2 = new Siticone.UI.WinForms.SiticoneGroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.siticoneGroupBox3.SuspendLayout();
            this.siticoneGroupBox1.SuspendLayout();
            this.siticoneGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(30, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 177;
            this.label1.Text = "Registrar Venta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 29);
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
            this.cbotipodocumento.Location = new System.Drawing.Point(227, 44);
            this.cbotipodocumento.Name = "cbotipodocumento";
            this.cbotipodocumento.ShadowDecoration.Parent = this.cbotipodocumento;
            this.cbotipodocumento.Size = new System.Drawing.Size(208, 36);
            this.cbotipodocumento.TabIndex = 173;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha:";
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtnombrecliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.txtnombrecliente.BorderThickness = 2;
            this.txtnombrecliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombrecliente.DefaultText = "";
            this.txtnombrecliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnombrecliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnombrecliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnombrecliente.DisabledState.Parent = this.txtnombrecliente;
            this.txtnombrecliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnombrecliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtnombrecliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnombrecliente.FocusedState.Parent = this.txtnombrecliente;
            this.txtnombrecliente.ForeColor = System.Drawing.Color.White;
            this.txtnombrecliente.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnombrecliente.HoveredState.Parent = this.txtnombrecliente;
            this.txtnombrecliente.Location = new System.Drawing.Point(245, 44);
            this.txtnombrecliente.Margin = new System.Windows.Forms.Padding(6);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.PasswordChar = '\0';
            this.txtnombrecliente.PlaceholderText = "Nombre Cliente";
            this.txtnombrecliente.SelectedText = "";
            this.txtnombrecliente.ShadowDecoration.Parent = this.txtnombrecliente;
            this.txtnombrecliente.Size = new System.Drawing.Size(249, 33);
            this.txtnombrecliente.TabIndex = 174;
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(479, 3);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(26, 23);
            this.txtidcliente.TabIndex = 101;
            this.txtidcliente.Text = "0";
            this.txtidcliente.Visible = false;
            // 
            // txtdocumentocliente
            // 
            this.txtdocumentocliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtdocumentocliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.txtdocumentocliente.BorderThickness = 2;
            this.txtdocumentocliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdocumentocliente.DefaultText = "";
            this.txtdocumentocliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdocumentocliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdocumentocliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdocumentocliente.DisabledState.Parent = this.txtdocumentocliente;
            this.txtdocumentocliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdocumentocliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtdocumentocliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdocumentocliente.FocusedState.Parent = this.txtdocumentocliente;
            this.txtdocumentocliente.ForeColor = System.Drawing.Color.White;
            this.txtdocumentocliente.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdocumentocliente.HoveredState.Parent = this.txtdocumentocliente;
            this.txtdocumentocliente.Location = new System.Drawing.Point(13, 44);
            this.txtdocumentocliente.Margin = new System.Windows.Forms.Padding(6);
            this.txtdocumentocliente.Name = "txtdocumentocliente";
            this.txtdocumentocliente.PasswordChar = '\0';
            this.txtdocumentocliente.PlaceholderText = "Nro Documento";
            this.txtdocumentocliente.SelectedText = "";
            this.txtdocumentocliente.ShadowDecoration.Parent = this.txtdocumentocliente;
            this.txtdocumentocliente.Size = new System.Drawing.Size(177, 33);
            this.txtdocumentocliente.TabIndex = 174;
            // 
            // btnbuscarclick
            // 
            this.btnbuscarclick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnbuscarclick.CheckedState.Parent = this.btnbuscarclick;
            this.btnbuscarclick.CustomImages.Parent = this.btnbuscarclick;
            this.btnbuscarclick.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnbuscarclick.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnbuscarclick.ForeColor = System.Drawing.Color.White;
            this.btnbuscarclick.HoveredState.Parent = this.btnbuscarclick;
            this.btnbuscarclick.Image = global::IcoFarma.Properties.Resources.Search;
            this.btnbuscarclick.Location = new System.Drawing.Point(193, 44);
            this.btnbuscarclick.Name = "btnbuscarclick";
            this.btnbuscarclick.ShadowDecoration.Parent = this.btnbuscarclick;
            this.btnbuscarclick.Size = new System.Drawing.Size(43, 36);
            this.btnbuscarclick.TabIndex = 169;
            this.btnbuscarclick.Click += new System.EventHandler(this.btnbuscarclick_Click);
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
            this.txtcantidad.Location = new System.Drawing.Point(707, 48);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.ShadowDecoration.Parent = this.txtcantidad;
            this.txtcantidad.Size = new System.Drawing.Size(136, 34);
            this.txtcantidad.TabIndex = 176;
            this.txtcantidad.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(704, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 106;
            this.label4.Text = "Cantidad:";
            // 
            // txtstock
            // 
            this.txtstock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtstock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.txtstock.BorderThickness = 2;
            this.txtstock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstock.DefaultText = "";
            this.txtstock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtstock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtstock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstock.DisabledState.Parent = this.txtstock;
            this.txtstock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtstock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstock.FocusedState.Parent = this.txtstock;
            this.txtstock.ForeColor = System.Drawing.Color.White;
            this.txtstock.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstock.HoveredState.Parent = this.txtstock;
            this.txtstock.Location = new System.Drawing.Point(573, 52);
            this.txtstock.Margin = new System.Windows.Forms.Padding(5);
            this.txtstock.Name = "txtstock";
            this.txtstock.PasswordChar = '\0';
            this.txtstock.PlaceholderText = "Stock";
            this.txtstock.SelectedText = "";
            this.txtstock.ShadowDecoration.Parent = this.txtstock;
            this.txtstock.Size = new System.Drawing.Size(117, 30);
            this.txtstock.TabIndex = 177;
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
            this.txtproducto.Location = new System.Drawing.Point(258, 51);
            this.txtproducto.Margin = new System.Windows.Forms.Padding(5);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.PasswordChar = '\0';
            this.txtproducto.PlaceholderText = "Producto";
            this.txtproducto.SelectedText = "";
            this.txtproducto.ShadowDecoration.Parent = this.txtproducto;
            this.txtproducto.Size = new System.Drawing.Size(189, 30);
            this.txtproducto.TabIndex = 174;
            // 
            // txtprecio
            // 
            this.txtprecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtprecio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.txtprecio.BorderThickness = 2;
            this.txtprecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprecio.DefaultText = "";
            this.txtprecio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtprecio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtprecio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprecio.DisabledState.Parent = this.txtprecio;
            this.txtprecio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprecio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtprecio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprecio.FocusedState.Parent = this.txtprecio;
            this.txtprecio.ForeColor = System.Drawing.Color.White;
            this.txtprecio.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprecio.HoveredState.Parent = this.txtprecio;
            this.txtprecio.Location = new System.Drawing.Point(457, 51);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(5);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.PasswordChar = '\0';
            this.txtprecio.PlaceholderText = "Precio";
            this.txtprecio.SelectedText = "";
            this.txtprecio.ShadowDecoration.Parent = this.txtprecio;
            this.txtprecio.Size = new System.Drawing.Size(106, 31);
            this.txtprecio.TabIndex = 176;
            this.txtprecio.TextChanged += new System.EventHandler(this.txtprecio_TextChanged);
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
            this.buscarproducto.Location = new System.Drawing.Point(209, 48);
            this.buscarproducto.Name = "buscarproducto";
            this.buscarproducto.ShadowDecoration.Parent = this.buscarproducto;
            this.buscarproducto.Size = new System.Drawing.Size(41, 33);
            this.buscarproducto.TabIndex = 175;
            this.buscarproducto.Click += new System.EventHandler(this.buscarproducto_Click_1);
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
            this.txtcodproducto.Location = new System.Drawing.Point(5, 51);
            this.txtcodproducto.Margin = new System.Windows.Forms.Padding(5);
            this.txtcodproducto.Name = "txtcodproducto";
            this.txtcodproducto.PasswordChar = '\0';
            this.txtcodproducto.PlaceholderText = "Cod. Producto";
            this.txtcodproducto.SelectedText = "";
            this.txtcodproducto.ShadowDecoration.Parent = this.txtcodproducto;
            this.txtcodproducto.Size = new System.Drawing.Size(196, 30);
            this.txtcodproducto.TabIndex = 174;
            this.txtcodproducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodproducto_KeyDown_1);
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(860, 54);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(26, 23);
            this.txtidproducto.TabIndex = 101;
            this.txtidproducto.Text = "0";
            this.txtidproducto.Visible = false;
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
            this.btnagregarproducto.Location = new System.Drawing.Point(939, 151);
            this.btnagregarproducto.Name = "btnagregarproducto";
            this.btnagregarproducto.ShadowDecoration.Parent = this.btnagregarproducto;
            this.btnagregarproducto.Size = new System.Drawing.Size(94, 87);
            this.btnagregarproducto.TabIndex = 178;
            this.btnagregarproducto.Click += new System.EventHandler(this.btnagregarproducto_Click_1);
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            this.dgvdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvdata.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dgvdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvdata.ColumnHeadersHeight = 50;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.SubTotal,
            this.btneliminar});
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.DefaultCellStyle = dataGridViewCellStyle29;
            this.dgvdata.DoubleBuffered = true;
            this.dgvdata.EnableHeadersVisualStyles = false;
            this.dgvdata.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dgvdata.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.dgvdata.HeaderForeColor = System.Drawing.Color.White;
            this.dgvdata.Location = new System.Drawing.Point(34, 244);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvdata.RowHeadersVisible = false;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.White;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvdata.RowTemplate.DividerHeight = 1;
            this.dgvdata.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.Size = new System.Drawing.Size(899, 572);
            this.dgvdata.TabIndex = 179;
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
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 150;
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
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btneliminar.DefaultCellStyle = dataGridViewCellStyle28;
            this.btneliminar.FillWeight = 57.07051F;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneliminar.HeaderText = "";
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btneliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btneliminar.Width = 25;
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
            this.txttotalpagar.Location = new System.Drawing.Point(939, 621);
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.PasswordChar = '\0';
            this.txttotalpagar.PlaceholderText = "";
            this.txttotalpagar.SelectedText = "";
            this.txttotalpagar.ShadowDecoration.Parent = this.txttotalpagar;
            this.txttotalpagar.Size = new System.Drawing.Size(217, 36);
            this.txttotalpagar.TabIndex = 180;
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
            this.btnregistrar.Location = new System.Drawing.Point(939, 796);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.ShadowDecoration.Parent = this.btnregistrar;
            this.btnregistrar.Size = new System.Drawing.Size(217, 36);
            this.btnregistrar.TabIndex = 181;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(935, 598);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 182;
            this.label10.Text = "Total a pagar:";
            // 
            // txtpagocon
            // 
            this.txtpagocon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtpagocon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.txtpagocon.BorderThickness = 2;
            this.txtpagocon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpagocon.DefaultText = "";
            this.txtpagocon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpagocon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpagocon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpagocon.DisabledState.Parent = this.txtpagocon;
            this.txtpagocon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpagocon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtpagocon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpagocon.FocusedState.Parent = this.txtpagocon;
            this.txtpagocon.ForeColor = System.Drawing.Color.White;
            this.txtpagocon.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpagocon.HoveredState.Parent = this.txtpagocon;
            this.txtpagocon.Location = new System.Drawing.Point(939, 683);
            this.txtpagocon.Name = "txtpagocon";
            this.txtpagocon.PasswordChar = '\0';
            this.txtpagocon.PlaceholderText = "";
            this.txtpagocon.SelectedText = "";
            this.txtpagocon.ShadowDecoration.Parent = this.txtpagocon;
            this.txtpagocon.Size = new System.Drawing.Size(217, 36);
            this.txtpagocon.TabIndex = 183;
            this.txtpagocon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpagocon_KeyDown);
            this.txtpagocon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpagocon_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(935, 660);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 184;
            this.label5.Text = "Paga con:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(935, 722);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 185;
            this.label6.Text = "Cambio:";
            // 
            // txtcambio
            // 
            this.txtcambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtcambio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.txtcambio.BorderThickness = 2;
            this.txtcambio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcambio.DefaultText = "";
            this.txtcambio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcambio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcambio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcambio.DisabledState.Parent = this.txtcambio;
            this.txtcambio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcambio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtcambio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcambio.FocusedState.Parent = this.txtcambio;
            this.txtcambio.ForeColor = System.Drawing.Color.White;
            this.txtcambio.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcambio.HoveredState.Parent = this.txtcambio;
            this.txtcambio.Location = new System.Drawing.Point(939, 745);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.PasswordChar = '\0';
            this.txtcambio.PlaceholderText = "";
            this.txtcambio.SelectedText = "";
            this.txtcambio.ShadowDecoration.Parent = this.txtcambio;
            this.txtcambio.Size = new System.Drawing.Size(217, 36);
            this.txtcambio.TabIndex = 186;
            // 
            // siticoneGroupBox3
            // 
            this.siticoneGroupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.siticoneGroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.siticoneGroupBox3.BorderRadius = 2;
            this.siticoneGroupBox3.Controls.Add(this.label16);
            this.siticoneGroupBox3.Controls.Add(this.label15);
            this.siticoneGroupBox3.Controls.Add(this.label14);
            this.siticoneGroupBox3.Controls.Add(this.label12);
            this.siticoneGroupBox3.Controls.Add(this.txtidproducto);
            this.siticoneGroupBox3.Controls.Add(this.txtcantidad);
            this.siticoneGroupBox3.Controls.Add(this.label7);
            this.siticoneGroupBox3.Controls.Add(this.label4);
            this.siticoneGroupBox3.Controls.Add(this.txtprecio);
            this.siticoneGroupBox3.Controls.Add(this.txtstock);
            this.siticoneGroupBox3.Controls.Add(this.txtcodproducto);
            this.siticoneGroupBox3.Controls.Add(this.txtproducto);
            this.siticoneGroupBox3.Controls.Add(this.buscarproducto);
            this.siticoneGroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.siticoneGroupBox3.CustomBorderThickness = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.siticoneGroupBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.siticoneGroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox3.ForeColor = System.Drawing.Color.White;
            this.siticoneGroupBox3.Location = new System.Drawing.Point(34, 149);
            this.siticoneGroupBox3.Name = "siticoneGroupBox3";
            this.siticoneGroupBox3.ShadowDecoration.Parent = this.siticoneGroupBox3;
            this.siticoneGroupBox3.Size = new System.Drawing.Size(899, 89);
            this.siticoneGroupBox3.TabIndex = 202;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(10, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 15);
            this.label7.TabIndex = 195;
            this.label7.Text = "Informacion del Producto:";
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
            this.txtfecha.Location = new System.Drawing.Point(21, 47);
            this.txtfecha.Margin = new System.Windows.Forms.Padding(5);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.PasswordChar = '\0';
            this.txtfecha.PlaceholderText = "";
            this.txtfecha.SelectedText = "";
            this.txtfecha.ShadowDecoration.Parent = this.txtfecha;
            this.txtfecha.Size = new System.Drawing.Size(180, 33);
            this.txtfecha.TabIndex = 173;
            // 
            // siticoneGroupBox1
            // 
            this.siticoneGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.siticoneGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.siticoneGroupBox1.BorderRadius = 2;
            this.siticoneGroupBox1.Controls.Add(this.label2);
            this.siticoneGroupBox1.Controls.Add(this.label3);
            this.siticoneGroupBox1.Controls.Add(this.label9);
            this.siticoneGroupBox1.Controls.Add(this.cbotipodocumento);
            this.siticoneGroupBox1.Controls.Add(this.txtfecha);
            this.siticoneGroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.siticoneGroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.siticoneGroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.siticoneGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox1.ForeColor = System.Drawing.Color.White;
            this.siticoneGroupBox1.Location = new System.Drawing.Point(34, 49);
            this.siticoneGroupBox1.Name = "siticoneGroupBox1";
            this.siticoneGroupBox1.ShadowDecoration.Parent = this.siticoneGroupBox1;
            this.siticoneGroupBox1.Size = new System.Drawing.Size(482, 89);
            this.siticoneGroupBox1.TabIndex = 200;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(10, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 15);
            this.label9.TabIndex = 195;
            this.label9.Text = "Informacion Compra:";
            // 
            // siticoneGroupBox2
            // 
            this.siticoneGroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.siticoneGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.siticoneGroupBox2.BorderRadius = 2;
            this.siticoneGroupBox2.Controls.Add(this.label11);
            this.siticoneGroupBox2.Controls.Add(this.label13);
            this.siticoneGroupBox2.Controls.Add(this.txtidcliente);
            this.siticoneGroupBox2.Controls.Add(this.txtnombrecliente);
            this.siticoneGroupBox2.Controls.Add(this.label8);
            this.siticoneGroupBox2.Controls.Add(this.txtdocumentocliente);
            this.siticoneGroupBox2.Controls.Add(this.btnbuscarclick);
            this.siticoneGroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.siticoneGroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.siticoneGroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.siticoneGroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox2.ForeColor = System.Drawing.Color.White;
            this.siticoneGroupBox2.Location = new System.Drawing.Point(525, 49);
            this.siticoneGroupBox2.Name = "siticoneGroupBox2";
            this.siticoneGroupBox2.ShadowDecoration.Parent = this.siticoneGroupBox2;
            this.siticoneGroupBox2.Size = new System.Drawing.Size(508, 89);
            this.siticoneGroupBox2.TabIndex = 203;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(10, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 15);
            this.label8.TabIndex = 195;
            this.label8.Text = "Informacion Cliente:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 15);
            this.label13.TabIndex = 204;
            this.label13.Text = "Nro Documento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(242, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 15);
            this.label11.TabIndex = 205;
            this.label11.Text = "Nombre Cliente:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(570, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 196;
            this.label12.Text = "Stock:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(454, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 16);
            this.label14.TabIndex = 197;
            this.label14.Text = "Precio:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(255, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 16);
            this.label15.TabIndex = 198;
            this.label15.Text = "Producto:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(2, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 16);
            this.label16.TabIndex = 199;
            this.label16.Text = "Cod Producto:";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1888, 852);
            this.Controls.Add(this.siticoneGroupBox2);
            this.Controls.Add(this.siticoneGroupBox1);
            this.Controls.Add(this.siticoneGroupBox3);
            this.Controls.Add(this.txtcambio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpagocon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.txttotalpagar);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.btnagregarproducto);
            this.Controls.Add(this.label1);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.siticoneGroupBox3.ResumeLayout(false);
            this.siticoneGroupBox3.PerformLayout();
            this.siticoneGroupBox1.ResumeLayout(false);
            this.siticoneGroupBox1.PerformLayout();
            this.siticoneGroupBox2.ResumeLayout(false);
            this.siticoneGroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Siticone.UI.WinForms.SiticoneRoundedComboBox cbotipodocumento;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtnombrecliente;
        private System.Windows.Forms.TextBox txtidcliente;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtdocumentocliente;
        private Siticone.UI.WinForms.SiticoneRoundedButton btnbuscarclick;
        private Siticone.UI.WinForms.SiticoneRoundedNumericUpDown txtcantidad;
        private System.Windows.Forms.Label label4;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtstock;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtproducto;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtprecio;
        private Siticone.UI.WinForms.SiticoneRoundedButton buscarproducto;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtcodproducto;
        private System.Windows.Forms.TextBox txtidproducto;
        private Siticone.UI.WinForms.SiticoneRoundedButton btnagregarproducto;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txttotalpagar;
        private Siticone.UI.WinForms.SiticoneRoundedButton btnregistrar;
        private System.Windows.Forms.Label label10;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtpagocon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtcambio;
        private Siticone.UI.WinForms.SiticoneGroupBox siticoneGroupBox3;
        private System.Windows.Forms.Label label7;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtfecha;
        private Siticone.UI.WinForms.SiticoneGroupBox siticoneGroupBox1;
        private System.Windows.Forms.Label label9;
        private Siticone.UI.WinForms.SiticoneGroupBox siticoneGroupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
    }
}