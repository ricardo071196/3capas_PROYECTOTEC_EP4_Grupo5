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
    public class OdontologoADO
    {

        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        



        public DataTable ListarOdontologos()
        {
            try
            {

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarOdontologos2Prueba";
                cmd.Parameters.Clear();

                //Codifique
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();
                ada.Fill(dts, "Odontologo");

                return dts.Tables["Odontologo"];

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

        public DataTable ListarOdontologosActivos()
        {
            try
            {

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "listarOdontologosActivos";
                cmd.Parameters.Clear();

                //Codifique
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();
                ada.Fill(dts, "Odontologo");

                return dts.Tables["Odontologo"];

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

        public Boolean InsertarOdontologos(OdontologoBE objOdontologoBE)
        {

            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarOdontologo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombres", objOdontologoBE.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", objOdontologoBE.Apellidos);
                cmd.Parameters.AddWithValue("@Genero", objOdontologoBE.Genero);
                cmd.Parameters.AddWithValue("@email", objOdontologoBE.email);
                cmd.Parameters.AddWithValue("@direccion", objOdontologoBE.direccion);
                cmd.Parameters.AddWithValue("@telefono", objOdontologoBE.telefono);
                cmd.Parameters.AddWithValue("@COP", objOdontologoBE.COP);
                cmd.Parameters.AddWithValue("@fechaCreacion", objOdontologoBE.fechaCreacion);
                cmd.Parameters.AddWithValue("@Estado", objOdontologoBE.Estado);
                cmd.Parameters.AddWithValue("@IdDist", objOdontologoBE.IdDist);
                
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
        public OdontologoBE ConsultarOdontologos(String Codigo)
        {

            OdontologoBE objodontologoBE = new OdontologoBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarOdontologo2Prueba";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@Idodontologo", Codigo);

                // Abrimos la conexion y ejecutamos...
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();

                    objodontologoBE.Idodontologo = dtr["Idodontologo"].ToString();
                    objodontologoBE.Nombres = dtr["Nombres"].ToString();
                    objodontologoBE.Apellidos = dtr["Apellidos"].ToString();
                    objodontologoBE.Genero = dtr["Genero"].ToString();
                    objodontologoBE.direccion = dtr["direccion"].ToString();
                    objodontologoBE.COP = dtr["COP"].ToString();
                    objodontologoBE.email = dtr["email"].ToString();
                    objodontologoBE.telefono = dtr["telefono"].ToString();
                    objodontologoBE.IdDist = dtr["IdDist"].ToString();
                    objodontologoBE.Estado = Convert.ToBoolean(dtr["Estado"]);



                }
                dtr.Close();
                return objodontologoBE;

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
        public Boolean ActualizarOdontologos(OdontologoBE objOdontologoBE)
        {

            //Codifique
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ActualizarOdontologoPrueba";
            cmd.Parameters.Clear();
            try
            {
                cmd.Parameters.AddWithValue("@Idodontologo", objOdontologoBE.Idodontologo);
                cmd.Parameters.AddWithValue("@Nombres", objOdontologoBE.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", objOdontologoBE.Apellidos);
                cmd.Parameters.AddWithValue("@Genero", objOdontologoBE.Genero);
                cmd.Parameters.AddWithValue("@email", objOdontologoBE.email);
                cmd.Parameters.AddWithValue("@direccion", objOdontologoBE.direccion);
                cmd.Parameters.AddWithValue("@Iddist", objOdontologoBE.IdDist);
                cmd.Parameters.AddWithValue("@telefono", objOdontologoBE.telefono);
                cmd.Parameters.AddWithValue("@Estado", objOdontologoBE.Estado);
                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
               
            }
             

            }




        }

    }






