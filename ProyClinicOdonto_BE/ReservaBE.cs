using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyClinicOdonto_BE
{
    public class ReservaBE
    {

        public String idreserva { get; set; }
        public String detalle { get; set; }
        public DateTime diaCita { get; set; }
        public String HoraCita { get; set; }
        public String idpaciente{ get; set; }
        public String idodontologo { get; set; }

        public String id_consultorio { get; set; }
        public String Usu_Registro { get; set; }
        public String Usu_Ult_Mod { get; set; }
        public bool Estado { get; set; }
    }
}
