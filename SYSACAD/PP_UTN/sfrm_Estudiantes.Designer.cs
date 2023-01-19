namespace Presentation
{
    partial class sfrm_Estudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sfrm_Estudiantes));
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.btn_libre = new System.Windows.Forms.Button();
            this.btn_regular = new System.Windows.Forms.Button();
            this.pic_CtrlClose = new System.Windows.Forms.PictureBox();
            this.cmb_selectMateria = new System.Windows.Forms.ComboBox();
            this.lbl_materia = new System.Windows.Forms.Label();
            this.lbl_condicion = new System.Windows.Forms.Label();
            this.lbl_dgvDescription = new System.Windows.Forms.Label();
            this.tlp_content = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exportCSV = new System.Windows.Forms.Button();
            this.btn_exportJSON = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CtrlClose)).BeginInit();
            this.tlp_content.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_main
            // 
            this.dgv_main.AllowUserToAddRows = false;
            this.dgv_main.AllowUserToDeleteRows = false;
            this.dgv_main.AllowUserToOrderColumns = true;
            this.dgv_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_main.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_main.Location = new System.Drawing.Point(3, 3);
            this.dgv_main.MaximumSize = new System.Drawing.Size(900, 1000);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.RowTemplate.Height = 25;
            this.dgv_main.Size = new System.Drawing.Size(335, 355);
            this.dgv_main.TabIndex = 0;
            // 
            // btn_libre
            // 
            this.btn_libre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btn_libre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_libre.FlatAppearance.BorderSize = 0;
            this.btn_libre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(127)))), ((int)(((byte)(27)))));
            this.btn_libre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_libre.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_libre.ForeColor = System.Drawing.Color.White;
            this.btn_libre.Location = new System.Drawing.Point(2, 36);
            this.btn_libre.Name = "btn_libre";
            this.btn_libre.Size = new System.Drawing.Size(151, 26);
            this.btn_libre.TabIndex = 15;
            this.btn_libre.Text = "Libre";
            this.btn_libre.UseVisualStyleBackColor = false;
            this.btn_libre.Click += new System.EventHandler(this.btn_libre_Click);
            // 
            // btn_regular
            // 
            this.btn_regular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btn_regular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regular.FlatAppearance.BorderSize = 0;
            this.btn_regular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(127)))), ((int)(((byte)(27)))));
            this.btn_regular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regular.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_regular.ForeColor = System.Drawing.Color.White;
            this.btn_regular.Location = new System.Drawing.Point(2, 68);
            this.btn_regular.Name = "btn_regular";
            this.btn_regular.Size = new System.Drawing.Size(151, 26);
            this.btn_regular.TabIndex = 16;
            this.btn_regular.Text = "Regular";
            this.btn_regular.UseVisualStyleBackColor = false;
            this.btn_regular.Click += new System.EventHandler(this.btn_regular_Click);
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
            this.cmb_selectMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_selectMateria.FormattingEnabled = true;
            this.cmb_selectMateria.Location = new System.Drawing.Point(120, 60);
            this.cmb_selectMateria.Name = "cmb_selectMateria";
            this.cmb_selectMateria.Size = new System.Drawing.Size(206, 23);
            this.cmb_selectMateria.Sorted = true;
            this.cmb_selectMateria.TabIndex = 21;
            this.cmb_selectMateria.SelectedIndexChanged += new System.EventHandler(this.cmb_selectMateria_SelectedIndexChanged);
            // 
            // lbl_materia
            // 
            this.lbl_materia.AutoSize = true;
            this.lbl_materia.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_materia.ForeColor = System.Drawing.Color.White;
            this.lbl_materia.Location = new System.Drawing.Point(40, 62);
            this.lbl_materia.Name = "lbl_materia";
            this.lbl_materia.Size = new System.Drawing.Size(74, 19);
            this.lbl_materia.TabIndex = 27;
            this.lbl_materia.Text = "Materia:";
            // 
            // lbl_condicion
            // 
            this.lbl_condicion.AutoSize = true;
            this.lbl_condicion.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_condicion.ForeColor = System.Drawing.Color.White;
            this.lbl_condicion.Location = new System.Drawing.Point(3, 3);
            this.lbl_condicion.Name = "lbl_condicion";
            this.lbl_condicion.Size = new System.Drawing.Size(151, 17);
            this.lbl_condicion.TabIndex = 28;
            this.lbl_condicion.Text = "Cambiar condición a:";
            // 
            // lbl_dgvDescription
            // 
            this.lbl_dgvDescription.AutoSize = true;
            this.lbl_dgvDescription.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_dgvDescription.ForeColor = System.Drawing.Color.White;
            this.lbl_dgvDescription.Location = new System.Drawing.Point(40, 95);
            this.lbl_dgvDescription.Name = "lbl_dgvDescription";
            this.lbl_dgvDescription.Size = new System.Drawing.Size(158, 17);
            this.lbl_dgvDescription.TabIndex = 31;
            this.lbl_dgvDescription.Text = "Estudiantes inscriptxs:";
            // 
            // tlp_content
            // 
            this.tlp_content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_content.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_content.ColumnCount = 2;
            this.tlp_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlp_content.Controls.Add(this.panel1, 1, 0);
            this.tlp_content.Controls.Add(this.dgv_main, 0, 0);
            this.tlp_content.Location = new System.Drawing.Point(40, 112);
            this.tlp_content.Name = "tlp_content";
            this.tlp_content.RowCount = 1;
            this.tlp_content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_content.Size = new System.Drawing.Size(501, 361);
            this.tlp_content.TabIndex = 30;
            this.tlp_content.Resize += new System.EventHandler(this.tlp_content_Resize);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_exportJSON);
            this.panel1.Controls.Add(this.btn_exportCSV);
            this.panel1.Controls.Add(this.lbl_condicion);
            this.panel1.Controls.Add(this.btn_libre);
            this.panel1.Controls.Add(this.btn_regular);
            this.panel1.Location = new System.Drawing.Point(344, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 355);
            this.panel1.TabIndex = 32;
            // 
            // btn_exportCSV
            // 
            this.btn_exportCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btn_exportCSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportCSV.FlatAppearance.BorderSize = 0;
            this.btn_exportCSV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(127)))), ((int)(((byte)(27)))));
            this.btn_exportCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportCSV.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_exportCSV.ForeColor = System.Drawing.Color.White;
            this.btn_exportCSV.Location = new System.Drawing.Point(2, 136);
            this.btn_exportCSV.Name = "btn_exportCSV";
            this.btn_exportCSV.Size = new System.Drawing.Size(151, 51);
            this.btn_exportCSV.TabIndex = 32;
            this.btn_exportCSV.Text = "Exportar a CSV";
            this.btn_exportCSV.UseVisualStyleBackColor = false;
            this.btn_exportCSV.Click += new System.EventHandler(this.btn_exportCSV_Click);
            // 
            // btn_exportJSON
            // 
            this.btn_exportJSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btn_exportJSON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportJSON.FlatAppearance.BorderSize = 0;
            this.btn_exportJSON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(127)))), ((int)(((byte)(27)))));
            this.btn_exportJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportJSON.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_exportJSON.ForeColor = System.Drawing.Color.White;
            this.btn_exportJSON.Location = new System.Drawing.Point(2, 193);
            this.btn_exportJSON.Name = "btn_exportJSON";
            this.btn_exportJSON.Size = new System.Drawing.Size(151, 51);
            this.btn_exportJSON.TabIndex = 33;
            this.btn_exportJSON.Text = "Exportar a JSON";
            this.btn_exportJSON.UseVisualStyleBackColor = false;
            this.btn_exportJSON.Click += new System.EventHandler(this.btn_exportJSON_Click);
            // 
            // sfrm_Estudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(569, 484);
            this.Controls.Add(this.lbl_dgvDescription);
            this.Controls.Add(this.tlp_content);
            this.Controls.Add(this.lbl_materia);
            this.Controls.Add(this.cmb_selectMateria);
            this.Controls.Add(this.pic_CtrlClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sfrm_Estudiantes";
            this.Text = "Gestión de Inscriptos";
            this.Load += new System.EventHandler(this.sfrm_Inscriptos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CtrlClose)).EndInit();
            this.tlp_content.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_main;
        private Button btn_libre;
        private Button btn_regular;
        private PictureBox pic_CtrlClose;
        private ComboBox cmb_selectMateria;
        private Label lbl_materia;
        private Label lbl_condicion;
        private Label lbl_dgvDescription;
        private TableLayoutPanel tlp_content;
        private Panel panel1;
        private Button btn_exportCSV;
        private Button btn_exportJSON;
    }
}