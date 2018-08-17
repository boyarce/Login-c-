using Negocio.business.exception;
using Negocio.business.rules.generic;
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
            EmptyRule empty = new EmptyRule();
            empty.isEmpty("USER", user);
            empty.isEmpty("PASS", pass);
            UserDAO dao = new UserDAOImpl();
            if(!dao.autentication(user, pass)){
                throw new BusinessException(
                    "USUARIO O CONTRASEÑA INVALIDO");
            }
        }
    }
}
