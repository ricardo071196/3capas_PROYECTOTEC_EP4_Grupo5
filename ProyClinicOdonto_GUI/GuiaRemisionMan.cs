using ProyClinicOdonto_BE;
using ProyClinicOdonto_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyClinicOdonto_GUI
{
    public partial class GuiaRemisionMan : Form
    {
        GuiaRemisionBL objGuiaRemisionBL = new GuiaRemisionBL();
        GuiaRemisionBE objGuiaRemisionBE = new GuiaRemisionBE();
        DistritoBL objDistritoBL = new DistritoBL();
        public GuiaRemisionMan()
        {
            InitializeComponent();
        }

        private void cboDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpDatos_Enter(object sender, EventArgs e)
        {

        }

        private void GuiaRemisionMan_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = objDistritoBL.ListarDistrito();
                DataRow dr;
                dr = dt.NewRow();
                dr["IdDist"] = 0;
                dr["Nombre"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboDistrito.DataSource = dt;
                cboDistrito.DisplayMember = "Nombre";
                cboDistrito.ValueMember = "IdDist";
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaEmision = dtpFecEmi.Value;
                DateTime fechaPartida = dtpFecPart.Value;
                DateTime fechaLlegada = dtpFecLlega.Value;


                //Codifique

                //Cargamos la entidad de negocio
                objGuiaRemisionBE.descripcion = txtDescripcion.Text;
                objGuiaRemisionBE.FechaEmision = fechaEmision;
                objGuiaRemisionBE.FechaPartida = fechaPartida;
                objGuiaRemisionBE.FechaLlegada = fechaLlegada;
                objGuiaRemisionBE.Proveedor = txtProveedor.Text;
                objGuiaRemisionBE.Ruc = mskRUC.Text;
                objGuiaRemisionBE.Telefono = mskTelefono.Text;
                objGuiaRemisionBE.Direccion = txtDireccion.Text;
                objGuiaRemisionBE.IdDist = cboDistrito.SelectedValue.ToString();
                objGuiaRemisionBE.UdMedidaDescripcion = txtUMedida.Text;
                objGuiaRemisionBE.Cantidad = mskCantidad.Text;
                if (objGuiaRemisionBL.InsertarGuia(objGuiaRemisionBE) == true)
                {
                    this.Close();
                }
                else
                {

                    throw new Exception("Disculpa la molestia, trabajaremos para mejorar nuestro sistema.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
