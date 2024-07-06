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
    public class UsuarioAUXADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public UsuarioAUXBE ConsultarUsuario2(String strLogin)
        {
            UsuarioAUXBE objUsuarioAUXBE = new UsuarioAUXBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarUsuarioAux";
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
                    objUsuarioAUXBE.Login_Usuario = dtr["Login_Usuario"].ToString();
                    objUsuarioAUXBE.Pass_Usuario = dtr["Pass_Usuario"].ToString();
                    objUsuarioAUXBE.Estado = dtr["Estado"].ToString();
                    objUsuarioAUXBE.Fec_Registro = Convert.ToDateTime(dtr["Fec_Registro"]);
                    objUsuarioAUXBE.Usu_Registro = dtr["Usu_Registro"].ToString();

                }
                dtr.Close();
                return objUsuarioAUXBE;

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
