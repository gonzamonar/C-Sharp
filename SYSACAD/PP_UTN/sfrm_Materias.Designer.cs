namespace Presentation
{
    partial class sfrm_Materias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sfrm_Materias));
            this.pic_CtrlClose = new System.Windows.Forms.PictureBox();
            this.cmb_filterField = new System.Windows.Forms.ComboBox();
            this.cmb_filterValue = new System.Windows.Forms.ComboBox();
            this.lbl_filtro = new System.Windows.Forms.Label();
            this.lbl_campo = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.tlp_content = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.btn_nuevaMateria = new System.Windows.Forms.Button();
            this.btn_nuevaAsignatura = new System.Windows.Forms.Button();
            this.btn_cargarCuatrimestre = new System.Windows.Forms.Button();
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.pnl_filter = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CtrlClose)).BeginInit();
            this.tlp_content.SuspendLayout();
            this.pnl_buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            this.pnl_filter.SuspendLayout();
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
            // cmb_filterField
            // 
            this.cmb_filterField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filterField.FormattingEnabled = true;
            this.cmb_filterField.Location = new System.Drawing.Point(73, 22);
            this.cmb_filterField.Name = "cmb_filterField";
            this.cmb_filterField.Size = new System.Drawing.Size(121, 23);
            this.cmb_filterField.TabIndex = 25;
            //this.cmb_filterField.SelectedIndexChanged += new System.EventHandler(this.cmb_filterField_SelectedIndexChanged);
            // 
            // cmb_filterValue
            // 
            this.cmb_filterValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filterValue.FormattingEnabled = true;
            this.cmb_filterValue.Location = new System.Drawing.Point(213, 22);
            this.cmb_filterValue.Name = "cmb_filterValue";
            this.cmb_filterValue.Size = new System.Drawing.Size(243, 23);
            this.cmb_filterValue.Sorted = true;
            this.cmb_filterValue.TabIndex = 26;
            //this.cmb_filterValue.SelectedIndexChanged += new System.EventHandler(this.cmb_filterValue_SelectedIndexChanged);
            // 
            // lbl_filtro
            // 
            this.lbl_filtro.AutoSize = true;
            this.lbl_filtro.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_filtro.ForeColor = System.Drawing.Color.White;
            this.lbl_filtro.Location = new System.Drawing.Point(2, 22);
            this.lbl_filtro.Name = "lbl_filtro";
            this.lbl_filtro.Size = new System.Drawing.Size(56, 19);
            this.lbl_filtro.TabIndex = 28;
            this.lbl_filtro.Text = "Filtro:";
            // 
            // lbl_campo
            // 
            this.lbl_campo.AutoSize = true;
            this.lbl_campo.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_campo.ForeColor = System.Drawing.Color.White;
            this.lbl_campo.Location = new System.Drawing.Point(73, 5);
            this.lbl_campo.Name = "lbl_campo";
            this.lbl_campo.Size = new System.Drawing.Size(49, 14);
            this.lbl_campo.TabIndex = 29;
            this.lbl_campo.Text = "Campo:";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_valor.ForeColor = System.Drawing.Color.White;
            this.lbl_valor.Location = new System.Drawing.Point(213, 5);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(39, 14);
            this.lbl_valor.TabIndex = 30;
            this.lbl_valor.Text = "Valor:";
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
            this.tlp_content.Controls.Add(this.pnl_buttons, 1, 0);
            this.tlp_content.Controls.Add(this.dgv_main, 0, 0);
            this.tlp_content.Location = new System.Drawing.Point(40, 134);
            this.tlp_content.Name = "tlp_content";
            this.tlp_content.RowCount = 1;
            this.tlp_content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_content.Size = new System.Drawing.Size(479, 328);
            this.tlp_content.TabIndex = 31;
            this.tlp_content.SizeChanged += new System.EventHandler(this.tlp_content_SizeChanged);
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.Controls.Add(this.btn_nuevaMateria);
            this.pnl_buttons.Controls.Add(this.btn_nuevaAsignatura);
            this.pnl_buttons.Controls.Add(this.btn_cargarCuatrimestre);
            this.pnl_buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_buttons.Location = new System.Drawing.Point(382, 3);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(94, 322);
            this.pnl_buttons.TabIndex = 32;
            // 
            // btn_nuevaMateria
            // 
            this.btn_nuevaMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btn_nuevaMateria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevaMateria.FlatAppearance.BorderSize = 0;
            this.btn_nuevaMateria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(127)))), ((int)(((byte)(27)))));
            this.btn_nuevaMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevaMateria.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_nuevaMateria.ForeColor = System.Drawing.Color.White;
            this.btn_nuevaMateria.Location = new System.Drawing.Point(3, 0);
            this.btn_nuevaMateria.Name = "btn_nuevaMateria";
            this.btn_nuevaMateria.Size = new System.Drawing.Size(90, 50);
            this.btn_nuevaMateria.TabIndex = 22;
            this.btn_nuevaMateria.Text = "Nueva Materia";
            this.btn_nuevaMateria.UseVisualStyleBackColor = false;
            this.btn_nuevaMateria.Click += new System.EventHandler(this.btn_nuevaMateria_Click);
            // 
            // btn_nuevaAsignatura
            // 
            this.btn_nuevaAsignatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btn_nuevaAsignatura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevaAsignatura.FlatAppearance.BorderSize = 0;
            this.btn_nuevaAsignatura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(127)))), ((int)(((byte)(27)))));
            this.btn_nuevaAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevaAsignatura.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_nuevaAsignatura.ForeColor = System.Drawing.Color.White;
            this.btn_nuevaAsignatura.Location = new System.Drawing.Point(4, 59);
            this.btn_nuevaAsignatura.Name = "btn_nuevaAsignatura";
            this.btn_nuevaAsignatura.Size = new System.Drawing.Size(90, 50);
            this.btn_nuevaAsignatura.TabIndex = 23;
            this.btn_nuevaAsignatura.Text = "Nueva Asignatura";
            this.btn_nuevaAsignatura.UseVisualStyleBackColor = false;
            this.btn_nuevaAsignatura.Click += new System.EventHandler(this.btn_nuevaAsignatura_Click);
            // 
            // btn_cargarCuatrimestre
            // 
            this.btn_cargarCuatrimestre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btn_cargarCuatrimestre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cargarCuatrimestre.FlatAppearance.BorderSize = 0;
            this.btn_cargarCuatrimestre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(127)))), ((int)(((byte)(27)))));
            this.btn_cargarCuatrimestre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargarCuatrimestre.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_cargarCuatrimestre.ForeColor = System.Drawing.Color.White;
            this.btn_cargarCuatrimestre.Location = new System.Drawing.Point(1, 249);
            this.btn_cargarCuatrimestre.Name = "btn_cargarCuatrimestre";
            this.btn_cargarCuatrimestre.Size = new System.Drawing.Size(90, 75);
            this.btn_cargarCuatrimestre.TabIndex = 24;
            this.btn_cargarCuatrimestre.Text = "Cargar Cuatrimestre Completo";
            this.btn_cargarCuatrimestre.UseVisualStyleBackColor = false;
            this.btn_cargarCuatrimestre.Click += new System.EventHandler(this.btn_cargarCuatrimestre_Click);
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
            this.dgv_main.Size = new System.Drawing.Size(373, 322);
            this.dgv_main.TabIndex = 0;
            // 
            // pnl_filter
            // 
            this.pnl_filter.Controls.Add(this.lbl_valor);
            this.pnl_filter.Controls.Add(this.cmb_filterField);
            this.pnl_filter.Controls.Add(this.cmb_filterValue);
            this.pnl_filter.Controls.Add(this.lbl_campo);
            this.pnl_filter.Controls.Add(this.lbl_filtro);
            this.pnl_filter.Location = new System.Drawing.Point(40, 59);
            this.pnl_filter.Name = "pnl_filter";
            this.pnl_filter.Size = new System.Drawing.Size(476, 52);
            this.pnl_filter.TabIndex = 32;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(40, 117);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(209, 17);
            this.lbl_title.TabIndex = 33;
            this.lbl_title.Text = "Materias cargadas en Sistema:";
            // 
            // sfrm_Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(569, 484);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pnl_filter);
            this.Controls.Add(this.tlp_content);
            this.Controls.Add(this.pic_CtrlClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sfrm_Materias";
            this.Text = "Gestión de Materias y Asignaturas";
            this.Load += new System.EventHandler(this.sfrm_Materias_Load);
            this.VisibleChanged += new System.EventHandler(this.sfrm_Materias_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pic_CtrlClose)).EndInit();
            this.tlp_content.ResumeLayout(false);
            this.pnl_buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            this.pnl_filter.ResumeLayout(false);
            this.pnl_filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pic_CtrlClose;
        private ComboBox cmb_filterField;
        private ComboBox cmb_filterValue;
        private Label lbl_filtro;
        private Label lbl_campo;
        private Label lbl_valor;
        private TableLayoutPanel tlp_content;
        private Panel pnl_filter;
        private Panel pnl_buttons;
        private Button btn_nuevaMateria;
        private Button btn_nuevaAsignatura;
        private Button btn_cargarCuatrimestre;
        private DataGridView dgv_main;
        private Label lbl_title;
    }
}