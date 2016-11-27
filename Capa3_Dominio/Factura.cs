using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio
{
  public  class Factura : ComprobanteDePago
    {
        public string Numero { get; set; }
        public string Serie { get; set; }
    }
}
