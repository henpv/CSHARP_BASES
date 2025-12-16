using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTechControl
{
    internal class EmpleadoTiempoCompleto : Empleado
    {
        private double _bonificacion;
        public double Bonificacion
        {
            get => _bonificacion;
            set
            {
                if (value < 0) throw new ArgumentException("La bonificación no puede ser menor a cero.");
                else _bonificacion = value;
            }
        }

        public EmpleadoTiempoCompleto(string nombre, string identificacion, double salarioBase, double bonificacion) : base(nombre, identificacion, salarioBase)
        {
            _bonificacion = bonificacion;
        }
        
        public override double CalcularSalario() => SalarioBase + Bonificacion;
    }
}
