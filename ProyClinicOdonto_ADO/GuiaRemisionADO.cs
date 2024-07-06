using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyClinicOdonto_BE;

namespace ProyClinicOdonto_ADO
{
    public class GuiaRemisionADO
    {
        // Insumos.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarGuia()
        {
            try
            {

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarGuiaRemsion";
                cmd.Parameters.Clear();

                //Codifique
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();
                ada.Fill(dts, "GuiadeRemision");

                return dts.Tables["GuiadeRemision"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }

        }

        public Boolean InsertarGuia(GuiaRemisionBE objGuiaRemisionBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarGuiaRemisiones";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@descripcion", objGuiaRemisionBE.descripcion);
                cmd.Parameters.AddWithValue("@fecha_emision", objGuiaRemisionBE.FechaEmision);
                cmd.Parameters.AddWithValue("@fecha_partida", objGuiaRemisionBE.FechaPartida);
                cmd.Parameters.AddWithValue("@fecha_llegada", objGuiaRemisionBE.FechaLlegada);
                cmd.Parameters.AddWithValue("@proveedor", objGuiaRemisionBE.Proveedor);
                cmd.Parameters.AddWithValue("@ruc", objGuiaRemisionBE.Ruc);
                cmd.Parameters.AddWithValue("@telefono", objGuiaRemisionBE.Telefono);
                cmd.Parameters.AddWithValue("@direccion", objGuiaRemisionBE.Direccion);
                cmd.Parameters.AddWithValue("@IdDist", objGuiaRemisionBE.IdDist);
                cmd.Parameters.AddWithValue("@udmedida_descripcion", objGuiaRemisionBE.UdMedidaDescripcion);
                cmd.Parameters.AddWithValue("@cantidad", objGuiaRemisionBE.Cantidad);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }
    }
}
