using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;
using Model.Enums;


namespace Presentation
{
    internal static partial class View
    {
        private static Form main;
        private static Form login;

        public static Form Main { get { return main; } set { main = value; } }
        public static Form Login { get { return login; } set { login = value; } }

//SIMPLE METHODS//

//Exit
    
        public static void Exit()
        {
            DialogResult result = MessageBox.Show("¿Confirma que desea salir?", "Cerrar Programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public static void ClosePopForm(Form frm)
        {
            DialogResult result = MessageBox.Show("¿Confirma que desea cancelar el proceso de alta?", "Cancelar Alta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frm.Close();
                Main.Show();
            }
        }

//Buttons
        public static void ChangeBtnVisibility(Button button, bool isVisible)
        {
            button.Visible = isVisible;
        }

        public static void ChangeBtnText(Button button, string text)
        {
            button.Text = text;
        }

        public static void UnlockBtn(Button button)
        {
            button.Enabled = true;
        }

        public static void UnlockBtn(Button button1, Button button2)
        {
            UnlockBtn(button1);
            UnlockBtn(button2);
        }

        public static void LockBtn(Button button)
        {
            button.Enabled = false;
        }

        public static void LockBtn(Button button1, Button button2)
        {
            LockBtn(button1);
            LockBtn(button2);
        }

//Combobox
        public static void ChangeCmbVisibility(ComboBox cmb, bool display)
        {
            cmb.Visible = display;
        }

        public static void ClearCmb(ComboBox cmb)
        {
            cmb.DataSource = null;
            cmb.Items.Clear();
        }

        public static void EnableCmb(ComboBox cmb, bool enabled)
        {
            cmb.Enabled = enabled;
        }

        public static void LoadCmb(ComboBox cmb, string str1, string str2, string str3, string str4)
        {
            LoadCmb(cmb, str1, str2, str3);
            LoadCmb(cmb, str4);
        }

        public static void LoadCmb(ComboBox cmb, string str1, string str2, string str3)
        {
            LoadCmb(cmb, str1, str2);
            LoadCmb(cmb, str3);
        }

        public static void LoadCmb(ComboBox cmb, string str1, string str2)
        {
            LoadCmb(cmb, str1);
            LoadCmb(cmb, str2);
        }

        public static void LoadCmb(ComboBox cmb, string str)
        {
            cmb.Items.Add(str);
        }

        public static void LoadCmbCuatrimestres(ComboBox cmb)
        {
            cmb.Items.Add(ECuatrimestre.Primero);
            cmb.Items.Add(ECuatrimestre.Segundo);
            cmb.Items.Add(ECuatrimestre.Verano);
        }

        public static void LoadCmbGenero(ComboBox cmb)
        {
            cmb.Items.Add(EGenero.M);
            cmb.Items.Add(EGenero.F);
            cmb.Items.Add(EGenero.NB);
            cmb.Items.Add(EGenero.O);
        }

        public static void LoadCmbParciales(ComboBox cmb)
        {
            cmb.Items.Add("Primer Parcial");
            cmb.Items.Add("Segundo Parcial");
        }

        public static void LoadCmbAsignaturas(ComboBox cmb, bool addEmptyOption)
        {
            DataTable dataTable = DatabaseCmb.GetSubjectsListDatatable(addEmptyOption);
            dataTable.DefaultView.Sort = dataTable.Columns[1].ColumnName;
            cmb.DataSource = dataTable;
            cmb.ValueMember = dataTable.Columns[0].ColumnName;
            cmb.DisplayMember = dataTable.Columns[1].ColumnName;
        }

        public static void LoadCmbEstudiantes(ComboBox cmb)
        {
            DataTable dataTable = DatabaseCmb.GetStudentsListDatatable();
            dataTable.DefaultView.Sort = dataTable.Columns[1].ColumnName;
            cmb.DataSource = dataTable;
            cmb.ValueMember = dataTable.Columns[0].ColumnName;
            cmb.DisplayMember = dataTable.Columns[1].ColumnName;
        }

        public static void LoadCmbMaterias(ComboBox cmb)
        {
            DataTable dataTable = DatabaseCmb.GetCoursesListDatatable();
            dataTable.DefaultView.Sort = dataTable.Columns[0].ColumnName;
            cmb.DataSource = dataTable;
            cmb.ValueMember = dataTable.Columns[0].ColumnName;
            cmb.DisplayMember = dataTable.Columns[0].ColumnName;
        }

        public static void LoadCmbAbleToEnrollMaterias(ComboBox cmb, int idEstudiante, string codigoCuatrimestreActivo)
        {
            DataTable dataTable = DatabaseCmb.GetStudentAbleToEnrollCoursesDatatable(idEstudiante, codigoCuatrimestreActivo);
            dataTable.DefaultView.Sort = dataTable.Columns[0].ColumnName;
            cmb.DataSource = dataTable;
            cmb.ValueMember = dataTable.Columns[0].ColumnName;
            cmb.DisplayMember = dataTable.Columns[0].ColumnName;
        }


        public static void LoadCmbMateriasAsignadas(ComboBox cmb, int idProfesor)
        {
            DataTable dataTable = DatabaseCmb.GetProfessorDesignatedCoursesDatatable(idProfesor);
            dataTable.DefaultView.Sort = dataTable.Columns[0].ColumnName;
            cmb.DataSource = dataTable;
            cmb.ValueMember = dataTable.Columns[0].ColumnName;
            cmb.DisplayMember = dataTable.Columns[0].ColumnName;
        }

        public static void LoadCmbAddDocentes(ComboBox cmb, string codigoMateria)
        {
            DataTable dataTable = DatabaseCmb.GetUndesignatedTeachersInCourseDatatable(codigoMateria);
            dataTable.DefaultView.Sort = dataTable.Columns[1].ColumnName;
            cmb.DataSource = dataTable;
            cmb.ValueMember = dataTable.Columns[0].ColumnName;
            cmb.DisplayMember = dataTable.Columns[1].ColumnName;
        }


        public static void LoadCmbNros(ComboBox cmb, int start, int end)
        {
            for(int i=start; i <= end; i++)
            {
                cmb.Items.Add(i);
            }
        }

        public static void LoadDisabledCmb(ComboBox cmb, string text)
        {
            cmb.Items.Clear();
            cmb.Items.Add(text);
            cmb.SelectedIndex = 0;
            cmb.Enabled = false;
        }

//DataGridView
        public static void HideDgvLeadingColumn(DataGridView dgv)
        {
            HideDgvColumn(dgv, 0);
        }

        public static void HideDgvColumn(DataGridView dgv, int column)
        {
            dgv.Columns[column].Visible = false;
        }

        public static void SortDgvByColumn(DataGridView dgv, int columnIndex, ListSortDirection sortDirection)
        {
            dgv.Sort(dgv.Columns[columnIndex], sortDirection);
        }

        public static void SortDgvByColumn(DataGridView dgv, int columnIndex)
        {
            SortDgvByColumn(dgv, columnIndex, ListSortDirection.Ascending);
        }

        public static void FilterDgvRows(DataGridView dgv, string columnName, string filter)
        {
            string rowFilter = string.Format("[{0}] = '{1}'", columnName, filter);
            (dgv.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

//Labels
        public static void ChangeLblText(Label label, string text)
        {
            label.Text = text;
        }

        public static void ChangeLblVisibility(Label label, bool visible)
        {
            label.Visible = visible;
        }

//MessageBoxes
        public static void ShowErrorMessageBox(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowErrorMessageBox(string message)
        {
            ShowErrorMessageBox(message, "Error");
        }

        public static void ShowConfirmationMessageBox(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

//Panel
        public static void ChangePnlVisibility(Panel panel, bool visible)
        {
            panel.Visible = visible;
        }

//Pictures
        public static void AnimatePicSize(PictureBox picture, int width, int height)
        {
            picture.Size = new Size(width, height);
        }

        public static string CastRdoToEPermiso(RadioButton rdo1, RadioButton rdo2)
        {
            string permiso = "Estudiante";

            if (rdo1.Checked)
            {
                permiso = "Admin";
            }

            if (rdo2.Checked)
            {
                permiso = "Docente";
            }

            return permiso;
        }

        
        //TextBoxes
        public static void ToggleTxtPwdchar(TextBox textbox, bool isUsingPwdchar)
        {
            textbox.UseSystemPasswordChar = isUsingPwdchar;
        }

        public static void ChangeTxtText(TextBox textbox, string text)
        {
            textbox.Text = text;
        }

        //Window States

        public static void MaximizeWindow(Form frm)
        {
            if (frm.WindowState == FormWindowState.Normal)
            {
                frm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                frm.WindowState = FormWindowState.Normal;
            }
        }

        public static void MinimizeWindow(Form frm)
        {
            frm.WindowState = FormWindowState.Minimized;
        }


//COMPLEX METHODS//

//Buttons + TextBoxes
        public static void AnimateBtnTogglePwdchar(Button button, TextBox textbox)
        {
            bool usePwdcharSystem = true;
            string btnText = "Mostrar";

            if (textbox.UseSystemPasswordChar)
            {
                usePwdcharSystem = false;
                btnText = "Ocultar";
            }

            ChangeBtnText(button, btnText);
            ToggleTxtPwdchar(textbox, usePwdcharSystem);
        }

//String + Gender
        
        public static string GetStringByGender(EGenero gender, string predet, string male, string female)
        {
            string text;

            if (gender == EGenero.M)
            {
                text = male;
            }
            else if (gender == EGenero.F)
            {
                text = female;
            }
            else
            {
                text = predet;
            }

            return text;
        }

        public static string GetStringByGender(EGenero gender, string predet, string male, string female, string nonbinary)
        {
            string text;

            if (gender == EGenero.NB)
            {
                text = nonbinary;
            }
            else
            {
                text = GetStringByGender(gender, predet, male, female);
            }

            return text;
        }

        public static string GetStringByGender(EGenero gender, string predet, string male, string female, string nonbinary, string other)
        {
            string text;

            if (gender == EGenero.O)
            {
                text = other;
            }
            else
            {
                text = GetStringByGender(gender, predet, male, female, nonbinary);
            }

            return text;
        }


        //Forms + Panels
        public static Form OpenFormInPanel(Form childForm, Form activeForm, Panel pnlControl)
        {
            if (activeForm is not null)
            {
                activeForm.Close();
            }
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pnlControl.Controls.Add(childForm);
            pnlControl.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            return childForm;
        }


        //TableLayoutPanel

        public static void ResizeResponsivelyTlpColumns(TableLayoutPanel tlp, bool isMaxWidthReached, Single maxWidthCol1, Single baseWidthCol2)
        {
            if (isMaxWidthReached)
            {
                tlp.ColumnStyles[0].SizeType = SizeType.Absolute;
                tlp.ColumnStyles[0].Width = maxWidthCol1;
                tlp.ColumnStyles[1].SizeType = SizeType.Percent;
                tlp.ColumnStyles[1].Width = 100F;
            }
            else
            {
                tlp.ColumnStyles[0].SizeType = SizeType.Percent;
                tlp.ColumnStyles[0].Width = 100F;
                tlp.ColumnStyles[1].SizeType = SizeType.Absolute;
                tlp.ColumnStyles[1].Width = baseWidthCol2;
            }
        }

        public static void ResizeResponsivelyTlpSingleColumn(TableLayoutPanel tlp, bool isMaxWidthReached, Single maxWidthCol1)
        {
            if (isMaxWidthReached)
            {
                tlp.ColumnStyles[0].SizeType = SizeType.Absolute;
                tlp.ColumnStyles[0].Width = maxWidthCol1;
            }
            else
            {
                tlp.ColumnStyles[0].SizeType = SizeType.Percent;
                tlp.ColumnStyles[0].Width = 50F;
            }
        }

//External - user32.dll

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public static void DragWindow(Form frm, MouseEventArgs e)
        {
            if (e.Clicks < 2)
            {
                ReleaseCapture();
                SendMessage(frm.Handle, 0x112, 0xf012, 0);
            }
        }
    }
}
