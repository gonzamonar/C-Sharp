namespace Presentation
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnl_titlebar = new System.Windows.Forms.Panel();
            this.pnl_windowCtrl = new System.Windows.Forms.Panel();
            this.pic_windowCtrl1Minimize = new System.Windows.Forms.PictureBox();
            this.pic_windowCtrl2Maximize = new System.Windows.Forms.PictureBox();
            this.pic_windowCtrl3Close = new System.Windows.Forms.PictureBox();
            this.lbl_windowTitle = new System.Windows.Forms.Label();
            this.pic_windowLogo = new System.Windows.Forms.PictureBox();
            this.pnl_sideMenu = new System.Windows.Forms.Panel();
            this.btn_asistencias = new System.Windows.Forms.Button();
            this.btn_inscripciones = new System.Windows.Forms.Button();
            this.btn_examenes = new System.Windows.Forms.Button();
            this.btn_calificar = new System.Windows.Forms.Button();
            this.btn_docentes = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_estudiantes = new System.Windows.Forms.Button();
            this.btn_materias = new System.Windows.Forms.Button();
            this.btn_usuarios = new System.Windows.Forms.Button();
            this.pnl_logoSysacad = new System.Windows.Forms.Panel();
            this.lbl_logoSysacad3 = new System.Windows.Forms.Label();
            this.lbl_logoSysacad1 = new System.Windows.Forms.Label();
            this.lbl_logoSysacad2 = new System.Windows.Forms.Label();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pic_mainLogo = new System.Windows.Forms.PictureBox();
            this.lbl_materia = new System.Windows.Forms.Label();
            this.lbl_infoUsername = new System.Windows.Forms.Label();
            this.lbl_infoName = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_infoPermiso = new System.Windows.Forms.Label();
            this.lbl_Permiso = new System.Windows.Forms.Label();
            this.pic_userIcon = new System.Windows.Forms.PictureBox();
            this.lbl_infoApellido = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.tlp_userData = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_info1 = new System.Windows.Forms.Panel();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.pnl_info2 = new System.Windows.Forms.Panel();
            this.btn_estadisticas = new System.Windows.Forms.Button();
            this.pnl_titlebar.SuspendLayout();
            this.pnl_windowCtrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_windowCtrl1Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_windowCtrl2Maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_windowCtrl3Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_windowLogo)).BeginInit();
            this.pnl_sideMenu.SuspendLayout();
            this.pnl_logoSysacad.SuspendLayout();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mainLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_userIcon)).BeginInit();
            this.tlp_userData.SuspendLayout();
            this.pnl_info1.SuspendLayout();
            this.pnl_info2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_titlebar
            // 
            this.pnl_titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(127)))), ((int)(((byte)(27)))));
            this.pnl_titlebar.Controls.Add(this.pnl_windowCtrl);
            this.pnl_titlebar.Controls.Add(this.lbl_windowTitle);
            this.pnl_titlebar.Controls.Add(this.pic_windowLogo);
            this.pnl_titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titlebar.Location = new System.Drawing.Point(0, 0);
            this.pnl_titlebar.Name = "pnl_titlebar";
            this.pnl_titlebar.Size = new System.Drawing.Size(1080, 40);
            this.pnl_titlebar.TabIndex = 13;
            this.pnl_titlebar.DoubleClick += new System.EventHandler(this.pnl_titlebar_DoubleClick);
            this.pnl_titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_titlebar_MouseDown);
            // 
            // pnl_windowCtrl
            // 
            this.pnl_windowCtrl.Controls.Add(this.pic_windowCtrl1Minimize);
            this.pnl_windowCtrl.Controls.Add(this.pic_windowCtrl2Maximize);
            this.pnl_windowCtrl.Controls.Add(this.pic_windowCtrl3Close);
            this.pnl_windowCtrl.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_windowCtrl.Location = new System.Drawing.Point(980, 0);
            this.pnl_windowCtrl.Name = "pnl_windowCtrl";
            this.pnl_windowCtrl.Size = new System.Drawing.Size(100, 40);
            this.pnl_windowCtrl.TabIndex = 19;
            // 
            // pic_windowCtrl1Minimize
            // 
            this.pic_windowCtrl1Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_windowCtrl1Minimize.Image = ((System.Drawing.Image)(resources.GetObject("pic_windowCtrl1Minimize.Image")));
            this.pic_windowCtrl1Minimize.Location = new System.Drawing.Point(12, 0);
            this.pic_windowCtrl1Minimize.Name = "pic_windowCtrl1Minimize";
            this.pic_windowCtrl1Minimize.Size = new System.Drawing.Size(20, 40);
            this.pic_windowCtrl1Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_windowCtrl1Minimize.TabIndex = 18;
            this.pic_windowCtrl1Minimize.TabStop = false;
            this.pic_windowCtrl1Minimize.Click += new System.EventHandler(this.pic_windowCtrl1Minimize_Click);
            this.pic_windowCtrl1Minimize.MouseEnter += new System.EventHandler(this.pic_windowCtrl1Minimize_MouseEnter);
            this.pic_windowCtrl1Minimize.MouseLeave += new System.EventHandler(this.pic_windowCtrl1Minimize_MouseLeave);
            // 
            // pic_windowCtrl2Maximize
            // 
            this.pic_windowCtrl2Maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_windowCtrl2Maximize.Image = ((System.Drawing.Image)(resources.GetObject("pic_windowCtrl2Maximize.Image")));
            this.pic_windowCtrl2Maximize.Location = new System.Drawing.Point(40, 0);
            this.pic_windowCtrl2Maximize.Name = "pic_windowCtrl2Maximize";
            this.pic_windowCtrl2Maximize.Size = new System.Drawing.Size(20, 40);
            this.pic_windowCtrl2Maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_windowCtrl2Maximize.TabIndex = 17;
            this.pic_windowCtrl2Maximize.TabStop = false;
            this.pic_windowCtrl2Maximize.Click += new System.EventHandler(this.pic_windowCtrl2Maximize_Click);
            this.pic_windowCtrl2Maximize.MouseEnter += new System.EventHandler(this.pic_windowCtrl2Maximize_MouseEnter);
            this.pic_windowCtrl2Maximize.MouseLeave += new System.EventHandler(this.pic_windowCtrl2Maximize_MouseLeave);
            // 
            // pic_windowCtrl3Close
            // 
            this.pic_windowCtrl3Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_windowCtrl3Close.Image = ((System.Drawing.Image)(resources.GetObject("pic_windowCtrl3Close.Image")));
            this.pic_windowCtrl3Close.Location = new System.Drawing.Point(68, 0);
            this.pic_windowCtrl3Close.Name = "pic_windowCtrl3Close";
            this.pic_windowCtrl3Close.Size = new System.Drawing.Size(20, 40);
            this.pic_windowCtrl3Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_windowCtrl3Close.TabIndex = 17;
            this.pic_windowCtrl3Close.TabStop = false;
            this.pic_windowCtrl3Close.Click += new System.EventHandler(this.pic_windowCtrl3Close_Click);
            this.pic_windowCtrl3Close.MouseEnter += new System.EventHandler(this.pic_windowCtrl3Close_MouseEnter);
            this.pic_windowCtrl3Close.MouseLeave += new System.EventHandler(this.pic_windowCtrl3Close_MouseLeave);
            // 
            // lbl_windowTitle
            // 
            this.lbl_windowTitle.AutoSize = true;
            this.lbl_windowTitle.Font = new System.Drawing.Font("Constantia", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_windowTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_windowTitle.Location = new System.Drawing.Point(49, 8);
            this.lbl_windowTitle.Name = "lbl_windowTitle";
            this.lbl_windowTitle.Size = new System.Drawing.Size(328, 24);
            this.lbl_windowTitle.TabIndex = 13;
            this.lbl_windowTitle.Text = "Sistema de Autogestión UTN-FRA";
            this.lbl_windowTitle.DoubleClick += new System.EventHandler(this.lbl_windowTitle_DoubleClick);
            this.lbl_windowTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_windowTitle_MouseDown);
            // 
            // pic_windowLogo
            // 
            this.pic_windowLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_windowLogo.Image = ((System.Drawing.Image)(resources.GetObject("pic_windowLogo.Image")));
            this.pic_windowLogo.Location = new System.Drawing.Point(4, 5);
            this.pic_windowLogo.Name = "pic_windowLogo";
            this.pic_windowLogo.Size = new System.Drawing.Size(39, 30);
            this.pic_windowLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_windowLogo.TabIndex = 11;
            this.pic_windowLogo.TabStop = false;
            // 
            // pnl_sideMenu
            // 
            this.pnl_sideMenu.AutoScroll = true;
            this.pnl_sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.pnl_sideMenu.Controls.Add(this.btn_estadisticas);
            this.pnl_sideMenu.Controls.Add(this.btn_asistencias);
            this.pnl_sideMenu.Controls.Add(this.btn_inscripciones);
            this.pnl_sideMenu.Controls.Add(this.btn_examenes);
            this.pnl_sideMenu.Controls.Add(this.btn_calificar);
            this.pnl_sideMenu.Controls.Add(this.btn_docentes);
            this.pnl_sideMenu.Controls.Add(this.btn_logout);
            this.pnl_sideMenu.Controls.Add(this.btn_estudiantes);
            this.pnl_sideMenu.Controls.Add(this.btn_materias);
            this.pnl_sideMenu.Controls.Add(this.btn_usuarios);
            this.pnl_sideMenu.Controls.Add(this.pnl_logoSysacad);
            this.pnl_sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_sideMenu.Location = new System.Drawing.Point(0, 40);
            this.pnl_sideMenu.Name = "pnl_sideMenu";
            this.pnl_sideMenu.Size = new System.Drawing.Size(230, 680);
            this.pnl_sideMenu.TabIndex = 14;
            // 
            // btn_asistencias
            // 
            this.btn_asistencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btn_asistencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_asistencias.FlatAppearance.BorderSize = 0;
            this.btn_asistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_asistencias.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_asistencias.ForeColor = System.Drawing.Color.White;
            this.btn_asistencias.Location = new System.Drawing.Point(0, 415);
            this.btn_asistencias.Name = "btn_asistencias";
            this.btn_asistencias.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_asistencias.Size = new System.Drawing.Size(230, 45);
            this.btn_asistencias.TabIndex = 14;
            this.btn_asistencias.Text = "Dar Asistencia";
            this.btn_asistencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_asistencias.UseVisualStyleBackColor = false;
            this.btn_asistencias.Click += new System.EventHandler(this.btn_asistencias_Click);
            // 
            // btn_inscripciones
            // 
            this.btn_inscripciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btn_inscripciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_inscripciones.FlatAppearance.BorderSize = 0;
            this.btn_inscripciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inscripciones.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_inscripciones.ForeColor = System.Drawing.Color.White;
            this.btn_inscripciones.Location = new System.Drawing.Point(0, 370);
            this.btn_inscripciones.Name = "btn_inscripciones";
            this.btn_inscripciones.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_inscripciones.Size = new System.Drawing.Size(230, 45);
            this.btn_inscripciones.TabIndex = 13;
            this.btn_inscripciones.Text = "Mis Inscripciones";
            this.btn_inscripciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inscripciones.UseVisualStyleBackColor = false;
            this.btn_inscripciones.Click += new System.EventHandler(this.btn_inscripciones_Click);
            // 
            // btn_examenes
            // 
            this.btn_examenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btn_examenes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_examenes.FlatAppearance.BorderSize = 0;
            this.btn_examenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_examenes.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_examenes.ForeColor = System.Drawing.Color.White;
            this.btn_examenes.Location = new System.Drawing.Point(0, 325);
            this.btn_examenes.Name = "btn_examenes";
            this.btn_examenes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_examenes.Size = new System.Drawing.Size(230, 45);
            this.btn_examenes.TabIndex = 12;
            this.btn_examenes.Text = "Gestión de Exámenes";
            this.btn_examenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_examenes.UseVisualStyleBackColor = false;
            this.btn_examenes.Click += new System.EventHandler(this.btn_examenes_Click);
            // 
            // btn_calificar
            // 
            this.btn_calificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btn_calificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_calificar.FlatAppearance.BorderSize = 0;
            this.btn_calificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calificar.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_calificar.ForeColor = System.Drawing.Color.White;
            this.btn_calificar.Location = new System.Drawing.Point(0, 280);
            this.btn_calificar.Name = "btn_calificar";
            this.btn_calificar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_calificar.Size = new System.Drawing.Size(230, 45);
            this.btn_calificar.TabIndex = 11;
            this.btn_calificar.Text = "Calificaciones";
            this.btn_calificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_calificar.UseVisualStyleBackColor = false;
            this.btn_calificar.Click += new System.EventHandler(this.btn_calificar_Click);
            // 
            // btn_docentes
            // 
            this.btn_docentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btn_docentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_docentes.FlatAppearance.BorderSize = 0;
            this.btn_docentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_docentes.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_docentes.ForeColor = System.Drawing.Color.White;
            this.btn_docentes.Location = new System.Drawing.Point(0, 235);
            this.btn_docentes.Name = "btn_docentes";
            this.btn_docentes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_docentes.Size = new System.Drawing.Size(230, 45);
            this.btn_docentes.TabIndex = 10;
            this.btn_docentes.Text = "Gestión de Docentes";
            this.btn_docentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_docentes.UseVisualStyleBackColor = false;
            this.btn_docentes.Click += new System.EventHandler(this.btn_docentes_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btn_logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_logout.BackgroundImage")));
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(0, 635);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_logout.Size = new System.Drawing.Size(230, 45);
            this.btn_logout.TabIndex = 9;
            this.btn_logout.Text = "Cerrar Sesión        ";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_estudiantes
            // 
            this.btn_estudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btn_estudiantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_estudiantes.FlatAppearance.BorderSize = 0;
            this.btn_estudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_estudiantes.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_estudiantes.ForeColor = System.Drawing.Color.White;
            this.btn_estudiantes.Location = new System.Drawing.Point(0, 190);
            this.btn_estudiantes.Name = "btn_estudiantes";
            this.btn_estudiantes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_estudiantes.Size = new System.Drawing.Size(230, 45);
            this.btn_estudiantes.TabIndex = 4;
            this.btn_estudiantes.Text = "Gestión de Estudiantes";
            this.btn_estudiantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_estudiantes.UseVisualStyleBackColor = false;
            this.btn_estudiantes.Click += new System.EventHandler(this.btn_estudiantes_Click);
            // 
            // btn_materias
            // 
            this.btn_materias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btn_materias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_materias.FlatAppearance.BorderSize = 0;
            this.btn_materias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_materias.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_materias.ForeColor = System.Drawing.Color.White;
            this.btn_materias.Location = new System.Drawing.Point(0, 145);
            this.btn_materias.Name = "btn_materias";
            this.btn_materias.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_materias.Size = new System.Drawing.Size(230, 45);
            this.btn_materias.TabIndex = 2;
            this.btn_materias.Text = "Gestión de Materias";
            this.btn_materias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_materias.UseVisualStyleBackColor = false;
            this.btn_materias.Click += new System.EventHandler(this.btn_materias_Click);
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btn_usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_usuarios.FlatAppearance.BorderSize = 0;
            this.btn_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usuarios.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_usuarios.ForeColor = System.Drawing.Color.White;
            this.btn_usuarios.Location = new System.Drawing.Point(0, 100);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_usuarios.Size = new System.Drawing.Size(230, 45);
            this.btn_usuarios.TabIndex = 1;
            this.btn_usuarios.Text = "Gestión de Usuarios";
            this.btn_usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_usuarios.UseVisualStyleBackColor = false;
            this.btn_usuarios.Click += new System.EventHandler(this.btn_usuarios_Click);
            // 
            // pnl_logoSysacad
            // 
            this.pnl_logoSysacad.Controls.Add(this.lbl_logoSysacad3);
            this.pnl_logoSysacad.Controls.Add(this.lbl_logoSysacad1);
            this.pnl_logoSysacad.Controls.Add(this.lbl_logoSysacad2);
            this.pnl_logoSysacad.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_logoSysacad.Location = new System.Drawing.Point(0, 0);
            this.pnl_logoSysacad.Name = "pnl_logoSysacad";
            this.pnl_logoSysacad.Size = new System.Drawing.Size(230, 100);
            this.pnl_logoSysacad.TabIndex = 0;
            // 
            // lbl_logoSysacad3
            // 
            this.lbl_logoSysacad3.AutoSize = true;
            this.lbl_logoSysacad3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.lbl_logoSysacad3.Font = new System.Drawing.Font("Arial", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_logoSysacad3.ForeColor = System.Drawing.Color.White;
            this.lbl_logoSysacad3.Location = new System.Drawing.Point(30, 64);
            this.lbl_logoSysacad3.MinimumSize = new System.Drawing.Size(170, 0);
            this.lbl_logoSysacad3.Name = "lbl_logoSysacad3";
            this.lbl_logoSysacad3.Size = new System.Drawing.Size(170, 27);
            this.lbl_logoSysacad3.TabIndex = 24;
            this.lbl_logoSysacad3.Text = "AVELLANEDA";
            this.lbl_logoSysacad3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_logoSysacad1
            // 
            this.lbl_logoSysacad1.AutoSize = true;
            this.lbl_logoSysacad1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.lbl_logoSysacad1.Font = new System.Drawing.Font("Arial", 31F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_logoSysacad1.ForeColor = System.Drawing.Color.White;
            this.lbl_logoSysacad1.Location = new System.Drawing.Point(30, 11);
            this.lbl_logoSysacad1.MinimumSize = new System.Drawing.Size(170, 0);
            this.lbl_logoSysacad1.Name = "lbl_logoSysacad1";
            this.lbl_logoSysacad1.Size = new System.Drawing.Size(170, 36);
            this.lbl_logoSysacad1.TabIndex = 22;
            this.lbl_logoSysacad1.Text = "SYSACAD";
            this.lbl_logoSysacad1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_logoSysacad2
            // 
            this.lbl_logoSysacad2.AutoSize = true;
            this.lbl_logoSysacad2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.lbl_logoSysacad2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_logoSysacad2.ForeColor = System.Drawing.Color.White;
            this.lbl_logoSysacad2.Location = new System.Drawing.Point(30, 46);
            this.lbl_logoSysacad2.MinimumSize = new System.Drawing.Size(170, 0);
            this.lbl_logoSysacad2.Name = "lbl_logoSysacad2";
            this.lbl_logoSysacad2.Size = new System.Drawing.Size(170, 18);
            this.lbl_logoSysacad2.TabIndex = 23;
            this.lbl_logoSysacad2.Text = "FACULTAD REGIONAL";
            this.lbl_logoSysacad2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_main
            // 
            this.pnl_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_main.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_main.Controls.Add(this.pic_mainLogo);
            this.pnl_main.Location = new System.Drawing.Point(230, 40);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(850, 604);
            this.pnl_main.TabIndex = 15;
            // 
            // pic_mainLogo
            // 
            this.pic_mainLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_mainLogo.Image = ((System.Drawing.Image)(resources.GetObject("pic_mainLogo.Image")));
            this.pic_mainLogo.Location = new System.Drawing.Point(323, 189);
            this.pic_mainLogo.Name = "pic_mainLogo";
            this.pic_mainLogo.Size = new System.Drawing.Size(220, 215);
            this.pic_mainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_mainLogo.TabIndex = 16;
            this.pic_mainLogo.TabStop = false;
            // 
            // lbl_materia
            // 
            this.lbl_materia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_materia.AutoSize = true;
            this.lbl_materia.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_materia.ForeColor = System.Drawing.Color.White;
            this.lbl_materia.Location = new System.Drawing.Point(70, -496);
            this.lbl_materia.Name = "lbl_materia";
            this.lbl_materia.Size = new System.Drawing.Size(74, 19);
            this.lbl_materia.TabIndex = 28;
            this.lbl_materia.Text = "Usuario:";
            // 
            // lbl_infoUsername
            // 
            this.lbl_infoUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_infoUsername.AutoSize = true;
            this.lbl_infoUsername.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_infoUsername.ForeColor = System.Drawing.Color.White;
            this.lbl_infoUsername.Location = new System.Drawing.Point(135, 8);
            this.lbl_infoUsername.Name = "lbl_infoUsername";
            this.lbl_infoUsername.Size = new System.Drawing.Size(91, 17);
            this.lbl_infoUsername.TabIndex = 29;
            this.lbl_infoUsername.Text = "<username>";
            // 
            // lbl_infoName
            // 
            this.lbl_infoName.AutoSize = true;
            this.lbl_infoName.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_infoName.ForeColor = System.Drawing.Color.White;
            this.lbl_infoName.Location = new System.Drawing.Point(83, 8);
            this.lbl_infoName.Name = "lbl_infoName";
            this.lbl_infoName.Size = new System.Drawing.Size(117, 17);
            this.lbl_infoName.TabIndex = 31;
            this.lbl_infoName.Text = "<personal_info>";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_Nombre.Location = new System.Drawing.Point(3, 8);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(67, 17);
            this.lbl_Nombre.TabIndex = 30;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // lbl_infoPermiso
            // 
            this.lbl_infoPermiso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_infoPermiso.AutoSize = true;
            this.lbl_infoPermiso.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_infoPermiso.ForeColor = System.Drawing.Color.White;
            this.lbl_infoPermiso.Location = new System.Drawing.Point(135, 35);
            this.lbl_infoPermiso.Name = "lbl_infoPermiso";
            this.lbl_infoPermiso.Size = new System.Drawing.Size(66, 17);
            this.lbl_infoPermiso.TabIndex = 33;
            this.lbl_infoPermiso.Text = "<access>";
            // 
            // lbl_Permiso
            // 
            this.lbl_Permiso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Permiso.AutoSize = true;
            this.lbl_Permiso.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Permiso.ForeColor = System.Drawing.Color.White;
            this.lbl_Permiso.Location = new System.Drawing.Point(64, 35);
            this.lbl_Permiso.Name = "lbl_Permiso";
            this.lbl_Permiso.Size = new System.Drawing.Size(67, 17);
            this.lbl_Permiso.TabIndex = 32;
            this.lbl_Permiso.Text = "Permiso:";
            // 
            // pic_userIcon
            // 
            this.pic_userIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_userIcon.Image = ((System.Drawing.Image)(resources.GetObject("pic_userIcon.Image")));
            this.pic_userIcon.Location = new System.Drawing.Point(8, 6);
            this.pic_userIcon.Name = "pic_userIcon";
            this.pic_userIcon.Size = new System.Drawing.Size(50, 50);
            this.pic_userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_userIcon.TabIndex = 34;
            this.pic_userIcon.TabStop = false;
            // 
            // lbl_infoApellido
            // 
            this.lbl_infoApellido.AutoSize = true;
            this.lbl_infoApellido.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_infoApellido.ForeColor = System.Drawing.Color.White;
            this.lbl_infoApellido.Location = new System.Drawing.Point(83, 35);
            this.lbl_infoApellido.Name = "lbl_infoApellido";
            this.lbl_infoApellido.Size = new System.Drawing.Size(117, 17);
            this.lbl_infoApellido.TabIndex = 36;
            this.lbl_infoApellido.Text = "<personal_info>";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Apellido.ForeColor = System.Drawing.Color.White;
            this.lbl_Apellido.Location = new System.Drawing.Point(3, 35);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(70, 17);
            this.lbl_Apellido.TabIndex = 35;
            this.lbl_Apellido.Text = "Apellido:";
            // 
            // tlp_userData
            // 
            this.tlp_userData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_userData.ColumnCount = 2;
            this.tlp_userData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_userData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_userData.Controls.Add(this.pnl_info1, 0, 0);
            this.tlp_userData.Controls.Add(this.pnl_info2, 1, 0);
            this.tlp_userData.Location = new System.Drawing.Point(235, 646);
            this.tlp_userData.Name = "tlp_userData";
            this.tlp_userData.RowCount = 1;
            this.tlp_userData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_userData.Size = new System.Drawing.Size(832, 70);
            this.tlp_userData.TabIndex = 17;
            // 
            // pnl_info1
            // 
            this.pnl_info1.Controls.Add(this.lbl_Usuario);
            this.pnl_info1.Controls.Add(this.lbl_materia);
            this.pnl_info1.Controls.Add(this.lbl_infoUsername);
            this.pnl_info1.Controls.Add(this.pic_userIcon);
            this.pnl_info1.Controls.Add(this.lbl_Permiso);
            this.pnl_info1.Controls.Add(this.lbl_infoPermiso);
            this.pnl_info1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_info1.Location = new System.Drawing.Point(3, 3);
            this.pnl_info1.Name = "pnl_info1";
            this.pnl_info1.Size = new System.Drawing.Size(410, 64);
            this.pnl_info1.TabIndex = 18;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_Usuario.Location = new System.Drawing.Point(64, 8);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(65, 17);
            this.lbl_Usuario.TabIndex = 35;
            this.lbl_Usuario.Text = "Usuario:";
            // 
            // pnl_info2
            // 
            this.pnl_info2.Controls.Add(this.lbl_infoApellido);
            this.pnl_info2.Controls.Add(this.lbl_Nombre);
            this.pnl_info2.Controls.Add(this.lbl_infoName);
            this.pnl_info2.Controls.Add(this.lbl_Apellido);
            this.pnl_info2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_info2.Location = new System.Drawing.Point(419, 3);
            this.pnl_info2.Name = "pnl_info2";
            this.pnl_info2.Size = new System.Drawing.Size(410, 64);
            this.pnl_info2.TabIndex = 19;
            // 
            // btn_estadisticas
            // 
            this.btn_estadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btn_estadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_estadisticas.FlatAppearance.BorderSize = 0;
            this.btn_estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_estadisticas.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_estadisticas.ForeColor = System.Drawing.Color.White;
            this.btn_estadisticas.Location = new System.Drawing.Point(0, 460);
            this.btn_estadisticas.Name = "btn_estadisticas";
            this.btn_estadisticas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_estadisticas.Size = new System.Drawing.Size(230, 45);
            this.btn_estadisticas.TabIndex = 15;
            this.btn_estadisticas.Text = "Estadísticas";
            this.btn_estadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_estadisticas.UseVisualStyleBackColor = false;
            this.btn_estadisticas.Click += new System.EventHandler(this.btn_estadisticas_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.tlp_userData);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.pnl_sideMenu);
            this.Controls.Add(this.pnl_titlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnl_titlebar.ResumeLayout(false);
            this.pnl_titlebar.PerformLayout();
            this.pnl_windowCtrl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_windowCtrl1Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_windowCtrl2Maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_windowCtrl3Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_windowLogo)).EndInit();
            this.pnl_sideMenu.ResumeLayout(false);
            this.pnl_logoSysacad.ResumeLayout(false);
            this.pnl_logoSysacad.PerformLayout();
            this.pnl_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_mainLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_userIcon)).EndInit();
            this.tlp_userData.ResumeLayout(false);
            this.pnl_info1.ResumeLayout(false);
            this.pnl_info1.PerformLayout();
            this.pnl_info2.ResumeLayout(false);
            this.pnl_info2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_titlebar;
        private PictureBox pic_windowCtrl1Minimize;
        private PictureBox pic_windowCtrl3Close;
        private PictureBox pic_windowCtrl2Maximize;
        private Label lbl_windowTitle;
        private PictureBox pic_windowLogo;
        private Panel pnl_sideMenu;
        private Panel pnl_main;
        private PictureBox pic_mainLogo;
        private Panel pnl_windowCtrl;
        private Panel pnl_logoSysacad;
        private Label lbl_logoSysacad3;
        private Label lbl_logoSysacad1;
        private Label lbl_logoSysacad2;
        private Button btn_usuarios;
        private Button btn_materias;
        private Button btn_estudiantes;
        private Button btn_logout;
        private Button btn_asistencias;
        private Button btn_inscripciones;
        private Button btn_examenes;
        private Button btn_calificar;
        private Button btn_docentes;
        private Label lbl_materia;
        private Label lbl_infoUsername;
        private Label lbl_infoName;
        private Label lbl_Nombre;
        private Label lbl_infoPermiso;
        private Label lbl_Permiso;
        private PictureBox pic_userIcon;
        private Label lbl_infoApellido;
        private Label lbl_Apellido;
        private TableLayoutPanel tlp_userData;
        private Panel pnl_info1;
        private Panel pnl_info2;
        private Label lbl_Usuario;
        private Button btn_estadisticas;
    }
}