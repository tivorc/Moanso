using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio
{
  public  class ComprobanteDePago
    {
        public int Id_comprobante { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }

        public Reserva Reserva { get; set; }


   
    }
}
