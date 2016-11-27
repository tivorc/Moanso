using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capa3_Dominio;

namespace Capa4_Presistencia
{
    class HabitacionDAO
    {
        public void guardar(Habitacion habitacion)
        {
            string cadenaConexion = "Data Source=(local); Initial Catalog=BDPrueba; Integrated Security=true";
            SqlConnection objetoconexion = new SqlConnection(cadenaConexion);
            objetoconexion.Open();
            string sentencia="insert into "
            
        }
    }
}
