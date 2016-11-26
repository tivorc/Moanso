using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio
{
    class Boleta : ComprobanteDePago
    {
        public int Numero { get; set; }
        public int Serie { get; set; }
    }
}
