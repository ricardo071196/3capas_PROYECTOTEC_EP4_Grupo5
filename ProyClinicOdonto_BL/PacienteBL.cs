using ProyClinicOdonto_ADO;
using ProyClinicOdonto_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace ProyClinicOdonto_BL
{
    public class PacienteBL
    {
        PacienteADO objPacienteADO = new PacienteADO();
        public DataTable ListarPacientes()
        {
            return objPacienteADO.ListarPacientes();
        }
        public Boolean InsertarPacientes(PacienteBE objPacienteBE)
        {
            return objPacienteADO.InsertarPacientes(objPacienteBE);
        }

        public PacienteBE ConsultarPacientes(String Codigo)
        {
            return objPacienteADO.ConsultarPacientes(Codigo);
        }
        public Boolean ActualizarPaciente(PacienteBE objPacienteBE)
        {
            return objPacienteADO.ActualizarPaciente(objPacienteBE);
        }

        public Boolean EliminarPaciente(String Codigo)
        {
            return objPacienteADO.EliminarPaciente(Codigo);
        }

    }
}
