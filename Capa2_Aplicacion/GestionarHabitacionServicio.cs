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
        public int guardarHabitacion(Habitacion habitacion)
        {
            try
            {
                int registros_afectados=0;
                gestorDAOSQL.abrirConexion();
                registros_afectados = habitacionDAO.guardarHabitacion(habitacion);
                gestorDAOSQL.cerrarConexion();
                return registros_afectados;
            }
            
            catch (Exception e)
            {

                throw e;
            }
            
        }
        public int modificarHabitacion(Habitacion habitacion)
        {
            try
            {
                int registros_afectados;
                gestorDAOSQL.abrirConexion();
                registros_afectados = habitacionDAO.modificarHabitacion(habitacion);
                gestorDAOSQL.cerrarConexion();
                return registros_afectados;
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public List<Habitacion> MostrarHabitacionesDisponibles()
        {
            try
            {
                gestorDAOSQL.abrirConexion();
                List<Habitacion> listarHabitacionesDisponibles = habitacionDAO.listarHabitacionesDisponibles();
                gestorDAOSQL.cerrarConexion();
                return listarHabitacionesDisponibles;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
    
}
