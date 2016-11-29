using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio
{
    public class Reserva
    {
        public int Id_reserva { get; set; }
        public DateTimeOffset Fecha_inicio { get; set; }
        public DateTimeOffset Fecha_fin { get; set; }
        public string Estado { get; set; }
        public string Tipo_reserva { get; set; }
        public double Precio { get; set; }
        public Habitacion Habitacion { get; set; }
        public Empleado empleado { get; set; }
        public List<Cliente> Lista_cliente { get; set; }



        public bool definirCobro()
        {

            if (Fecha_inicio.Day == Fecha_fin.Day)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }


}
