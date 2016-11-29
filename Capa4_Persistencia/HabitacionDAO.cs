using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capa3_Dominio;

namespace Capa4_Persistencia
{
    public class HabitacionDAO
    {
        private GestorDAOSQL gestorDAOSQL;
        public HabitacionDAO(GestorDAOSQL gestorDAOSQL)
        {
            this.gestorDAOSQL = gestorDAOSQL;
        }

        public int guardarHabitacion(Habitacion habitacion)
        {
            int registros_afectados;
            String sentenciaSQL = "INSERT INTO Habitacion(numero, tipo_habitacion, precio, estado) VALUES(@numero, @tipo_habitacion, @precio, @estado)";
            try
            {
                SqlCommand comando = gestorDAOSQL.obtenerComandoSQL(sentenciaSQL);
                asignarParametrosHabitacion(habitacion, comando);
                registros_afectados = comando.ExecuteNonQuery();
                return registros_afectados;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Habitacion> listarHabitacionesDisponibles()
        {
            List<Habitacion> listaHabitacionesDisponibles = new List<Habitacion>();
            Habitacion habitacion;
            string sentenciaSQL = "SELECT id_habitacion, numero, tipo_habitacion, precio, estado FROM Habitacion WHERE estado = 'DISPONIBLE'";
            try
            {
                SqlDataReader resultado = gestorDAOSQL.ejecutarConsulta(sentenciaSQL);
                while (resultado.Read())
                {

                    habitacion = new Habitacion();
                    habitacion.Id_habitacion = resultado.GetInt32(0);
                    habitacion.Numero = resultado.GetString(1);
                    habitacion.Tipo_habitacion = resultado.GetString(2);
                    habitacion.Precio = resultado.GetDouble(3);
                    habitacion.Estado = resultado.GetString(4);
                    listaHabitacionesDisponibles.Add(habitacion);
                }
                resultado.Close();
                return listaHabitacionesDisponibles;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public List<Habitacion> listarHabitaciones()
        {
            List<Habitacion> listaHabitaciones = new List<Habitacion>();
            Habitacion habitacion;
            string sentenciaSQL = "SELECT numero, tipo_habitacion, precio, estado FROM Habitacion";
            try
            {
                SqlDataReader resultado = gestorDAOSQL.ejecutarConsulta(sentenciaSQL);
                while (resultado.Read())
                {
                    habitacion = new Habitacion();
                    habitacion.Numero = resultado.GetString(0);
                    habitacion.Tipo_habitacion = resultado.GetString(1);
                    habitacion.Precio = resultado.GetDouble(2);
                    habitacion.Estado = resultado.GetString(3);
                    listaHabitaciones.Add(habitacion);
                }
                resultado.Close();
                return listaHabitaciones;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public int modificarHabitacion(Habitacion habitacion)
        {
            int registros_afectados;
            string sentenciaSQL = "UPDATE Habitacion SET numero = @numero, tipo_habitacion = @tipo_habitacion, precio = @precio, estado = @estado";
            try
            {
                SqlCommand comando = gestorDAOSQL.obtenerComandoSQL(sentenciaSQL);
                asignarParametrosHabitacion(habitacion, comando);
                comando.Parameters.AddWithValue("@id_habitacion", habitacion.Id_habitacion);
                registros_afectados = comando.ExecuteNonQuery();
                return registros_afectados;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int eliminarHabitacion(Habitacion habitacion)
        {
            int registros_afectados;
            string sentenciaSQL = "DELETE FROM Habitacion WHERE id_habitacion = @id_habitacion";
            try
            {
                SqlCommand comando = gestorDAOSQL.obtenerComandoSQL(sentenciaSQL);
                comando.Parameters.AddWithValue("@id_habitacion", habitacion.Id_habitacion);
                registros_afectados = comando.ExecuteNonQuery();
                return registros_afectados;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void asignarParametrosHabitacion(Habitacion habitacion, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("@numero", habitacion.Numero);
            comando.Parameters.AddWithValue("@tipo_habitacion", habitacion.Tipo_habitacion);
            comando.Parameters.AddWithValue("@precio", habitacion.Precio);
            comando.Parameters.AddWithValue("@estado", habitacion.Estado);
        }
    }
}
