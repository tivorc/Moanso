using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capa4_Persistencia;
using Capa3_Dominio;


namespace Capa2_Aplicacion
{
    public class GestionarClienteServicio
    {
        private GestorDAOSQL gestorDAOSQL;
        private ClienteDAO clienteDao;


        public GestionarClienteServicio()
        {
            gestorDAOSQL = new GestorDAOSQL();
            clienteDao = new ClienteDAO(gestorDAOSQL);
        }
        public int guardarCliente(Cliente cliente)
        {
            try
            {
                int registro_afectado;
                gestorDAOSQL.abrirConexion();
                registro_afectado = clienteDao.guardarCliente(cliente);
                gestorDAOSQL.cerrarConexion();
                return registro_afectado;
            }
            catch (Exception e)
            {

                throw e;
            }
           

        }
        public int modificarCliente(Cliente cliente)
        {
            try
            {
                int registro_afectado;
                gestorDAOSQL.abrirConexion();
                registro_afectado = clienteDao.modificarCliente(cliente);
                gestorDAOSQL.cerrarConexion();
                return registro_afectado;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

    }
}
