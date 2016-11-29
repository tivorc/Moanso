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
        public string Apellidos { get; set; }
        public string Tipo_documento { get; set; }
    }
}
