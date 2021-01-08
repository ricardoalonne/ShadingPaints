using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using DTO_CM;
namespace DAO
{
    public class DAO_COLOR
    {
        SqlConnection conexion;
        public DAO_COLOR()
        {
            conexion = new SqlConnection(ConexionBD.CadenaConexion);
        }

        public void InsertarColor(DTO_COLOR objcolor)
        {
            SqlCommand cmd = new SqlCommand("SP_Insert_Color", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@COLOR", objcolor.COLOR);
            cmd.Parameters.AddWithValue("@T", objcolor.T);
            cmd.Parameters.AddWithValue("@CI", objcolor.CI);
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public DataTable ListaColor()
        {
            DataTable dt = null;
            conexion.Open();
            SqlCommand command = new SqlCommand("select * from T_COLOR", conexion);
            SqlDataAdapter daAdaptador = new SqlDataAdapter(command);
            dt = new DataTable();
            daAdaptador.Fill(dt);
            conexion.Close();
            return dt;
        }
        public void GuardarCambiosTablaColor(DTO_COLOR objcolordto)
        {
            string update = "UPDATE T_COLOR SET COLOR='" + objcolordto.COLOR + "', T='"+ objcolordto.T+ "', CI='"+ objcolordto.CI+ "' WHERE ID_COLOR='" + objcolordto.ID_COLOR + "'";
            SqlCommand command = new SqlCommand(update, conexion);
            conexion.Open();
            command.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
