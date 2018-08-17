using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.dao.impl
{
    public interface UserDAO
    {
        bool autentication(String user, String pass);
    }
}
