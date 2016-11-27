using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capa3_Dominio;

namespace Capa4_Persistencia
{
    public class ClienteDAO
    {
        private GestorDAOSQL gestorDAOSQL;
        public ClienteDAO(GestorDAOSQL gestorDAOSQL)
        {
            this.gestorDAOSQL = gestorDAOSQL;
        }

        public int guardarCliente(Cliente cliente)
        {
            int registro_afectados;
            string sentenciaSQL = "INSERT INTO Cliente(numero_documento, nombre, apellido_paterno, apellido_materno, direccion, " +
                "telefono, tipo_cliente, ruc, razon_social, id_tipo_documento) VALUES(@numero_documento, @nombre, @apellido_paterno, " +
                "@direccion, @telefono, @tipo_cliente, @ruc, @razon_social, @id_tipo_documento)";
            try
            {
                SqlCommand comando = gestorDAOSQL.obtenerComandoSQL(sentenciaSQL);
                asignarParametros(cliente, comando);
                registro_afectados = comando.ExecuteNonQuery();
                return registro_afectados;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public int modificarCliente(Cliente cliente)
        {
            int registros_afectados;
            string sentenciaSQL = "UPDATE Cliente SET numero_documento = @numero_documento, nombre = @nombre, apellido_paterno = @apellido_paterno, apellido_materno = @apellido_materno, direccion = @direccion, " + 
                "telefono = @telefono, tipo_cliente = @tipo_cliente, ruc = @ruc, razon_social = @razon_social, id_documento = @id_documento WHERE id_cliente = @id_cliente";
            try
            {
                SqlCommand comando = gestorDAOSQL.obtenerComandoSQL(sentenciaSQL);
                asignarParametros(cliente, comando);
                comando.Parameters.AddWithValue("@id_cliente", cliente.Id_cliente);
                registros_afectados = comando.ExecuteNonQuery();
                return registros_afectados;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void asignarParametros(Cliente cliente, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("@numero_documento", cliente.Numero_documento);
            comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
            comando.Parameters.AddWithValue("@apellido_paterno", cliente.Apellido_paterno);
            comando.Parameters.AddWithValue("@apellido_materno", cliente.Apellido_materno);
            comando.Parameters.AddWithValue("@direccion", cliente.Direccion);
            comando.Parameters.AddWithValue("@telefono", cliente.Telefono);
            comando.Parameters.AddWithValue("@tipo_cliente", cliente.Tipo_cliente);
            comando.Parameters.AddWithValue("@ruc", cliente.Ruc);
            comando.Parameters.AddWithValue("@razon_social", cliente.Razon_social);
            comando.Parameters.AddWithValue("@id_documento", cliente.Tipo_documento.Id_documento);
        }
    }
}
