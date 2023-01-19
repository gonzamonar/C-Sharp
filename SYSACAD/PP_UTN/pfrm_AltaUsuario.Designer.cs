namespace Presentation
{
    partial class pfrm_AltaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pfrm_AltaUsuario));
            this.btn_createUser = new System.Windows.Forms.Button();
            this.pic_CtrlClose = new System.Windows.Forms.PictureBox();
            this.rdo_admin = new System.Windows.Forms.RadioButton();
            this.rdo_profesor = new System.Windows.Forms.RadioButton();
            this.rdo_estudiante = new System.Windows.Forms.RadioButton();
            this.pnl_txtUser = new System.Windows.Forms.Panel();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.pnl_txtpwd = new System.Windows.Forms.Panel();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.pnl_txtLastname = new System.Windows.Forms.Panel();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.pnl_txtName = new System.Windows.Forms.Panel();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pnl_txtDni = new System.Windows.Forms.Panel();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_usertype1 = new System.Windows.Forms.Label();
            this.lbl_usertype2 = new System.Windows.Forms.Label();
            this.lbl_errorUsername = new System.Windows.Forms.Label();
            this.lbl_errorPassword = new System.Windows.Forms.Label();
            this.lbl_errorName = new System.Windows.Forms.Label();
            this.lbl_errorLastname = new System.Windows.Forms.Label();
            this.lbl_errorDni = new System.Windows.Forms.Label();
            this.lbl_errorUserType = new System.Windows.Forms.Label();
            this.lbl_errorGender = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.cmb_gender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CtrlClose)).BeginInit();
            this.pnl_txtUser.SuspendLayout();
            this.pnl_txtpwd.SuspendLayout();
            this.pnl_txtLastname.SuspendLayout();
            this.pnl_txtName.SuspendLayout();
            this.pnl_txtDni.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_createUser
            // 
            this.btn_createUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_createUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(127)))), ((int)(((byte)(27)))));
            this.btn_createUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_createUser.FlatAppearance.BorderSize = 0;
            this.btn_createUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btn_createUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createUser.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_createUser.ForeColor = System.Drawing.Color.White;
            this.btn_createUser.Location = new System.Drawing.Point(380, 495);
            this.btn_createUser.Name = "btn_createUser";
            this.btn_createUser.Size = new System.Drawing.Size(92, 30);
            this.btn_createUser.TabIndex = 16;
            this.btn_createUser.Text = "Dar de Alta";
            this.btn_createUser.UseVisualStyleBackColor = false;
            this.btn_createUser.Click += new System.EventHandler(this.btn_createUser_Click);
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
            // rdo_admin
            // 
            this.rdo_admin.AutoSize = true;
            this.rdo_admin.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rdo_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdo_admin.Location = new System.Drawing.Point(141, 93);
            this.rdo_admin.Name = "rdo_admin";
            this.rdo_admin.Size = new System.Drawing.Size(60, 18);
            this.rdo_admin.TabIndex = 22;
            this.rdo_admin.TabStop = true;
            this.rdo_admin.Text = "Admin";
            this.rdo_admin.UseVisualStyleBackColor = true;
            this.rdo_admin.CheckedChanged += new System.EventHandler(this.rdo_admin_CheckedChanged);
            // 
            // rdo_profesor
            // 
            this.rdo_profesor.AutoSize = true;
            this.rdo_profesor.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rdo_profesor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdo_profesor.Location = new System.Drawing.Point(259, 93);
            this.rdo_profesor.Name = "rdo_profesor";
            this.rdo_profesor.Size = new System.Drawing.Size(69, 18);
            this.rdo_profesor.TabIndex = 23;
            this.rdo_profesor.TabStop = true;
            this.rdo_profesor.Text = "Profesor";
            this.rdo_profesor.UseVisualStyleBackColor = true;
            this.rdo_profesor.CheckedChanged += new System.EventHandler(this.rdo_profesor_CheckedChanged);
            // 
            // rdo_estudiante
            // 
            this.rdo_estudiante.AutoSize = true;
            this.rdo_estudiante.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rdo_estudiante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdo_estudiante.Location = new System.Drawing.Point(389, 93);
            this.rdo_estudiante.Name = "rdo_estudiante";
            this.rdo_estudiante.Size = new System.Drawing.Size(81, 18);
            this.rdo_estudiante.TabIndex = 24;
            this.rdo_estudiante.TabStop = true;
            this.rdo_estudiante.Text = "Estudiante";
            this.rdo_estudiante.UseVisualStyleBackColor = true;
            this.rdo_estudiante.CheckedChanged += new System.EventHandler(this.rdo_estudiante_CheckedChanged);
            // 
            // pnl_txtUser
            // 
            this.pnl_txtUser.BackColor = System.Drawing.Color.White;
            this.pnl_txtUser.Controls.Add(this.txt_username);
            this.pnl_txtUser.Location = new System.Drawing.Point(141, 166);
            this.pnl_txtUser.Name = "pnl_txtUser";
            this.pnl_txtUser.Size = new System.Drawing.Size(331, 29);
            this.pnl_txtUser.TabIndex = 27;
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.White;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.Font = new System.Drawing.Font("Constantia", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txt_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.txt_username.Location = new System.Drawing.Point(8, 6);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(320, 16);
            this.txt_username.TabIndex = 4;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(110)))), ((int)(((byte)(43)))));
            this.lbl_user.Location = new System.Drawing.Point(49, 171);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(61, 17);
            this.lbl_user.TabIndex = 26;
            this.lbl_user.Text = "Usuario";
            // 
            // pnl_txtpwd
            // 
            this.pnl_txtpwd.BackColor = System.Drawing.Color.White;
            this.pnl_txtpwd.Controls.Add(this.txt_pwd);
            this.pnl_txtpwd.Location = new System.Drawing.Point(141, 223);
            this.pnl_txtpwd.Name = "pnl_txtpwd";
            this.pnl_txtpwd.Size = new System.Drawing.Size(331, 29);
            this.pnl_txtpwd.TabIndex = 29;
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
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(110)))), ((int)(((byte)(43)))));
            this.lbl_password.Location = new System.Drawing.Point(49, 228);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(84, 17);
            this.lbl_password.TabIndex = 28;
            this.lbl_password.Text = "Contraseña";
            // 
            // pnl_txtLastname
            // 
            this.pnl_txtLastname.BackColor = System.Drawing.Color.White;
            this.pnl_txtLastname.Controls.Add(this.txt_lastname);
            this.pnl_txtLastname.Location = new System.Drawing.Point(141, 337);
            this.pnl_txtLastname.Name = "pnl_txtLastname";
            this.pnl_txtLastname.Size = new System.Drawing.Size(331, 29);
            this.pnl_txtLastname.TabIndex = 33;
            // 
            // txt_lastname
            // 
            this.txt_lastname.BackColor = System.Drawing.Color.White;
            this.txt_lastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_lastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_lastname.Font = new System.Drawing.Font("Constantia", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txt_lastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.txt_lastname.Location = new System.Drawing.Point(8, 6);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(320, 16);
            this.txt_lastname.TabIndex = 4;
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_lastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(110)))), ((int)(((byte)(43)))));
            this.lbl_lastname.Location = new System.Drawing.Point(49, 342);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(66, 17);
            this.lbl_lastname.TabIndex = 32;
            this.lbl_lastname.Text = "Apellido";
            // 
            // pnl_txtName
            // 
            this.pnl_txtName.BackColor = System.Drawing.Color.White;
            this.pnl_txtName.Controls.Add(this.txt_name);
            this.pnl_txtName.Location = new System.Drawing.Point(141, 280);
            this.pnl_txtName.Name = "pnl_txtName";
            this.pnl_txtName.Size = new System.Drawing.Size(331, 29);
            this.pnl_txtName.TabIndex = 31;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.White;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.Font = new System.Drawing.Font("Constantia", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txt_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.txt_name.Location = new System.Drawing.Point(8, 6);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(320, 16);
            this.txt_name.TabIndex = 4;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(110)))), ((int)(((byte)(43)))));
            this.lbl_name.Location = new System.Drawing.Point(49, 285);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(63, 17);
            this.lbl_name.TabIndex = 30;
            this.lbl_name.Text = "Nombre";
            // 
            // pnl_txtDni
            // 
            this.pnl_txtDni.BackColor = System.Drawing.Color.White;
            this.pnl_txtDni.Controls.Add(this.txt_dni);
            this.pnl_txtDni.Location = new System.Drawing.Point(141, 394);
            this.pnl_txtDni.Name = "pnl_txtDni";
            this.pnl_txtDni.Size = new System.Drawing.Size(140, 29);
            this.pnl_txtDni.TabIndex = 35;
            // 
            // txt_dni
            // 
            this.txt_dni.BackColor = System.Drawing.Color.White;
            this.txt_dni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_dni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_dni.Font = new System.Drawing.Font("Constantia", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txt_dni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.txt_dni.Location = new System.Drawing.Point(8, 6);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(129, 16);
            this.txt_dni.TabIndex = 4;
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_dni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(110)))), ((int)(((byte)(43)))));
            this.lbl_dni.Location = new System.Drawing.Point(49, 399);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(35, 17);
            this.lbl_dni.TabIndex = 34;
            this.lbl_dni.Text = "DNI";
            // 
            // lbl_usertype1
            // 
            this.lbl_usertype1.AutoSize = true;
            this.lbl_usertype1.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_usertype1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(110)))), ((int)(((byte)(43)))));
            this.lbl_usertype1.Location = new System.Drawing.Point(51, 76);
            this.lbl_usertype1.Name = "lbl_usertype1";
            this.lbl_usertype1.Size = new System.Drawing.Size(61, 18);
            this.lbl_usertype1.TabIndex = 36;
            this.lbl_usertype1.Text = "Tipo de";
            // 
            // lbl_usertype2
            // 
            this.lbl_usertype2.AutoSize = true;
            this.lbl_usertype2.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_usertype2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(110)))), ((int)(((byte)(43)))));
            this.lbl_usertype2.Location = new System.Drawing.Point(51, 94);
            this.lbl_usertype2.Name = "lbl_usertype2";
            this.lbl_usertype2.Size = new System.Drawing.Size(69, 18);
            this.lbl_usertype2.TabIndex = 37;
            this.lbl_usertype2.Text = "Usuario:";
            // 
            // lbl_errorUsername
            // 
            this.lbl_errorUsername.AutoSize = true;
            this.lbl_errorUsername.Font = new System.Drawing.Font("Alef", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_errorUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_errorUsername.Location = new System.Drawing.Point(141, 148);
            this.lbl_errorUsername.Name = "lbl_errorUsername";
            this.lbl_errorUsername.Size = new System.Drawing.Size(0, 16);
            this.lbl_errorUsername.TabIndex = 38;
            // 
            // lbl_errorPassword
            // 
            this.lbl_errorPassword.AutoSize = true;
            this.lbl_errorPassword.Font = new System.Drawing.Font("Alef", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_errorPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_errorPassword.Location = new System.Drawing.Point(141, 205);
            this.lbl_errorPassword.Name = "lbl_errorPassword";
            this.lbl_errorPassword.Size = new System.Drawing.Size(0, 16);
            this.lbl_errorPassword.TabIndex = 39;
            // 
            // lbl_errorName
            // 
            this.lbl_errorName.AutoSize = true;
            this.lbl_errorName.Font = new System.Drawing.Font("Alef", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_errorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_errorName.Location = new System.Drawing.Point(141, 262);
            this.lbl_errorName.Name = "lbl_errorName";
            this.lbl_errorName.Size = new System.Drawing.Size(0, 16);
            this.lbl_errorName.TabIndex = 40;
            // 
            // lbl_errorLastname
            // 
            this.lbl_errorLastname.AutoSize = true;
            this.lbl_errorLastname.Font = new System.Drawing.Font("Alef", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_errorLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_errorLastname.Location = new System.Drawing.Point(141, 319);
            this.lbl_errorLastname.Name = "lbl_errorLastname";
            this.lbl_errorLastname.Size = new System.Drawing.Size(0, 16);
            this.lbl_errorLastname.TabIndex = 41;
            // 
            // lbl_errorDni
            // 
            this.lbl_errorDni.AutoSize = true;
            this.lbl_errorDni.Font = new System.Drawing.Font("Alef", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_errorDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_errorDni.Location = new System.Drawing.Point(141, 376);
            this.lbl_errorDni.Name = "lbl_errorDni";
            this.lbl_errorDni.Size = new System.Drawing.Size(0, 16);
            this.lbl_errorDni.TabIndex = 42;
            // 
            // lbl_errorUserType
            // 
            this.lbl_errorUserType.AutoSize = true;
            this.lbl_errorUserType.Font = new System.Drawing.Font("Alef", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_errorUserType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_errorUserType.Location = new System.Drawing.Point(141, 78);
            this.lbl_errorUserType.Name = "lbl_errorUserType";
            this.lbl_errorUserType.Size = new System.Drawing.Size(0, 16);
            this.lbl_errorUserType.TabIndex = 43;
            // 
            // lbl_errorGender
            // 
            this.lbl_errorGender.AutoSize = true;
            this.lbl_errorGender.Font = new System.Drawing.Font("Alef", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_errorGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_errorGender.Location = new System.Drawing.Point(141, 437);
            this.lbl_errorGender.Name = "lbl_errorGender";
            this.lbl_errorGender.Size = new System.Drawing.Size(0, 16);
            this.lbl_errorGender.TabIndex = 46;
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(110)))), ((int)(((byte)(43)))));
            this.lbl_gender.Location = new System.Drawing.Point(49, 456);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(57, 17);
            this.lbl_gender.TabIndex = 44;
            this.lbl_gender.Text = "Género";
            // 
            // cmb_gender
            // 
            this.cmb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_gender.Font = new System.Drawing.Font("Constantia", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_gender.FormattingEnabled = true;
            this.cmb_gender.Location = new System.Drawing.Point(141, 455);
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.Size = new System.Drawing.Size(142, 23);
            this.cmb_gender.TabIndex = 47;
            // 
            // pfrm_AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(510, 551);
            this.Controls.Add(this.cmb_gender);
            this.Controls.Add(this.lbl_errorGender);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_errorUserType);
            this.Controls.Add(this.lbl_errorDni);
            this.Controls.Add(this.lbl_errorLastname);
            this.Controls.Add(this.lbl_errorName);
            this.Controls.Add(this.lbl_errorPassword);
            this.Controls.Add(this.lbl_errorUsername);
            this.Controls.Add(this.lbl_usertype2);
            this.Controls.Add(this.lbl_usertype1);
            this.Controls.Add(this.pnl_txtDni);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.pnl_txtLastname);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.pnl_txtName);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.pnl_txtpwd);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.pnl_txtUser);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.rdo_estudiante);
            this.Controls.Add(this.rdo_profesor);
            this.Controls.Add(this.rdo_admin);
            this.Controls.Add(this.pic_CtrlClose);
            this.Controls.Add(this.btn_createUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pfrm_AltaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popform Alta Usuario";
            this.Load += new System.EventHandler(this.pfrm_AltaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_CtrlClose)).EndInit();
            this.pnl_txtUser.ResumeLayout(false);
            this.pnl_txtUser.PerformLayout();
            this.pnl_txtpwd.ResumeLayout(false);
            this.pnl_txtpwd.PerformLayout();
            this.pnl_txtLastname.ResumeLayout(false);
            this.pnl_txtLastname.PerformLayout();
            this.pnl_txtName.ResumeLayout(false);
            this.pnl_txtName.PerformLayout();
            this.pnl_txtDni.ResumeLayout(false);
            this.pnl_txtDni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_createUser;
        private PictureBox pic_CtrlClose;
        private RadioButton rdo_admin;
        private RadioButton rdo_profesor;
        private RadioButton rdo_estudiante;
        private Panel pnl_txtUser;
        private TextBox txt_username;
        private Label lbl_user;
        private Panel pnl_txtpwd;
        private TextBox txt_pwd;
        private Label lbl_password;
        private Panel pnl_txtLastname;
        private TextBox txt_lastname;
        private Label lbl_lastname;
        private Panel pnl_txtName;
        private TextBox txt_name;
        private Label lbl_name;
        private Panel pnl_txtDni;
        private TextBox txt_dni;
        private Label lbl_dni;
        private Label lbl_usertype1;
        private Label lbl_usertype2;
        private Label lbl_errorUsername;
        private Label lbl_errorPassword;
        private Label lbl_errorName;
        private Label lbl_errorLastname;
        private Label lbl_errorDni;
        private Label lbl_errorUserType;
        private Label lbl_errorGender;
        private Label lbl_gender;
        private ComboBox cmb_gender;
    }
}