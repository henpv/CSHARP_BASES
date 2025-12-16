using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTechControl
{
    internal class ProductoFisico:Producto
    {

        private double _costoEnvio;
        public double CostoEnvio
        {
            get => _costoEnvio;
            set
            {
                if (value <= 0) throw new ArgumentException("El costo de envío debe ser mayor a cero.");
                else _costoEnvio = value;
            }
        }

        public ProductoFisico(string codigo, string nombre, double precioBase, double costoEnvio) : base(codigo, nombre, precioBase)
        {
            CostoEnvio = costoEnvio;
        }

        public override double CalcularPrecioFinal() => PrecioBase + CostoEnvio; 

    }
}
