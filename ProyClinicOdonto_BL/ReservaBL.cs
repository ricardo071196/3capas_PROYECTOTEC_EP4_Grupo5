using ProyClinicOdonto_ADO;
using ProyClinicOdonto_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProyClinicOdonto_BL
{
    public class ReservaBL
    {
        ReservaADO objReservaADO = new ReservaADO();
        public DataTable ListarReserva()
        {
            return objReservaADO.ListarReserva();
        }

        public Boolean InsertarReserva(ReservaBE objReservaBE)
        {
            return objReservaADO.InsertarReserva(objReservaBE);
        }
        public ReservaBE ConsultarReserva(String Codigo)
        {
            return objReservaADO.ConsultarReserva(Codigo);
        }
        public Boolean ActualizarReserva(ReservaBE objReservaBE)
        {
            return objReservaADO.ActualizarReserva(objReservaBE);
        }
    }
}
