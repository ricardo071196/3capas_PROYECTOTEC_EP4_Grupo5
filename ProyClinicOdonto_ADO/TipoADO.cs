using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyClinicOdonto_ADO
{
    public class TipoADO
    {

        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
    public DataTable ListarTipo()
    {
        DataSet dts = new DataSet();
        cnx.ConnectionString = MiConexion.GetCnx();
        cmd.Connection = cnx;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "usp_ListarTipo";
        try
        {

            cmd.Parameters.Clear();
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            ada.Fill(dts, "Tipo");
            return dts.Tables["Tipo"];
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message);
        }
    }
    }
}
