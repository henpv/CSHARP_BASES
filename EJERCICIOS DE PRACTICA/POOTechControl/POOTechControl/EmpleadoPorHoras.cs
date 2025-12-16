using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTechControl
{
    internal class EmpleadoPorHoras:Empleado
    {
        private int _horasTrabajadas;
        public int HorasTrabajadas
        {
            get => _horasTrabajadas;
            set
            {
                if (value < 0) throw new ArgumentException("Las horas trabajadas ser menor a cero.");
                else _horasTrabajadas = value;
            }
        }

        private double _valorHora;
        public double ValorHora
        {
            get => _valorHora;
            set
            {
                if (value <= 0) throw new ArgumentException("El valor de la hora no puede ser menor a cero.");
                else _valorHora = value;
            }
        }

        public EmpleadoPorHoras(string nombre, string identificacion, double salarioBase, int horasTrabajadas, double valorHora) : base(nombre, identificacion, salarioBase)
        {
            _horasTrabajadas = horasTrabajadas;
            _valorHora = valorHora;
        }

        public override double CalcularSalario() => HorasTrabajadas * ValorHora;
    }
}
