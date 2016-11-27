using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capa3_Dominio;

namespace Capa4_Persistencia
{
    class ClienteDAO
    {
        private GestorDAOSQL gestorDAOSQL;
        public ClienteDAO(GestorDAOSQL gestorDAOSQL)
        {
            this.gestorDAOSQL = gestorDAOSQL;
        }

        public int guardarCliente(Cliente cliente)
        {
            int registro_afectados = 0; //modificar
            string sentenciaSQL = "INSERT INTO Cliente";
            try
            {
                SqlCommand comando = gestorDAOSQL.obtenerComandoSQL(sentenciaSQL);


                return registro_afectados;
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
            comando.Parameters.AddWithValue("@apellido_materno", cliente.Apellido_materno);
        }
    }
}
