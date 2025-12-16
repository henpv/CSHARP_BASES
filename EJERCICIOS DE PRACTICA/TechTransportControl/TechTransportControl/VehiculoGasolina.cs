using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTransportControl
{
    internal class VehiculoGasolina : Vehiculo
    {
        private double _cilindraje;
        public double Cilindraje
        {
            get { return _cilindraje; }
            set
            {
                if(value <= 0) throw new ArgumentOutOfRangeException("El cilindraje no puede ser menor a cero.");
                else _cilindraje = value;
            }
        }

        private double _consumoPromedio;
        public double ConsumoPromedio
        {
            get { return _consumoPromedio; }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("El consumo promedio no puede ser menos a cero.");
                else _consumoPromedio = value;
            }
        }

        public override string Tipo => "VehiculoGasolina";

        public VehiculoGasolina(string id, string nombre, double valorBase, double cilindraje, double consumoPromedio) : base(id, nombre, valorBase)
        {
            Cilindraje = cilindraje;
            ConsumoPromedio = consumoPromedio;

        }

        public override double CalcularCostoMantenimiento()
        {
            double costo = ValorBase * 0.05 + Cilindraje * 10;
            return costo ;
        }

    }
}
