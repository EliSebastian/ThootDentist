
namespace ThootDentist
{
    partial class Calendario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendario));
            this.PanelUp = new System.Windows.Forms.Panel();
            this.Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Calendario3 = new System.Windows.Forms.MonthCalendar();
            this.DataGridCalendario = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Btn_CitaLista = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LabelPruebas = new System.Windows.Forms.Label();
            this.PanelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCalendario)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelUp
            // 
            this.PanelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.PanelUp.Controls.Add(this.Title);
            this.PanelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUp.Location = new System.Drawing.Point(0, 0);
            this.PanelUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelUp.Name = "PanelUp";
            this.PanelUp.Size = new System.Drawing.Size(966, 35);
            this.PanelUp.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.Title.Location = new System.Drawing.Point(4, 5);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(112, 30);
            this.Title.TabIndex = 0;
            this.Title.Text = "Calendario";
            // 
            // Calendario3
            // 
            this.Calendario3.Location = new System.Drawing.Point(25, 62);
            this.Calendario3.MaxSelectionCount = 1;
            this.Calendario3.Name = "Calendario3";
            this.Calendario3.TabIndex = 2;
            this.Calendario3.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Calendario3_DateSelected);
            // 
            // DataGridCalendario
            // 
            this.DataGridCalendario.AllowUserToAddRows = false;
            this.DataGridCalendario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridCalendario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridCalendario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridCalendario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridCalendario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridCalendario.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridCalendario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridCalendario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(91)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(128)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridCalendario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridCalendario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCalendario.DoubleBuffered = true;
            this.DataGridCalendario.EnableHeadersVisualStyles = false;
            this.DataGridCalendario.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(91)))), ((int)(((byte)(86)))));
            this.DataGridCalendario.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.DataGridCalendario.Location = new System.Drawing.Point(285, 62);
            this.DataGridCalendario.Name = "DataGridCalendario";
            this.DataGridCalendario.ReadOnly = true;
            this.DataGridCalendario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridCalendario.RowHeadersVisible = false;
            this.DataGridCalendario.Size = new System.Drawing.Size(669, 475);
            this.DataGridCalendario.TabIndex = 16;
            // 
            // Btn_CitaLista
            // 
            this.Btn_CitaLista.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_CitaLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(128)))), ((int)(((byte)(121)))));
            this.Btn_CitaLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_CitaLista.BorderRadius = 5;
            this.Btn_CitaLista.ButtonText = "Marcar Cita";
            this.Btn_CitaLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CitaLista.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_CitaLista.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_CitaLista.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_CitaLista.Iconimage")));
            this.Btn_CitaLista.Iconimage_right = null;
            this.Btn_CitaLista.Iconimage_right_Selected = null;
            this.Btn_CitaLista.Iconimage_Selected = null;
            this.Btn_CitaLista.IconMarginLeft = 50;
            this.Btn_CitaLista.IconMarginRight = 0;
            this.Btn_CitaLista.IconRightVisible = true;
            this.Btn_CitaLista.IconRightZoom = 0D;
            this.Btn_CitaLista.IconVisible = true;
            this.Btn_CitaLista.IconZoom = 90D;
            this.Btn_CitaLista.IsTab = false;
            this.Btn_CitaLista.Location = new System.Drawing.Point(25, 236);
            this.Btn_CitaLista.Name = "Btn_CitaLista";
            this.Btn_CitaLista.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(128)))), ((int)(((byte)(121)))));
            this.Btn_CitaLista.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_CitaLista.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_CitaLista.selected = false;
            this.Btn_CitaLista.Size = new System.Drawing.Size(248, 48);
            this.Btn_CitaLista.TabIndex = 37;
            this.Btn_CitaLista.Text = "Marcar Cita";
            this.Btn_CitaLista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_CitaLista.Textcolor = System.Drawing.Color.White;
            this.Btn_CitaLista.TextFont = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CitaLista.Click += new System.EventHandler(this.Btn_CitaLista_Click);
            // 
            // LabelPruebas
            // 
            this.LabelPruebas.AutoSize = true;
            this.LabelPruebas.Location = new System.Drawing.Point(22, 311);
            this.LabelPruebas.Name = "LabelPruebas";
            this.LabelPruebas.Size = new System.Drawing.Size(43, 13);
            this.LabelPruebas.TabIndex = 38;
            this.LabelPruebas.Text = "Puebas";
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(966, 543);
            this.Controls.Add(this.LabelPruebas);
            this.Controls.Add(this.Btn_CitaLista);
            this.Controls.Add(this.DataGridCalendario);
            this.Controls.Add(this.Calendario3);
            this.Controls.Add(this.PanelUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calendario";
            this.Text = "Calendario";
            this.PanelUp.ResumeLayout(false);
            this.PanelUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCalendario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelUp;
        private Bunifu.Framework.UI.BunifuCustomLabel Title;
        private System.Windows.Forms.MonthCalendar Calendario3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridCalendario;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_CitaLista;
        private System.Windows.Forms.Label LabelPruebas;
    }
}