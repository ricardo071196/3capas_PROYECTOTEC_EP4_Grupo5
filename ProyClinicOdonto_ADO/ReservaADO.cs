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
    public class ReservaADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;



        public DataTable ListarReserva()
        {
            try
            {

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarReservas2";
                cmd.Parameters.Clear();

                //Codifique
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();
                ada.Fill(dts, "Detalle_Reserva");

                return dts.Tables["Detalle_Reserva"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public Boolean InsertarReserva(ReservaBE objReservaBE)
        {

            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarReserva3";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@detalle", objReservaBE.detalle);
                cmd.Parameters.AddWithValue("@diacita", objReservaBE.diaCita);
                cmd.Parameters.AddWithValue("@horacita", objReservaBE.HoraCita);
                cmd.Parameters.AddWithValue("@idpaciente", objReservaBE.idpaciente);
                cmd.Parameters.AddWithValue("@Idodontologo", objReservaBE.idodontologo);
                cmd.Parameters.AddWithValue("@id_consultorio", objReservaBE.id_consultorio);
                cmd.Parameters.AddWithValue("@Estado", objReservaBE.Estado);


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









        public ReservaBE ConsultarReserva(String Codigo)
        {

            ReservaBE objReservaBE = new ReservaBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarReservaPrueba2";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@idreserva", Codigo);

                // Abrimos la conexion y ejecutamos...
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objReservaBE.idreserva = dtr["idreserva"].ToString();
                    objReservaBE.idpaciente = dtr["idpaciente"].ToString();
                    objReservaBE.detalle = dtr["detalle"].ToString();
                    objReservaBE.diaCita = Convert.ToDateTime(dtr["diaCita"]);
                    objReservaBE.HoraCita = dtr["HoraCita"].ToString();
                    objReservaBE.idodontologo = dtr["idodontologo"].ToString();
                    objReservaBE.id_consultorio = dtr["id_consultorio"].ToString();
                    objReservaBE.Estado = Convert.ToBoolean(dtr["Estado"]);
                }
                dtr.Close();
                return objReservaBE;

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



        public Boolean ActualizarReserva (ReservaBE objReservaBE)
        {

            //Codifique
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ActualizarReservaPruebaNuevo2";
            cmd.Parameters.Clear();
            try
            {
                cmd.Parameters.AddWithValue("@idreserva", objReservaBE.idreserva);
                cmd.Parameters.AddWithValue("@detalle", objReservaBE.detalle);
                cmd.Parameters.AddWithValue("@diaCita", objReservaBE.diaCita);
                cmd.Parameters.AddWithValue("@HoraCita", objReservaBE.HoraCita);
                cmd.Parameters.AddWithValue("@idodontologo", objReservaBE.idodontologo);
                cmd.Parameters.AddWithValue("@id_consultorio", objReservaBE.id_consultorio);
                cmd.Parameters.AddWithValue("@Estado", objReservaBE.Estado);
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




