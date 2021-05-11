
namespace ThootDentist
{
    partial class AgendarCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendarCita));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.CmBox_Tratamientos = new System.Windows.Forms.ComboBox();
            this.CmBox_AMPM = new System.Windows.Forms.ComboBox();
            this.CmBox_Minutos = new System.Windows.Forms.ComboBox();
            this.CmBox_Hora = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pruebas = new System.Windows.Forms.Label();
            this.Btn_Guardar = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Guardar)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(522, 35);
            this.panel1.TabIndex = 2;
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Close.Image")));
            this.Btn_Close.ImageActive = ((System.Drawing.Image)(resources.GetObject("Btn_Close.ImageActive")));
            this.Btn_Close.Location = new System.Drawing.Point(492, 3);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(30, 30);
            this.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Close.TabIndex = 10;
            this.Btn_Close.TabStop = false;
            this.Btn_Close.Zoom = 5;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(4, 5);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(134, 30);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Agendar Cita";
            // 
            // Calendario
            // 
            this.Calendario.Location = new System.Drawing.Point(9, 49);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 3;
            // 
            // CmBox_Tratamientos
            // 
            this.CmBox_Tratamientos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmBox_Tratamientos.FormattingEnabled = true;
            this.CmBox_Tratamientos.Location = new System.Drawing.Point(269, 65);
            this.CmBox_Tratamientos.Name = "CmBox_Tratamientos";
            this.CmBox_Tratamientos.Size = new System.Drawing.Size(241, 21);
            this.CmBox_Tratamientos.TabIndex = 4;
            // 
            // CmBox_AMPM
            // 
            this.CmBox_AMPM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmBox_AMPM.FormattingEnabled = true;
            this.CmBox_AMPM.Items.AddRange(new object[] {
            "am",
            "pm"});
            this.CmBox_AMPM.Location = new System.Drawing.Point(449, 123);
            this.CmBox_AMPM.Name = "CmBox_AMPM";
            this.CmBox_AMPM.Size = new System.Drawing.Size(61, 21);
            this.CmBox_AMPM.TabIndex = 5;
            // 
            // CmBox_Minutos
            // 
            this.CmBox_Minutos.AutoCompleteCustomSource.AddRange(new string[] {
            "00",
            "30"});
            this.CmBox_Minutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmBox_Minutos.FormattingEnabled = true;
            this.CmBox_Minutos.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.CmBox_Minutos.Location = new System.Drawing.Point(371, 123);
            this.CmBox_Minutos.Name = "CmBox_Minutos";
            this.CmBox_Minutos.Size = new System.Drawing.Size(72, 21);
            this.CmBox_Minutos.TabIndex = 6;
            // 
            // CmBox_Hora
            // 
            this.CmBox_Hora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmBox_Hora.FormattingEnabled = true;
            this.CmBox_Hora.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.CmBox_Hora.Location = new System.Drawing.Point(269, 123);
            this.CmBox_Hora.Name = "CmBox_Hora";
            this.CmBox_Hora.Size = new System.Drawing.Size(96, 21);
            this.CmBox_Hora.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tratamiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hora";
            // 
            // Pruebas
            // 
            this.Pruebas.AutoSize = true;
            this.Pruebas.Location = new System.Drawing.Point(269, 168);
            this.Pruebas.Name = "Pruebas";
            this.Pruebas.Size = new System.Drawing.Size(33, 13);
            this.Pruebas.TabIndex = 10;
            this.Pruebas.Text = "Label";
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.ImageActive = null;
            this.Btn_Guardar.Location = new System.Drawing.Point(439, 150);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(71, 71);
            this.Btn_Guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Guardar.TabIndex = 11;
            this.Btn_Guardar.TabStop = false;
            this.Btn_Guardar.Zoom = 10;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // AgendarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 232);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Pruebas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmBox_Hora);
            this.Controls.Add(this.CmBox_Minutos);
            this.Controls.Add(this.CmBox_AMPM);
            this.Controls.Add(this.CmBox_Tratamientos);
            this.Controls.Add(this.Calendario);
            this.Controls.Add(this.panel1);
            this.Name = "AgendarCita";
            this.Text = "AgendarCita";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Guardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.ComboBox CmBox_Tratamientos;
        private System.Windows.Forms.ComboBox CmBox_AMPM;
        private System.Windows.Forms.ComboBox CmBox_Minutos;
        private System.Windows.Forms.ComboBox CmBox_Hora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton Btn_Close;
        private System.Windows.Forms.Label Pruebas;
        private Bunifu.Framework.UI.BunifuImageButton Btn_Guardar;
    }
}