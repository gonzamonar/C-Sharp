namespace Presentation
{
    partial class sfrm_Calificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sfrm_Calificaciones));
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.btn_calificar = new System.Windows.Forms.Button();
            this.pic_CtrlClose = new System.Windows.Forms.PictureBox();
            this.cmb_selectMateria = new System.Windows.Forms.ComboBox();
            this.lbl_materia = new System.Windows.Forms.Label();
            this.cmb_notas = new System.Windows.Forms.ComboBox();
            this.lbl_calificacion = new System.Windows.Forms.Label();
            this.lbl_parcial = new System.Windows.Forms.Label();
            this.cmb_parciales = new System.Windows.Forms.ComboBox();
            this.lbl_dgvDescription = new System.Windows.Forms.Label();
            this.tlp_content = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_controls = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CtrlClose)).BeginInit();
            this.tlp_content.SuspendLayout();
            this.pnl_controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_main
            // 
            this.dgv_main.AllowUserToAddRows = false;
            this.dgv_main.AllowUserToDeleteRows = false;
            this.dgv_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_main.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.dgv_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_main.Location = new System.Drawing.Point(3, 3);
            this.dgv_main.MaximumSize = new System.Drawing.Size(900, 1000);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_main.RowTemplate.Height = 25;
            this.dgv_main.Size = new System.Drawing.Size(350, 344);
            this.dgv_main.TabIndex = 0;
            // 
            // btn_calificar
            // 
            this.btn_calificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btn_calificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_calificar.Enabled = false;
            this.btn_calificar.FlatAppearance.BorderSize = 0;
            this.btn_calificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(127)))), ((int)(((byte)(27)))));
            this.btn_calificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calificar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_calificar.ForeColor = System.Drawing.Color.White;
            this.btn_calificar.Location = new System.Drawing.Point(6, 294);
            this.btn_calificar.Name = "btn_calificar";
            this.btn_calificar.Size = new System.Drawing.Size(121, 49);
            this.btn_calificar.TabIndex = 16;
            this.btn_calificar.Text = "Seleccione una Materia";
            this.btn_calificar.UseVisualStyleBackColor = false;
            this.btn_calificar.Click += new System.EventHandler(this.btn_calificar_Click);
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
            this.cmb_selectMateria.Font = new System.Drawing.Font("Carlito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_selectMateria.FormattingEnabled = true;
            this.cmb_selectMateria.Location = new System.Drawing.Point(120, 71);
            this.cmb_selectMateria.Name = "cmb_selectMateria";
            this.cmb_selectMateria.Size = new System.Drawing.Size(206, 25);
            this.cmb_selectMateria.Sorted = true;
            this.cmb_selectMateria.TabIndex = 21;
            this.cmb_selectMateria.SelectedIndexChanged += new System.EventHandler(this.cmb_selectMateria_SelectedIndexChanged);
            // 
            // lbl_materia
            // 
            this.lbl_materia.AutoSize = true;
            this.lbl_materia.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_materia.ForeColor = System.Drawing.Color.White;
            this.lbl_materia.Location = new System.Drawing.Point(40, 71);
            this.lbl_materia.Name = "lbl_materia";
            this.lbl_materia.Size = new System.Drawing.Size(74, 19);
            this.lbl_materia.TabIndex = 27;
            this.lbl_materia.Text = "Materia:";
            // 
            // cmb_notas
            // 
            this.cmb_notas.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_notas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmb_notas.Font = new System.Drawing.Font("Carlito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_notas.FormattingEnabled = true;
            this.cmb_notas.Location = new System.Drawing.Point(6, 87);
            this.cmb_notas.Name = "cmb_notas";
            this.cmb_notas.Size = new System.Drawing.Size(121, 201);
            this.cmb_notas.TabIndex = 29;
            // 
            // lbl_calificacion
            // 
            this.lbl_calificacion.AutoSize = true;
            this.lbl_calificacion.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_calificacion.ForeColor = System.Drawing.Color.White;
            this.lbl_calificacion.Location = new System.Drawing.Point(6, 58);
            this.lbl_calificacion.Name = "lbl_calificacion";
            this.lbl_calificacion.Size = new System.Drawing.Size(105, 19);
            this.lbl_calificacion.TabIndex = 34;
            this.lbl_calificacion.Text = "Calificación:";
            // 
            // lbl_parcial
            // 
            this.lbl_parcial.AutoSize = true;
            this.lbl_parcial.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_parcial.ForeColor = System.Drawing.Color.White;
            this.lbl_parcial.Location = new System.Drawing.Point(6, 1);
            this.lbl_parcial.Name = "lbl_parcial";
            this.lbl_parcial.Size = new System.Drawing.Size(67, 19);
            this.lbl_parcial.TabIndex = 36;
            this.lbl_parcial.Text = "Parcial:";
            // 
            // cmb_parciales
            // 
            this.cmb_parciales.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_parciales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_parciales.Font = new System.Drawing.Font("Carlito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_parciales.FormattingEnabled = true;
            this.cmb_parciales.Location = new System.Drawing.Point(6, 23);
            this.cmb_parciales.Name = "cmb_parciales";
            this.cmb_parciales.Size = new System.Drawing.Size(121, 25);
            this.cmb_parciales.TabIndex = 35;
            // 
            // lbl_dgvDescription
            // 
            this.lbl_dgvDescription.AutoSize = true;
            this.lbl_dgvDescription.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_dgvDescription.ForeColor = System.Drawing.Color.White;
            this.lbl_dgvDescription.Location = new System.Drawing.Point(40, 101);
            this.lbl_dgvDescription.Name = "lbl_dgvDescription";
            this.lbl_dgvDescription.Size = new System.Drawing.Size(158, 17);
            this.lbl_dgvDescription.TabIndex = 40;
            this.lbl_dgvDescription.Text = "Estudiantes inscriptxs:";
            // 
            // tlp_content
            // 
            this.tlp_content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_content.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_content.ColumnCount = 2;
            this.tlp_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tlp_content.Controls.Add(this.pnl_controls, 1, 0);
            this.tlp_content.Controls.Add(this.dgv_main, 0, 0);
            this.tlp_content.Location = new System.Drawing.Point(40, 118);
            this.tlp_content.Name = "tlp_content";
            this.tlp_content.RowCount = 1;
            this.tlp_content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_content.Size = new System.Drawing.Size(501, 350);
            this.tlp_content.TabIndex = 39;
            this.tlp_content.Resize += new System.EventHandler(this.tlp_content_Resize);
            // 
            // pnl_controls
            // 
            this.pnl_controls.Controls.Add(this.lbl_parcial);
            this.pnl_controls.Controls.Add(this.btn_calificar);
            this.pnl_controls.Controls.Add(this.cmb_notas);
            this.pnl_controls.Controls.Add(this.lbl_calificacion);
            this.pnl_controls.Controls.Add(this.cmb_parciales);
            this.pnl_controls.Location = new System.Drawing.Point(359, 3);
            this.pnl_controls.Name = "pnl_controls";
            this.pnl_controls.Size = new System.Drawing.Size(139, 344);
            this.pnl_controls.TabIndex = 39;
            // 
            // sfrm_Calificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(569, 484);
            this.Controls.Add(this.lbl_dgvDescription);
            this.Controls.Add(this.tlp_content);
            this.Controls.Add(this.lbl_materia);
            this.Controls.Add(this.cmb_selectMateria);
            this.Controls.Add(this.pic_CtrlClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sfrm_Calificaciones";
            this.Text = "Gestión de Inscriptos";
            this.Load += new System.EventHandler(this.sfrm_Inscriptos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CtrlClose)).EndInit();
            this.tlp_content.ResumeLayout(false);
            this.pnl_controls.ResumeLayout(false);
            this.pnl_controls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_calificar;
        private ComboBox cmb_selectMateria;
        private ComboBox cmb_notas;
        private ComboBox cmb_parciales;
        private DataGridView dgv_main;
        private Label lbl_materia;
        private Label lbl_calificacion;
        private Label lbl_parcial;
        private Label lbl_dgvDescription;
        private Panel pnl_controls;
        private PictureBox pic_CtrlClose;
        private TableLayoutPanel tlp_content;
    }
}