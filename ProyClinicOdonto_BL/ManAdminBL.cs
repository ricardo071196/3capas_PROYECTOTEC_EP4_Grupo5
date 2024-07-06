using ProyClinicOdonto_ADO;
using ProyClinicOdonto_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyClinicOdonto_BL
{
    public class ManAdminBL
    {
        ListaUsuariosADO objListaUsuariosADO = new ListaUsuariosADO();
        public DataTable ListarUsuario()
        {
            return objListaUsuariosADO.ListarUsuario();
        }
        public Boolean InsertarUsuario(ManAdminBE objManAdminBE)
        {
            return objListaUsuariosADO.InsertarUsuario(objManAdminBE);
        }


        public Boolean ActualizarUsuarioDatos(ManAdminBE objManAdminBE)
        {
            return objListaUsuariosADO.ActualizarUsuarioDatos(objManAdminBE);
        }

        public ManAdminBE ConsultarUsuarioDatos(String Login_Usuario)
        {
            return objListaUsuariosADO.ConsultarUsuarioDatos(Login_Usuario);
        }
    }
}
