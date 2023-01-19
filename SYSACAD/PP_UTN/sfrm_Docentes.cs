using Model;
using Domain;

namespace Presentation
{
    public partial class sfrm_Docentes : Form
    {
        public sfrm_Docentes()
        {
            InitializeComponent();
        }

//EVENTS
//Form Load
        private void sfrm_Inscriptos_Load(object sender, EventArgs e)
        {
            View.ChangeLblText(lbl_cuatri, "");
            View.ChangeLblText(lbl_anio, "");
            View.LoadCmbMaterias(cmb_selectMateria);
            cmb_selectMateria_SelectedIndexChanged(sender, e);
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
            if (Validation.Input.IsCmbSelected(cmb_selectMateria))
            {
                string? codigoMateria = cmb_selectMateria.SelectedValue.ToString();
                if (codigoMateria is not null && Repository.DoesCourseExist(codigoMateria))
                {
                    dgv_main.DataSource = View.DatabaseViews.GetTeachersInCourseGridview(codigoMateria);
                    View.HideDgvLeadingColumn(dgv_main);
                    View.LoadCmbAddDocentes(cmb_selectDocente, codigoMateria);

                    Materia? m = Repository.GetMateria(codigoMateria);
                    if(m is not null)
                    {
                        View.ChangeLblText(lbl_titulo, m.Asignatura.Titulo);
                        View.ChangeLblText(lbl_cuatri, m.Cuatrimestre.Periodo.ToString());
                        View.ChangeLblText(lbl_anio, m.Cuatrimestre.Anio.ToString());
                    }
                }
            }
        }

//Buttons
        private void btn_designar_Click(object sender, EventArgs e)
        {
            byte errorCode = Error.GetErrorCode(Validation.Input.IsCmbSelected(cmb_selectMateria), Validation.Input.IsCmbSelected(cmb_selectDocente));

            if (Error.IsErrorFree(errorCode))
            {
                string? codigoMateria = cmb_selectMateria.SelectedValue.ToString();
                string? idDocente = cmb_selectDocente.SelectedValue.ToString();
                if(codigoMateria is not null && idDocente is not null)
                {
                    Controller.AsignarDocente(codigoMateria, idDocente);
                    cmb_selectMateria_SelectedIndexChanged(sender, e);
                }
            }
            else
            {
                string errorMsg = Error.GetErrorMsg(errorCode, "", Error.Msg.IsNotSelected("una materia"), Error.Msg.IsNotSelected("un docente"));
                View.ShowErrorMessageBox(errorMsg);
            }
        }
    }
}
