using ProyClinicOdonto_ADO;
using ProyClinicOdonto_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyClinicOdonto_BL
{
    public class UsuarioAdminBL
    {
        UsuarioAdminADO objUsuarioAdminADD = new UsuarioAdminADO();

        public UsuarioAdminBE ConsultarUsuario4(String strLogin)
        {
            return objUsuarioAdminADD.ConsultarUsuario4(strLogin);
        }
    }
}
