namespace Presentation
{
    partial class sfrm_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sfrm_Usuarios));
            this.pic_CtrlClose = new System.Windows.Forms.PictureBox();
            this.tlp_content = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.btn_newUser = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CtrlClose)).BeginInit();
            this.tlp_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
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
            this.pic_CtrlClose.TabIndex = 21;
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
            this.tlp_content.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_content.ColumnCount = 2;
            this.tlp_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_content.Controls.Add(this.dgv_main, 0, 0);
            this.tlp_content.Controls.Add(this.btn_newUser, 1, 0);
            this.tlp_content.Location = new System.Drawing.Point(40, 100);
            this.tlp_content.Name = "tlp_content";
            this.tlp_content.RowCount = 1;
            this.tlp_content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_content.Size = new System.Drawing.Size(501, 361);
            this.tlp_content.TabIndex = 24;
            this.tlp_content.Resize += new System.EventHandler(this.tlp_content_Resize);
            // 
            // dgv_main
            // 
            this.dgv_main.AllowUserToAddRows = false;
            this.dgv_main.AllowUserToDeleteRows = false;
            this.dgv_main.AllowUserToOrderColumns = true;
            this.dgv_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_main.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_main.Location = new System.Drawing.Point(3, 3);
            this.dgv_main.MaximumSize = new System.Drawing.Size(900, 1000);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.RowTemplate.Height = 25;
            this.dgv_main.Size = new System.Drawing.Size(395, 355);
            this.dgv_main.TabIndex = 22;
            // 
            // btn_newUser
            // 
            this.btn_newUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btn_newUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_newUser.FlatAppearance.BorderSize = 0;
            this.btn_newUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(127)))), ((int)(((byte)(27)))));
            this.btn_newUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newUser.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_newUser.ForeColor = System.Drawing.Color.White;
            this.btn_newUser.Location = new System.Drawing.Point(404, 3);
            this.btn_newUser.MaximumSize = new System.Drawing.Size(89, 50);
            this.btn_newUser.MinimumSize = new System.Drawing.Size(89, 50);
            this.btn_newUser.Name = "btn_newUser";
            this.btn_newUser.Size = new System.Drawing.Size(89, 50);
            this.btn_newUser.TabIndex = 16;
            this.btn_newUser.Text = "Nuevo Usuario";
            this.btn_newUser.UseVisualStyleBackColor = false;
            this.btn_newUser.Click += new System.EventHandler(this.btn_newUser_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(40, 78);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(239, 19);
            this.lbl_title.TabIndex = 29;
            this.lbl_title.Text = "Usuarios cargados en sistema:";
            // 
            // sfrm_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(569, 484);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.tlp_content);
            this.Controls.Add(this.pic_CtrlClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(569, 484);
            this.Name = "sfrm_Usuarios";
            this.Text = "Gestión de Usuarios";
            this.VisibleChanged += new System.EventHandler(this.sfrm_Usuarios_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pic_CtrlClose)).EndInit();
            this.tlp_content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pic_CtrlClose;
        private TableLayoutPanel tlp_content;
        private DataGridView dgv_main;
        private Button btn_newUser;
        private Label lbl_title;
    }
}