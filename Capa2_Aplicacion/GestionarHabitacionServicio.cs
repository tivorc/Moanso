using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa3_Dominio;
using Capa4_Persistencia;


namespace Capa2_Aplicacion
{
    public class GestionarHabitacionServicio
    {
        private GestorDAOSQL gestorDAOSQL;
        private TipoHabitacionDAO tipoHabitacionDAO;

        public GestionarHabitacionServicio()
        {
            gestorDAOSQL = new GestorDAOSQL();
            tipoHabitacionDAO = new TipoHabitacionDAO(gestorDAOSQL);
        }
        
    }
    
}
