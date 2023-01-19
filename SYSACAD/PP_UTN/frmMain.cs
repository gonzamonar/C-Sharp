using Domain;


namespace Presentation
{
    public partial class frmMain : Form
    {
        private static Form activeForm = null;
        private const int cGrip = 16;
        private const int cCaption = 32;

//Form Init
        public frmMain()
        {
            InitializeComponent();
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            DoubleBuffered = true;
            SetStyle(ControlStyles.StandardClick | ControlStyles.StandardDoubleClick, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            View.Main = this;

            //For testing purposes
            //Session.Login("root", "r00t");
            //Session.Login("aturing", "Laboratorio");
            //Session.Login("monroe26", "7yearitch");

            UpdateSessionAccess();
            UpdateSessionBanner();
        }

//Window Controls
        #region Window Controls
        private void pic_windowCtrl1Minimize_Click(object sender, EventArgs e)
        {
            View.MinimizeWindow(this);
        }

        private void pic_windowCtrl2Maximize_Click(object sender, EventArgs e)
        {
            View.MaximizeWindow(this);
        }

        private void pic_windowCtrl3Close_Click(object sender, EventArgs e)
        {
            View.Exit();
        }

        private void pic_windowCtrl1Minimize_MouseEnter(object sender, EventArgs e)
        {
            View.AnimatePicSize(pic_windowCtrl1Minimize, 23, 40);
        }

        private void pic_windowCtrl1Minimize_MouseLeave(object sender, EventArgs e)
        {
            View.AnimatePicSize(pic_windowCtrl1Minimize, 20, 40);
        }

        private void pic_windowCtrl2Maximize_MouseEnter(object sender, EventArgs e)
        {
            View.AnimatePicSize(pic_windowCtrl2Maximize, 23, 40);
        }

        private void pic_windowCtrl2Maximize_MouseLeave(object sender, EventArgs e)
        {
            View.AnimatePicSize(pic_windowCtrl2Maximize, 20, 40);
        }
        private void pic_windowCtrl3Close_MouseEnter(object sender, EventArgs e)
        {
            View.AnimatePicSize(pic_windowCtrl3Close, 23, 40);
        }

        private void pic_windowCtrl3Close_MouseLeave(object sender, EventArgs e)
        {
            View.AnimatePicSize(pic_windowCtrl3Close, 20, 40);
        }

        private void pnl_titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            View.DragWindow(this, e);
        }

        private void pnl_titlebar_DoubleClick(object sender, EventArgs e)
        {
            View.MaximizeWindow(this);
        }

        private void lbl_windowTitle_MouseDown(object sender, MouseEventArgs e)
        {
            pnl_titlebar_MouseDown(sender, e);
        }

        private void lbl_windowTitle_DoubleClick(object sender, EventArgs e)
        {
            pnl_titlebar_DoubleClick(sender, e);
        }

        #endregion

//Resize Borderless Window
        protected override void WndProc(ref Message message)
        {
            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                Point pos = new Point(message.LParam.ToInt32());
                pos = PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    message.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= ClientSize.Width - cGrip && pos.Y >= ClientSize.Height - cGrip)
                {
                    message.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref message);
        }

//Side Menu Buttons

        //Admin
        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            activeForm = View.OpenFormInPanel(new sfrm_Usuarios(), activeForm, pnl_main);
        }

        private void btn_materias_Click(object sender, EventArgs e)
        {
            activeForm = View.OpenFormInPanel(new sfrm_Materias(), activeForm, pnl_main);
        }

        private void btn_estudiantes_Click(object sender, EventArgs e)
        {
            activeForm = View.OpenFormInPanel(new sfrm_Estudiantes(), activeForm, pnl_main);
        }

        private void btn_docentes_Click(object sender, EventArgs e)
        {
            activeForm = View.OpenFormInPanel(new sfrm_Docentes(), activeForm, pnl_main);
        }

        //Docente
        private void btn_calificar_Click(object sender, EventArgs e)
        {
            activeForm = View.OpenFormInPanel(new sfrm_Calificaciones(), activeForm, pnl_main);
        }

        private void btn_examenes_Click(object sender, EventArgs e)
        {
            activeForm = View.OpenFormInPanel(new sfrm_Examenes(), activeForm, pnl_main);
        }

        //Estudiante
        private void btn_inscripciones_Click(object sender, EventArgs e)
        {
            activeForm = View.OpenFormInPanel(new sfrm_Inscripciones(), activeForm, pnl_main);
        }

        private void btn_asistencias_Click(object sender, EventArgs e)
        {
            activeForm = View.OpenFormInPanel(new sfrm_Asistencia(), activeForm, pnl_main);
        }

        //Cerrar Sesión
        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Confirma que desea cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Session.Logout();
                View.Login.Show();
                Close();
            }
        }
        

//Functions
        private void UpdateSessionAccess()
        {
            View.ChangeBtnVisibility(btn_inscripciones, false);
            View.ChangeBtnVisibility(btn_estadisticas, false);

            if (!Session.IsAnAdminSession())
            {
                View.ChangeBtnVisibility(btn_usuarios, false);
                View.ChangeBtnVisibility(btn_materias, false);
                View.ChangeBtnVisibility(btn_estudiantes, false);
                View.ChangeBtnVisibility(btn_docentes, false);
            }

            if (!Session.IsAProfSession())
            {
                View.ChangeBtnVisibility(btn_calificar, false);
                View.ChangeBtnVisibility(btn_examenes, false);
                View.ChangeBtnVisibility(btn_inscripciones, true);
            }

            if (!Session.IsAStudentSession())
            {
                View.ChangeBtnVisibility(btn_asistencias, false);
                View.ChangeBtnText(btn_inscripciones, "Gestión de Inscripciones");
            }
        }

        private void UpdateSessionBanner()
        {
            if (Session.IsSessionActive())
            {
                View.ChangeLblText(lbl_infoUsername, Session.LoggedUser.Username);
            }

            if (Session.IsAnAdminSession())
            {
                View.ChangeLblVisibility(lbl_Nombre, false);
                View.ChangeLblVisibility(lbl_infoName, false);
                View.ChangeLblVisibility(lbl_Apellido, false);
                View.ChangeLblVisibility(lbl_infoApellido, false);
                View.ChangeLblText(lbl_infoPermiso, "Admin");
            } 
            else if (Session.IsAProfSession())
            {
                View.ChangeLblText(lbl_infoPermiso, "Profesor");
                View.ChangeLblText(lbl_infoName, Session.LoggedProfessor.Nombre);
                View.ChangeLblText(lbl_infoApellido, Session.LoggedProfessor.Apellido);
            }
            else if (Session.IsAStudentSession())
            {
                View.ChangeLblText(lbl_infoPermiso, "Estudiante");
                View.ChangeLblText(lbl_infoName, Session.LoggedStudent.Nombre);
                View.ChangeLblText(lbl_infoApellido, Session.LoggedStudent.Apellido);
            }
        }

        private void btn_estadisticas_Click(object sender, EventArgs e)
        {
            activeForm = View.OpenFormInPanel(new sfrm_Estadisticas(), activeForm, pnl_main);
        }
    }
}
