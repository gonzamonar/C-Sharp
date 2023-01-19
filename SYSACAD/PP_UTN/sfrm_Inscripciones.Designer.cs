namespace Presentation
{
    partial class sfrm_Inscripciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sfrm_Inscripciones));
            this.btn_inscribir = new System.Windows.Forms.Button();
            this.pic_CtrlClose = new System.Windows.Forms.PictureBox();
            this.cmb_selectMateria = new System.Windows.Forms.ComboBox();
            this.lbl_materia = new System.Windows.Forms.Label();
            this.lbl_userData = new System.Windows.Forms.Label();
            this.lbl_cuatri = new System.Windows.Forms.Label();
            this.lbl_anio = new System.Windows.Forms.Label();
            this.tlp_content = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_column2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_col1 = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.cmb_selectEstudiante = new System.Windows.Forms.ComboBox();
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.txt_inscripcion1 = new System.Windows.Forms.TextBox();
            this.txt_inscripcion2 = new System.Windows.Forms.TextBox();
            this.lbl_inscripcion2 = new System.Windows.Forms.Label();
            this.lbl_inscripcion1 = new System.Windows.Forms.Label();
            this.lbl_docentes = new System.Windows.Forms.Label();
            this.pnl_col2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CtrlClose)).BeginInit();
            this.tlp_content.SuspendLayout();
            this.tlp_column2.SuspendLayout();
            this.pnl_col1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            this.pnl_col2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_inscribir
            // 
            this.btn_inscribir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btn_inscribir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inscribir.FlatAppearance.BorderSize = 0;
            this.btn_inscribir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(127)))), ((int)(((byte)(27)))));
            this.btn_inscribir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inscribir.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_inscribir.ForeColor = System.Drawing.Color.White;
            this.btn_inscribir.Location = new System.Drawing.Point(22, 295);
            this.btn_inscribir.Name = "btn_inscribir";
            this.btn_inscribir.Size = new System.Drawing.Size(182, 50);
            this.btn_inscribir.TabIndex = 15;
            this.btn_inscribir.Text = "Inscribirme";
            this.btn_inscribir.UseVisualStyleBackColor = false;
            this.btn_inscribir.Click += new System.EventHandler(this.btn_inscribir_Click);
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
            this.cmb_selectMateria.Location = new System.Drawing.Point(14, 113);
            this.cmb_selectMateria.Name = "cmb_selectMateria";
            this.cmb_selectMateria.Size = new System.Drawing.Size(206, 23);
            this.cmb_selectMateria.Sorted = true;
            this.cmb_selectMateria.TabIndex = 21;
            this.cmb_selectMateria.SelectedIndexChanged += new System.EventHandler(this.cmb_selectMateria_SelectedIndexChanged);
            // 
            // lbl_materia
            // 
            this.lbl_materia.AutoSize = true;
            this.lbl_materia.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_materia.ForeColor = System.Drawing.Color.White;
            this.lbl_materia.Location = new System.Drawing.Point(13, 93);
            this.lbl_materia.Name = "lbl_materia";
            this.lbl_materia.Size = new System.Drawing.Size(219, 17);
            this.lbl_materia.TabIndex = 27;
            this.lbl_materia.Text = "Materias aptas para inscribirse:";
            // 
            // lbl_userData
            // 
            this.lbl_userData.AutoSize = true;
            this.lbl_userData.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_userData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(47)))));
            this.lbl_userData.Location = new System.Drawing.Point(15, 21);
            this.lbl_userData.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbl_userData.Name = "lbl_userData";
            this.lbl_userData.Size = new System.Drawing.Size(140, 19);
            this.lbl_userData.TabIndex = 32;
            this.lbl_userData.Text = "Datos Estudiante";
            // 
            // lbl_cuatri
            // 
            this.lbl_cuatri.AutoSize = true;
            this.lbl_cuatri.Font = new System.Drawing.Font("Constantia", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_cuatri.ForeColor = System.Drawing.Color.White;
            this.lbl_cuatri.Location = new System.Drawing.Point(14, 224);
            this.lbl_cuatri.Name = "lbl_cuatri";
            this.lbl_cuatri.Size = new System.Drawing.Size(89, 15);
            this.lbl_cuatri.TabIndex = 33;
            this.lbl_cuatri.Text = "Cuatrimestre";
            // 
            // lbl_anio
            // 
            this.lbl_anio.AutoSize = true;
            this.lbl_anio.Font = new System.Drawing.Font("Constantia", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_anio.ForeColor = System.Drawing.Color.White;
            this.lbl_anio.Location = new System.Drawing.Point(180, 224);
            this.lbl_anio.Name = "lbl_anio";
            this.lbl_anio.Size = new System.Drawing.Size(32, 15);
            this.lbl_anio.TabIndex = 34;
            this.lbl_anio.Text = "Año";
            // 
            // tlp_content
            // 
            this.tlp_content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_content.ColumnCount = 2;
            this.tlp_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_content.Controls.Add(this.tlp_column2, 1, 0);
            this.tlp_content.Controls.Add(this.pnl_col1, 0, 0);
            this.tlp_content.Location = new System.Drawing.Point(39, 71);
            this.tlp_content.Name = "tlp_content";
            this.tlp_content.RowCount = 1;
            this.tlp_content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_content.Size = new System.Drawing.Size(499, 357);
            this.tlp_content.TabIndex = 37;
            this.tlp_content.Resize += new System.EventHandler(this.tlp_content_Resize);
            // 
            // tlp_column2
            // 
            this.tlp_column2.ColumnCount = 1;
            this.tlp_column2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_column2.Controls.Add(this.pnl_col2, 0, 0);
            this.tlp_column2.Controls.Add(this.dgv_main, 0, 1);
            this.tlp_column2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_column2.Location = new System.Drawing.Point(252, 3);
            this.tlp_column2.Name = "tlp_column2";
            this.tlp_column2.RowCount = 2;
            this.tlp_column2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tlp_column2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_column2.Size = new System.Drawing.Size(244, 351);
            this.tlp_column2.TabIndex = 38;
            // 
            // pnl_col1
            // 
            this.pnl_col1.Controls.Add(this.lbl_titulo);
            this.pnl_col1.Controls.Add(this.lbl_materia);
            this.pnl_col1.Controls.Add(this.lbl_anio);
            this.pnl_col1.Controls.Add(this.btn_inscribir);
            this.pnl_col1.Controls.Add(this.lbl_cuatri);
            this.pnl_col1.Controls.Add(this.cmb_selectMateria);
            this.pnl_col1.Controls.Add(this.lbl_userData);
            this.pnl_col1.Controls.Add(this.cmb_selectEstudiante);
            this.pnl_col1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_col1.Location = new System.Drawing.Point(3, 3);
            this.pnl_col1.MaximumSize = new System.Drawing.Size(400, 0);
            this.pnl_col1.Name = "pnl_col1";
            this.pnl_col1.Size = new System.Drawing.Size(243, 351);
            this.pnl_col1.TabIndex = 38;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(14, 168);
            this.lbl_titulo.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(174, 18);
            this.lbl_titulo.TabIndex = 38;
            this.lbl_titulo.Text = "Seleccione una materia";
            // 
            // cmb_selectEstudiante
            // 
            this.cmb_selectEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.cmb_selectEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_selectEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_selectEstudiante.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_selectEstudiante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(47)))));
            this.cmb_selectEstudiante.FormattingEnabled = true;
            this.cmb_selectEstudiante.Location = new System.Drawing.Point(13, 17);
            this.cmb_selectEstudiante.Name = "cmb_selectEstudiante";
            this.cmb_selectEstudiante.Size = new System.Drawing.Size(206, 27);
            this.cmb_selectEstudiante.Sorted = true;
            this.cmb_selectEstudiante.TabIndex = 38;
            this.cmb_selectEstudiante.Visible = false;
            this.cmb_selectEstudiante.SelectedIndexChanged += new System.EventHandler(this.cmb_selectEstudiante_SelectedIndexChanged);
            // 
            // dgv_main
            // 
            this.dgv_main.AllowUserToAddRows = false;
            this.dgv_main.AllowUserToDeleteRows = false;
            this.dgv_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_main.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_main.Location = new System.Drawing.Point(3, 173);
            this.dgv_main.MaximumSize = new System.Drawing.Size(750, 0);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.RowTemplate.Height = 25;
            this.dgv_main.Size = new System.Drawing.Size(238, 175);
            this.dgv_main.TabIndex = 0;
            // 
            // txt_inscripcion1
            // 
            this.txt_inscripcion1.Enabled = false;
            this.txt_inscripcion1.Location = new System.Drawing.Point(6, 38);
            this.txt_inscripcion1.Name = "txt_inscripcion1";
            this.txt_inscripcion1.Size = new System.Drawing.Size(188, 23);
            this.txt_inscripcion1.TabIndex = 38;
            // 
            // txt_inscripcion2
            // 
            this.txt_inscripcion2.Enabled = false;
            this.txt_inscripcion2.Location = new System.Drawing.Point(6, 98);
            this.txt_inscripcion2.Name = "txt_inscripcion2";
            this.txt_inscripcion2.Size = new System.Drawing.Size(188, 23);
            this.txt_inscripcion2.TabIndex = 39;
            // 
            // lbl_inscripcion2
            // 
            this.lbl_inscripcion2.AutoSize = true;
            this.lbl_inscripcion2.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_inscripcion2.ForeColor = System.Drawing.Color.White;
            this.lbl_inscripcion2.Location = new System.Drawing.Point(6, 78);
            this.lbl_inscripcion2.Name = "lbl_inscripcion2";
            this.lbl_inscripcion2.Size = new System.Drawing.Size(117, 17);
            this.lbl_inscripcion2.TabIndex = 36;
            this.lbl_inscripcion2.Text = "Inscripción Nº 2:";
            // 
            // lbl_inscripcion1
            // 
            this.lbl_inscripcion1.AutoSize = true;
            this.lbl_inscripcion1.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_inscripcion1.ForeColor = System.Drawing.Color.White;
            this.lbl_inscripcion1.Location = new System.Drawing.Point(6, 18);
            this.lbl_inscripcion1.Name = "lbl_inscripcion1";
            this.lbl_inscripcion1.Size = new System.Drawing.Size(115, 17);
            this.lbl_inscripcion1.TabIndex = 35;
            this.lbl_inscripcion1.Text = "Inscripción Nº 1:";
            // 
            // lbl_docentes
            // 
            this.lbl_docentes.AutoSize = true;
            this.lbl_docentes.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_docentes.ForeColor = System.Drawing.Color.White;
            this.lbl_docentes.Location = new System.Drawing.Point(4, 145);
            this.lbl_docentes.Name = "lbl_docentes";
            this.lbl_docentes.Size = new System.Drawing.Size(146, 17);
            this.lbl_docentes.TabIndex = 29;
            this.lbl_docentes.Text = "Materias Aprobadas:";
            // 
            // pnl_col2
            // 
            this.pnl_col2.Controls.Add(this.lbl_docentes);
            this.pnl_col2.Controls.Add(this.lbl_inscripcion1);
            this.pnl_col2.Controls.Add(this.lbl_inscripcion2);
            this.pnl_col2.Controls.Add(this.txt_inscripcion2);
            this.pnl_col2.Controls.Add(this.txt_inscripcion1);
            this.pnl_col2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_col2.Location = new System.Drawing.Point(3, 3);
            this.pnl_col2.Name = "pnl_col2";
            this.pnl_col2.Size = new System.Drawing.Size(238, 164);
            this.pnl_col2.TabIndex = 40;
            // 
            // sfrm_Inscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(570, 484);
            this.Controls.Add(this.tlp_content);
            this.Controls.Add(this.pic_CtrlClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sfrm_Inscripciones";
            this.Text = "Gestión de Inscriptos";
            this.Load += new System.EventHandler(this.sfrm_Inscriptos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_CtrlClose)).EndInit();
            this.tlp_content.ResumeLayout(false);
            this.tlp_column2.ResumeLayout(false);
            this.pnl_col1.ResumeLayout(false);
            this.pnl_col1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            this.pnl_col2.ResumeLayout(false);
            this.pnl_col2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btn_inscribir;
        private PictureBox pic_CtrlClose;
        private ComboBox cmb_selectMateria;
        private Label lbl_materia;
        private Label lbl_userData;
        private Label lbl_cuatri;
        private Label lbl_anio;
        private TableLayoutPanel tlp_content;
        private Panel pnl_col1;
        private TableLayoutPanel tlp_column2;
        private Label lbl_titulo;
        private ComboBox cmb_selectEstudiante;
        private Panel pnl_col2;
        private Label lbl_docentes;
        private Label lbl_inscripcion1;
        private Label lbl_inscripcion2;
        private TextBox txt_inscripcion2;
        private TextBox txt_inscripcion1;
        private DataGridView dgv_main;
    }
}