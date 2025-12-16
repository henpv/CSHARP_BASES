using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTechControl
{
    internal class ProductoDigital:Producto
    {

        private double _impuestoDigital;
        public double ImpuestoDigital
        {
            get => _impuestoDigital;
            set
            {
                if (value <= 0 || value > 100) throw new ArgumentException("El impuesto digital debe estar entre 1 y 100.");
                else _impuestoDigital = (value / 100);
            }
        }

        public ProductoDigital(string codigo, string nombre, double precioBase, double impuestoDigital) : base(codigo, nombre, precioBase)
        {
            ImpuestoDigital = impuestoDigital;
        }

        public override double CalcularPrecioFinal() => PrecioBase + (PrecioBase * ImpuestoDigital);

    }
}
