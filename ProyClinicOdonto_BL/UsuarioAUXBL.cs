using ProyClinicOdonto_ADO;
using ProyClinicOdonto_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyClinicOdonto_BL
{


    public class UsuarioAUXBL
    {
        UsuarioAUXADO objUsuarioAUXADD= new UsuarioAUXADO();

            public UsuarioAUXBE ConsultarUsuario2(String strLogin)
            {
                return objUsuarioAUXADD.ConsultarUsuario2(strLogin);
            }
        }
}
