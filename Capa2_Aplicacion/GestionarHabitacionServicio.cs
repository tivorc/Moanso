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
        private HabitacionDAO habitacionDAO;

        public GestionarHabitacionServicio()
        {
            gestorDAOSQL = new GestorDAOSQL();
            tipoHabitacionDAO = new TipoHabitacionDAO(gestorDAOSQL);
            habitacionDAO = new HabitacionDAO(gestorDAOSQL);
        }
        public int guardarHabitacion(TipoHabitacion tipoHabitacion)
        {
            int registros_afectados;
            gestorDAOSQL.abrirConexion();
            Habitacion habitacion = new Habitacion();
            habitacion.Tipo_habitacion = tipoHabitacion;
            registros_afectados = habitacionDAO.guardarHabitacion(habitacion);
            return registros_afectados;
        }
        
    }
    
}
