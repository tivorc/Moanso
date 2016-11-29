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
        public string Numero { get; set; }
        public double Total { get; set; }
        public string Estado { get; set; }
        public Reserva Reserva { get; set; }
        public Cliente Cliente { get; set; }

        public double calcularMonto()
        {
            bool cobro = Reserva.definirCobro();
            if (cobro)
            {
                int tiempo = calcularHorasHospedaje(Reserva.Fecha_inicio, Reserva.Fecha_fin);
                return calcularMontoHoras(tiempo);
            } else
            {
                int tiempo = calcularDiasHospedaje(Reserva.Fecha_inicio, Reserva.Fecha_fin);
                return calcularMontoDias(tiempo);
            }
        }

        public int calcularDiasHospedaje(DateTimeOffset inicio, DateTimeOffset fin)
        {

            TimeSpan ts = fin - inicio;
            return ts.Days;

        }

        public double calcularMontoHoras(int tiempo)
        {
            return Reserva.Habitacion.Tipo_habitacion.PrecioHora * tiempo;
        }

        public double calcularMontoDias(int tiempo)
        {
            return Reserva.Habitacion.Tipo_habitacion.PrecioDia * tiempo;
        }
        public int calcularHorasHospedaje(DateTimeOffset inicio, DateTimeOffset fin)
        {
            TimeSpan ts = fin - inicio;
            return ts.Hours;
        }
    }
}
