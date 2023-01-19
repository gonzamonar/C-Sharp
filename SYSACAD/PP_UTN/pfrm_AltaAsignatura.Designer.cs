namespace Presentation
{
    partial class pform_AltaAsignatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pform_AltaAsignatura));
            this.btn_tryAlta = new System.Windows.Forms.Button();
            this.pic_CtrlClose = new System.Windows.Forms.PictureBox();
            this.pnl_txtTituloCodif = new System.Windows.Forms.Panel();
            this.txt_tituloCodif = new System.Windows.Forms.TextBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_correlativas = new System.Windows.Forms.Label();
            this.pnl_txtCodigo = new System.Windows.Forms.Panel();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_errorTituloCodif = new System.Windows.Forms.Label();
            this.cmb_correlativa2 = new System.Windows.Forms.ComboBox();
            this.cmb_correlativa1 = new System.Windows.Forms.ComboBox();
            this.cmb_correlativa3 = new System.Windows.Forms.ComboBox();
            this.lbl_tituloCodif1 = new System.Windows.Forms.Label();
            this.pnl_txtTitulo = new System.Windows.Forms.Panel();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.lbl_errorTitulo = new System.Windows.Forms.Label();
            this.lbl_errorCodigo = new System.Windows.Forms.Label();
            this.lbl_tituloCodif2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CtrlClose)).BeginInit();
            this.pnl_txtTituloCodif.SuspendLayout();
            this.pnl_txtCodigo.SuspendLayout();
            this.pnl_txtTitulo.SuspendLayout();
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
            // pnl_txtTituloCodif
            // 
            this.pnl_txtTituloCodif.BackColor = System.Drawing.Color.White;
            this.pnl_txtTituloCodif.Controls.Add(this.txt_tituloCodif);
            this.pnl_txtTituloCodif.Location = new System.Drawing.Point(141, 244);
            this.pnl_txtTituloCodif.Name = "pnl_txtTituloCodif";
            this.pnl_txtTituloCodif.Size = new System.Drawing.Size(331, 29);
            this.pnl_txtTituloCodif.TabIndex = 27;
            // 
            // txt_tituloCodif
            // 
            this.txt_tituloCodif.BackColor = System.Drawing.Color.White;
            this.txt_tituloCodif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tituloCodif.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tituloCodif.Font = new System.Drawing.Font("Constantia", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txt_tituloCodif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.txt_tituloCodif.Location = new System.Drawing.Point(8, 6);
            this.txt_tituloCodif.Name = "txt_tituloCodif";
            this.txt_tituloCodif.PlaceholderText = "Sin espacios ni caracteres especiales.";
            this.txt_tituloCodif.Size = new System.Drawing.Size(320, 16);
            this.txt_tituloCodif.TabIndex = 4;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(110)))), ((int)(((byte)(43)))));
            this.lbl_titulo.Location = new System.Drawing.Point(49, 170);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(53, 17);
            this.lbl_titulo.TabIndex = 26;
            this.lbl_titulo.Text = "Título:";
            // 
            // lbl_correlativas
            // 
            this.lbl_correlativas.AutoSize = true;
            this.lbl_correlativas.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_correlativas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(110)))), ((int)(((byte)(43)))));
            this.lbl_correlativas.Location = new System.Drawing.Point(51, 324);
            this.lbl_correlativas.Name = "lbl_correlativas";
            this.lbl_correlativas.Size = new System.Drawing.Size(169, 17);
            this.lbl_correlativas.TabIndex = 28;
            this.lbl_correlativas.Text = "Correlativas (Opcional):";
            // 
            // pnl_txtCodigo
            // 
            this.pnl_txtCodigo.BackColor = System.Drawing.Color.White;
            this.pnl_txtCodigo.Controls.Add(this.txt_codigo);
            this.pnl_txtCodigo.Location = new System.Drawing.Point(230, 88);
            this.pnl_txtCodigo.Name = "pnl_txtCodigo";
            this.pnl_txtCodigo.Size = new System.Drawing.Size(80, 29);
            this.pnl_txtCodigo.TabIndex = 35;
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.Color.White;
            this.txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_codigo.Font = new System.Drawing.Font("Constantia", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txt_codigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.txt_codigo.Location = new System.Drawing.Point(8, 6);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.PlaceholderText = "0000";
            this.txt_codigo.Size = new System.Drawing.Size(69, 16);
            this.txt_codigo.TabIndex = 4;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_codigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(110)))), ((int)(((byte)(43)))));
            this.lbl_codigo.Location = new System.Drawing.Point(51, 94);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(165, 18);
            this.lbl_codigo.TabIndex = 37;
            this.lbl_codigo.Text = "Código de Asignatura:";
            // 
            // lbl_errorTituloCodif
            // 
            this.lbl_errorTituloCodif.AutoSize = true;
            this.lbl_errorTituloCodif.Font = new System.Drawing.Font("Alef", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_errorTituloCodif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_errorTituloCodif.Location = new System.Drawing.Point(141, 226);
            this.lbl_errorTituloCodif.Name = "lbl_errorTituloCodif";
            this.lbl_errorTituloCodif.Size = new System.Drawing.Size(0, 16);
            this.lbl_errorTituloCodif.TabIndex = 38;
            // 
            // cmb_correlativa2
            // 
            this.cmb_correlativa2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_correlativa2.Font = new System.Drawing.Font("Constantia", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_correlativa2.FormattingEnabled = true;
            this.cmb_correlativa2.Location = new System.Drawing.Point(230, 363);
            this.cmb_correlativa2.Name = "cmb_correlativa2";
            this.cmb_correlativa2.Size = new System.Drawing.Size(239, 23);
            this.cmb_correlativa2.Sorted = true;
            this.cmb_correlativa2.TabIndex = 43;
            this.cmb_correlativa2.SelectedIndexChanged += new System.EventHandler(this.cmb_correlativa2_SelectedIndexChanged);
            // 
            // cmb_correlativa1
            // 
            this.cmb_correlativa1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_correlativa1.Font = new System.Drawing.Font("Constantia", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_correlativa1.FormattingEnabled = true;
            this.cmb_correlativa1.Location = new System.Drawing.Point(230, 322);
            this.cmb_correlativa1.Name = "cmb_correlativa1";
            this.cmb_correlativa1.Size = new System.Drawing.Size(239, 23);
            this.cmb_correlativa1.Sorted = true;
            this.cmb_correlativa1.TabIndex = 42;
            this.cmb_correlativa1.SelectedIndexChanged += new System.EventHandler(this.cmb_correlativa1_SelectedIndexChanged);
            // 
            // cmb_correlativa3
            // 
            this.cmb_correlativa3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_correlativa3.Font = new System.Drawing.Font("Constantia", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_correlativa3.FormattingEnabled = true;
            this.cmb_correlativa3.Location = new System.Drawing.Point(230, 406);
            this.cmb_correlativa3.Name = "cmb_correlativa3";
            this.cmb_correlativa3.Size = new System.Drawing.Size(239, 23);
            this.cmb_correlativa3.Sorted = true;
            this.cmb_correlativa3.TabIndex = 44;
            // 
            // lbl_tituloCodif1
            // 
            this.lbl_tituloCodif1.AutoSize = true;
            this.lbl_tituloCodif1.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_tituloCodif1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(110)))), ((int)(((byte)(43)))));
            this.lbl_tituloCodif1.Location = new System.Drawing.Point(51, 239);
            this.lbl_tituloCodif1.Name = "lbl_tituloCodif1";
            this.lbl_tituloCodif1.Size = new System.Drawing.Size(49, 17);
            this.lbl_tituloCodif1.TabIndex = 46;
            this.lbl_tituloCodif1.Text = "Título";
            // 
            // pnl_txtTitulo
            // 
            this.pnl_txtTitulo.BackColor = System.Drawing.Color.White;
            this.pnl_txtTitulo.Controls.Add(this.txt_titulo);
            this.pnl_txtTitulo.Location = new System.Drawing.Point(141, 164);
            this.pnl_txtTitulo.Name = "pnl_txtTitulo";
            this.pnl_txtTitulo.Size = new System.Drawing.Size(331, 29);
            this.pnl_txtTitulo.TabIndex = 45;
            // 
            // txt_titulo
            // 
            this.txt_titulo.BackColor = System.Drawing.Color.White;
            this.txt_titulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_titulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_titulo.Font = new System.Drawing.Font("Constantia", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txt_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.txt_titulo.Location = new System.Drawing.Point(8, 6);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(320, 16);
            this.txt_titulo.TabIndex = 4;
            // 
            // lbl_errorTitulo
            // 
            this.lbl_errorTitulo.AutoSize = true;
            this.lbl_errorTitulo.Font = new System.Drawing.Font("Alef", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_errorTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_errorTitulo.Location = new System.Drawing.Point(141, 145);
            this.lbl_errorTitulo.Name = "lbl_errorTitulo";
            this.lbl_errorTitulo.Size = new System.Drawing.Size(0, 16);
            this.lbl_errorTitulo.TabIndex = 47;
            // 
            // lbl_errorCodigo
            // 
            this.lbl_errorCodigo.AutoSize = true;
            this.lbl_errorCodigo.Font = new System.Drawing.Font("Alef", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_errorCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_errorCodigo.Location = new System.Drawing.Point(230, 69);
            this.lbl_errorCodigo.Name = "lbl_errorCodigo";
            this.lbl_errorCodigo.Size = new System.Drawing.Size(0, 16);
            this.lbl_errorCodigo.TabIndex = 48;
            // 
            // lbl_tituloCodif2
            // 
            this.lbl_tituloCodif2.AutoSize = true;
            this.lbl_tituloCodif2.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_tituloCodif2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(110)))), ((int)(((byte)(43)))));
            this.lbl_tituloCodif2.Location = new System.Drawing.Point(51, 256);
            this.lbl_tituloCodif2.Name = "lbl_tituloCodif2";
            this.lbl_tituloCodif2.Size = new System.Drawing.Size(82, 17);
            this.lbl_tituloCodif2.TabIndex = 49;
            this.lbl_tituloCodif2.Text = "codificado:";
            // 
            // pform_AltaAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(510, 551);
            this.Controls.Add(this.lbl_tituloCodif2);
            this.Controls.Add(this.lbl_errorCodigo);
            this.Controls.Add(this.lbl_errorTitulo);
            this.Controls.Add(this.lbl_tituloCodif1);
            this.Controls.Add(this.pnl_txtTitulo);
            this.Controls.Add(this.cmb_correlativa3);
            this.Controls.Add(this.cmb_correlativa1);
            this.Controls.Add(this.cmb_correlativa2);
            this.Controls.Add(this.lbl_errorTituloCodif);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.pnl_txtCodigo);
            this.Controls.Add(this.lbl_correlativas);
            this.Controls.Add(this.pnl_txtTituloCodif);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.pic_CtrlClose);
            this.Controls.Add(this.btn_tryAlta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pform_AltaAsignatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popform Alta Asignatura";
            this.Load += new System.EventHandler(this.pform_AltaAsignatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_CtrlClose)).EndInit();
            this.pnl_txtTituloCodif.ResumeLayout(false);
            this.pnl_txtTituloCodif.PerformLayout();
            this.pnl_txtCodigo.ResumeLayout(false);
            this.pnl_txtCodigo.PerformLayout();
            this.pnl_txtTitulo.ResumeLayout(false);
            this.pnl_txtTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_tryAlta;
        private PictureBox pic_CtrlClose;
        private Panel pnl_txtTituloCodif;
        private TextBox txt_tituloCodif;
        private Label lbl_titulo;
        private Label lbl_correlativas;
        private Panel pnl_txtCodigo;
        private TextBox txt_codigo;
        private Label lbl_codigo;
        private Label lbl_errorTituloCodif;
        private ComboBox cmb_correlativa2;
        private ComboBox cmb_correlativa1;
        private ComboBox cmb_correlativa3;
        private Label lbl_tituloCodif1;
        private Panel pnl_txtTitulo;
        private TextBox txt_titulo;
        private Label lbl_errorCodigo;
        private Label lbl_errorTitulo;
        private Label lbl_tituloCodif2;
    }
}