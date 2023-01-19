using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Enums;

namespace Model
{
    public class Admin : Usuario
    {
        public Admin(string id, string username, string password, EPermiso credencial)
        : base(id, username, password, credencial)
        {
        }

        public override int GetUserId()
        {
            return this.Id;
        }
    }
}
