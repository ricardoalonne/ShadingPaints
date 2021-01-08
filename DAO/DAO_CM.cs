using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

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
    }
}
