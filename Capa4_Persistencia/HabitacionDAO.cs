using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capa3_Dominio;

namespace Capa4_Persistencia
{
    class HabitacionDAO
    {
        private GestorDAOSQL gestorDAOSQL;
        public HabitacionDAO(GestorDAOSQL gestorDAOSQL)
        {
            this.gestorDAOSQL = gestorDAOSQL;
        }

        public int guardarHabitacion(Habitacion habitacion)
        {
            int registros_afectados;
            String sentenciaSQL = "INSERT INTO Habitacion(numero, piso, estado, id_tipo_habitacion) VALUES(@numero, @piso, @estado, @id_tipo_habitacion)";
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
            TipoHabitacion tipoHabitacion;
            string sentenciaSQL = "SELECT h.id_habitacion, h.numero, h.piso, h.estado, t.nombre, t.precio FROM Habitacion h inner join TipoHabitacion t on h.id_tipo_habitacion = t.id_tipo_habitacion WHERE h.estado = 'D'";
            try
            {
                SqlDataReader resultado = gestorDAOSQL.ejecutarConsulta(sentenciaSQL);
                while (resultado.Read())
                {

                    habitacion = new Habitacion();
                    tipoHabitacion = new TipoHabitacion();
                    habitacion.Id_habitacion = resultado.GetInt32(0);
                    habitacion.Numero = resultado.GetString(1);
                    habitacion.Piso = resultado.GetString(2);
                    habitacion.Estado = resultado.GetString(3);
                    tipoHabitacion.Nombre = resultado.GetString(4);
                    tipoHabitacion.Precio = resultado.GetDouble(5);
                    habitacion.Tipo_habitacion = tipoHabitacion;
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

        public int modificarHabitacion(Habitacion habitacion)
        {
            int registros_afectados;
            string sentenciaSQL = "UPDATE Habitacion SET nombre = @nombre, numero = @numero, piso = @piso, id_tipo_habitacion = @id_tipo_habitacion";
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
            comando.Parameters.AddWithValue("@piso", habitacion.Piso);
            comando.Parameters.AddWithValue("@estado", habitacion.Estado);
            comando.Parameters.AddWithValue("@id_tipo_habitacion", habitacion.Tipo_habitacion.Id_tipo_habitacion);
        }
    }
}
