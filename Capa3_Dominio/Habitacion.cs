using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio
{
   public class Habitacion
    {
        public int Id_habitacion { get; set; }
        public string Numero { get; set; }
        public char Piso { get; set; }
        public char Estado { get; set; }
        public TipoHabitacion Tipo_habitacion { get; set; }

        

    }
}
