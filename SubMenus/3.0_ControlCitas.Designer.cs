
namespace ThootDentist
{
    partial class Form_AgendarCita
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AgendarCita));
            this.PanelUp = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtBox_Buscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Foto = new System.Windows.Forms.PictureBox();
            this.Lbl_Nombre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Lbl_Genero = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Lbl_Edad = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Lbl_NumeroCelular = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Lbl_Correo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.DataGridCitas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Btn_TomarFoto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_ReagendarCita = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelUp.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelUp
            // 
            this.PanelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.PanelUp.Controls.Add(this.panel1);
            this.PanelUp.Controls.Add(this.Title);
            this.PanelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUp.Location = new System.Drawing.Point(0, 0);
            this.PanelUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelUp.Name = "PanelUp";
            this.PanelUp.Size = new System.Drawing.Size(982, 35);
            this.PanelUp.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 35);
            this.panel1.TabIndex = 1;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(4, 5);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(161, 30);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Control de Citas";
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
            // TxtBox_Buscar
            // 
            this.TxtBox_Buscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBox_Buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtBox_Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBox_Buscar.HintForeColor = System.Drawing.Color.Empty;
            this.TxtBox_Buscar.HintText = "";
            this.TxtBox_Buscar.isPassword = false;
            this.TxtBox_Buscar.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(44)))));
            this.TxtBox_Buscar.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtBox_Buscar.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(128)))), ((int)(((byte)(121)))));
            this.TxtBox_Buscar.LineThickness = 3;
            this.TxtBox_Buscar.Location = new System.Drawing.Point(9, 44);
            this.TxtBox_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_Buscar.Name = "TxtBox_Buscar";
            this.TxtBox_Buscar.Size = new System.Drawing.Size(370, 44);
            this.TxtBox_Buscar.TabIndex = 3;
            this.TxtBox_Buscar.Text = "Buscar";
            this.TxtBox_Buscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtBox_Buscar.OnValueChanged += new System.EventHandler(this.TxtBox_Buscar_OnValueChanged);
            // 
            // Foto
            // 
            this.Foto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Foto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Foto.Location = new System.Drawing.Point(686, 42);
            this.Foto.Name = "Foto";
            this.Foto.Size = new System.Drawing.Size(284, 160);
            this.Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Foto.TabIndex = 5;
            this.Foto.TabStop = false;
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre.Location = new System.Drawing.Point(487, 42);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(0, 17);
            this.Lbl_Nombre.TabIndex = 6;
            // 
            // Lbl_Genero
            // 
            this.Lbl_Genero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Genero.AutoSize = true;
            this.Lbl_Genero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Genero.Location = new System.Drawing.Point(487, 69);
            this.Lbl_Genero.Name = "Lbl_Genero";
            this.Lbl_Genero.Size = new System.Drawing.Size(54, 17);
            this.Lbl_Genero.TabIndex = 7;
            this.Lbl_Genero.Text = "Genero:";
            // 
            // Lbl_Edad
            // 
            this.Lbl_Edad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Edad.AutoSize = true;
            this.Lbl_Edad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Edad.Location = new System.Drawing.Point(592, 69);
            this.Lbl_Edad.Name = "Lbl_Edad";
            this.Lbl_Edad.Size = new System.Drawing.Size(41, 17);
            this.Lbl_Edad.TabIndex = 8;
            this.Lbl_Edad.Text = "Edad:";
            // 
            // Lbl_NumeroCelular
            // 
            this.Lbl_NumeroCelular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_NumeroCelular.AutoSize = true;
            this.Lbl_NumeroCelular.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NumeroCelular.Location = new System.Drawing.Point(487, 93);
            this.Lbl_NumeroCelular.Name = "Lbl_NumeroCelular";
            this.Lbl_NumeroCelular.Size = new System.Drawing.Size(61, 17);
            this.Lbl_NumeroCelular.TabIndex = 9;
            this.Lbl_NumeroCelular.Text = "Telefono:";
            // 
            // Lbl_Correo
            // 
            this.Lbl_Correo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Correo.AutoSize = true;
            this.Lbl_Correo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Correo.Location = new System.Drawing.Point(487, 123);
            this.Lbl_Correo.Name = "Lbl_Correo";
            this.Lbl_Correo.Size = new System.Drawing.Size(0, 17);
            this.Lbl_Correo.TabIndex = 10;
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(91)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(128)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.DoubleBuffered = true;
            this.DataGrid.EnableHeadersVisualStyles = false;
            this.DataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(91)))), ((int)(((byte)(86)))));
            this.DataGrid.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.DataGrid.Location = new System.Drawing.Point(12, 95);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.Size = new System.Drawing.Size(367, 475);
            this.DataGrid.TabIndex = 15;
            this.DataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellDoubleClick);
            // 
            // DataGridCitas
            // 
            this.DataGridCitas.AllowUserToAddRows = false;
            this.DataGridCitas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridCitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridCitas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridCitas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridCitas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGridCitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridCitas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(91)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(128)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCitas.DoubleBuffered = true;
            this.DataGridCitas.EnableHeadersVisualStyles = false;
            this.DataGridCitas.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(91)))), ((int)(((byte)(86)))));
            this.DataGridCitas.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.DataGridCitas.Location = new System.Drawing.Point(386, 209);
            this.DataGridCitas.Name = "DataGridCitas";
            this.DataGridCitas.ReadOnly = true;
            this.DataGridCitas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridCitas.RowHeadersVisible = false;
            this.DataGridCitas.Size = new System.Drawing.Size(584, 361);
            this.DataGridCitas.TabIndex = 20;
            // 
            // Btn_TomarFoto
            // 
            this.Btn_TomarFoto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_TomarFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_TomarFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(128)))), ((int)(((byte)(121)))));
            this.Btn_TomarFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_TomarFoto.BorderRadius = 5;
            this.Btn_TomarFoto.ButtonText = "Agendar Cita";
            this.Btn_TomarFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_TomarFoto.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_TomarFoto.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_TomarFoto.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_TomarFoto.Iconimage")));
            this.Btn_TomarFoto.Iconimage_right = null;
            this.Btn_TomarFoto.Iconimage_right_Selected = null;
            this.Btn_TomarFoto.Iconimage_Selected = null;
            this.Btn_TomarFoto.IconMarginLeft = 15;
            this.Btn_TomarFoto.IconMarginRight = 0;
            this.Btn_TomarFoto.IconRightVisible = true;
            this.Btn_TomarFoto.IconRightZoom = 0D;
            this.Btn_TomarFoto.IconVisible = true;
            this.Btn_TomarFoto.IconZoom = 100D;
            this.Btn_TomarFoto.IsTab = false;
            this.Btn_TomarFoto.Location = new System.Drawing.Point(536, 154);
            this.Btn_TomarFoto.Name = "Btn_TomarFoto";
            this.Btn_TomarFoto.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(128)))), ((int)(((byte)(121)))));
            this.Btn_TomarFoto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_TomarFoto.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_TomarFoto.selected = false;
            this.Btn_TomarFoto.Size = new System.Drawing.Size(144, 48);
            this.Btn_TomarFoto.TabIndex = 23;
            this.Btn_TomarFoto.Text = "Agendar Cita";
            this.Btn_TomarFoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_TomarFoto.Textcolor = System.Drawing.Color.White;
            this.Btn_TomarFoto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TomarFoto.Click += new System.EventHandler(this.Btn_AgendarCita_Click);
            // 
            // Btn_ReagendarCita
            // 
            this.Btn_ReagendarCita.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_ReagendarCita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ReagendarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(128)))), ((int)(((byte)(121)))));
            this.Btn_ReagendarCita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_ReagendarCita.BorderRadius = 5;
            this.Btn_ReagendarCita.ButtonText = "Reagendar Cita";
            this.Btn_ReagendarCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ReagendarCita.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_ReagendarCita.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_ReagendarCita.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_ReagendarCita.Iconimage")));
            this.Btn_ReagendarCita.Iconimage_right = null;
            this.Btn_ReagendarCita.Iconimage_right_Selected = null;
            this.Btn_ReagendarCita.Iconimage_Selected = null;
            this.Btn_ReagendarCita.IconMarginLeft = 15;
            this.Btn_ReagendarCita.IconMarginRight = 0;
            this.Btn_ReagendarCita.IconRightVisible = true;
            this.Btn_ReagendarCita.IconRightZoom = 0D;
            this.Btn_ReagendarCita.IconVisible = true;
            this.Btn_ReagendarCita.IconZoom = 100D;
            this.Btn_ReagendarCita.IsTab = false;
            this.Btn_ReagendarCita.Location = new System.Drawing.Point(386, 155);
            this.Btn_ReagendarCita.Name = "Btn_ReagendarCita";
            this.Btn_ReagendarCita.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(128)))), ((int)(((byte)(121)))));
            this.Btn_ReagendarCita.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_ReagendarCita.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_ReagendarCita.selected = false;
            this.Btn_ReagendarCita.Size = new System.Drawing.Size(144, 48);
            this.Btn_ReagendarCita.TabIndex = 24;
            this.Btn_ReagendarCita.Text = "Reagendar Cita";
            this.Btn_ReagendarCita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ReagendarCita.Textcolor = System.Drawing.Color.White;
            this.Btn_ReagendarCita.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ReagendarCita.Click += new System.EventHandler(this.Btn_ReagendarCita_Click);
            // 
            // Form_AgendarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 582);
            this.Controls.Add(this.Btn_ReagendarCita);
            this.Controls.Add(this.Btn_TomarFoto);
            this.Controls.Add(this.DataGridCitas);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.Lbl_Correo);
            this.Controls.Add(this.Lbl_NumeroCelular);
            this.Controls.Add(this.Lbl_Edad);
            this.Controls.Add(this.Lbl_Genero);
            this.Controls.Add(this.Lbl_Nombre);
            this.Controls.Add(this.Foto);
            this.Controls.Add(this.TxtBox_Buscar);
            this.Controls.Add(this.PanelUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AgendarCita";
            this.Text = "AgendarCita";
            this.PanelUp.ResumeLayout(false);
            this.PanelUp.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelUp;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel Title;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtBox_Buscar;
        private System.Windows.Forms.PictureBox Foto;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbl_Nombre;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbl_Genero;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbl_Edad;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbl_NumeroCelular;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbl_Correo;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridCitas;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_TomarFoto;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_ReagendarCita;
    }
}