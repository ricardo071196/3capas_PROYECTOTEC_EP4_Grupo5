using ProyClinicOdonto_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyClinicOdonto_ADO
{
  public class UsuarioAdminADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public UsuarioAdminBE ConsultarUsuario4(String strLogin)
        {
            UsuarioAdminBE objUsuarioAdminBE = new UsuarioAdminBE();
        cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarUsuarioAdmin";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@Login_Usuario", strLogin);

                // Abrimos la conexion y ejecutamos...
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objUsuarioAdminBE.Login_Usuario = dtr["Login_Usuario"].ToString();
                    objUsuarioAdminBE.Pass_Usuario = dtr["Pass_Usuario"].ToString();
                    objUsuarioAdminBE.Niv_Usuario = Convert.ToInt16(dtr["Niv_Usuario"]);
                    objUsuarioAdminBE.Est_Usuario = Convert.ToInt16(dtr["Est_Usuario"]);
                    objUsuarioAdminBE.Fec_Registro = Convert.ToDateTime(dtr["Fec_Registro"]);
                    objUsuarioAdminBE.Usu_Registro = dtr["Usu_Registro"].ToString();

    }
    dtr.Close();
                return objUsuarioAdminBE;

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
    }
}

