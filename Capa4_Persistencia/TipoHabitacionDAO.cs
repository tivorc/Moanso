using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capa3_Dominio;

namespace Capa4_Persistencia
{
    public class TipoHabitacionDAO
    {
        private GestorDAOSQL gestorDAOSQL;
        public TipoHabitacionDAO(GestorDAOSQL gestorDAOSQL)
        {
            this.gestorDAOSQL = gestorDAOSQL;
        }
                
        public List<TipoHabitacion> listarTipoHabitacion()
        {
            List<TipoHabitacion> listaTipoHabitaciones = new List<TipoHabitacion>();
            TipoHabitacion tipoHabitacion;
            string sentenciaSQL = "SELECT id_tipo_habitacion, nombre, descripcion, precio FROM TipoHabitacion";
            try
            {
                SqlDataReader resultado = gestorDAOSQL.ejecutarConsulta(sentenciaSQL);
                while (resultado.Read())
                {
                    tipoHabitacion = crearObjetoTipoHabitacion(resultado);
                    listaTipoHabitaciones.Add(tipoHabitacion);
                }
                resultado.Close();
                return listaTipoHabitaciones;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private TipoHabitacion crearObjetoTipoHabitacion(SqlDataReader resultado)
        {
            TipoHabitacion tipoHabitacion;
            tipoHabitacion = new TipoHabitacion();
            tipoHabitacion.Id_tipo_habitacion = resultado.GetInt32(0);
            tipoHabitacion.Nombre = resultado.GetString(1);
            tipoHabitacion.Descripcion = resultado.GetString(2);
            tipoHabitacion.Precio = resultado.GetDouble(3);
            return tipoHabitacion;
        }
        
    }
}
