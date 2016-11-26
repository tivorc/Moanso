using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio
{
    class Reserva
    {
        public int Id_reserva { get; set; }
        public DateTime Fecha_inicio { get; set; }
        public DateTime Fecha_fin { get; set; }
        public char Estado { get; set; }
        public char Tipo_reserva { get; set; }
        public Habitacion Habitacion { get; set; }
        public Empleado empleado { get; set; }
        public List<Cliente> Lista_cliente { get; set; }
    }
}
