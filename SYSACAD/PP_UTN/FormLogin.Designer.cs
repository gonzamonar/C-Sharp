namespace Presentation
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnl_titlebar = new System.Windows.Forms.Panel();
            this.pic_windowCtrl2Close = new System.Windows.Forms.PictureBox();
            this.pic_windowCtrl1Minimize = new System.Windows.Forms.PictureBox();
            this.lbl_windowTitle = new System.Windows.Forms.Label();
            this.pic_windowLogo = new System.Windows.Forms.PictureBox();
            this.pnl_txtPwd = new System.Windows.Forms.Panel();
            this.btn_pwdcharSwitch = new System.Windows.Forms.Button();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.pnl_txtUser = new System.Windows.Forms.Panel();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.btn_tryLogin = new System.Windows.Forms.Button();
            this.pic_mainLogo = new System.Windows.Forms.PictureBox();
            this.lbl_accesoRapido = new System.Windows.Forms.Label();
            this.btn_autofillAlumno = new System.Windows.Forms.Button();
            this.btn_autofillAdmin = new System.Windows.Forms.Button();
            this.btn_autofillProfesor = new System.Windows.Forms.Button();
            this.pnl_titlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_windowCtrl2Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_windowCtrl1Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_windowLogo)).BeginInit();
            this.pnl_txtPwd.SuspendLayout();
            this.pnl_txtUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mainLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_titlebar
            // 
            this.pnl_titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(127)))), ((int)(((byte)(27)))));
            this.pnl_titlebar.Controls.Add(this.pic_windowCtrl2Close);
            this.pnl_titlebar.Controls.Add(this.pic_windowCtrl1Minimize);
            this.pnl_titlebar.Controls.Add(this.lbl_windowTitle);
            this.pnl_titlebar.Controls.Add(this.pic_windowLogo);
            this.pnl_titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titlebar.Location = new System.Drawing.Point(0, 0);
            this.pnl_titlebar.Name = "pnl_titlebar";
            this.pnl_titlebar.Size = new System.Drawing.Size(780, 50);
            this.pnl_titlebar.TabIndex = 0;
            this.pnl_titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_titlebar_MouseDown);
            // 
            // pic_windowCtrl2Close
            // 
            this.pic_windowCtrl2Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_windowCtrl2Close.Image = ((System.Drawing.Image)(resources.GetObject("pic_windowCtrl2Close.Image")));
            this.pic_windowCtrl2Close.Location = new System.Drawing.Point(748, 0);
            this.pic_windowCtrl2Close.Name = "pic_windowCtrl2Close";
            this.pic_windowCtrl2Close.Size = new System.Drawing.Size(20, 40);
            this.pic_windowCtrl2Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_windowCtrl2Close.TabIndex = 17;
            this.pic_windowCtrl2Close.TabStop = false;
            this.pic_windowCtrl2Close.Click += new System.EventHandler(this.pic_windowCtrl2Close_Click);
            this.pic_windowCtrl2Close.MouseEnter += new System.EventHandler(this.pic_windowCtrl2Close_MouseEnter);
            this.pic_windowCtrl2Close.MouseLeave += new System.EventHandler(this.pic_windowCtrl2Close_MouseLeave);
            // 
            // pic_windowCtrl1Minimize
            // 
            this.pic_windowCtrl1Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_windowCtrl1Minimize.Image = ((System.Drawing.Image)(resources.GetObject("pic_windowCtrl1Minimize.Image")));
            this.pic_windowCtrl1Minimize.Location = new System.Drawing.Point(719, 0);
            this.pic_windowCtrl1Minimize.Name = "pic_windowCtrl1Minimize";
            this.pic_windowCtrl1Minimize.Size = new System.Drawing.Size(20, 40);
            this.pic_windowCtrl1Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_windowCtrl1Minimize.TabIndex = 17;
            this.pic_windowCtrl1Minimize.TabStop = false;
            this.pic_windowCtrl1Minimize.MouseEnter += new System.EventHandler(this.pic_windowCtrl1Minimize_MouseEnter);
            this.pic_windowCtrl1Minimize.MouseLeave += new System.EventHandler(this.pic_windowCtrl1Minimize_MouseLeave);
            // 
            // lbl_windowTitle
            // 
            this.lbl_windowTitle.AutoSize = true;
            this.lbl_windowTitle.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_windowTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_windowTitle.Location = new System.Drawing.Point(79, 11);
            this.lbl_windowTitle.Name = "lbl_windowTitle";
            this.lbl_windowTitle.Size = new System.Drawing.Size(387, 29);
            this.lbl_windowTitle.TabIndex = 13;
            this.lbl_windowTitle.Text = "Sistema de Autogestión UTN-FRA";
            this.lbl_windowTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_windowTitle_MouseDown);
            // 
            // pic_windowLogo
            // 
            this.pic_windowLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_windowLogo.Image = ((System.Drawing.Image)(resources.GetObject("pic_windowLogo.Image")));
            this.pic_windowLogo.Location = new System.Drawing.Point(4, 3);
            this.pic_windowLogo.Name = "pic_windowLogo";
            this.pic_windowLogo.Size = new System.Drawing.Size(66, 44);
            this.pic_windowLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_windowLogo.TabIndex = 11;
            this.pic_windowLogo.TabStop = false;
            // 
            // pnl_txtPwd
            // 
            this.pnl_txtPwd.BackColor = System.Drawing.Color.White;
            this.pnl_txtPwd.Controls.Add(this.btn_pwdcharSwitch);
            this.pnl_txtPwd.Controls.Add(this.txt_pwd);
            this.pnl_txtPwd.Location = new System.Drawing.Point(226, 375);
            this.pnl_txtPwd.Name = "pnl_txtPwd";
            this.pnl_txtPwd.Size = new System.Drawing.Size(331, 29);
            this.pnl_txtPwd.TabIndex = 9;
            // 
            // btn_pwdcharSwitch
            // 
            this.btn_pwdcharSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btn_pwdcharSwitch.FlatAppearance.BorderSize = 0;
            this.btn_pwdcharSwitch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(127)))), ((int)(((byte)(27)))));
            this.btn_pwdcharSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pwdcharSwitch.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_pwdcharSwitch.ForeColor = System.Drawing.Color.White;
            this.btn_pwdcharSwitch.Location = new System.Drawing.Point(267, 0);
            this.btn_pwdcharSwitch.Name = "btn_pwdcharSwitch";
            this.btn_pwdcharSwitch.Size = new System.Drawing.Size(64, 29);
            this.btn_pwdcharSwitch.TabIndex = 9;
            this.btn_pwdcharSwitch.Text = "Mostrar";
            this.btn_pwdcharSwitch.UseVisualStyleBackColor = false;
            this.btn_pwdcharSwitch.Click += new System.EventHandler(this.btn_pwdcharSwitch_Click);
            // 
            // txt_pwd
            // 
            this.txt_pwd.BackColor = System.Drawing.Color.White;
            this.txt_pwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pwd.Font = new System.Drawing.Font("Constantia", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txt_pwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.txt_pwd.Location = new System.Drawing.Point(8, 6);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(320, 16);
            this.txt_pwd.TabIndex = 4;
            this.txt_pwd.UseSystemPasswordChar = true;
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_pwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(110)))), ((int)(((byte)(43)))));
            this.lbl_pwd.Location = new System.Drawing.Point(226, 355);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(91, 18);
            this.lbl_pwd.TabIndex = 8;
            this.lbl_pwd.Text = "Contraseña";
            // 
            // pnl_txtUser
            // 
            this.pnl_txtUser.BackColor = System.Drawing.Color.White;
            this.pnl_txtUser.Controls.Add(this.txt_user);
            this.pnl_txtUser.Location = new System.Drawing.Point(226, 288);
            this.pnl_txtUser.Name = "pnl_txtUser";
            this.pnl_txtUser.Size = new System.Drawing.Size(331, 29);
            this.pnl_txtUser.TabIndex = 7;
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.White;
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user.Font = new System.Drawing.Font("Constantia", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txt_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.txt_user.Location = new System.Drawing.Point(8, 6);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(320, 16);
            this.txt_user.TabIndex = 4;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(110)))), ((int)(((byte)(43)))));
            this.lbl_user.Location = new System.Drawing.Point(226, 268);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(65, 18);
            this.lbl_user.TabIndex = 6;
            this.lbl_user.Text = "Usuario";
            // 
            // btn_tryLogin
            // 
            this.btn_tryLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btn_tryLogin.FlatAppearance.BorderSize = 0;
            this.btn_tryLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(127)))), ((int)(((byte)(27)))));
            this.btn_tryLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tryLogin.Font = new System.Drawing.Font("Constantia", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_tryLogin.ForeColor = System.Drawing.Color.White;
            this.btn_tryLogin.Location = new System.Drawing.Point(226, 469);
            this.btn_tryLogin.Name = "btn_tryLogin";
            this.btn_tryLogin.Size = new System.Drawing.Size(331, 37);
            this.btn_tryLogin.TabIndex = 10;
            this.btn_tryLogin.Text = "Acceder";
            this.btn_tryLogin.UseVisualStyleBackColor = false;
            this.btn_tryLogin.Click += new System.EventHandler(this.btn_tryLogin_Click);
            // 
            // pic_mainLogo
            // 
            this.pic_mainLogo.BackColor = System.Drawing.SystemColors.Control;
            this.pic_mainLogo.Image = ((System.Drawing.Image)(resources.GetObject("pic_mainLogo.Image")));
            this.pic_mainLogo.Location = new System.Drawing.Point(285, 50);
            this.pic_mainLogo.Name = "pic_mainLogo";
            this.pic_mainLogo.Size = new System.Drawing.Size(200, 200);
            this.pic_mainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_mainLogo.TabIndex = 12;
            this.pic_mainLogo.TabStop = false;
            // 
            // lbl_accesoRapido
            // 
            this.lbl_accesoRapido.AutoSize = true;
            this.lbl_accesoRapido.Font = new System.Drawing.Font("Constantia", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_accesoRapido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(110)))), ((int)(((byte)(43)))));
            this.lbl_accesoRapido.Location = new System.Drawing.Point(12, 645);
            this.lbl_accesoRapido.Name = "lbl_accesoRapido";
            this.lbl_accesoRapido.Size = new System.Drawing.Size(154, 24);
            this.lbl_accesoRapido.TabIndex = 13;
            this.lbl_accesoRapido.Text = "Acceso Rápido:";
            // 
            // btn_autofillAlumno
            // 
            this.btn_autofillAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btn_autofillAlumno.FlatAppearance.BorderSize = 0;
            this.btn_autofillAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(127)))), ((int)(((byte)(27)))));
            this.btn_autofillAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_autofillAlumno.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_autofillAlumno.ForeColor = System.Drawing.Color.White;
            this.btn_autofillAlumno.Location = new System.Drawing.Point(383, 645);
            this.btn_autofillAlumno.Name = "btn_autofillAlumno";
            this.btn_autofillAlumno.Size = new System.Drawing.Size(92, 26);
            this.btn_autofillAlumno.TabIndex = 16;
            this.btn_autofillAlumno.Text = "Estudiante";
            this.btn_autofillAlumno.UseVisualStyleBackColor = false;
            this.btn_autofillAlumno.Click += new System.EventHandler(this.btn_autofillAlumno_Click);
            // 
            // btn_autofillAdmin
            // 
            this.btn_autofillAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btn_autofillAdmin.FlatAppearance.BorderSize = 0;
            this.btn_autofillAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(127)))), ((int)(((byte)(27)))));
            this.btn_autofillAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_autofillAdmin.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_autofillAdmin.ForeColor = System.Drawing.Color.White;
            this.btn_autofillAdmin.Location = new System.Drawing.Point(187, 645);
            this.btn_autofillAdmin.Name = "btn_autofillAdmin";
            this.btn_autofillAdmin.Size = new System.Drawing.Size(92, 26);
            this.btn_autofillAdmin.TabIndex = 14;
            this.btn_autofillAdmin.Text = "Admin";
            this.btn_autofillAdmin.UseVisualStyleBackColor = false;
            this.btn_autofillAdmin.Click += new System.EventHandler(this.btn_autofillAdmin_Click);
            // 
            // btn_autofillProfesor
            // 
            this.btn_autofillProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btn_autofillProfesor.FlatAppearance.BorderSize = 0;
            this.btn_autofillProfesor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(127)))), ((int)(((byte)(27)))));
            this.btn_autofillProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_autofillProfesor.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_autofillProfesor.ForeColor = System.Drawing.Color.White;
            this.btn_autofillProfesor.Location = new System.Drawing.Point(285, 645);
            this.btn_autofillProfesor.Name = "btn_autofillProfesor";
            this.btn_autofillProfesor.Size = new System.Drawing.Size(92, 26);
            this.btn_autofillProfesor.TabIndex = 15;
            this.btn_autofillProfesor.Text = "Profesor";
            this.btn_autofillProfesor.UseVisualStyleBackColor = false;
            this.btn_autofillProfesor.Click += new System.EventHandler(this.btn_autofillProfesor_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 680);
            this.Controls.Add(this.lbl_accesoRapido);
            this.Controls.Add(this.btn_autofillAlumno);
            this.Controls.Add(this.btn_autofillAdmin);
            this.Controls.Add(this.btn_autofillProfesor);
            this.Controls.Add(this.pic_mainLogo);
            this.Controls.Add(this.btn_tryLogin);
            this.Controls.Add(this.pnl_txtPwd);
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.pnl_txtUser);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.pnl_titlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.VisibleChanged += new System.EventHandler(this.frmLogin_VisibleChanged);
            this.pnl_titlebar.ResumeLayout(false);
            this.pnl_titlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_windowCtrl2Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_windowCtrl1Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_windowLogo)).EndInit();
            this.pnl_txtPwd.ResumeLayout(false);
            this.pnl_txtPwd.PerformLayout();
            this.pnl_txtUser.ResumeLayout(false);
            this.pnl_txtUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mainLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnl_titlebar;
        private Panel pnl_txtPwd;
        private Button btn_pwdcharSwitch;
        private TextBox txt_pwd;
        private Label lbl_pwd;
        private Panel pnl_txtUser;
        private TextBox txt_user;
        private Label lbl_user;
        private Button btn_tryLogin;
        private PictureBox pic_windowLogo;
        private PictureBox pic_mainLogo;
        private Label lbl_windowTitle;
        private Label lbl_accesoRapido;
        private Button btn_autofillAlumno;
        private Button btn_autofillAdmin;
        private Button btn_autofillProfesor;
        private PictureBox pic_windowCtrl2Close;
        private PictureBox pic_windowCtrl1Minimize;
    }
}