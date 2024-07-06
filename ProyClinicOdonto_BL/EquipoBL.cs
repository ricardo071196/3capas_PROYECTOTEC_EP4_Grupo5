using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ProyClinicOdonto_ADO;
using ProyClinicOdonto_BE;

namespace ProyClinicOdonto_BL
{
    public class EquipoBL
    {
        EquipoADO objEquipoADO = new EquipoADO();



        public DataTable ListarEquipo()
        {
            return objEquipoADO.ListarEquipo();
        }
        public Boolean InsertarEquipo(EquipoBE objEquipoBE)
        {
            return objEquipoADO.InsertarEquipo(objEquipoBE);
        }

        public Boolean ActualizarEquipo(EquipoBE objEquipoBE)
        {
            return objEquipoADO.ActualizarEquipo(objEquipoBE);
        }

        public EquipoBE ConsultarEquipo(String Codigo)
        {
            return objEquipoADO.ConsultarEquipo(Codigo);
        }
    }
    

}


