using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyClinicOdonto_ADO;
namespace ProyClinicOdonto_BL
{
    public class EspecialidadBL
    {
        EspecialidadADO objCategoriaADO = new EspecialidadADO();

        public DataTable ListarEspecialidad()
        {
            return objCategoriaADO.ListarEspecialidad();
        }
    }
}
