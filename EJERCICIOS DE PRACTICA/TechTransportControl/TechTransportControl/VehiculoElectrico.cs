using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTransportControl
{
    internal class VehiculoElectrico: Vehiculo
    {
        private double _capacidadBateria;
        public double CapacidadBateria
        {
            get => _capacidadBateria;
            set
            {
                if (value < 0 || value > 100) throw new ArgumentException("La capacidad de la bateria debe definirse entre 0 y 100");
                else _capacidadBateria = value;
            }
        }

        private double _vidaUtilEstimada;
        public double VidaUtilEstimada
        {
            get => _vidaUtilEstimada;
            set
            {
                if (value <= 0 || value > 10) throw new ArgumentException("La vida util no debe ser mayor a 10 años.");
                else _vidaUtilEstimada = value;
            }
        }

        public override string Tipo => "VehiculoElectrico";

        public VehiculoElectrico(string id, string nombre, double valorBase, double capacidadBateria, double vidaUtilEstimada) : base (id, nombre, valorBase)
        {
            CapacidadBateria = capacidadBateria;
            VidaUtilEstimada = vidaUtilEstimada;
        }

        public override double CalcularCostoMantenimiento()
        {
            double costo = ValorBase * 0.03 + CapacidadBateria * 8;
            return costo;
        }

    }
}
