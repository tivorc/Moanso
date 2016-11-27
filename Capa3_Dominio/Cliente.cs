using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio
{
   public class Cliente
    {
        public int Id_cliente { get; set; }
        public string Numero_documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido_paterno { get; set; }
        public string Apellido_materno { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public char Tipo_cliente { get; set; }
        public string Ruc { get; set; }
        public string Razon_social { get; set; }
        public TipoDocumento Tipo_documento { get; set; }
    }
}
