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

namespace Presentation
{
    public partial class pform_AltaAsignatura : Form
    {
        public pform_AltaAsignatura()
        {
            InitializeComponent();
        }

//Form Load
        private void pform_AltaAsignatura_Load(object sender, EventArgs e)
        {
            View.ChangeLblText(lbl_errorCodigo, "");
            View.ChangeLblText(lbl_errorTitulo, "");
            View.ChangeLblText(lbl_errorTituloCodif, "");
            View.LoadCmbAsignaturas(cmb_correlativa1, true);
            View.EnableCmb(cmb_correlativa2, false);
            View.EnableCmb(cmb_correlativa3, false);
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

//Button
        private void btn_tryAlta_Click(object sender, EventArgs e)
        {
            if (TryAltaAsignatura())
            {
                Close();
                View.Main.Show();
            }
        }

//Cmb Controls
        private void cmb_correlativa1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Validation.Input.IsCmbSelected(cmb_correlativa1, true))
            {
                View.EnableCmb(cmb_correlativa2, true);
                View.LoadCmbAsignaturas(cmb_correlativa2, true);
            }
            else
            {
                View.ClearCmb(cmb_correlativa2);
                View.EnableCmb(cmb_correlativa2, false);
            }
        }

        private void cmb_correlativa2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Validation.Input.IsCmbSelected(cmb_correlativa2, true))
            {
                View.EnableCmb(cmb_correlativa3, true);
                View.LoadCmbAsignaturas(cmb_correlativa3, true);
            }
            else
            {
                View.ClearCmb(cmb_correlativa3);
                View.EnableCmb(cmb_correlativa3, false);
            }
        }

//FUNCTIONS
        private bool TryAltaAsignatura()
        {
            bool taskCompleted = false;
        //Error Codes Generation
            byte codigoErrorCode = Error.GetErrorCode(Validation.Input.IsNotEmptyNullOrWhiteSpace(txt_codigo.Text), Validation.Input.IsANumber(txt_codigo.Text),
                                                   Validation.Input.IsBetweenRange(txt_codigo.Text, 1000, 4000), !Repository.DoesSubjectExist(txt_codigo.Text));
            byte tituloErrorCode = Error.GetErrorCode(Validation.Input.IsNotEmptyNullOrWhiteSpace(txt_titulo.Text), Validation.Input.IsAlphabeticalOrWhiteSpace(txt_titulo.Text),
                                                        Validation.Input.IsInMinRange(txt_titulo.TextLength, 6), Validation.Input.IsInMaxRange(txt_titulo.TextLength, 25), !Repository.IsSubjectTitleUsed(txt_titulo.Text));
            byte codiftituloErrorCode = Error.GetErrorCode(Validation.Input.IsNotEmptyNullOrWhiteSpace(txt_tituloCodif.Text), Validation.Input.IsAlphanumerical(txt_tituloCodif.Text),
                                            Validation.Input.IsInMinRange(txt_tituloCodif.TextLength, 6), Validation.Input.IsInMaxRange(txt_tituloCodif.TextLength, 25), !Repository.IsSubjectCodedTitleUsed(txt_tituloCodif.Text));
        //Error Messages Generation
            string codigoErrorMsg = Error.GetErrorMsg(codigoErrorCode, "", Error.Msg.IsMandatory, Error.Msg.IsNaN, Error.Msg.IsOutOfRange("1000 - 4000"), Error.Msg.KeyExists("El código de la asignatura"));
            string tituloErrorMsg = Error.GetErrorMsg(tituloErrorCode, "", Error.Msg.IsMandatory, Error.Msg.IsAlphaWhite, Error.Msg.IsTooShort("6"), Error.Msg.IsTooLong("25"), Error.Msg.KeyExists("El título de la asignatura"));
            string codifTituloErrorMsg = Error.GetErrorMsg(codiftituloErrorCode, "", Error.Msg.IsMandatory, Error.Msg.IsAlphanum, Error.Msg.IsTooShort("6"), Error.Msg.IsTooLong("25"), Error.Msg.KeyExists("El título codificado de la asignatura"));

        //Error Check && Action Execution
            if (Error.IsErrorFree(codigoErrorCode, tituloErrorCode, codiftituloErrorCode))
            {
                taskCompleted = true;
                byte seleccionCorrelativas = Error.GetErrorCode(!Validation.Input.IsCmbSelected(cmb_correlativa1, true), !Validation.Input.IsCmbSelected(cmb_correlativa2, true), !Validation.Input.IsCmbSelected(cmb_correlativa3, true));
                int result;
                switch (seleccionCorrelativas)
                {
                    case 1:
                        result = Controller.CrearAsignatura(txt_codigo.Text, txt_titulo.Text, txt_tituloCodif.Text, cmb_correlativa1.SelectedValue.ToString());
                        break;
                    case 3:
                        result = Controller.CrearAsignatura(txt_codigo.Text, txt_titulo.Text, txt_tituloCodif.Text, cmb_correlativa1.SelectedValue.ToString(), cmb_correlativa2.SelectedValue.ToString());
                        break;
                    case 7:
                        result = Controller.CrearAsignatura(txt_codigo.Text, txt_titulo.Text, txt_tituloCodif.Text, cmb_correlativa1.SelectedValue.ToString(), cmb_correlativa2.SelectedValue.ToString(), cmb_correlativa3.SelectedValue.ToString());
                        break;
                    default:
                        result = Controller.CrearAsignatura(txt_codigo.Text, txt_titulo.Text, txt_tituloCodif.Text);
                        break;
                }
                
                string confirmMsg = (result == 1) ? "La asignatura ha sido creada con éxito." : "La asignatura ya existe.";
                View.ShowConfirmationMessageBox(confirmMsg, "Alta Exitosa");
            }

            if (!taskCompleted)
            {
                View.ChangeLblText(lbl_errorCodigo, codigoErrorMsg);
                View.ChangeLblText(lbl_errorTitulo, tituloErrorMsg);
                View.ChangeLblText(lbl_errorTituloCodif, codifTituloErrorMsg);
            }

            return taskCompleted;
        }

    }
}
