using ProyClinicOdonto_ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyClinicOdonto_BL
{
    public class OdontologosListaBL
    {
       OdontologosListaADO objCategoriaADO = new OdontologosListaADO();

        public DataTable OdontologosLista()
        {
            return objCategoriaADO.OdontologosLista();
        }
    }
}
