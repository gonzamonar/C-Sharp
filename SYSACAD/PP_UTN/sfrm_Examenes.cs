using Model;
using Model.Enums;
using Domain;

namespace Presentation
{
    public partial class sfrm_Examenes : Form
    {
        public sfrm_Examenes()
        {
            InitializeComponent();
        }

//EVENTS
//Form Load
        private void sfrm_Inscriptos_Load(object sender, EventArgs e)
        {
            View.LoadCmbMateriasAsignadas(cmb_selectMateria, Session.LoggedProfessor.Id);
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
                string codigoMateria = cmb_selectMateria.SelectedValue.ToString();
                if (codigoMateria is not null && Repository.DoesCourseExist(codigoMateria))
                {
                    bool courseIsNotEmpty = !Repository.IsCourseEmpty(codigoMateria);
                    dgv_main.DataSource = View.DatabaseViews.GetExamsDataTable(codigoMateria);

                    byte codePP = Error.GetErrorCode(courseIsNotEmpty, !Repository.IsExamCreated(codigoMateria, "PrimerParcial"));
                    byte codeSP = Error.GetErrorCode(courseIsNotEmpty, !Repository.IsExamCreated(codigoMateria, "SegundoParcial"));
                    string txtPP = Error.GetErrorMsg(codePP, "Crear Primer Parcial", "Sin Inscriptos", "Actualizar Fecha" + Environment.NewLine + "Primer Parcial");
                    string txtSP = Error.GetErrorMsg(codeSP, "Crear Segundo Parcial", "Sin Inscriptos", "Actualizar Fecha" + Environment.NewLine + "Segundo Parcial");

                    if (courseIsNotEmpty)
                    {
                        View.UnlockBtn(btn_crearPP, btn_crearSP);
                    }
                    else
                    {
                        View.LockBtn(btn_crearPP, btn_crearSP);
                    }

                    View.ChangeBtnText(btn_crearPP, txtPP);
                    View.ChangeBtnText(btn_crearSP, txtSP);
                }
            }
        }

//Buttons
        private void btn_crearPP_Click(object sender, EventArgs e)
        {
            CreateExam(sender, e, "PrimerParcial");
        }

        private void btn_crearSP_Click(object sender, EventArgs e)
        {
            CreateExam(sender, e, "SegundoParcial");
        }

//Responsive Design
        private void tlp_content_Resize(object sender, EventArgs e)
        {
            bool isColumnAtMaxSize = Size.Width > 1200F;
            View.ResizeResponsivelyTlpColumns(tlp_content, isColumnAtMaxSize, 900F, 205F);
        }


//FUNCTIONS
        private void CreateExam(object sender, EventArgs e, string tipoExamen)
        {
            string codigoMateria = cmb_selectMateria.SelectedValue.ToString();
            int userId = Session.LoggedProfessor.Id;

            int day = dtp_fecha.Value.Day;
            int month = dtp_fecha.Value.Month;
            int year = dtp_fecha.Value.Year;

            string date = $"{year}-{month}-{day}";

            Controller.CrearExamen(codigoMateria, userId, tipoExamen, date);
            cmb_selectMateria_SelectedIndexChanged(sender, e);
        }
    }
}
