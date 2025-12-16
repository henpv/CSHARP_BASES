using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPropiedadesHerenciaPolimorfismo2
{
    internal class Circulo:Figura
    {

        private double _radio;
        public double Radio
        {
            get => _radio;
            set
            {
                if (value <= 0) throw new ArgumentException("El rádio debe ser mayor a cero");
                else _radio = value;
            }
        }

        public override string Tipo  => "Circulo"; 

        public Circulo(string nombre, string color, double radio): base(nombre, color)
        {
            Radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio,2);
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }


    }
}
