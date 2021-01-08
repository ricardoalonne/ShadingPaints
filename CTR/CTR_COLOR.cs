using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DAO;
using DTO_CM;

namespace CTR
{
    public class CTR_COLOR
    {
        DAO_COLOR objcolorDAO;
        public CTR_COLOR()
        {
            objcolorDAO = new DAO_COLOR();
        }
        public void Registrar(DTO_COLOR objcolor)
        {

            if (objcolor.T <= 0)
            {
                objcolor.error = 1; //cantidad invalidad!!
                return;
            }
            if (objcolor.COLOR.Length > 50)
            {
                objcolor.error = 2; //Color supero los 50 caracteres!!
                return;
            }
            if (objcolor.CI <= 0)
            {
                objcolor.error = 3; //cantidad invalidad!!
                return;
            }

            objcolor.error = 77;
            objcolorDAO.InsertarColor(objcolor);
        }
        public DataTable ListarSColores()//retorna una tabla con todas las solicitudes de Abastecimiento
        {
            return objcolorDAO.ListaColor();
        }
        public void ActualizarDetalleSP(DTO_COLOR objcolor)
        {
            if (objcolor.T <= 0)
            {
                objcolor.error = 1; //cantidad invalidad!!
                return;
            }
            if (objcolor.COLOR.Length > 50)
            {
                objcolor.error = 2; //Color supero los 50 caracteres!!
                return;
            }
            if (objcolor.CI <= 0)
            {
                objcolor.error = 3; //cantidad invalidad!!
                return;
            }
            objcolor.error = 88;
            objcolorDAO.GuardarCambiosTablaColor(objcolor);
        }
    }
}
