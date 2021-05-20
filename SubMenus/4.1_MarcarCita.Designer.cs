
namespace ThootDentist
{
    partial class MarcarCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarcarCita));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Cmbox_Marca = new System.Windows.Forms.ComboBox();
            this.TxBox_Comentario = new System.Windows.Forms.TextBox();
            this.Btn_MarcarCita = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.Btn_Close);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 35);
            this.panel1.TabIndex = 3;
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Close.Image")));
            this.Btn_Close.ImageActive = ((System.Drawing.Image)(resources.GetObject("Btn_Close.ImageActive")));
            this.Btn_Close.Location = new System.Drawing.Point(469, 3);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(30, 30);
            this.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Close.TabIndex = 10;
            this.Btn_Close.TabStop = false;
            this.Btn_Close.Zoom = 5;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(4, 5);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(120, 30);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Marcar Cita";
            // 
            // Cmbox_Marca
            // 
            this.Cmbox_Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbox_Marca.FormattingEnabled = true;
            this.Cmbox_Marca.Items.AddRange(new object[] {
            "Pendiente",
            "Realizada",
            "Cancelada"});
            this.Cmbox_Marca.Location = new System.Drawing.Point(386, 69);
            this.Cmbox_Marca.Name = "Cmbox_Marca";
            this.Cmbox_Marca.Size = new System.Drawing.Size(121, 21);
            this.Cmbox_Marca.TabIndex = 5;
            // 
            // TxBox_Comentario
            // 
            this.TxBox_Comentario.BackColor = System.Drawing.SystemColors.Control;
            this.TxBox_Comentario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxBox_Comentario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxBox_Comentario.Location = new System.Drawing.Point(12, 65);
            this.TxBox_Comentario.Multiline = true;
            this.TxBox_Comentario.Name = "TxBox_Comentario";
            this.TxBox_Comentario.Size = new System.Drawing.Size(368, 164);
            this.TxBox_Comentario.TabIndex = 6;
            // 
            // Btn_MarcarCita
            // 
            this.Btn_MarcarCita.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_MarcarCita.color = System.Drawing.Color.SeaGreen;
            this.Btn_MarcarCita.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.Btn_MarcarCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_MarcarCita.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MarcarCita.ForeColor = System.Drawing.Color.White;
            this.Btn_MarcarCita.Image = ((System.Drawing.Image)(resources.GetObject("Btn_MarcarCita.Image")));
            this.Btn_MarcarCita.ImagePosition = 15;
            this.Btn_MarcarCita.ImageZoom = 50;
            this.Btn_MarcarCita.LabelPosition = 36;
            this.Btn_MarcarCita.LabelText = "Marcar Cita";
            this.Btn_MarcarCita.Location = new System.Drawing.Point(387, 124);
            this.Btn_MarcarCita.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_MarcarCita.Name = "Btn_MarcarCita";
            this.Btn_MarcarCita.Size = new System.Drawing.Size(110, 110);
            this.Btn_MarcarCita.TabIndex = 7;
            this.Btn_MarcarCita.Click += new System.EventHandler(this.Btn_MarcarCita_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(13, 35);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(121, 30);
            this.bunifuCustomLabel2.TabIndex = 11;
            this.bunifuCustomLabel2.Text = "Comentario";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(387, 36);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(71, 30);
            this.bunifuCustomLabel3.TabIndex = 12;
            this.bunifuCustomLabel3.Text = "Marca";
            // 
            // MarcarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 241);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.Btn_MarcarCita);
            this.Controls.Add(this.TxBox_Comentario);
            this.Controls.Add(this.Cmbox_Marca);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MarcarCita";
            this.Text = "Marcar Cita";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton Btn_Close;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox Cmbox_Marca;
        private System.Windows.Forms.TextBox TxBox_Comentario;
        private Bunifu.Framework.UI.BunifuTileButton Btn_MarcarCita;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
    }
}