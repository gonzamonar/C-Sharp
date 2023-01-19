using Domain;

namespace Presentation
{
    public partial class frmLogin : Form
    {
//Form Init
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            View.Login = this;
        }

        private void frmLogin_VisibleChanged(object sender, EventArgs e)
        {
            View.ChangeTxtText(txt_user, "");
            View.ChangeTxtText(txt_pwd, "");
        }

//Window Controls
        private void pic_windowCtrl1Minimize_MouseEnter(object sender, EventArgs e)
        {
            View.AnimatePicSize(pic_windowCtrl1Minimize, 23, 40);
        }

        private void pic_windowCtrl1Minimize_MouseLeave(object sender, EventArgs e)
        {
            View.AnimatePicSize(pic_windowCtrl1Minimize, 20, 40);
        }

        private void pic_windowCtrl2Close_Click(object sender, EventArgs e)
        {
            View.Exit();
        }

        private void pic_windowCtrl2Close_MouseEnter(object sender, EventArgs e)
        {
            View.AnimatePicSize(pic_windowCtrl2Close, 23, 40);
        }

        private void pic_windowCtrl2Close_MouseLeave(object sender, EventArgs e)
        {
            View.AnimatePicSize(pic_windowCtrl2Close, 20, 40);
        }

        private void pnl_titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            View.DragWindow(this, e);
        }

        private void lbl_windowTitle_MouseDown(object sender, MouseEventArgs e)
        {
            pnl_titlebar_MouseDown(sender, e);
        }

//User Input Section
        private void btn_pwdcharSwitch_Click(object sender, EventArgs e)
        {
            View.AnimateBtnTogglePwdchar(btn_pwdcharSwitch, txt_pwd);
        }

        private void btn_tryLogin_Click(object sender, EventArgs e)
        {
            int login = Session.Login(txt_user.Text.ToLower(), txt_pwd.Text);
            switch (login)
            {
                case -1:
                    MessageBox.Show("Nombre de usuario incorrecto.");
                    break;
                case 0:
                    MessageBox.Show("Contraseña incorrecta.");
                    break;
                case 1:
                    MessageBox.Show("Acceso concedido.");
                    frmWelcome welcomeScreen = new frmWelcome();
                    welcomeScreen.Show();
                    Hide();
                    break;
            }
        }

//Acceso Rápido
        private void btn_autofillAdmin_Click(object sender, EventArgs e)
        {
            View.ChangeTxtText(txt_user, "root");
            View.ChangeTxtText(txt_pwd, "r00t");
        }

        private void btn_autofillProfesor_Click(object sender, EventArgs e)
        {
            View.ChangeTxtText(txt_user, "aturing");
            View.ChangeTxtText(txt_pwd, "Laboratorio");
        }

        private void btn_autofillAlumno_Click(object sender, EventArgs e)
        {
            View.ChangeTxtText(txt_user, "monroe26");
            View.ChangeTxtText(txt_pwd, "7yearitch");
        }
    }
}
