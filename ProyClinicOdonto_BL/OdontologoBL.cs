using ProyClinicOdonto_ADO;
using ProyClinicOdonto_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProyClinicOdonto_BL
{
    public class OdontologoBL
    {
        OdontologoADO objOdontologoADO = new OdontologoADO();
        public DataTable ListarOdontologos()
        {
            return objOdontologoADO.ListarOdontologos();
        }
        public DataTable ListarOdontologosActivos()
        {
            return objOdontologoADO.ListarOdontologosActivos();
        }

        public Boolean InsertarOdontologos(OdontologoBE objOdontologoBE)
        {
            return objOdontologoADO.InsertarOdontologos(objOdontologoBE);
        }
        public Boolean ActualizarOdontologos(OdontologoBE objOdontologoBE)
        {
            return objOdontologoADO.ActualizarOdontologos(objOdontologoBE);
        }

        public OdontologoBE ConsultarOdontologos(String Codigo)
        {
            return objOdontologoADO.ConsultarOdontologos(Codigo);
        }


    }
}

