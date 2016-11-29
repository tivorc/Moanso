using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio
{
   public class Empleado
    {
        public int Id_empleado { get; set; }
        public string Numero_documento { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public char Tipo_empleado { get; set; }
        public string Nombre_usuario { get; set; }
        public string Contraseña { get; set; }
        public string Tipo_documento { get; set; }
    }
}
