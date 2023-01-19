using Model.Enums;
using Domain;

namespace Presentation
{
    public partial class sfrm_Calificaciones : Form
    {
        public sfrm_Calificaciones()
        {
            InitializeComponent();
        }

//EVENTS
//Form Load
        private void sfrm_Inscriptos_Load(object sender, EventArgs e)
        {
            View.LoadCmbMateriasAsignadas(cmb_selectMateria, Session.LoggedProfessor.Id);
            cmb_selectMateria_SelectedIndexChanged(sender, e);
            View.ClearCmb(cmb_notas);
            View.LoadCmbNros(cmb_notas, 1, 10);
            View.LoadCmbParciales(cmb_parciales);
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


//ComboBox
        private void cmb_selectMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            View.UnlockBtn(btn_calificar);
            View.ChangeBtnText(btn_calificar, "Calificar");

            if (Validation.Input.IsCmbSelected(cmb_selectMateria))
            {
                string codigoMateria = cmb_selectMateria.SelectedValue.ToString();
                if (codigoMateria is not null && Repository.DoesCourseExist(codigoMateria))
                {
                    dgv_main.DataSource = View.DatabaseViews.GetEnrolledGridview(codigoMateria);
                    View.SortDgvByColumn(dgv_main, 2);
                    View.HideDgvLeadingColumn(dgv_main);
                    View.HideDgvColumn(dgv_main, 1);
                }
            }
        }

//Buttons
        private void btn_calificar_Click(object sender, EventArgs e)
        {
            CambiarCalificacion(sender, e);
        }

//Responsive Design
        private void tlp_content_Resize(object sender, EventArgs e)
        {
            bool isColumnAtMaxSize = Size.Width > 1100F;
            View.ResizeResponsivelyTlpColumns(tlp_content, isColumnAtMaxSize, 900F, 145F);
        }


//FUNCTIONS
        private void CambiarCalificacion(object sender, EventArgs e)
        {
            byte errorCode = Error.GetErrorCode(Validation.Input.IsCmbSelected(cmb_parciales), Validation.Input.IsCmbSelected(cmb_notas), Validation.Input.IsDgvRowSelected(dgv_main));

            if (Error.IsErrorFree(errorCode))
            {
                ETipoExamen tipoExamen = (cmb_parciales.SelectedIndex == 0) ? ETipoExamen.PrimerParcial : ETipoExamen.SegundoParcial;
                int nota = cmb_notas.SelectedIndex + 1;
                string codigoMateria = cmb_selectMateria.SelectedValue.ToString();
                string idEstudiante;

                for (int i = 0; i < dgv_main.SelectedRows.Count; i++)
                {
                    idEstudiante = dgv_main.SelectedRows[i].Cells[0].Value.ToString();
                    if(int.TryParse(idEstudiante, out int id))
                    {
                        Controller.Calificar(codigoMateria, id, nota, tipoExamen);
                    }
                }
                cmb_selectMateria_SelectedIndexChanged(sender, e);
            }
            else
            {
                string errorMsg = Error.GetErrorMsg(errorCode, "", Error.Msg.IsNotSelected("un examen"), Error.Msg.IsNotSelected("una nota"), Error.Msg.IsNotSelected("al menos un estudiante"));
                View.ShowErrorMessageBox(errorMsg);
            }
        }
    }
}
