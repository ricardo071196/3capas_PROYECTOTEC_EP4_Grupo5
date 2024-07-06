using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyClinicOdonto_BE
{
    public class PacienteBE
    {
        public String idpaciente{ get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public String Genero { get; set; }
        public String email { get; set; }
        
        //public String direccion { get; set; }
        public String telefono{ get; set; }

        public String alergias { get; set; }

        public DateTime fechaInscripcion{ get; set; }
        public String usuRegistro { get; set; }
        
        //public bool Estado{ get; set; }

        public DateTime fec_Ult_mod { get; set; }
        public String usu_Ult_mod { get; set; }
      
        public String IdDist { get; set; }
    }
}
