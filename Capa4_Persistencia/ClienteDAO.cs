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
            string sentenciaSQL = "INSERT INTO Cliente(numero_documento, nombre, apellidos, tipo_documento) VALUES(@numero_documento, @nombre, @apellidos, @tipo_documento)";
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
            string sentenciaSQL = "UPDATE Cliente SET numero_documento = @numero_documento, nombre = @nombre, apellidos = @apellidos, tipo_documento = @tipo_documento WHERE id_cliente = @id_cliente";
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

        public Cliente buscarPorDocumento(string numero_documento)
        {
            Cliente cliente = null;
            String sentenciaSQL = "select id_cliente, numero_documento, nombre, apellidos, tipo_documento FROM Cliente WHERE numero_documento = '" + numero_documento + "'";
            try
            {
                SqlDataReader resultado = gestorDAOSQL.ejecutarConsulta(sentenciaSQL);
                if (resultado.Read())
                {
                    cliente = new Cliente();
                    cliente.Id_cliente = resultado.GetInt32(0);
                    cliente.Numero_documento = resultado.GetString(1);
                    cliente.Nombre = resultado.GetString(2);
                    cliente.Apellidos = resultado.GetString(3);
                }
                resultado.Close();
                return cliente;
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
            comando.Parameters.AddWithValue("@apellidos", cliente.Apellidos);
            comando.Parameters.AddWithValue("@tipo_documento", cliente.Tipo_documento);
        }
    }
}
