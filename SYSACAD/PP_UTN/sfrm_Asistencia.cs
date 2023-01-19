using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Model;
using Model.Enums;

namespace Presentation
{
    public partial class sfrm_Asistencia : Form
    {
        public sfrm_Asistencia()
        {
            InitializeComponent();
        }

//EVENTS
//Form Load && Show
        private void sfrm_Asistencia_Load(object sender, EventArgs e)
        {
            string titulo = View.GetStringByGender(Session.GetUserGender(), "Materias inscriptx:", "Materias inscripto:", "Materias inscripta:", "Materias inscripte:");
            View.ChangeLblText(lbl_title, titulo);
        }

        private void sfrm_Asistencia_VisibleChanged(object sender, EventArgs e)
        {
            dgv_main.DataSource = View.DatabaseViews.GetStudentEnrolledCoursesGridview(Session.LoggedStudent.Id);
            View.HideDgvLeadingColumn(dgv_main);
            View.SortDgvByColumn(dgv_main, 1);
        }

//Window Controls
        private void pic_CtrlClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pic_CtrlClose_MouseEnter(object sender, EventArgs e)
        {
            View.AnimatePicSize(pic_CtrlClose, 23, 40);
        }

        private void pic_CtrlClose_MouseLeave(object sender, EventArgs e)
        {
            View.AnimatePicSize(pic_CtrlClose, 20, 40);
        }

//Buttons
        private void btn_darAsistencia_Click(object sender, EventArgs e)
        {
            if (dgv_main.SelectedRows.Count >= 1)
            {
                int idEstudiante = Session.LoggedStudent.Id;
                string codigoMateria;

                for (int i = 0; i < dgv_main.SelectedRows.Count; i++)
                {
                    codigoMateria = dgv_main.SelectedRows[i].Cells[0].Value.ToString();
                    Controller.DarAsistencia(codigoMateria, idEstudiante);
                }

                sfrm_Asistencia_VisibleChanged(sender, e);
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos una codigoMateria");
            }
        }

//Responsive Design
        private void tlp_content_Resize(object sender, EventArgs e)
        {
            bool isColumnAtMaxSize = Size.Width > 1100F;
            View.ResizeResponsivelyTlpColumns(tlp_content, isColumnAtMaxSize, 900F, 100F);
        }
    }
}
