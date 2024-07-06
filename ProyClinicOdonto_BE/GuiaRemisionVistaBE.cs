using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyClinicOdonto_BE
{
   public class GuiaRemisionVistaBE
    {
        public string NumGuia { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaPartida { get; set; }
        public DateTime FechaLlegada { get; set; }
        public string Proveedor { get; set; }
        public string Ruc { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string IdDist { get; set; }
        public string NombreDistrito { get; set; }
        public string UdMedidaDescripcion { get; set; }
        public string Cantidad { get; set; }
    }
}
