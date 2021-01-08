using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class ConexionBD
    {
        public static string CadenaConexion
        {
            get
            {

                return "Data Source=(Local); Initial Catalog = PINTURAS; Integrated Security = True";

            }
        }
    }
}
