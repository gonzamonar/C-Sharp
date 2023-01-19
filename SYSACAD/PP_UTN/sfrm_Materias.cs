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
    public partial class sfrm_Materias : Form
    {
        public sfrm_Materias()
        {
            InitializeComponent();
        }

//EVENTS
//Form Load && Show
        private void sfrm_Materias_Load(object sender, EventArgs e)
        {
            View.ChangePnlVisibility(pnl_filter, false);
            View.LoadCmb(cmb_filterField, "", "Asignatura", "Cuatrimestre", "Año");
            View.LoadDisabledCmb(cmb_filterValue, "Elija un campo para filtrar");
        }

        private void sfrm_Materias_VisibleChanged(object sender, EventArgs e)
        {
            dgv_main.DataSource = View.DatabaseViews.GetCoursesGridview();
            //cmb_filterField_SelectedIndexChanged(sender, e);
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
        private void btn_nuevaMateria_Click(object sender, EventArgs e)
        {
            View.Main.Hide();
            pfrm_AltaMateria popformAltaMateria = new pfrm_AltaMateria(true);
            popformAltaMateria.Show();
        }

        private void btn_nuevaAsignatura_Click(object sender, EventArgs e)
        {
            View.Main.Hide();
            pform_AltaAsignatura popformAltaAsignatura = new pform_AltaAsignatura();
            popformAltaAsignatura.Show();
        }

        private void btn_cargarCuatrimestre_Click(object sender, EventArgs e)
        {
            View.Main.Hide();
            pfrm_AltaMateria popformAltaMateria = new pfrm_AltaMateria(false);
            popformAltaMateria.Show();
        }

//Responsive Design
        private void tlp_content_SizeChanged(object sender, EventArgs e)
        {
            bool isColumnAtMaxSize = Size.Width > 1100F;
            View.ResizeResponsivelyTlpColumns(tlp_content, isColumnAtMaxSize, 900F, 100F);
        }

//Cmb Controls [Filter]
        //private void cmb_filterField_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        cmb_filterValue.SelectedIndex = 0;
        //        UpdateFilterValueCmb();
        //        ApplyFilter();
        //    }
        //    catch
        //    {
        //        View.ShowErrorMessageBox("Error: La de herramienta de filtro dejó de funcionar.", "Error");
        //    }
        //}

        //private void cmb_filterValue_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ApplyFilter();
        //}


//FUNCTIONS
        //private void ApplyFilter()
        //{
        //    dgv_main.DataSource = View.DatabaseViews.GetCoursesGridview();

        //        //if (cmb_filterField.SelectedIndex > 0 && cmb_filterValue.SelectedIndex > 0)
        //        //{
        //        //    string column = cmb_filterField.Text;
        //        //    string value = cmb_filterValue.Text;
        //        //    View.FilterDgvRows(dgv_main, column, value);
        //        //}

        //        //View.SortDgvByColumn(dgv_main, 0);
        //}

        //private void UpdateFilterValueCmb()
        //{
        //    int index = cmb_filterField.SelectedIndex;
        //    if(index > -1)
        //    {
        //        View.ClearCmb(cmb_filterValue);
        //        View.LoadCmb(cmb_filterValue, ""); //add empty option
        //        View.EnableCmb(cmb_filterValue, true);

        //        switch (index)
        //        {
        //            case 0:
        //                View.LoadDisabledCmb(cmb_filterValue, "Elija un campo para filtrar");
        //                break;
        //            case 1:
        //                View.LoadCmbAsignaturas(cmb_filterValue, true);
        //                break;
        //            case 2:
        //                View.LoadCmbCuatrimestres(cmb_filterValue);
        //                break;
        //            case 3:
        //                List<string> list = View.GetListFromDataTableColumn(View.CreateCoursesDataTable(), 3);
        //                View.LoadCmbFromList(cmb_filterValue, list);
        //                break;
        //        }
        //    }
        //}
    }
}
