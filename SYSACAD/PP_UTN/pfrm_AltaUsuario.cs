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
using Library;

namespace Presentation
{
    public partial class pfrm_AltaUsuario : Form
    {
        public pfrm_AltaUsuario()
        {
            InitializeComponent();
        }

        private void pfrm_AltaUsuario_Load(object sender, EventArgs e)
        {
            View.LoadCmbGenero(cmb_gender);
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

//Rdo Controls
        private void rdo_admin_CheckedChanged(object sender, EventArgs e)
        {
            DisplayPersonFields(false);
        }

        private void rdo_profesor_CheckedChanged(object sender, EventArgs e)
        {
            DisplayPersonFields(true);
        }

        private void rdo_estudiante_CheckedChanged(object sender, EventArgs e)
        {
            DisplayPersonFields(true);
        }

//Button
        private void btn_createUser_Click(object sender, EventArgs e)
        {
            if (TryAltaUsuario(out int result))
            {
                Close();
                View.Main.Show();
                if(result == 1)
                {
                    View.ShowConfirmationMessageBox("El usuario ha sido creado con éxito.", "Alta Exitosa");
                }
                else
                {
                    View.ShowErrorMessageBox("No se ha podido realizar el alta, inténtelo nuevamente.", "Ha ocurrido un error");
                }
            }
        }

//FUNCTIONS
        private bool TryAltaUsuario(out int result)
        {
            result = 0;
            bool taskCompleted = false;
        //Error Codes Generation
            byte usertypeErrorCode = Error.GetErrorCode(Validation.Input.IsRdoSelected(rdo_admin, rdo_profesor, rdo_estudiante));
            byte usernameErrorCode = Error.GetErrorCode(Validation.Input.IsNotEmptyNullOrWhiteSpace(txt_username.Text), Validation.Input.IsAlphanumerical(txt_username.Text),
                                                        Validation.Input.IsInMinRange(txt_username.TextLength, 4), Validation.Input.IsInMaxRange(txt_username.TextLength, 15), Repository.IsUsernameAvailable(txt_username.Text));
            byte pwdErrorCode = Error.GetErrorCode(Validation.Input.IsNotEmptyNullOrWhiteSpace(txt_pwd.Text), Validation.Input.IsAlphanumerical(txt_pwd.Text),
                                            Validation.Input.IsInMinRange(txt_pwd.TextLength, 4), Validation.Input.IsInMaxRange(txt_pwd.TextLength, 15));
            byte nameErrorCode = Error.GetErrorCode(Validation.Input.IsNotEmptyNullOrWhiteSpace(txt_name.Text), Validation.Input.IsAlphabeticalOrWhiteSpace(txt_name.Text),
                                                    Validation.Input.IsInMinRange(txt_name.TextLength, 2));
            byte lastnameErrorCode = Error.GetErrorCode(Validation.Input.IsNotEmptyNullOrWhiteSpace(txt_lastname.Text), Validation.Input.IsAlphabeticalOrWhiteSpace(txt_lastname.Text),
                                        Validation.Input.IsInMinRange(txt_lastname.TextLength, 2));
            byte dniErrorCode = Error.GetErrorCode(Validation.Input.IsNotEmptyNullOrWhiteSpace(txt_dni.Text), Validation.Input.IsANumber(txt_dni.Text, out int nroDni),
                                        Validation.Input.IsBetweenRange(txt_dni.Text, 1000000, 500000000));
            byte genderErrorCode = Error.GetErrorCode(Validation.Input.IsCmbSelected(cmb_gender));

        //Error Messages Generation
            string usertypeErrorMsg = Error.GetErrorMsg(usertypeErrorCode, "", Error.Msg.IsNotSelected());
            string usernameErrorMsg = Error.GetErrorMsg(usernameErrorCode, "", Error.Msg.IsMandatory, Error.Msg.IsAlphanum, Error.Msg.IsTooShort("4"), Error.Msg.IsTooLong("15"), Error.Msg.KeyExists("El nombre de usuario"));
            string pwdErrorMsg = Error.GetErrorMsg(pwdErrorCode, "", Error.Msg.IsMandatory, Error.Msg.IsAlphanum, Error.Msg.IsTooShort("4"), Error.Msg.IsTooLong("15"));
            string nameErrorMsg = Error.GetErrorMsg(nameErrorCode, "", Error.Msg.IsMandatory, Error.Msg.IsAlphaWhite, Error.Msg.IsTooShort("2"));
            string lastnameErrorMsg = Error.GetErrorMsg(lastnameErrorCode, "", Error.Msg.IsMandatory, Error.Msg.IsAlphaWhite, Error.Msg.IsTooShort("2"));
            string dniErrorMsg = Error.GetErrorMsg(dniErrorCode, "", Error.Msg.IsMandatory, Error.Msg.IsNaN, Error.Msg.IsOutOfRange("1M a 500M"));
            string genderErrorMsg = Error.GetErrorMsg(genderErrorCode, "", Error.Msg.IsNotSelected());

        //Error Check && Action Execution
            if (Error.IsErrorFree(usertypeErrorCode, usernameErrorCode, pwdErrorCode))
            {
                if(rdo_admin.Checked || (!rdo_admin.Checked && Error.IsErrorFree(nameErrorCode, lastnameErrorCode, dniErrorCode)))
                {
                    taskCompleted = true;
                    string username = txt_username.Text.ToLower();
                    string credencial = View.CastRdoToEPermiso(rdo_admin, rdo_profesor);
                    string name = txt_name.Text.ToTitle();
                    string lastname = txt_lastname.Text.ToTitle();
                    string genero = cmb_gender.Text;
                    
                    result = Controller.CrearUsuario(username, txt_pwd.Text, credencial, name, lastname, nroDni, genero);
                }
            }

            if (!taskCompleted)
            {
                View.ChangeLblText(lbl_errorUserType, usertypeErrorMsg);
                View.ChangeLblText(lbl_errorUsername, usernameErrorMsg);
                View.ChangeLblText(lbl_errorPassword, pwdErrorMsg);
                View.ChangeLblText(lbl_errorName, nameErrorMsg);
                View.ChangeLblText(lbl_errorLastname, lastnameErrorMsg);
                View.ChangeLblText(lbl_errorDni, dniErrorMsg);
                View.ChangeLblText(lbl_errorGender, genderErrorMsg);
            }

            return taskCompleted;
        }


        private void DisplayPersonFields(bool display)
        {
            View.ChangeLblText(lbl_errorUserType, "");
            View.ChangeLblVisibility(lbl_name, display);
            View.ChangeLblVisibility(lbl_lastname, display);
            View.ChangeLblVisibility(lbl_dni, display);
            View.ChangeLblVisibility(lbl_gender, display);
            View.ChangeLblVisibility(lbl_errorName, display);
            View.ChangeLblVisibility(lbl_errorLastname, display);
            View.ChangeLblVisibility(lbl_errorDni, display);
            View.ChangeLblVisibility(lbl_errorGender, display);
            View.ChangePnlVisibility(pnl_txtName, display);
            View.ChangePnlVisibility(pnl_txtLastname, display);
            View.ChangePnlVisibility(pnl_txtDni, display);
            View.ChangeCmbVisibility(cmb_gender, display);
        }
    }
}
