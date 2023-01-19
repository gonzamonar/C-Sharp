using Model;
using Domain;
using Model.Enums;

namespace Presentation
{
    public partial class sfrm_Inscripciones : Form
    {
        private Estudiante? activeStudent;

        public sfrm_Inscripciones()
        {
            InitializeComponent();
        }

//EVENTS
//Form Load
        private void sfrm_Inscriptos_Load(object sender, EventArgs e)
        {
            View.ChangeLblText(lbl_cuatri, "");
            View.ChangeLblText(lbl_anio, "");

            if (Session.IsAStudentSession())
            {
                activeStudent = Session.LoggedStudent;
                activeStudent.MateriasInscripto.Clear();
                Repository.CargarMateriasInscripto(activeStudent);
            }
            else if (Session.IsAnAdminSession())
            {
                View.ChangeLblText(lbl_userData, "");
                View.ChangeCmbVisibility(cmb_selectEstudiante, true);
                View.LoadCmbEstudiantes(cmb_selectEstudiante);
            }
            UpdateEnrollOptions();
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


//Cmb Controls
        private void cmb_selectMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Validation.Input.IsCmbSelected(cmb_selectMateria))
            {
                string? codigoMateria = cmb_selectMateria.SelectedValue.ToString();
                if (codigoMateria is not null && Repository.DoesCourseExist(codigoMateria))
                {
                    Materia? m = Repository.GetMateria(codigoMateria);
                    if (m is not null)
                    {
                        View.ChangeLblText(lbl_titulo, m.Asignatura.Titulo);
                        View.ChangeLblText(lbl_cuatri, m.Cuatrimestre.Periodo.ToString());
                        View.ChangeLblText(lbl_anio, m.Cuatrimestre.Anio.ToString());
                    }
                }
            }
        }

        //ONLY Admin Feature
        private void cmb_selectEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Validation.Input.IsCmbSelected(cmb_selectEstudiante))
            {
                string? studentId = cmb_selectEstudiante.SelectedValue.ToString();

                if (int.TryParse(studentId, out int id) && Repository.DoesUserExist(id, "Estudiante"))
                {
                    activeStudent = (Estudiante)Repository.GetUser(id);
                    UnfreezeEnrollButton();
                    UpdateEnrollOptions();
                }
            }
        }


        //Buttons
        private void btn_inscribir_Click(object sender, EventArgs e)
        {
            if (Validation.Input.IsCmbSelected(cmb_selectMateria) && 
                (Session.IsAStudentSession() || (Session.IsAnAdminSession() && Validation.Input.IsCmbSelected(cmb_selectEstudiante))))
            {
                string codigoMateria = cmb_selectMateria.SelectedValue.ToString();
                Controller.InscribirEstudiante(codigoMateria, activeStudent);
                UpdateEnrollOptions();
            }
        }

//Responsive Design
        private void tlp_content_Resize(object sender, EventArgs e)
        {
            bool isColumnAtMaxSize = Size.Width > 850F;
            View.ResizeResponsivelyTlpSingleColumn(tlp_content, isColumnAtMaxSize, 400F);
        }


//FUNCTIONS
        private void LoadInscriptionTxts()
        {
            View.ChangeTxtText(txt_inscripcion1, "");
            View.ChangeTxtText(txt_inscripcion2, "");

            TextBox[] txtArray = { txt_inscripcion1, txt_inscripcion2 };
            int i = 0;
            foreach (Materia m in activeStudent.MateriasInscripto)
            {
                if (txtArray.Length > i)
                {
                    txtArray[i].Text = m.Codigo;
                    i++;
                }
            }
        }

        private static bool AreMaxEnrollmentsReached(Estudiante e)
        {
            return e.MateriasInscripto.Count() == Estudiante.MaxInscripcionesPermitidas;
        }

        private void FreezeEnrollButton()
        {
            btn_inscribir.Enabled = false;
            btn_inscribir.Text = "Nº de Inscripciones" + Environment.NewLine + "Máximas Alcanzadas";
        }

        private void UnfreezeEnrollButton()
        {
            btn_inscribir.Enabled = true;
            btn_inscribir.Text = "Inscribir";
        }

        private static ECuatrimestre GetCurrentCuatrimestre()
        {
            ECuatrimestre cuatrimestreActivo;
            if (DateTime.Now.Month >= 7)
            {
                cuatrimestreActivo = ECuatrimestre.Segundo;
            }
            else if(DateTime.Now.Month >= 3)
            {
                cuatrimestreActivo = ECuatrimestre.Primero;
            }
            else
            {
                cuatrimestreActivo = ECuatrimestre.Verano;
            }

            return cuatrimestreActivo;
        }

        private void UpdateEnrollOptions()
        {
            ECuatrimestre cuatrimestreActivo = GetCurrentCuatrimestre();
            int anio = DateTime.Now.Year;

            dgv_main.DataSource = View.DatabaseViews.GetStudentApprovedAssignmentsGridview(activeStudent.Username);
            View.ClearCmb(cmb_selectMateria);
            View.LoadCmbAbleToEnrollMaterias(cmb_selectMateria, activeStudent.Id, Cuatrimestre.Keygen(cuatrimestreActivo, anio));
            View.ChangeLblText(lbl_userData, activeStudent.GetUserInfo());

            activeStudent.MateriasInscripto.Clear();
            Repository.CargarMateriasInscripto(activeStudent);
            LoadInscriptionTxts();

            if (AreMaxEnrollmentsReached(activeStudent))
            {
                FreezeEnrollButton();
            }
        }
    }
}