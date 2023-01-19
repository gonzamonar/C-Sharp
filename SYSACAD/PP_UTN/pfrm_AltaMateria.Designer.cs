namespace Presentation
{
    partial class pfrm_AltaMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pfrm_AltaMateria));
            this.btn_tryAlta = new System.Windows.Forms.Button();
            this.pic_CtrlClose = new System.Windows.Forms.PictureBox();
            this.lbl_asignatura = new System.Windows.Forms.Label();
            this.lbl_cuatrimestre = new System.Windows.Forms.Label();
            this.pnl_txtAnio = new System.Windows.Forms.Panel();
            this.txt_anio = new System.Windows.Forms.TextBox();
            this.lbl_anio = new System.Windows.Forms.Label();
            this.lbl_errorAsignatura = new System.Windows.Forms.Label();
            this.lbl_errorCuatrimestre = new System.Windows.Forms.Label();
            this.lbl_errorAnio = new System.Windows.Forms.Label();
            this.cmb_selectCuatri = new System.Windows.Forms.ComboBox();
            this.cmb_selectAsignatura = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CtrlClose)).BeginInit();
            this.pnl_txtAnio.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_tryAlta
            // 
            this.btn_tryAlta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tryAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(127)))), ((int)(((byte)(27)))));
            this.btn_tryAlta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tryAlta.FlatAppearance.BorderSize = 0;
            this.btn_tryAlta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btn_tryAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tryAlta.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_tryAlta.ForeColor = System.Drawing.Color.White;
            this.btn_tryAlta.Location = new System.Drawing.Point(380, 495);
            this.btn_tryAlta.Name = "btn_tryAlta";
            this.btn_tryAlta.Size = new System.Drawing.Size(92, 26);
            this.btn_tryAlta.TabIndex = 16;
            this.btn_tryAlta.Text = "Dar de Alta";
            this.btn_tryAlta.UseVisualStyleBackColor = false;
            this.btn_tryAlta.Click += new System.EventHandler(this.btn_tryAlta_Click);
            // 
            // pic_CtrlClose
            // 
            this.pic_CtrlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_CtrlClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_CtrlClose.Image = ((System.Drawing.Image)(resources.GetObject("pic_CtrlClose.Image")));
            this.pic_CtrlClose.Location = new System.Drawing.Point(478, 12);
            this.pic_CtrlClose.Name = "pic_CtrlClose";
            this.pic_CtrlClose.Size = new System.Drawing.Size(20, 40);
            this.pic_CtrlClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_CtrlClose.TabIndex = 21;
            this.pic_CtrlClose.TabStop = false;
            this.pic_CtrlClose.Click += new System.EventHandler(this.pic_CtrlClose_Click);
            this.pic_CtrlClose.MouseEnter += new System.EventHandler(this.pic_CtrlClose_MouseEnter);
            this.pic_CtrlClose.MouseLeave += new System.EventHandler(this.pic_CtrlClose_MouseLeave);
            // 
            // lbl_asignatura
            // 
            this.lbl_asignatura.AutoSize = true;
            this.lbl_asignatura.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_asignatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(110)))), ((int)(((byte)(43)))));
            this.lbl_asignatura.Location = new System.Drawing.Point(49, 153);
            this.lbl_asignatura.Name = "lbl_asignatura";
            this.lbl_asignatura.Size = new System.Drawing.Size(85, 17);
            this.lbl_asignatura.TabIndex = 26;
            this.lbl_asignatura.Text = "Asignatura:";
            // 
            // lbl_cuatrimestre
            // 
            this.lbl_cuatrimestre.AutoSize = true;
            this.lbl_cuatrimestre.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_cuatrimestre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(110)))), ((int)(((byte)(43)))));
            this.lbl_cuatrimestre.Location = new System.Drawing.Point(49, 228);
            this.lbl_cuatrimestre.Name = "lbl_cuatrimestre";
            this.lbl_cuatrimestre.Size = new System.Drawing.Size(100, 17);
            this.lbl_cuatrimestre.TabIndex = 28;
            this.lbl_cuatrimestre.Text = "Cuatrimestre:";
            // 
            // pnl_txtAnio
            // 
            this.pnl_txtAnio.BackColor = System.Drawing.Color.White;
            this.pnl_txtAnio.Controls.Add(this.txt_anio);
            this.pnl_txtAnio.Location = new System.Drawing.Point(173, 298);
            this.pnl_txtAnio.Name = "pnl_txtAnio";
            this.pnl_txtAnio.Size = new System.Drawing.Size(116, 29);
            this.pnl_txtAnio.TabIndex = 31;
            // 
            // txt_anio
            // 
            this.txt_anio.BackColor = System.Drawing.Color.White;
            this.txt_anio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_anio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_anio.Font = new System.Drawing.Font("Constantia", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txt_anio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.txt_anio.Location = new System.Drawing.Point(8, 6);
            this.txt_anio.Name = "txt_anio";
            this.txt_anio.Size = new System.Drawing.Size(105, 16);
            this.txt_anio.TabIndex = 4;
            // 
            // lbl_anio
            // 
            this.lbl_anio.AutoSize = true;
            this.lbl_anio.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_anio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(110)))), ((int)(((byte)(43)))));
            this.lbl_anio.Location = new System.Drawing.Point(49, 303);
            this.lbl_anio.Name = "lbl_anio";
            this.lbl_anio.Size = new System.Drawing.Size(38, 17);
            this.lbl_anio.TabIndex = 30;
            this.lbl_anio.Text = "Año:";
            // 
            // lbl_errorAsignatura
            // 
            this.lbl_errorAsignatura.AutoSize = true;
            this.lbl_errorAsignatura.Font = new System.Drawing.Font("Alef", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_errorAsignatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_errorAsignatura.Location = new System.Drawing.Point(173, 129);
            this.lbl_errorAsignatura.Name = "lbl_errorAsignatura";
            this.lbl_errorAsignatura.Size = new System.Drawing.Size(0, 16);
            this.lbl_errorAsignatura.TabIndex = 38;
            // 
            // lbl_errorCuatrimestre
            // 
            this.lbl_errorCuatrimestre.AutoSize = true;
            this.lbl_errorCuatrimestre.Font = new System.Drawing.Font("Alef", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_errorCuatrimestre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_errorCuatrimestre.Location = new System.Drawing.Point(173, 205);
            this.lbl_errorCuatrimestre.Name = "lbl_errorCuatrimestre";
            this.lbl_errorCuatrimestre.Size = new System.Drawing.Size(0, 16);
            this.lbl_errorCuatrimestre.TabIndex = 39;
            // 
            // lbl_errorAnio
            // 
            this.lbl_errorAnio.AutoSize = true;
            this.lbl_errorAnio.Font = new System.Drawing.Font("Alef", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_errorAnio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_errorAnio.Location = new System.Drawing.Point(173, 279);
            this.lbl_errorAnio.Name = "lbl_errorAnio";
            this.lbl_errorAnio.Size = new System.Drawing.Size(0, 16);
            this.lbl_errorAnio.TabIndex = 40;
            // 
            // cmb_selectCuatri
            // 
            this.cmb_selectCuatri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_selectCuatri.Font = new System.Drawing.Font("Constantia", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_selectCuatri.FormattingEnabled = true;
            this.cmb_selectCuatri.Location = new System.Drawing.Point(173, 228);
            this.cmb_selectCuatri.Name = "cmb_selectCuatri";
            this.cmb_selectCuatri.Size = new System.Drawing.Size(217, 23);
            this.cmb_selectCuatri.TabIndex = 41;
            // 
            // cmb_selectAsignatura
            // 
            this.cmb_selectAsignatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_selectAsignatura.Font = new System.Drawing.Font("Constantia", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_selectAsignatura.FormattingEnabled = true;
            this.cmb_selectAsignatura.Location = new System.Drawing.Point(173, 151);
            this.cmb_selectAsignatura.Name = "cmb_selectAsignatura";
            this.cmb_selectAsignatura.Size = new System.Drawing.Size(217, 23);
            this.cmb_selectAsignatura.Sorted = true;
            this.cmb_selectAsignatura.TabIndex = 42;
            // 
            // pfrm_AltaMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(510, 551);
            this.Controls.Add(this.cmb_selectAsignatura);
            this.Controls.Add(this.cmb_selectCuatri);
            this.Controls.Add(this.lbl_errorAnio);
            this.Controls.Add(this.lbl_errorCuatrimestre);
            this.Controls.Add(this.lbl_errorAsignatura);
            this.Controls.Add(this.pnl_txtAnio);
            this.Controls.Add(this.lbl_anio);
            this.Controls.Add(this.lbl_cuatrimestre);
            this.Controls.Add(this.lbl_asignatura);
            this.Controls.Add(this.pic_CtrlClose);
            this.Controls.Add(this.btn_tryAlta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pfrm_AltaMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popform Alta Materia";
            this.Load += new System.EventHandler(this.pfrm_AltaMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_CtrlClose)).EndInit();
            this.pnl_txtAnio.ResumeLayout(false);
            this.pnl_txtAnio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_tryAlta;
        private PictureBox pic_CtrlClose;
        private Label lbl_asignatura;
        private Label lbl_cuatrimestre;
        private Panel pnl_txtAnio;
        private TextBox txt_anio;
        private Label lbl_anio;
        private Label lbl_errorAsignatura;
        private Label lbl_errorCuatrimestre;
        private Label lbl_errorAnio;
        private ComboBox cmb_selectCuatri;
        private ComboBox cmb_selectAsignatura;
    }
}