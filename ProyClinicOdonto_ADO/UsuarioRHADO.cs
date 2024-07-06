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
    public class UsuarioRHADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        public UsuarioRHBE ConsultarUsuario3(String strLogin)
        {
            UsuarioRHBE objUsuarioRHBE = new UsuarioRHBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarUsuarioRH";
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
                    objUsuarioRHBE.Login_Usuario = dtr["Login_Usuario"].ToString();
                    objUsuarioRHBE.Pass_Usuario = dtr["Pass_Usuario"].ToString();
                    objUsuarioRHBE.Estado = dtr["Estado"].ToString();
                    objUsuarioRHBE.Fec_Registro = Convert.ToDateTime(dtr["Fec_Registro"]);
                    objUsuarioRHBE.Usu_Registro = dtr["Usu_Registro"].ToString();

                }
                dtr.Close();
                return objUsuarioRHBE;

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