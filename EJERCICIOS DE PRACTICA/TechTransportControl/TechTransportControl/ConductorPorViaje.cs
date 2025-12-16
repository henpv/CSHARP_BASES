using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTransportControl
{
    internal class ConductorPorViaje : Conductor    
    {
        private double _numeroViajes;

        public double NumeroViajes
        {
            get { return _numeroViajes; }
            set
            {
                if (value < 0) throw new ArgumentException("La cantidad de numero de viajes no puede ser menor a cero.");
                else _numeroViajes = value;
            }
        }

        private double _pagoPorViaje;

        public double PagoPorViaje
        {
            get { return _pagoPorViaje; }
            set
            {
                if (value <= 0) throw new ArgumentException("El pago por viaje debe ser mayor a cero.");
                else _pagoPorViaje = value;
            }
        }

        public override string Tipo => "ConductorPorViaje";

        public ConductorPorViaje(string id, string nombre, double salarioBase, double numeroViajes,  double pagoPorViaje) : base(id, nombre, salarioBase)
        {
            NumeroViajes = numeroViajes;
            PagoPorViaje = pagoPorViaje;
        }

        public override double CalcularPagoMensual()
        {
            double pagoMensual = SalarioBase + (NumeroViajes * PagoPorViaje);
            return pagoMensual;
        }
    }
}
