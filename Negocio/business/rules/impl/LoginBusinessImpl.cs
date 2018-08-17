using Persistencia.dao.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.business.rules.impl
{
   public class LoginBusinessImpl : LoginBusiness
    {
        public void autentication(string user, string pass)
        {
            UserDAO dao = new UserDAOImpl()            
        }
    }
}
