using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyClinicOdonto_BE
{
    public class OdontologoBE
    {
        public String Idodontologo { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public String Genero { get; set; }
        public String email { get; set; }
        public String direccion { get; set; }
        public String telefono { get; set; }

        // public String  Idespecialidad { get; set; }

        public String COP { get; set; }

        public String usuRegistro { get; set; }

        

        public DateTime Fec_Ult_Mod { get; set; }
        public String usu_Ult_Mod { get; set; }
        public DateTime fechaCreacion { get; set; }

        public bool Estado { get; set; }
        public String IdDist { get; set; }

    }
}
