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
        private readonly int id;
        private static int NextId = 1;

        public Admin(string username, string password, EPermiso credencial)
            : base(username, password, credencial)
        {
            id = NextId;
            NextId++;
        }

        public override int GetUserId()
        {
            return id;
        }
    }
}
