using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capa3_Dominio;

namespace Capa4_Persistencia
{
    public class TipoDocumentoDAO
    {
        private GestorDAOSQL gestorDAOSQL;
        public TipoDocumentoDAO(GestorDAOSQL gestorDAOSQL)
        {
            this.gestorDAOSQL = gestorDAOSQL;
        }

        public List<TipoDocumento> listarTipoDocumento()
        {
            List<TipoDocumento> listaTipoDocumentos = new List<TipoDocumento>();
            TipoDocumento tipoDocumento;
            string sentenciaSQL = "SELECT id_tipo_documento, descripcion FROM TipoDocumento";
            try
            {
                SqlDataReader resultado = gestorDAOSQL.ejecutarConsulta(sentenciaSQL);
                while (resultado.Read())
                {
                    tipoDocumento = crearObjetoTipoDocumento(resultado);
                    listaTipoDocumentos.Add(tipoDocumento);
                }
                resultado.Close();
                return listaTipoDocumentos;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private TipoDocumento crearObjetoTipoDocumento(SqlDataReader resultado)
        {
            TipoDocumento tipoDocumento;
            tipoDocumento = new TipoDocumento();
            tipoDocumento.Id_documento = resultado.GetInt32(0);
            tipoDocumento.Descripcion = resultado.GetString(1);
            return tipoDocumento;
        }
    }
}
