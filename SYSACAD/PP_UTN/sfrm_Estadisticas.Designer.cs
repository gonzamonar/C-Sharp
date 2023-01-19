namespace Presentation
{
    partial class sfrm_Estadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sfrm_Estadisticas));
            this.pic_CtrlClose = new System.Windows.Forms.PictureBox();
            this.tlp_content = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_column2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_notas = new System.Windows.Forms.DataGridView();
            this.dgv_inscriptos = new System.Windows.Forms.DataGridView();
            this.lbl_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CtrlClose)).BeginInit();
            this.tlp_content.SuspendLayout();
            this.tlp_column2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inscriptos)).BeginInit();
            this.SuspendLayout();
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
            // tlp_content
            // 
            this.tlp_content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_content.ColumnCount = 2;
            this.tlp_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_content.Controls.Add(this.dgv_inscriptos, 0, 0);
            this.tlp_content.Controls.Add(this.tlp_column2, 1, 0);
            this.tlp_content.Location = new System.Drawing.Point(39, 71);
            this.tlp_content.Name = "tlp_content";
            this.tlp_content.RowCount = 1;
            this.tlp_content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_content.Size = new System.Drawing.Size(499, 357);
            this.tlp_content.TabIndex = 37;
            // 
            // tlp_column2
            // 
            this.tlp_column2.ColumnCount = 1;
            this.tlp_column2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_column2.Controls.Add(this.dgv_notas, 0, 0);
            this.tlp_column2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_column2.Location = new System.Drawing.Point(252, 3);
            this.tlp_column2.Name = "tlp_column2";
            this.tlp_column2.RowCount = 1;
            this.tlp_column2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tlp_column2.Size = new System.Drawing.Size(244, 351);
            this.tlp_column2.TabIndex = 38;
            // 
            // dgv_notas
            // 
            this.dgv_notas.AllowUserToAddRows = false;
            this.dgv_notas.AllowUserToDeleteRows = false;
            this.dgv_notas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_notas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.dgv_notas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_notas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_notas.Location = new System.Drawing.Point(3, 3);
            this.dgv_notas.MaximumSize = new System.Drawing.Size(750, 0);
            this.dgv_notas.Name = "dgv_notas";
            this.dgv_notas.RowTemplate.Height = 25;
            this.dgv_notas.Size = new System.Drawing.Size(238, 345);
            this.dgv_notas.TabIndex = 0;
            // 
            // dgv_inscriptos
            // 
            this.dgv_inscriptos.AllowUserToAddRows = false;
            this.dgv_inscriptos.AllowUserToDeleteRows = false;
            this.dgv_inscriptos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_inscriptos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.dgv_inscriptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_inscriptos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_inscriptos.Location = new System.Drawing.Point(3, 3);
            this.dgv_inscriptos.MaximumSize = new System.Drawing.Size(750, 0);
            this.dgv_inscriptos.Name = "dgv_inscriptos";
            this.dgv_inscriptos.RowTemplate.Height = 25;
            this.dgv_inscriptos.Size = new System.Drawing.Size(243, 351);
            this.dgv_inscriptos.TabIndex = 39;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(39, 54);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(163, 17);
            this.lbl_title.TabIndex = 38;
            this.lbl_title.Text = "Datos de inscripciones:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(291, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Datos de notas:";
            // 
            // sfrm_Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(570, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.tlp_content);
            this.Controls.Add(this.pic_CtrlClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sfrm_Estadisticas";
            this.Text = "Gestión de Inscriptos";
            this.Load += new System.EventHandler(this.sfrm_Inscriptos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_CtrlClose)).EndInit();
            this.tlp_content.ResumeLayout(false);
            this.tlp_column2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inscriptos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pic_CtrlClose;
        private TableLayoutPanel tlp_content;
        private TableLayoutPanel tlp_column2;
        private DataGridView dgv_notas;
        private DataGridView dgv_inscriptos;
        private Label lbl_title;
        private Label label1;
    }
}