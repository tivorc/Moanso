using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capa3_Dominio;

namespace Capa4_Persistencia
{
    public class EmpleadoDAO
    {
        private GestorDAOSQL gestorDAOSQL;
        public EmpleadoDAO(GestorDAOSQL gestorDAOSQL)
        {
            this.gestorDAOSQL = gestorDAOSQL;
        }
    }
}
