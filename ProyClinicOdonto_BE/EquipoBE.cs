using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyClinicOdonto_BE
{
    public class EquipoBE
    {
        // Definimos la entidad de negocio Producto, con todas las propiedades de acuerdo a la estructura 
        // de la tabla Tb_Producto
        public String idequipo { get; set; }
        public String Nombre { get; set; }
        public String Tipo { get; set; }
        public String Cantidad { get; set; }
        public String Descripcion { get; set; }
        public String Stock { get; set; }
        public String Observacion { get; set; }

        public String id_piso { get; set; }
        public bool Estado { get; set; }
        public String Usu_Registro{ get; set; }
        public DateTime Fec_Ult_Mod { get; set; }
        public DateTime Fec_registro { get; set; }
        public String Usu_Ult_Mod { get; set; }
        public String IdTipo { get; set; }
        public String Idlocal { get; set; }

        public String Ruc { get; set; }

        public String Proveedor { get; set; }

        public String Telefono { get; set; }


        public DateTime Fecha_partida { get; set; }


    }
}


