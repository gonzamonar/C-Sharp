namespace Presentation
{
    partial class sfrm_Examenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sfrm_Examenes));
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.btn_crearPP = new System.Windows.Forms.Button();
            this.pic_CtrlClose = new System.Windows.Forms.PictureBox();
            this.cmb_selectMateria = new System.Windows.Forms.ComboBox();
            this.lbl_materia = new System.Windows.Forms.Label();
            this.btn_crearSP = new System.Windows.Forms.Button();
            this.lbl_dia = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.tlp_content = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CtrlClose)).BeginInit();
            this.tlp_content.SuspendLayout();
            this.pnl_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_main
            // 
            this.dgv_main.AllowUserToAddRows = false;
            this.dgv_main.AllowUserToDeleteRows = false;
            this.dgv_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_main.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_main.Location = new System.Drawing.Point(3, 3);
            this.dgv_main.MaximumSize = new System.Drawing.Size(900, 1000);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.RowTemplate.Height = 25;
            this.dgv_main.Size = new System.Drawing.Size(290, 345);
            this.dgv_main.TabIndex = 0;
            // 
            // btn_crearPP
            // 
            this.btn_crearPP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btn_crearPP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_crearPP.Enabled = false;
            this.btn_crearPP.FlatAppearance.BorderSize = 0;
            this.btn_crearPP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(127)))), ((int)(((byte)(27)))));
            this.btn_crearPP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crearPP.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_crearPP.ForeColor = System.Drawing.Color.White;
            this.btn_crearPP.Location = new System.Drawing.Point(3, 80);
            this.btn_crearPP.Name = "btn_crearPP";
            this.btn_crearPP.Size = new System.Drawing.Size(180, 50);
            this.btn_crearPP.TabIndex = 16;
            this.btn_crearPP.Text = "Seleccione una Materia";
            this.btn_crearPP.UseVisualStyleBackColor = false;
            this.btn_crearPP.Click += new System.EventHandler(this.btn_crearPP_Click);
            // 
            // pic_CtrlClose
            // 
            this.pic_CtrlClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_CtrlClose.Image = ((System.Drawing.Image)(resources.GetObject("pic_CtrlClose.Image")));
            this.pic_CtrlClose.Location = new System.Drawing.Point(15, 5);
            this.pic_CtrlClose.Name = "pic_CtrlClose";
            this.pic_CtrlClose.Size = new System.Drawing.Size(20, 40);
            this.pic_CtrlClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_CtrlClose.TabIndex = 20;
            this.pic_CtrlClose.TabStop = false;
            this.pic_CtrlClose.Click += new System.EventHandler(this.pic_CtrlClose_Click);
            this.pic_CtrlClose.MouseEnter += new System.EventHandler(this.pic_CtrlClose_MouseEnter);
            this.pic_CtrlClose.MouseLeave += new System.EventHandler(this.pic_CtrlClose_MouseLeave);
            // 
            // cmb_selectMateria
            // 
            this.cmb_selectMateria.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_selectMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_selectMateria.Font = new System.Drawing.Font("Carlito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_selectMateria.Location = new System.Drawing.Point(120, 71);
            this.cmb_selectMateria.Name = "cmb_selectMateria";
            this.cmb_selectMateria.Size = new System.Drawing.Size(206, 25);
            this.cmb_selectMateria.Sorted = true;
            this.cmb_selectMateria.TabIndex = 21;
            this.cmb_selectMateria.SelectedIndexChanged += new System.EventHandler(this.cmb_selectMateria_SelectedIndexChanged);
            // 
            // lbl_materia
            // 
            this.lbl_materia.AutoSize = true;
            this.lbl_materia.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_materia.ForeColor = System.Drawing.Color.White;
            this.lbl_materia.Location = new System.Drawing.Point(40, 71);
            this.lbl_materia.Name = "lbl_materia";
            this.lbl_materia.Size = new System.Drawing.Size(74, 19);
            this.lbl_materia.TabIndex = 27;
            this.lbl_materia.Text = "Materia:";
            // 
            // btn_crearSP
            // 
            this.btn_crearSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btn_crearSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_crearSP.Enabled = false;
            this.btn_crearSP.FlatAppearance.BorderSize = 0;
            this.btn_crearSP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(127)))), ((int)(((byte)(27)))));
            this.btn_crearSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crearSP.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_crearSP.ForeColor = System.Drawing.Color.White;
            this.btn_crearSP.Location = new System.Drawing.Point(3, 155);
            this.btn_crearSP.Name = "btn_crearSP";
            this.btn_crearSP.Size = new System.Drawing.Size(180, 50);
            this.btn_crearSP.TabIndex = 29;
            this.btn_crearSP.Text = "Seleccione una Materia";
            this.btn_crearSP.UseVisualStyleBackColor = false;
            this.btn_crearSP.Click += new System.EventHandler(this.btn_crearSP_Click);
            // 
            // lbl_dia
            // 
            this.lbl_dia.AutoSize = true;
            this.lbl_dia.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_dia.ForeColor = System.Drawing.Color.White;
            this.lbl_dia.Location = new System.Drawing.Point(3, 6);
            this.lbl_dia.Name = "lbl_dia";
            this.lbl_dia.Size = new System.Drawing.Size(53, 19);
            this.lbl_dia.TabIndex = 33;
            this.lbl_dia.Text = "Fecha";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_fecha.Font = new System.Drawing.Font("Carlito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(3, 28);
            this.dtp_fecha.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtp_fecha.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(180, 25);
            this.dtp_fecha.TabIndex = 36;
            // 
            // tlp_content
            // 
            this.tlp_content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_content.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_content.ColumnCount = 2;
            this.tlp_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tlp_content.Controls.Add(this.pnl_buttons, 1, 0);
            this.tlp_content.Controls.Add(this.dgv_main, 0, 0);
            this.tlp_content.Location = new System.Drawing.Point(40, 106);
            this.tlp_content.Name = "tlp_content";
            this.tlp_content.RowCount = 1;
            this.tlp_content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_content.Size = new System.Drawing.Size(501, 351);
            this.tlp_content.TabIndex = 37;
            this.tlp_content.Resize += new System.EventHandler(this.tlp_content_Resize);
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.Controls.Add(this.lbl_dia);
            this.pnl_buttons.Controls.Add(this.btn_crearPP);
            this.pnl_buttons.Controls.Add(this.btn_crearSP);
            this.pnl_buttons.Controls.Add(this.dtp_fecha);
            this.pnl_buttons.Location = new System.Drawing.Point(299, 3);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(199, 345);
            this.pnl_buttons.TabIndex = 39;
            // 
            // sfrm_Examenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(569, 484);
            this.Controls.Add(this.tlp_content);
            this.Controls.Add(this.lbl_materia);
            this.Controls.Add(this.cmb_selectMateria);
            this.Controls.Add(this.pic_CtrlClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sfrm_Examenes";
            this.Text = "Gestión de Inscriptos";
            this.Load += new System.EventHandler(this.sfrm_Inscriptos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CtrlClose)).EndInit();
            this.tlp_content.ResumeLayout(false);
            this.pnl_buttons.ResumeLayout(false);
            this.pnl_buttons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_main;
        private Button btn_crearPP;
        private PictureBox pic_CtrlClose;
        private ComboBox cmb_selectMateria;
        private Label lbl_materia;
        private Button btn_crearSP;
        private Label lbl_dia;
        private DateTimePicker dtp_fecha;
        private TableLayoutPanel tlp_content;
        private Panel pnl_buttons;
    }
}