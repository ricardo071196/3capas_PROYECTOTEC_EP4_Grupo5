using ProyClinicOdonto_ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ProyClinicOdonto_BE;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.CompilerServices.RuntimeHelpers;


namespace ProyClinicOdonto_ADO
{
    public class PacienteADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;


        public DataTable ListarPacientes()
        {
            try
            {

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarPaciente";
                cmd.Parameters.Clear();

                //Codifique
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();
                ada.Fill(dts, "Paciente");

                return dts.Tables["Paciente"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Boolean InsertarPacientes(PacienteBE objPacienteBE)
        {

            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarPaciente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idpaciente", objPacienteBE.idpaciente);
                cmd.Parameters.AddWithValue("@Nombres", objPacienteBE.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", objPacienteBE.Apellidos);
                cmd.Parameters.AddWithValue("@Genero", objPacienteBE.Genero);
                cmd.Parameters.AddWithValue("@email", objPacienteBE.email);
                //cmd.Parameters.AddWithValue("@direccion", objPacienteBE.direccion);
                cmd.Parameters.AddWithValue("@telefono", objPacienteBE.telefono);
                cmd.Parameters.AddWithValue("@alergias", objPacienteBE.alergias);
                cmd.Parameters.AddWithValue("@fechaInscripcion", objPacienteBE.fechaInscripcion);
                //cmd.Parameters.AddWithValue("@Estado", objPacienteBE.Estado);
                cmd.Parameters.AddWithValue("@IdDist", objPacienteBE.IdDist);


                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }

        }


        public PacienteBE ConsultarPacientes(String Codigo)
        {

            PacienteBE objPacienteBE = new PacienteBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarPacientePrueba";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@idpaciente", Codigo);

                // Abrimos la conexion y ejecutamos...
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objPacienteBE.idpaciente = dtr["idpaciente"].ToString();
                    objPacienteBE.Nombres = dtr["Nombres"].ToString();
                    objPacienteBE.Apellidos = dtr["Apellidos"].ToString();
                    objPacienteBE.Genero = dtr["Genero"].ToString();
                    objPacienteBE.email = dtr["email"].ToString();
                    //objPacienteBE.direccion = dtr["direccion"].ToString();
                    objPacienteBE.IdDist = dtr["IdDist"].ToString();
                    objPacienteBE.telefono = dtr["telefono"].ToString();
                    objPacienteBE.alergias = dtr["alergias"].ToString();
                }
                dtr.Close();
                return objPacienteBE;

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




        public Boolean ActualizarPaciente(PacienteBE objPacienteBE)
        {

            //Codifique
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ActualizarPacientePrueba";
            cmd.Parameters.Clear();
            try
            {
                cmd.Parameters.AddWithValue("@idpaciente", objPacienteBE.idpaciente);
                cmd.Parameters.AddWithValue("@Nombres", objPacienteBE.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", objPacienteBE.Apellidos);
                cmd.Parameters.AddWithValue("@Genero ", objPacienteBE.Genero);
                cmd.Parameters.AddWithValue("@email", objPacienteBE.email);
                //cmd.Parameters.AddWithValue("@direccion", objPacienteBE.direccion);
                cmd.Parameters.AddWithValue("@Iddist", objPacienteBE.IdDist);
                cmd.Parameters.AddWithValue("@telefono", objPacienteBE.telefono);
                cmd.Parameters.AddWithValue("@alergias", objPacienteBE.alergias);
                //cmd.Parameters.AddWithValue("@Estado", objPacienteBE.Estado);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }
        public Boolean EliminarPaciente(String Codigo)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarPaciente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("idpaciente", Codigo);
                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if(cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }

        }



    }
}


    
