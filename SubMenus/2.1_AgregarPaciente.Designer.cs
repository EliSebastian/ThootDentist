
namespace ThootDentist
{
    partial class AgregarPaciente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarPaciente));
            this.PanelUp = new System.Windows.Forms.Panel();
            this.Btn_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxBox_Nombres = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CmBox_Genero = new System.Windows.Forms.ComboBox();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Tx_Telefono = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtBox_Correo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxBox_ApellidoPa = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxBox_ApellidoMa = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.PictBox_Foto = new System.Windows.Forms.PictureBox();
            this.Btn_TomarFoto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Guardar = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Lbl_ErrorNombre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Lbl_ErrorApellidoP = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Lbl_ErrorApellidoM = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Lbl_ErrorGenero = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Lbl_ErrorTelefono = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Lbl_ErrorCorreo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Lbl_ErrorCalendario = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CmBox_Dispositivos = new System.Windows.Forms.ComboBox();
            this.Btn_EncenderCamara = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictBox_Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelUp
            // 
            this.PanelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.PanelUp.Controls.Add(this.Btn_Close);
            this.PanelUp.Controls.Add(this.Title);
            this.PanelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUp.Location = new System.Drawing.Point(0, 0);
            this.PanelUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelUp.Name = "PanelUp";
            this.PanelUp.Size = new System.Drawing.Size(982, 35);
            this.PanelUp.TabIndex = 1;
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Close.Image")));
            this.Btn_Close.ImageActive = ((System.Drawing.Image)(resources.GetObject("Btn_Close.ImageActive")));
            this.Btn_Close.Location = new System.Drawing.Point(949, 3);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(30, 30);
            this.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Close.TabIndex = 24;
            this.Btn_Close.TabStop = false;
            this.Btn_Close.Zoom = 5;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.Title.Location = new System.Drawing.Point(4, 5);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(203, 30);
            this.Title.TabIndex = 0;
            this.Title.Text = "Control de Pacientes";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(68, 49);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(253, 40);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Agregar Paciente";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(70, 113);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(113, 25);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Nombre(s):";
            // 
            // TxBox_Nombres
            // 
            this.TxBox_Nombres.BackColor = System.Drawing.SystemColors.Window;
            this.TxBox_Nombres.BorderColorFocused = System.Drawing.Color.Blue;
            this.TxBox_Nombres.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxBox_Nombres.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TxBox_Nombres.BorderThickness = 1;
            this.TxBox_Nombres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxBox_Nombres.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxBox_Nombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxBox_Nombres.isPassword = false;
            this.TxBox_Nombres.Location = new System.Drawing.Point(75, 142);
            this.TxBox_Nombres.Margin = new System.Windows.Forms.Padding(4);
            this.TxBox_Nombres.Name = "TxBox_Nombres";
            this.TxBox_Nombres.Size = new System.Drawing.Size(512, 25);
            this.TxBox_Nombres.TabIndex = 1;
            this.TxBox_Nombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxBox_Nombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxBox_Nombres_KeyPress);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(70, 236);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(83, 25);
            this.bunifuCustomLabel3.TabIndex = 6;
            this.bunifuCustomLabel3.Text = "Genero:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(334, 236);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(196, 25);
            this.bunifuCustomLabel4.TabIndex = 7;
            this.bunifuCustomLabel4.Text = "Fecha de Nacimiento";
            // 
            // CmBox_Genero
            // 
            this.CmBox_Genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmBox_Genero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmBox_Genero.FormattingEnabled = true;
            this.CmBox_Genero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.CmBox_Genero.Location = new System.Drawing.Point(75, 264);
            this.CmBox_Genero.Name = "CmBox_Genero";
            this.CmBox_Genero.Size = new System.Drawing.Size(142, 25);
            this.CmBox_Genero.TabIndex = 4;
            // 
            // Calendario
            // 
            this.Calendario.BackColor = System.Drawing.SystemColors.Control;
            this.Calendario.Location = new System.Drawing.Point(339, 292);
            this.Calendario.MaxSelectionCount = 1;
            this.Calendario.Name = "Calendario";
            this.Calendario.ShowToday = false;
            this.Calendario.TabIndex = 6;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(70, 310);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(94, 25);
            this.bunifuCustomLabel6.TabIndex = 12;
            this.bunifuCustomLabel6.Text = "Telefono:";
            // 
            // Tx_Telefono
            // 
            this.Tx_Telefono.BackColor = System.Drawing.SystemColors.Window;
            this.Tx_Telefono.BorderColorFocused = System.Drawing.Color.Blue;
            this.Tx_Telefono.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tx_Telefono.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Tx_Telefono.BorderThickness = 1;
            this.Tx_Telefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tx_Telefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_Telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tx_Telefono.isPassword = false;
            this.Tx_Telefono.Location = new System.Drawing.Point(75, 339);
            this.Tx_Telefono.Margin = new System.Windows.Forms.Padding(4);
            this.Tx_Telefono.Name = "Tx_Telefono";
            this.Tx_Telefono.Size = new System.Drawing.Size(252, 25);
            this.Tx_Telefono.TabIndex = 5;
            this.Tx_Telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Tx_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tx_Telefono_KeyPress);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(70, 438);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(178, 25);
            this.bunifuCustomLabel7.TabIndex = 14;
            this.bunifuCustomLabel7.Text = "Correo electronico";
            // 
            // TxtBox_Correo
            // 
            this.TxtBox_Correo.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBox_Correo.BorderColorFocused = System.Drawing.Color.Blue;
            this.TxtBox_Correo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBox_Correo.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TxtBox_Correo.BorderThickness = 1;
            this.TxtBox_Correo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBox_Correo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBox_Correo.isPassword = false;
            this.TxtBox_Correo.Location = new System.Drawing.Point(75, 476);
            this.TxtBox_Correo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_Correo.Name = "TxtBox_Correo";
            this.TxtBox_Correo.Size = new System.Drawing.Size(512, 25);
            this.TxtBox_Correo.TabIndex = 7;
            this.TxtBox_Correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtBox_Correo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBox_Correo_KeyPress);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(70, 171);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(167, 25);
            this.bunifuCustomLabel8.TabIndex = 16;
            this.bunifuCustomLabel8.Text = "Apellido Paterno:";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(334, 171);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(173, 25);
            this.bunifuCustomLabel9.TabIndex = 17;
            this.bunifuCustomLabel9.Text = "Apellido Materno:";
            // 
            // TxBox_ApellidoPa
            // 
            this.TxBox_ApellidoPa.BackColor = System.Drawing.SystemColors.Window;
            this.TxBox_ApellidoPa.BorderColorFocused = System.Drawing.Color.Blue;
            this.TxBox_ApellidoPa.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxBox_ApellidoPa.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TxBox_ApellidoPa.BorderThickness = 1;
            this.TxBox_ApellidoPa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxBox_ApellidoPa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxBox_ApellidoPa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxBox_ApellidoPa.isPassword = false;
            this.TxBox_ApellidoPa.Location = new System.Drawing.Point(75, 200);
            this.TxBox_ApellidoPa.Margin = new System.Windows.Forms.Padding(4);
            this.TxBox_ApellidoPa.Name = "TxBox_ApellidoPa";
            this.TxBox_ApellidoPa.Size = new System.Drawing.Size(250, 25);
            this.TxBox_ApellidoPa.TabIndex = 2;
            this.TxBox_ApellidoPa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxBox_ApellidoPa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxBox_Apellido_P_KeyPress);
            // 
            // TxBox_ApellidoMa
            // 
            this.TxBox_ApellidoMa.BackColor = System.Drawing.SystemColors.Window;
            this.TxBox_ApellidoMa.BorderColorFocused = System.Drawing.Color.Blue;
            this.TxBox_ApellidoMa.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxBox_ApellidoMa.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TxBox_ApellidoMa.BorderThickness = 1;
            this.TxBox_ApellidoMa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxBox_ApellidoMa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxBox_ApellidoMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxBox_ApellidoMa.isPassword = false;
            this.TxBox_ApellidoMa.Location = new System.Drawing.Point(337, 200);
            this.TxBox_ApellidoMa.Margin = new System.Windows.Forms.Padding(4);
            this.TxBox_ApellidoMa.Name = "TxBox_ApellidoMa";
            this.TxBox_ApellidoMa.Size = new System.Drawing.Size(250, 25);
            this.TxBox_ApellidoMa.TabIndex = 3;
            this.TxBox_ApellidoMa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxBox_ApellidoMa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxBox_Apellido_M_KeyPress);
            // 
            // PictBox_Foto
            // 
            this.PictBox_Foto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PictBox_Foto.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictBox_Foto.InitialImage")));
            this.PictBox_Foto.Location = new System.Drawing.Point(629, 123);
            this.PictBox_Foto.Name = "PictBox_Foto";
            this.PictBox_Foto.Size = new System.Drawing.Size(320, 180);
            this.PictBox_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictBox_Foto.TabIndex = 21;
            this.PictBox_Foto.TabStop = false;
            // 
            // Btn_TomarFoto
            // 
            this.Btn_TomarFoto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_TomarFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(128)))), ((int)(((byte)(121)))));
            this.Btn_TomarFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_TomarFoto.BorderRadius = 5;
            this.Btn_TomarFoto.ButtonText = "Tomar Foto";
            this.Btn_TomarFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_TomarFoto.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_TomarFoto.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_TomarFoto.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_TomarFoto.Iconimage")));
            this.Btn_TomarFoto.Iconimage_right = null;
            this.Btn_TomarFoto.Iconimage_right_Selected = null;
            this.Btn_TomarFoto.Iconimage_Selected = null;
            this.Btn_TomarFoto.IconMarginLeft = 30;
            this.Btn_TomarFoto.IconMarginRight = 0;
            this.Btn_TomarFoto.IconRightVisible = true;
            this.Btn_TomarFoto.IconRightZoom = 0D;
            this.Btn_TomarFoto.IconVisible = true;
            this.Btn_TomarFoto.IconZoom = 80D;
            this.Btn_TomarFoto.IsTab = false;
            this.Btn_TomarFoto.Location = new System.Drawing.Point(817, 310);
            this.Btn_TomarFoto.Name = "Btn_TomarFoto";
            this.Btn_TomarFoto.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(128)))), ((int)(((byte)(121)))));
            this.Btn_TomarFoto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_TomarFoto.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_TomarFoto.selected = false;
            this.Btn_TomarFoto.Size = new System.Drawing.Size(132, 48);
            this.Btn_TomarFoto.TabIndex = 22;
            this.Btn_TomarFoto.Text = "Tomar Foto";
            this.Btn_TomarFoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_TomarFoto.Textcolor = System.Drawing.Color.White;
            this.Btn_TomarFoto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TomarFoto.Click += new System.EventHandler(this.Btn_TomarFoto_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(128)))), ((int)(((byte)(121)))));
            this.Btn_Guardar.color = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(128)))), ((int)(((byte)(121)))));
            this.Btn_Guardar.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.Btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Guardar.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.ImagePosition = 20;
            this.Btn_Guardar.ImageZoom = 45;
            this.Btn_Guardar.LabelPosition = 41;
            this.Btn_Guardar.LabelText = "Guardar";
            this.Btn_Guardar.Location = new System.Drawing.Point(839, 438);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(128, 129);
            this.Btn_Guardar.TabIndex = 23;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PanelUp;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Lbl_ErrorNombre
            // 
            this.Lbl_ErrorNombre.AutoSize = true;
            this.Lbl_ErrorNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ErrorNombre.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbl_ErrorNombre.Location = new System.Drawing.Point(189, 123);
            this.Lbl_ErrorNombre.Name = "Lbl_ErrorNombre";
            this.Lbl_ErrorNombre.Size = new System.Drawing.Size(40, 15);
            this.Lbl_ErrorNombre.TabIndex = 24;
            this.Lbl_ErrorNombre.Text = "Error 1";
            // 
            // Lbl_ErrorApellidoP
            // 
            this.Lbl_ErrorApellidoP.AutoSize = true;
            this.Lbl_ErrorApellidoP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ErrorApellidoP.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbl_ErrorApellidoP.Location = new System.Drawing.Point(243, 181);
            this.Lbl_ErrorApellidoP.Name = "Lbl_ErrorApellidoP";
            this.Lbl_ErrorApellidoP.Size = new System.Drawing.Size(40, 15);
            this.Lbl_ErrorApellidoP.TabIndex = 25;
            this.Lbl_ErrorApellidoP.Text = "Error 1";
            // 
            // Lbl_ErrorApellidoM
            // 
            this.Lbl_ErrorApellidoM.AutoSize = true;
            this.Lbl_ErrorApellidoM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ErrorApellidoM.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbl_ErrorApellidoM.Location = new System.Drawing.Point(513, 181);
            this.Lbl_ErrorApellidoM.Name = "Lbl_ErrorApellidoM";
            this.Lbl_ErrorApellidoM.Size = new System.Drawing.Size(40, 15);
            this.Lbl_ErrorApellidoM.TabIndex = 26;
            this.Lbl_ErrorApellidoM.Text = "Error 1";
            // 
            // Lbl_ErrorGenero
            // 
            this.Lbl_ErrorGenero.AutoSize = true;
            this.Lbl_ErrorGenero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ErrorGenero.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbl_ErrorGenero.Location = new System.Drawing.Point(159, 246);
            this.Lbl_ErrorGenero.Name = "Lbl_ErrorGenero";
            this.Lbl_ErrorGenero.Size = new System.Drawing.Size(40, 15);
            this.Lbl_ErrorGenero.TabIndex = 27;
            this.Lbl_ErrorGenero.Text = "Error 1";
            // 
            // Lbl_ErrorTelefono
            // 
            this.Lbl_ErrorTelefono.AutoSize = true;
            this.Lbl_ErrorTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ErrorTelefono.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbl_ErrorTelefono.Location = new System.Drawing.Point(167, 320);
            this.Lbl_ErrorTelefono.Name = "Lbl_ErrorTelefono";
            this.Lbl_ErrorTelefono.Size = new System.Drawing.Size(40, 15);
            this.Lbl_ErrorTelefono.TabIndex = 28;
            this.Lbl_ErrorTelefono.Text = "Error 1";
            // 
            // Lbl_ErrorCorreo
            // 
            this.Lbl_ErrorCorreo.AutoSize = true;
            this.Lbl_ErrorCorreo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ErrorCorreo.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbl_ErrorCorreo.Location = new System.Drawing.Point(254, 457);
            this.Lbl_ErrorCorreo.Name = "Lbl_ErrorCorreo";
            this.Lbl_ErrorCorreo.Size = new System.Drawing.Size(40, 15);
            this.Lbl_ErrorCorreo.TabIndex = 29;
            this.Lbl_ErrorCorreo.Text = "Error 1";
            // 
            // Lbl_ErrorCalendario
            // 
            this.Lbl_ErrorCalendario.AutoSize = true;
            this.Lbl_ErrorCalendario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ErrorCalendario.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbl_ErrorCalendario.Location = new System.Drawing.Point(336, 268);
            this.Lbl_ErrorCalendario.Name = "Lbl_ErrorCalendario";
            this.Lbl_ErrorCalendario.Size = new System.Drawing.Size(40, 15);
            this.Lbl_ErrorCalendario.TabIndex = 30;
            this.Lbl_ErrorCalendario.Text = "Error 1";
            // 
            // CmBox_Dispositivos
            // 
            this.CmBox_Dispositivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmBox_Dispositivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmBox_Dispositivos.FormattingEnabled = true;
            this.CmBox_Dispositivos.Location = new System.Drawing.Point(797, 82);
            this.CmBox_Dispositivos.Name = "CmBox_Dispositivos";
            this.CmBox_Dispositivos.Size = new System.Drawing.Size(173, 21);
            this.CmBox_Dispositivos.TabIndex = 32;
            // 
            // Btn_EncenderCamara
            // 
            this.Btn_EncenderCamara.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_EncenderCamara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(128)))), ((int)(((byte)(121)))));
            this.Btn_EncenderCamara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_EncenderCamara.BorderRadius = 5;
            this.Btn_EncenderCamara.ButtonText = "Encerder Camara";
            this.Btn_EncenderCamara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_EncenderCamara.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_EncenderCamara.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_EncenderCamara.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_EncenderCamara.Iconimage")));
            this.Btn_EncenderCamara.Iconimage_right = null;
            this.Btn_EncenderCamara.Iconimage_right_Selected = null;
            this.Btn_EncenderCamara.Iconimage_Selected = null;
            this.Btn_EncenderCamara.IconMarginLeft = 30;
            this.Btn_EncenderCamara.IconMarginRight = 0;
            this.Btn_EncenderCamara.IconRightVisible = true;
            this.Btn_EncenderCamara.IconRightZoom = 0D;
            this.Btn_EncenderCamara.IconVisible = true;
            this.Btn_EncenderCamara.IconZoom = 80D;
            this.Btn_EncenderCamara.IsTab = false;
            this.Btn_EncenderCamara.Location = new System.Drawing.Point(629, 69);
            this.Btn_EncenderCamara.Name = "Btn_EncenderCamara";
            this.Btn_EncenderCamara.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(128)))), ((int)(((byte)(121)))));
            this.Btn_EncenderCamara.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_EncenderCamara.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_EncenderCamara.selected = false;
            this.Btn_EncenderCamara.Size = new System.Drawing.Size(162, 48);
            this.Btn_EncenderCamara.TabIndex = 35;
            this.Btn_EncenderCamara.Text = "Encerder Camara";
            this.Btn_EncenderCamara.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_EncenderCamara.Textcolor = System.Drawing.Color.White;
            this.Btn_EncenderCamara.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EncenderCamara.Click += new System.EventHandler(this.Btn_IniciarCamara_Click);
            // 
            // AgregarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 582);
            this.Controls.Add(this.Btn_EncenderCamara);
            this.Controls.Add(this.CmBox_Dispositivos);
            this.Controls.Add(this.Lbl_ErrorCalendario);
            this.Controls.Add(this.Lbl_ErrorCorreo);
            this.Controls.Add(this.Lbl_ErrorTelefono);
            this.Controls.Add(this.Lbl_ErrorGenero);
            this.Controls.Add(this.Lbl_ErrorApellidoM);
            this.Controls.Add(this.Lbl_ErrorApellidoP);
            this.Controls.Add(this.Lbl_ErrorNombre);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_TomarFoto);
            this.Controls.Add(this.PictBox_Foto);
            this.Controls.Add(this.TxBox_ApellidoMa);
            this.Controls.Add(this.TxBox_ApellidoPa);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.TxtBox_Correo);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.Tx_Telefono);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.Calendario);
            this.Controls.Add(this.CmBox_Genero);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.TxBox_Nombres);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.PanelUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AgregarPaciente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarPaciente_FormClosing);
            this.Load += new System.EventHandler(this.AgregarPaciente_Load);
            this.PanelUp.ResumeLayout(false);
            this.PanelUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictBox_Foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelUp;
        private Bunifu.Framework.UI.BunifuCustomLabel Title;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxBox_Nombres;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.ComboBox CmBox_Genero;
        private System.Windows.Forms.MonthCalendar Calendario;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMetroTextbox Tx_Telefono;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtBox_Correo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxBox_ApellidoPa;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxBox_ApellidoMa;
        private System.Windows.Forms.PictureBox PictBox_Foto;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_TomarFoto;
        private Bunifu.Framework.UI.BunifuTileButton Btn_Guardar;
        private Bunifu.Framework.UI.BunifuImageButton Btn_Close;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbl_ErrorNombre;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbl_ErrorApellidoP;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbl_ErrorApellidoM;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbl_ErrorGenero;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbl_ErrorTelefono;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbl_ErrorCorreo;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbl_ErrorCalendario;
        private System.Windows.Forms.ComboBox CmBox_Dispositivos;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_EncenderCamara;
    }
}