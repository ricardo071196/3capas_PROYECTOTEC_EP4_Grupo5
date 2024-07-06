using ProyClinicOdonto_ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyClinicOdonto_BL
{
  public class NombreEquipoBL
    {
        NombreEquipoADO objNombreEquipoADO = new NombreEquipoADO();
        public DataTable ListarNombreEquipo()
        {
            return objNombreEquipoADO.ListarNombreEquipo();
        }
    }
}
