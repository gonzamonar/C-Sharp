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

namespace Presentation
{
    public partial class sfrm_Usuarios : Form
    {
        public sfrm_Usuarios()
        {
            InitializeComponent();
        }

//EVENTS
//Form Load && Show
        private void sfrm_Usuarios_VisibleChanged(object sender, EventArgs e)
        {
            dgv_main.DataSource = View.DatabaseViews.GetUsersGridview();
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

//Button
        private void btn_newUser_Click(object sender, EventArgs e)
        {
            View.Main.Hide();
            pfrm_AltaUsuario popformAltaUsuario = new pfrm_AltaUsuario();
            popformAltaUsuario.Show();
        }

//Responsive Design
        private void tlp_content_Resize(object sender, EventArgs e)
        {
            bool isColumnAtMaxSize = Size.Width > 1100F;
            View.ResizeResponsivelyTlpColumns(tlp_content, isColumnAtMaxSize, 900F, 100F);
        }
    }
}
