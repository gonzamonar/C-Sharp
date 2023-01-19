using Model.Enums;
using Domain;

namespace Presentation
{
    public partial class sfrm_Estudiantes : Form
    {
        private delegate string ObtenerDatosParaArchivo(string codigo);

        public sfrm_Estudiantes()
        {
            InitializeComponent();
        }

//EVENTS
//Form Load
        private void sfrm_Inscriptos_Load(object sender, EventArgs e)
        {
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
                    dgv_main.DataSource = View.DatabaseViews.GetEnrolledGridview(codigoMateria);
                    View.HideDgvLeadingColumn(dgv_main);
                }
            }
        }

//Buttons
        private void btn_libre_Click(object sender, EventArgs e)
        {
            CambiarCondicion(sender, e, "Libre");
        }

        private void btn_regular_Click(object sender, EventArgs e)
        {
            CambiarCondicion(sender, e, "Regular");
        }

//Responsive Design
        private void tlp_content_Resize(object sender, EventArgs e)
        {
            bool isColumnAtMaxSize = Size.Width > 1150F;
            View.ResizeResponsivelyTlpColumns(tlp_content, isColumnAtMaxSize, 900F, 160F);
        }


//FUNCTIONS
        private void CambiarCondicion(object sender, EventArgs e, string condicion)
        {
            if (dgv_main.SelectedRows.Count >= 1)
            {
                string? codigoMateria = cmb_selectMateria.SelectedValue.ToString();

                for (int i = 0; i < dgv_main.SelectedRows.Count; i++)
                {
                    string? idEstudiante = dgv_main.SelectedRows[i].Cells[0].Value.ToString();
                    Controller.CambiarRegularidad(codigoMateria, idEstudiante, condicion);
                }
                cmb_selectMateria_SelectedIndexChanged(sender, e);
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un estudiante");
            }
        }

        private void btn_exportCSV_Click(object sender, EventArgs e)
        {
            CrearArchivo(Repository.CrearArchivoCSV, ".csv");
        }

        private void btn_exportJSON_Click(object sender, EventArgs e)
        {
            CrearArchivo(Repository.CrearArchivoJSON, ".json");
        }

        private void CrearArchivo(ObtenerDatosParaArchivo delegado, string extension)
        {
            if (Validation.Input.IsCmbSelected(cmb_selectMateria))
            {
                string? codigoMateria = cmb_selectMateria.SelectedValue.ToString();

                if (codigoMateria is not null)
                {
                    try
                    {
                        string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        string rutaArchivo = Path.Combine(rutaEscritorio, $"{codigoMateria}{extension}");

                        string datosParaArchivo = delegado(codigoMateria);

                        File.WriteAllText(rutaArchivo, datosParaArchivo);

                        View.ShowConfirmationMessageBox($"El archivo se ha exportado correctamente en el directorio: {rutaArchivo}.", "Archivo exportado correctamente");
                    }
                    catch
                    {
                        View.ShowErrorMessageBox("Ha ocurrido un error durante la creación del archivo", "Error de creación");
                    }
                }
            }
        }
    }
}
