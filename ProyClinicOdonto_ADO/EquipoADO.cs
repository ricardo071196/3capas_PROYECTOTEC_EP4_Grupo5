using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProyClinicOdonto_ADO;
using System.Data;
using ProyClinicOdonto_BE;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace ProyClinicOdonto_ADO
{
    public class EquipoADO
    {
        // Insumos.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        

        //METODO DE MANTENIMIENTO

        public DataTable ListarEquipo()
        {
            try
            {

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarEquipoPrueba2";
                cmd.Parameters.Clear();

                //Codifique
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();
                ada.Fill(dts, "Equipo");

                return dts.Tables["Equipo"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }


        public Boolean InsertarEquipo(EquipoBE objEquipoBE)
        {

            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarEquipo2";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", objEquipoBE.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", objEquipoBE.Descripcion);
                cmd.Parameters.AddWithValue("@Estado", objEquipoBE.Estado);
                cmd.Parameters.AddWithValue("@Idtipo", objEquipoBE.IdTipo);
                cmd.Parameters.AddWithValue("@id_piso", objEquipoBE.id_piso);
                // cmd.Parameters.AddWithValue("@Idlocal", objEquipoBE.Idlocal);
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

        public EquipoBE ConsultarEquipo(String Codigo)
        {

            EquipoBE objEquipoBE = new EquipoBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarEquipo";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@idequipo", Codigo);

                // Abrimos la conexion y ejecutamos...
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();

                    objEquipoBE.idequipo = dtr["idequipo"].ToString();
                    objEquipoBE.Nombre = dtr["Nombre"].ToString();
                    objEquipoBE.Cantidad = dtr["Cantidad"].ToString();
                    objEquipoBE.Descripcion = dtr["Descripcion"].ToString();
                    //objEquipoBE.Idlocal= dtr["Idlocal"].ToString();
                    objEquipoBE.IdTipo = dtr["IdTipo"].ToString();
                    objEquipoBE.Estado = Convert.ToBoolean(dtr["Estado"]);
                    objEquipoBE.id_piso = dtr["id_piso"].ToString();
                    objEquipoBE.Observacion = dtr["Observacion"].ToString();
                    objEquipoBE.Stock = dtr["Stock"].ToString();
                }
                dtr.Close();
                return objEquipoBE;

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


        public Boolean ActualizarEquipo(EquipoBE objEquipoBE)
        {

            //Codifique
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ActualizarEquipo";
            cmd.Parameters.Clear();
            try
            {
                cmd.Parameters.AddWithValue("@idequipo", objEquipoBE.idequipo);
                cmd.Parameters.AddWithValue("@Nombre", objEquipoBE.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", objEquipoBE.Descripcion);
                cmd.Parameters.AddWithValue("@Estado", objEquipoBE.Estado);
                cmd.Parameters.AddWithValue("@id_piso", objEquipoBE.id_piso);
                cmd.Parameters.AddWithValue("@Observacion", objEquipoBE.Observacion);
                cmd.Parameters.AddWithValue("@Stock", objEquipoBE.Stock);
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

