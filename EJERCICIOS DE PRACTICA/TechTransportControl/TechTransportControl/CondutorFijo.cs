using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTransportControl
{
    internal class ConductorFijo : Conductor
    {
        private double _bonificacion;

        public double Bonificacion
        {
            get { return _bonificacion; }
            set {
                if (value < 0) throw new ArgumentException("La bonificación no puede ser menor a cero.");
                else _bonificacion = value;
            }
        }
        public override string Tipo => "ConductorFijo";

        public ConductorFijo(string id, string nombre, double salarioBase,double bonificacion ) : base (id, nombre, salarioBase)
        {
            Bonificacion = bonificacion;
        }

        public override double CalcularPagoMensual()
        {
            double pagoMensual = SalarioBase + Bonificacion;
            return pagoMensual;
        }

    }
}
