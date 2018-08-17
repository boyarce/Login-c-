using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.business.rules
{
    public interface LoginBusiness
    {
        /// <summary>
        /// metodo encargado de verificar y autenticar
        /// </summary>
        /// <param name="user">nombre del usuario</param>
        /// <param name="pass">password del usuario</param>
        void autentication(string user, string pass);
    }
}
