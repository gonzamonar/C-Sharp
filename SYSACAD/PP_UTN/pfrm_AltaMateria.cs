using System;
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
using Model.Enums;

namespace Presentation
{
    public partial class pfrm_AltaMateria : Form
    {
        private bool singleLoadMode;

//Form Init
        public pfrm_AltaMateria(bool singleLoadMode)
        {
            InitializeComponent();
            this.singleLoadMode = singleLoadMode;
        }

        private void pfrm_AltaMateria_Load(object sender, EventArgs e)
        {
            if (singleLoadMode)
            {
                View.LoadCmbAsignaturas(cmb_selectAsignatura, false);
            }
            else
            {
                View.LoadDisabledCmb(cmb_selectAsignatura, "Todas las asignaturas.");
            }
            View.LoadCmbCuatrimestres(cmb_selectCuatri);
        }

//Window Controls
        private void pic_CtrlClose_Click(object sender, EventArgs e)
        {
            View.ClosePopForm(this);
        }

        private void pic_CtrlClose_MouseEnter(object sender, EventArgs e)
        {
            View.AnimatePicSize(pic_CtrlClose, 23, 40);
        }

        private void pic_CtrlClose_MouseLeave(object sender, EventArgs e)
        {
            View.AnimatePicSize(pic_CtrlClose, 20, 40);
        }

//Botón de Alta
        private void btn_tryAlta_Click(object sender, EventArgs e)
        {
            if (TryAltaMateria())
            {
                Close();
                View.Main.Show();
            }
        }


//FUNCTIONS
        private bool TryAltaMateria()
        {
            bool taskCompleted = false;
        //Error Codes Generation
            byte asignaturaErrorCode = Error.GetErrorCode(Validation.Input.IsCmbSelected(cmb_selectAsignatura));
            byte cuatriErrorCode = Error.GetErrorCode(Validation.Input.IsCmbSelected(cmb_selectCuatri));
            byte anioErrorCode = Error.GetErrorCode(Validation.Input.IsNotEmptyNullOrWhiteSpace(txt_anio.Text), Validation.Input.IsANumber(txt_anio.Text),
                                                   Validation.Input.IsBetweenRange(txt_anio.Text, 2010, 2030));
        //Error Messages Generation
            string asignaturaErrorMsg = Error.GetErrorMsg(asignaturaErrorCode, "", Error.Msg.IsNotSelected("una asignatura"));
            string cuatriErrorMsg = Error.GetErrorMsg(cuatriErrorCode, "", Error.Msg.IsNotSelected());
            string anioErrorMsg = Error.GetErrorMsg(anioErrorCode, "", Error.Msg.IsMandatory, Error.Msg.IsNaN, Error.Msg.IsOutOfRange("2010 - 2030"));

        //Error Check && Action Execution
            if (Error.IsErrorFree(asignaturaErrorCode, cuatriErrorCode, anioErrorCode))
            {
                taskCompleted = true;
                string confirmMsg;
                string confirmTitle = "Alta Exitosa";

                if (singleLoadMode)
                {
                    try
                    {
                        int result = 0;
                        result = Controller.CrearMateria(cmb_selectAsignatura.SelectedValue.ToString(), cmb_selectCuatri.Text, txt_anio.Text);
                        confirmMsg = (result == 1) ? "La materia ha sido creada con éxito." : "La materia ya existe.";
                    }
                    catch
                    {
                        confirmMsg = "Ocurrió un error insperado, reintente nuevamente";
                        confirmTitle = "Error";
                    }
                }
                else
                {
                    int result = Controller.CargarCuatrimestreCompleto(cmb_selectCuatri.Text, txt_anio.Text);
                    confirmMsg = GetConfirmMsg(result);
                }
                View.ShowConfirmationMessageBox(confirmMsg, confirmTitle);
            }

            
            if(!taskCompleted)
            {
                View.ChangeLblText(lbl_errorAsignatura, asignaturaErrorMsg);
                View.ChangeLblText(lbl_errorCuatrimestre, cuatriErrorMsg);
                View.ChangeLblText(lbl_errorAnio, anioErrorMsg);
            }

            return taskCompleted;
        }


        private static string GetConfirmMsg(int result)
        {
            string confirmMsg;

            int asignaturasCargadas = Repository.ContarAsignaturasCargadas();

            if (result == asignaturasCargadas)
            {
                confirmMsg = "El cuatrimestre ha sido cargado con éxito.";
            }
            else if (result == 0)
            {
                confirmMsg = "El cuatrimestre ya se encontraba cargado.";
            }
            else if (result == asignaturasCargadas - 1)
            {
                confirmMsg = "Una materia del cuatrimestre ya estaba cargada" + Environment.NewLine + "y se crearon las materias restantes.";
            }
            else
            {
                confirmMsg = "Algunas materias del cuatrimestre ya estaban cargadas" + Environment.NewLine + "y se crearon las materias restantes.";
            }

            return confirmMsg;
        }
    }
}
