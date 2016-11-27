using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio
{
   public class TipoHabitacion
    {
        public int Id_tipo_habitacion  { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double PrecioHora { get; set; }
        public double PrecioDia { get; set; }


    }
}
