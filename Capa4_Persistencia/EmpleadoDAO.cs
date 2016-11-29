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
        public int guardarEmpleado(Empleado empleado)
        {
            int registro_afectados;
            string sentenciaSQL = "INSERT INTO EMPLEADO(numero_documento, nombre, apellidos, telefono, tipo_empleado, usuario, contraseña, tipo_documento) VALUES(@numero_documento, @nombre, @apellidos, @telefono, @tipo_empleado, @usuario, @contraseña, @tipo_documento)";
            try
            {
                SqlCommand comando = gestorDAOSQL.obtenerComandoSQL(sentenciaSQL);
                asignarParametros(empleado, comando);
                registro_afectados = comando.ExecuteNonQuery();
                return registro_afectados;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public int modificarEmpleado(Empleado empleado)
        {
            int registros_afectados;
            string sentenciaSQL = "UPDATE Empleado SET numero_documento = @numero_documento, nombre = @nombre, apellidos = @apellidos, telefono = @telefono, tipo_empleado = @tipo_empleado, usuario = @usuario, contraseña = @contraseña, tipo_documento = @tipo_documento WHERE id_cliente = @id_cliente";
            try
            {
                SqlCommand comando = gestorDAOSQL.obtenerComandoSQL(sentenciaSQL);
                asignarParametros(empleado, comando);
                comando.Parameters.AddWithValue("@id_cliente", empleado.Id_empleado);
                registros_afectados = comando.ExecuteNonQuery();
                return registros_afectados;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void asignarParametros(Empleado empleado, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("@numero_documento", empleado.Numero_documento);
            comando.Parameters.AddWithValue("@nombre", empleado.Nombre);
            comando.Parameters.AddWithValue("@apellidos", empleado.Apellidos);
            comando.Parameters.AddWithValue("@apellidos", empleado.Apellidos);
            comando.Parameters.AddWithValue("@apellidos", empleado.Telefono);
            comando.Parameters.AddWithValue("@apellidos", empleado.Tipo_empleado);
            comando.Parameters.AddWithValue("@apellidos", empleado.Nombre_usuario);
            comando.Parameters.AddWithValue("@apellidos", empleado.Contraseña);
            comando.Parameters.AddWithValue("@tipo_documento", empleado.Tipo_documento);
        }
    }
}
