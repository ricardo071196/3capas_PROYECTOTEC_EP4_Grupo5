using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyClinicOdonto_BE;
using ProyClinicOdonto_ADO;

namespace ProyClinicOdonto_ADO
{
    public class UsuarioADO
        //Instancias
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public UsuarioBE ConsultarUsuario(String strLogin)
        {
            UsuarioBE objUsuarioBE = new UsuarioBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarUsuarioRecep";
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
                    objUsuarioBE.Login_Usuario = dtr["Login_Usuario"].ToString();
                    objUsuarioBE.Pass_Usuario = dtr["Pass_Usuario"].ToString();
                    objUsuarioBE.Estado = dtr["Estado"].ToString();
                    objUsuarioBE.Fec_Registro = Convert.ToDateTime(dtr["Fec_Registro"]);
                    objUsuarioBE.Usu_Registro = dtr["Usu_Registro"].ToString();

                }
                dtr.Close();
                return objUsuarioBE;

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
