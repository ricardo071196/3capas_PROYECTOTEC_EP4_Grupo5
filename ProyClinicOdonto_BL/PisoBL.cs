using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyClinicOdonto_ADO;

namespace ProyClinicOdonto_BL
{
  public class PisoBL
    {
        PisoADO objPisoADO = new PisoADO();

        public DataTable ListarPiso()
        {
            return objPisoADO.ListarPiso();
        }
    }
}
