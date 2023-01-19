namespace Presentation
{
    partial class sfrm_Docentes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sfrm_Docentes));
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.btn_designar = new System.Windows.Forms.Button();
            this.pic_CtrlClose = new System.Windows.Forms.PictureBox();
            this.cmb_selectMateria = new System.Windows.Forms.ComboBox();
            this.lbl_materia = new System.Windows.Forms.Label();
            this.lbl_docentes = new System.Windows.Forms.Label();
            this.lbl_nuevoDocente = new System.Windows.Forms.Label();
            this.cmb_selectDocente = new System.Windows.Forms.ComboBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_cuatri = new System.Windows.Forms.Label();
            this.lbl_anio = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_selectMateria = new System.Windows.Forms.Panel();
            this.pnl_addDocente = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CtrlClose)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnl_selectMateria.SuspendLayout();
            this.pnl_addDocente.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_main
            // 
            this.dgv_main.AllowUserToAddRows = false;
            this.dgv_main.AllowUserToDeleteRows = false;
            this.dgv_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_main.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_main.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_main.Location = new System.Drawing.Point(374, 104);
            this.dgv_main.MaximumSize = new System.Drawing.Size(500, 550);
            this.dgv_main.Name = "dgv_main";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_main.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_main.RowTemplate.Height = 25;
            this.dgv_main.Size = new System.Drawing.Size(181, 315);
            this.dgv_main.TabIndex = 0;
            // 
            // btn_designar
            // 
            this.btn_designar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btn_designar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_designar.FlatAppearance.BorderSize = 0;
            this.btn_designar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(127)))), ((int)(((byte)(27)))));
            this.btn_designar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_designar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_designar.ForeColor = System.Drawing.Color.White;
            this.btn_designar.Location = new System.Drawing.Point(0, 92);
            this.btn_designar.Name = "btn_designar";
            this.btn_designar.Size = new System.Drawing.Size(206, 26);
            this.btn_designar.TabIndex = 15;
            this.btn_designar.Text = "Designar";
            this.btn_designar.UseVisualStyleBackColor = false;
            this.btn_designar.Click += new System.EventHandler(this.btn_designar_Click);
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
            this.cmb_selectMateria.Location = new System.Drawing.Point(0, 41);
            this.cmb_selectMateria.Name = "cmb_selectMateria";
            this.cmb_selectMateria.Size = new System.Drawing.Size(206, 23);
            this.cmb_selectMateria.Sorted = true;
            this.cmb_selectMateria.TabIndex = 21;
            this.cmb_selectMateria.SelectedIndexChanged += new System.EventHandler(this.cmb_selectMateria_SelectedIndexChanged);
            // 
            // lbl_materia
            // 
            this.lbl_materia.AutoSize = true;
            this.lbl_materia.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_materia.ForeColor = System.Drawing.Color.White;
            this.lbl_materia.Location = new System.Drawing.Point(0, 9);
            this.lbl_materia.Name = "lbl_materia";
            this.lbl_materia.Size = new System.Drawing.Size(74, 19);
            this.lbl_materia.TabIndex = 27;
            this.lbl_materia.Text = "Materia:";
            // 
            // lbl_docentes
            // 
            this.lbl_docentes.AutoSize = true;
            this.lbl_docentes.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_docentes.ForeColor = System.Drawing.Color.White;
            this.lbl_docentes.Location = new System.Drawing.Point(374, 72);
            this.lbl_docentes.Name = "lbl_docentes";
            this.lbl_docentes.Size = new System.Drawing.Size(146, 19);
            this.lbl_docentes.TabIndex = 29;
            this.lbl_docentes.Text = "Docentes a cargo:";
            // 
            // lbl_nuevoDocente
            // 
            this.lbl_nuevoDocente.AutoSize = true;
            this.lbl_nuevoDocente.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_nuevoDocente.ForeColor = System.Drawing.Color.White;
            this.lbl_nuevoDocente.Location = new System.Drawing.Point(0, 10);
            this.lbl_nuevoDocente.Name = "lbl_nuevoDocente";
            this.lbl_nuevoDocente.Size = new System.Drawing.Size(140, 19);
            this.lbl_nuevoDocente.TabIndex = 31;
            this.lbl_nuevoDocente.Text = "Agregar docente:";
            // 
            // cmb_selectDocente
            // 
            this.cmb_selectDocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_selectDocente.FormattingEnabled = true;
            this.cmb_selectDocente.Location = new System.Drawing.Point(0, 42);
            this.cmb_selectDocente.Name = "cmb_selectDocente";
            this.cmb_selectDocente.Size = new System.Drawing.Size(206, 23);
            this.cmb_selectDocente.TabIndex = 30;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(0, 92);
            this.lbl_titulo.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(187, 19);
            this.lbl_titulo.TabIndex = 32;
            this.lbl_titulo.Text = "Seleccione una materia";
            // 
            // lbl_cuatri
            // 
            this.lbl_cuatri.AutoSize = true;
            this.lbl_cuatri.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_cuatri.ForeColor = System.Drawing.Color.White;
            this.lbl_cuatri.Location = new System.Drawing.Point(0, 172);
            this.lbl_cuatri.Name = "lbl_cuatri";
            this.lbl_cuatri.Size = new System.Drawing.Size(110, 19);
            this.lbl_cuatri.TabIndex = 33;
            this.lbl_cuatri.Text = "Cuatrimestre";
            // 
            // lbl_anio
            // 
            this.lbl_anio.AutoSize = true;
            this.lbl_anio.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_anio.ForeColor = System.Drawing.Color.White;
            this.lbl_anio.Location = new System.Drawing.Point(166, 172);
            this.lbl_anio.Name = "lbl_anio";
            this.lbl_anio.Size = new System.Drawing.Size(40, 19);
            this.lbl_anio.TabIndex = 34;
            this.lbl_anio.Text = "Año";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnl_selectMateria, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnl_addDocente, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(39, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(216, 403);
            this.tableLayoutPanel1.TabIndex = 35;
            // 
            // pnl_selectMateria
            // 
            this.pnl_selectMateria.Controls.Add(this.lbl_materia);
            this.pnl_selectMateria.Controls.Add(this.cmb_selectMateria);
            this.pnl_selectMateria.Controls.Add(this.lbl_anio);
            this.pnl_selectMateria.Controls.Add(this.lbl_titulo);
            this.pnl_selectMateria.Controls.Add(this.lbl_cuatri);
            this.pnl_selectMateria.Location = new System.Drawing.Point(3, 3);
            this.pnl_selectMateria.Name = "pnl_selectMateria";
            this.pnl_selectMateria.Size = new System.Drawing.Size(210, 195);
            this.pnl_selectMateria.TabIndex = 36;
            // 
            // pnl_addDocente
            // 
            this.pnl_addDocente.Controls.Add(this.lbl_nuevoDocente);
            this.pnl_addDocente.Controls.Add(this.btn_designar);
            this.pnl_addDocente.Controls.Add(this.cmb_selectDocente);
            this.pnl_addDocente.Location = new System.Drawing.Point(3, 204);
            this.pnl_addDocente.Name = "pnl_addDocente";
            this.pnl_addDocente.Size = new System.Drawing.Size(210, 157);
            this.pnl_addDocente.TabIndex = 37;
            // 
            // sfrm_Docentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(569, 484);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbl_docentes);
            this.Controls.Add(this.pic_CtrlClose);
            this.Controls.Add(this.dgv_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sfrm_Docentes";
            this.Text = "Gestión de Inscriptos";
            this.Load += new System.EventHandler(this.sfrm_Inscriptos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CtrlClose)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnl_selectMateria.ResumeLayout(false);
            this.pnl_selectMateria.PerformLayout();
            this.pnl_addDocente.ResumeLayout(false);
            this.pnl_addDocente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_main;
        private Button btn_designar;
        private PictureBox pic_CtrlClose;
        private ComboBox cmb_selectMateria;
        private Label lbl_materia;
        private Label lbl_docentes;
        private Label lbl_nuevoDocente;
        private ComboBox cmb_selectDocente;
        private Label lbl_titulo;
        private Label lbl_cuatri;
        private Label lbl_anio;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnl_selectMateria;
        private Panel pnl_addDocente;
    }
}