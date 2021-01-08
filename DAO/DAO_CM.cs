using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_CM
    {
        SqlConnection conexion;


        public DAO_CM()
        {
            conexion = new SqlConnection(ConexionBD.CadenaConexion);
        }

        public DataTable SelectDemandaXColorYMes()
        {
            try
            {
                conexion.Open();
                DataTable dtable = new DataTable();
                SqlCommand cmd = new SqlCommand("SP_SelectDemandaXColorYMes", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtable);
                conexion.Close();
                return dtable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable SelectBanderaXColorYMes()
        {
            try
            {
                conexion.Open();
                DataTable dtable = new DataTable();
                SqlCommand cmd = new SqlCommand("SP_SelectBanderaXColorYMes", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtable);
                conexion.Close();
                return dtable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable SelectInventarioXColorYMes()
        {
            try
            {
                conexion.Open();
                DataTable dtable = new DataTable();
                SqlCommand cmd = new SqlCommand("SP_SelectInventarioXColorYMes", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtable);
                conexion.Close();
                return dtable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable SelectProduccionXColorYMes()
        {
            try
            {
                conexion.Open();
                DataTable dtable = new DataTable();
                SqlCommand cmd = new SqlCommand("SP_SelectProduccionXColorYMes", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtable);
                conexion.Close();
                return dtable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Insert_Color(DTO_COLOR objDTOColor)
        {
            conexion.Open();         
            SqlCommand cmd = new SqlCommand("SP_Insert_Color", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@COLOR", objDTOColor.ID_COLOR));
            cmd.Parameters.Add(new SqlParameter("@T", objDTOColor.T));
            cmd.Parameters.Add(new SqlParameter("@CI", objDTOColor.CI));
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
