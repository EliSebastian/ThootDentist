
namespace ThootDentist
{
    partial class LogIn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.Up = new System.Windows.Forms.Panel();
            this.BtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Lbl_ErrorUsuario = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Lbl_ErrorContraseña = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtBx_Contraseña = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtBx_Usuario = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Up.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Up
            // 
            this.Up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(128)))), ((int)(((byte)(121)))));
            this.Up.Controls.Add(this.BtnClose);
            this.Up.Controls.Add(this.pictureBox1);
            this.Up.Controls.Add(this.label1);
            this.Up.Dock = System.Windows.Forms.DockStyle.Top;
            this.Up.Location = new System.Drawing.Point(0, 0);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(452, 73);
            this.Up.TabIndex = 0;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = ((System.Drawing.Image)(resources.GetObject("BtnClose.ImageActive")));
            this.BtnClose.Location = new System.Drawing.Point(419, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 30);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClose.TabIndex = 0;
            this.BtnClose.TabStop = false;
            this.BtnClose.Zoom = 5;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(109, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(128)))), ((int)(((byte)(121)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 60);
            this.panel1.TabIndex = 1;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(112)))), ((int)(((byte)(22)))));
            this.BtnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLogin.BorderRadius = 0;
            this.BtnLogin.ButtonText = "Iniciar Sesion";
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.DisabledColor = System.Drawing.Color.Gray;
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnLogin.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnLogin.Iconimage")));
            this.BtnLogin.Iconimage_right = null;
            this.BtnLogin.Iconimage_right_Selected = null;
            this.BtnLogin.Iconimage_Selected = null;
            this.BtnLogin.IconMarginLeft = 0;
            this.BtnLogin.IconMarginRight = 0;
            this.BtnLogin.IconRightVisible = true;
            this.BtnLogin.IconRightZoom = 0D;
            this.BtnLogin.IconVisible = true;
            this.BtnLogin.IconZoom = 90D;
            this.BtnLogin.IsTab = false;
            this.BtnLogin.Location = new System.Drawing.Point(153, 291);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(112)))), ((int)(((byte)(22)))));
            this.BtnLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(74)))), ((int)(((byte)(14)))));
            this.BtnLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnLogin.selected = false;
            this.BtnLogin.Size = new System.Drawing.Size(154, 48);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Iniciar Sesion";
            this.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogin.Textcolor = System.Drawing.Color.White;
            this.BtnLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // Lbl_ErrorUsuario
            // 
            this.Lbl_ErrorUsuario.AutoSize = true;
            this.Lbl_ErrorUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ErrorUsuario.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbl_ErrorUsuario.Location = new System.Drawing.Point(140, 113);
            this.Lbl_ErrorUsuario.Name = "Lbl_ErrorUsuario";
            this.Lbl_ErrorUsuario.Size = new System.Drawing.Size(40, 15);
            this.Lbl_ErrorUsuario.TabIndex = 4;
            this.Lbl_ErrorUsuario.Text = "Error 1";
            // 
            // Lbl_ErrorContraseña
            // 
            this.Lbl_ErrorContraseña.AutoSize = true;
            this.Lbl_ErrorContraseña.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ErrorContraseña.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbl_ErrorContraseña.Location = new System.Drawing.Point(175, 214);
            this.Lbl_ErrorContraseña.Name = "Lbl_ErrorContraseña";
            this.Lbl_ErrorContraseña.Size = new System.Drawing.Size(40, 15);
            this.Lbl_ErrorContraseña.TabIndex = 5;
            this.Lbl_ErrorContraseña.Text = "Error 2";
            // 
            // TxtBx_Contraseña
            // 
            this.TxtBx_Contraseña.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(91)))), ((int)(((byte)(86)))));
            this.TxtBx_Contraseña.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(157)))));
            this.TxtBx_Contraseña.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(128)))), ((int)(((byte)(121)))));
            this.TxtBx_Contraseña.BorderThickness = 2;
            this.TxtBx_Contraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBx_Contraseña.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_Contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBx_Contraseña.isPassword = true;
            this.TxtBx_Contraseña.Location = new System.Drawing.Point(45, 234);
            this.TxtBx_Contraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBx_Contraseña.Name = "TxtBx_Contraseña";
            this.TxtBx_Contraseña.Size = new System.Drawing.Size(371, 36);
            this.TxtBx_Contraseña.TabIndex = 2;
            this.TxtBx_Contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(46, 199);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(123, 30);
            this.bunifuCustomLabel1.TabIndex = 11;
            this.bunifuCustomLabel1.Text = "Contraseña";
            // 
            // TxtBx_Usuario
            // 
            this.TxtBx_Usuario.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(91)))), ((int)(((byte)(86)))));
            this.TxtBx_Usuario.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(157)))));
            this.TxtBx_Usuario.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(128)))), ((int)(((byte)(121)))));
            this.TxtBx_Usuario.BorderThickness = 2;
            this.TxtBx_Usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBx_Usuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBx_Usuario.isPassword = false;
            this.TxtBx_Usuario.Location = new System.Drawing.Point(45, 130);
            this.TxtBx_Usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBx_Usuario.Name = "TxtBx_Usuario";
            this.TxtBx_Usuario.Size = new System.Drawing.Size(371, 36);
            this.TxtBx_Usuario.TabIndex = 1;
            this.TxtBx_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(46, 98);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(88, 30);
            this.bunifuCustomLabel2.TabIndex = 13;
            this.bunifuCustomLabel2.Text = "Usuario";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Up;
            this.bunifuDragControl1.Vertical = true;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 438);
            this.ControlBox = false;
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.TxtBx_Usuario);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.TxtBx_Contraseña);
            this.Controls.Add(this.Lbl_ErrorContraseña);
            this.Controls.Add(this.Lbl_ErrorUsuario);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Up);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Up.ResumeLayout(false);
            this.Up.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Up;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        //private Bunifu.Framework.UI.BunifuTextbox TxtBx_Contraseña;
        //private Bunifu.Framework.UI.BunifuTextbox TxtBx_Usuario;
        private Bunifu.Framework.UI.BunifuFlatButton BtnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton BtnClose;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbl_ErrorUsuario;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbl_ErrorContraseña;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtBx_Contraseña;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtBx_Usuario;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

