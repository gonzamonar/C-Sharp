using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Enums;

namespace Model
{
    public abstract class Usuario
    {
        private int id;
        private string username;
        private string password;
        protected EPermiso credencial;

        public int Id { get { return id; } set { id = value; } }
        public string Username { get { return username; } }
        public EPermiso Credencial { get { return credencial; } }


        public Usuario(string id, string username, string password, EPermiso credencial)
        {
            int.TryParse(id, out this.id);
            this.username = username;
            this.password = password;
            this.credencial = credencial;
        }

        public Usuario(string username, string password, EPermiso credencial)
        {
            this.username = username;
            this.password = password;
            this.credencial = credencial;
        }

        public int ChangePassword(string newPassword, string password)
        {
            if (CheckPassword(password))
            {
                this.password = newPassword;
            }
            return 1;
        }

        public bool CheckPassword(string password)
        {
            bool isCorrectPwd = false;
            if (password == this.password)
            {
                isCorrectPwd = true;
            }

            return isCorrectPwd;
        }

        public int ChangeUsername(string newUsername, string password)
        {
            if (CheckPassword(password))
            {
                username = newUsername;
            }
            return 1;
        }

        virtual public string GetUserInfo()
        {
            return username;
        }

        abstract public int GetUserId();
    }
}

