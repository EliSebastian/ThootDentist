
namespace ThootDentist
{
    partial class ControlPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPacientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelUp = new System.Windows.Forms.Panel();
            this.Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtBx_Buscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Btn_Agregar = new Bunifu.Framework.UI.BunifuTileButton();
            this.Btn_Borrar = new Bunifu.Framework.UI.BunifuTileButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.holaMundoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataGridPacientes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.PanelUp.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelUp
            // 
            this.PanelUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.PanelUp.Controls.Add(this.Title);
            this.PanelUp.Location = new System.Drawing.Point(0, 0);
            this.PanelUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelUp.Name = "PanelUp";
            this.PanelUp.Size = new System.Drawing.Size(982, 35);
            this.PanelUp.TabIndex = 0;
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
            // TxtBx_Buscar
            // 
            this.TxtBx_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBx_Buscar.AutoSize = true;
            this.TxtBx_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtBx_Buscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBx_Buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtBx_Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBx_Buscar.HintForeColor = System.Drawing.Color.Empty;
            this.TxtBx_Buscar.HintText = "";
            this.TxtBx_Buscar.isPassword = false;
            this.TxtBx_Buscar.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(44)))));
            this.TxtBx_Buscar.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtBx_Buscar.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(128)))), ((int)(((byte)(121)))));
            this.TxtBx_Buscar.LineThickness = 3;
            this.TxtBx_Buscar.Location = new System.Drawing.Point(9, 44);
            this.TxtBx_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBx_Buscar.Name = "TxtBx_Buscar";
            this.TxtBx_Buscar.Size = new System.Drawing.Size(370, 44);
            this.TxtBx_Buscar.TabIndex = 2;
            this.TxtBx_Buscar.Text = "Buscar";
            this.TxtBx_Buscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtBx_Buscar.OnValueChanged += new System.EventHandler(this.TxtBx_Buscar_OnValueChanged);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.Btn_Agregar.color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.Btn_Agregar.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(138)))), ((int)(((byte)(62)))));
            this.Btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Agregar.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Btn_Agregar.ForeColor = System.Drawing.Color.White;
            this.Btn_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Agregar.Image")));
            this.Btn_Agregar.ImagePosition = 15;
            this.Btn_Agregar.ImageZoom = 50;
            this.Btn_Agregar.LabelPosition = 41;
            this.Btn_Agregar.LabelText = "Agregar";
            this.Btn_Agregar.Location = new System.Drawing.Point(847, 130);
            this.Btn_Agregar.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(120, 120);
            this.Btn_Agregar.TabIndex = 5;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Btn_Borrar
            // 
            this.Btn_Borrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Borrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.Btn_Borrar.color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.Btn_Borrar.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Btn_Borrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Borrar.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Btn_Borrar.ForeColor = System.Drawing.Color.White;
            this.Btn_Borrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Borrar.Image")));
            this.Btn_Borrar.ImagePosition = 15;
            this.Btn_Borrar.ImageZoom = 50;
            this.Btn_Borrar.LabelPosition = 41;
            this.Btn_Borrar.LabelText = "Eliminar";
            this.Btn_Borrar.Location = new System.Drawing.Point(847, 262);
            this.Btn_Borrar.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_Borrar.Name = "Btn_Borrar";
            this.Btn_Borrar.Size = new System.Drawing.Size(120, 120);
            this.Btn_Borrar.TabIndex = 6;
            this.Btn_Borrar.Click += new System.EventHandler(this.Btn_Borrar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.holaMundoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 26);
            // 
            // holaMundoToolStripMenuItem
            // 
            this.holaMundoToolStripMenuItem.Name = "holaMundoToolStripMenuItem";
            this.holaMundoToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.holaMundoToolStripMenuItem.Text = "Hola mundo";
            // 
            // DataGridPacientes
            // 
            this.DataGridPacientes.AllowUserToAddRows = false;
            this.DataGridPacientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridPacientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridPacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridPacientes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridPacientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridPacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(91)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(128)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridPacientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridPacientes.DoubleBuffered = true;
            this.DataGridPacientes.EnableHeadersVisualStyles = false;
            this.DataGridPacientes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(91)))), ((int)(((byte)(86)))));
            this.DataGridPacientes.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.DataGridPacientes.Location = new System.Drawing.Point(12, 95);
            this.DataGridPacientes.MultiSelect = false;
            this.DataGridPacientes.Name = "DataGridPacientes";
            this.DataGridPacientes.ReadOnly = true;
            this.DataGridPacientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridPacientes.RowHeadersVisible = false;
            this.DataGridPacientes.Size = new System.Drawing.Size(826, 475);
            this.DataGridPacientes.TabIndex = 16;
            // 
            // ControlPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(982, 582);
            this.Controls.Add(this.DataGridPacientes);
            this.Controls.Add(this.Btn_Borrar);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.TxtBx_Buscar);
            this.Controls.Add(this.PanelUp);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ControlPacientes";
            this.Text = "ControlPacientes";
            this.PanelUp.ResumeLayout(false);
            this.PanelUp.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelUp;
        private Bunifu.Framework.UI.BunifuCustomLabel Title;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtBx_Buscar;
        private Bunifu.Framework.UI.BunifuTileButton Btn_Agregar;
        private Bunifu.Framework.UI.BunifuTileButton Btn_Borrar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem holaMundoToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridPacientes;
    }
}