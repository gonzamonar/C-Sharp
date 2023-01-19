using Model;
using Domain;
using Model.Enums;
using System.Data;

namespace Presentation
{
    public partial class sfrm_Estadisticas : Form
    {

        public sfrm_Estadisticas()
        {
            InitializeComponent();
        }

//EVENTS
//Form Load
        private void sfrm_Inscriptos_Load(object sender, EventArgs e)
        {
            //dgv_inscriptos.DataSource = View.DataTables.StatisticsEnrollments();
            //dgv_notas.DataSource = View.DataTables.StatisticsGrades();
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


//FUNCTIONS
        
    }
}