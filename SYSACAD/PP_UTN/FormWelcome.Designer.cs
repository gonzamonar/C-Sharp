namespace Presentation
{
    partial class frmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.pnl_titlebar = new System.Windows.Forms.Panel();
            this.lbl_windowTitle = new System.Windows.Forms.Label();
            this.pic_windowLogo = new System.Windows.Forms.PictureBox();
            this.pic_mainLogoBkgd = new System.Windows.Forms.PictureBox();
            this.pic_mainLogo = new System.Windows.Forms.PictureBox();
            this.lbl_mainLogo1 = new System.Windows.Forms.Label();
            this.lbl_mainLogo2 = new System.Windows.Forms.Label();
            this.lbl_mainLogo3 = new System.Windows.Forms.Label();
            this.tmr_fadeIn = new System.Windows.Forms.Timer(this.components);
            this.tmr_fadeOut = new System.Windows.Forms.Timer(this.components);
            this.pnl_titlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_windowLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mainLogoBkgd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mainLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_welcome.Font = new System.Drawing.Font("Constantia", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(110)))), ((int)(((byte)(43)))));
            this.lbl_welcome.Location = new System.Drawing.Point(375, 104);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(207, 37);
            this.lbl_welcome.TabIndex = 14;
            this.lbl_welcome.Text = "BIENVENIDX";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Constantia", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(110)))), ((int)(((byte)(43)))));
            this.lbl_user.Location = new System.Drawing.Point(431, 141);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(158, 31);
            this.lbl_user.TabIndex = 15;
            this.lbl_user.Text = "<USUARIO>";
            // 
            // pnl_titlebar
            // 
            this.pnl_titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(127)))), ((int)(((byte)(27)))));
            this.pnl_titlebar.Controls.Add(this.lbl_windowTitle);
            this.pnl_titlebar.Controls.Add(this.pic_windowLogo);
            this.pnl_titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titlebar.Location = new System.Drawing.Point(0, 0);
            this.pnl_titlebar.Name = "pnl_titlebar";
            this.pnl_titlebar.Size = new System.Drawing.Size(784, 75);
            this.pnl_titlebar.TabIndex = 16;
            // 
            // lbl_windowTitle
            // 
            this.lbl_windowTitle.AutoSize = true;
            this.lbl_windowTitle.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_windowTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_windowTitle.Location = new System.Drawing.Point(79, 23);
            this.lbl_windowTitle.Name = "lbl_windowTitle";
            this.lbl_windowTitle.Size = new System.Drawing.Size(387, 29);
            this.lbl_windowTitle.TabIndex = 13;
            this.lbl_windowTitle.Text = "Sistema de Autogestión UTN-FRA";
            // 
            // pic_windowLogo
            // 
            this.pic_windowLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_windowLogo.Image = ((System.Drawing.Image)(resources.GetObject("pic_windowLogo.Image")));
            this.pic_windowLogo.Location = new System.Drawing.Point(4, 15);
            this.pic_windowLogo.Name = "pic_windowLogo";
            this.pic_windowLogo.Size = new System.Drawing.Size(66, 44);
            this.pic_windowLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_windowLogo.TabIndex = 11;
            this.pic_windowLogo.TabStop = false;
            // 
            // pic_mainLogoBkgd
            // 
            this.pic_mainLogoBkgd.Image = ((System.Drawing.Image)(resources.GetObject("pic_mainLogoBkgd.Image")));
            this.pic_mainLogoBkgd.Location = new System.Drawing.Point(-29, 65);
            this.pic_mainLogoBkgd.Name = "pic_mainLogoBkgd";
            this.pic_mainLogoBkgd.Size = new System.Drawing.Size(454, 348);
            this.pic_mainLogoBkgd.TabIndex = 17;
            this.pic_mainLogoBkgd.TabStop = false;
            // 
            // pic_mainLogo
            // 
            this.pic_mainLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(93)))), ((int)(((byte)(92)))));
            this.pic_mainLogo.Image = ((System.Drawing.Image)(resources.GetObject("pic_mainLogo.Image")));
            this.pic_mainLogo.Location = new System.Drawing.Point(0, 128);
            this.pic_mainLogo.Name = "pic_mainLogo";
            this.pic_mainLogo.Size = new System.Drawing.Size(200, 200);
            this.pic_mainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_mainLogo.TabIndex = 18;
            this.pic_mainLogo.TabStop = false;
            // 
            // lbl_mainLogo1
            // 
            this.lbl_mainLogo1.AutoSize = true;
            this.lbl_mainLogo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(93)))), ((int)(((byte)(92)))));
            this.lbl_mainLogo1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_mainLogo1.ForeColor = System.Drawing.Color.White;
            this.lbl_mainLogo1.Location = new System.Drawing.Point(0, 105);
            this.lbl_mainLogo1.MinimumSize = new System.Drawing.Size(200, 0);
            this.lbl_mainLogo1.Name = "lbl_mainLogo1";
            this.lbl_mainLogo1.Size = new System.Drawing.Size(200, 35);
            this.lbl_mainLogo1.TabIndex = 19;
            this.lbl_mainLogo1.Text = "SYSACAD";
            this.lbl_mainLogo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mainLogo2
            // 
            this.lbl_mainLogo2.AutoSize = true;
            this.lbl_mainLogo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(93)))), ((int)(((byte)(92)))));
            this.lbl_mainLogo2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_mainLogo2.ForeColor = System.Drawing.Color.White;
            this.lbl_mainLogo2.Location = new System.Drawing.Point(0, 324);
            this.lbl_mainLogo2.MinimumSize = new System.Drawing.Size(200, 0);
            this.lbl_mainLogo2.Name = "lbl_mainLogo2";
            this.lbl_mainLogo2.Size = new System.Drawing.Size(200, 18);
            this.lbl_mainLogo2.TabIndex = 20;
            this.lbl_mainLogo2.Text = "FACULTAD REGIONAL";
            this.lbl_mainLogo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mainLogo3
            // 
            this.lbl_mainLogo3.AutoSize = true;
            this.lbl_mainLogo3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(93)))), ((int)(((byte)(92)))));
            this.lbl_mainLogo3.Font = new System.Drawing.Font("Arial", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_mainLogo3.ForeColor = System.Drawing.Color.White;
            this.lbl_mainLogo3.Location = new System.Drawing.Point(0, 342);
            this.lbl_mainLogo3.MinimumSize = new System.Drawing.Size(200, 0);
            this.lbl_mainLogo3.Name = "lbl_mainLogo3";
            this.lbl_mainLogo3.Size = new System.Drawing.Size(200, 27);
            this.lbl_mainLogo3.TabIndex = 21;
            this.lbl_mainLogo3.Text = "AVELLANEDA";
            this.lbl_mainLogo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmr_fadeIn
            // 
            this.tmr_fadeIn.Interval = 30;
            this.tmr_fadeIn.Tick += new System.EventHandler(this.tmr_fadeIn_Tick);
            // 
            // tmr_fadeOut
            // 
            this.tmr_fadeOut.Interval = 30;
            this.tmr_fadeOut.Tick += new System.EventHandler(this.tmr_fadeOut_Tick);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.lbl_mainLogo3);
            this.Controls.Add(this.lbl_mainLogo2);
            this.Controls.Add(this.lbl_mainLogo1);
            this.Controls.Add(this.pic_mainLogo);
            this.Controls.Add(this.pnl_titlebar);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.pic_mainLogoBkgd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome Screen";
            this.Load += new System.EventHandler(this.frmWelcome_Load);
            this.pnl_titlebar.ResumeLayout(false);
            this.pnl_titlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_windowLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mainLogoBkgd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mainLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_welcome;
        private Label lbl_user;
        private Panel pnl_titlebar;
        private Label lbl_windowTitle;
        private PictureBox pic_windowLogo;
        private PictureBox pic_mainLogoBkgd;
        private PictureBox pic_mainLogo;
        private Label lbl_mainLogo1;
        private Label lbl_mainLogo2;
        private Label lbl_mainLogo3;
        private System.Windows.Forms.Timer tmr_fadeIn;
        private System.Windows.Forms.Timer tmr_fadeOut;
    }
}