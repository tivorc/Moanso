using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capa3_Dominio;
using Capa4_Persistencia;

namespace Capa2_Aplicacion
{
   public class GestionarEmpleadoServicio
    {
        private GestorDAOSQL gestorDAOSQL;
        private EmpleadoDAO empleadoDAO;


        public GestionarEmpleadoServicio()
        {
            gestorDAOSQL = new GestorDAOSQL();
            empleadoDAO = new EmpleadoDAO(gestorDAOSQL);

            
        }
        public int guardarEmpleado(Empleado empleado)
        {
            try
            {
                int registro_afectado;
                gestorDAOSQL.abrirConexion();
                registro_afectado =empleadoDAO.guardarEmpleado(empleado) ;
                gestorDAOSQL.cerrarConexion();
                return registro_afectado;
            }
            catch (Exception e)
            {

                throw e;
            }


        }
        public int modificarEmpleado(Empleado empleado)
        {
            try
            {
                int registro_afectado;
                gestorDAOSQL.abrirConexion();
                registro_afectado = empleadoDAO.modificarEmpleado(empleado);
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
