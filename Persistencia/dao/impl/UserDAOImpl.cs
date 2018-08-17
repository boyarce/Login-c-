using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.dao.impl
{
    public class UserDAOImpl : UserDAO
    {
        public bool autentication(string user, string pass)
        {
            if ("admin".Equals(user) && "123456".Equals(pass))
            {
                return true;
            }
            else {
                return false
            }
        }
    }
}
