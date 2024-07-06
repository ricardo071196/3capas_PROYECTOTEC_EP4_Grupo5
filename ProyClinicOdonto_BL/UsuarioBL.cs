using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyClinicOdonto_BE;
using ProyClinicOdonto_ADO;

namespace ProyClinicOdonto_BL
{
    public class UsuarioBL
    {
        UsuarioADO objUsuarioADD = new UsuarioADO();

        public UsuarioBE ConsultarUsuario(String strLogin)
        {
            return objUsuarioADD.ConsultarUsuario(strLogin);
        }
    }
}
