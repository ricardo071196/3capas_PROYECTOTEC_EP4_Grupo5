using ProyClinicOdonto_ADO;
using ProyClinicOdonto_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyClinicOdonto_BL
{
   public class UsuarioRHBL
    {
        UsuarioRHADO objUsuarioRHADD = new UsuarioRHADO();

        public UsuarioRHBE ConsultarUsuario3(String strLogin)
        {
            return objUsuarioRHADD.ConsultarUsuario3(strLogin);
        }
    }
}
