using Model;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

//Form Load
        private void frmWelcome_Load(object sender, EventArgs e)
        {
            Opacity = 0.0;
            if (Session.IsSessionActive())
            {
                string welcome = View.GetStringByGender(Session.GetUserGender(), "BIENVENIDX", "BIENVENIDO", "BIENVENIDA", "BIENVENIDE");
                View.ChangeLblText(lbl_welcome, welcome);
                View.ChangeLblText(lbl_user, Session.LoggedUser.GetUserInfo());
            }
            tmr_fadeIn.Start();
        }

//Timers
        int contador = 0;
        private void tmr_fadeIn_Tick(object sender, EventArgs e)
        {
            if(Opacity < 1)
            {
                Opacity += 0.05;
            }
            contador++;
            if(contador == 100)
            {
                tmr_fadeIn.Stop();
                tmr_fadeOut.Start();
            }
        }

        private void tmr_fadeOut_Tick(object sender, EventArgs e)
        {
            Opacity -= 0.1;
            if (Opacity == 0)
            {
                tmr_fadeOut.Stop();
                frmMain formMain = new frmMain();
                formMain.Show();
                Close();
            }
        }
    }
}
