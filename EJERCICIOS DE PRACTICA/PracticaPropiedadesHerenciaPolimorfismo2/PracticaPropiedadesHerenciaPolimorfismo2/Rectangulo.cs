using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPropiedadesHerenciaPolimorfismo2
{
    internal class Rectangulo:Figura
    {
        private double _ancho;
        public double Ancho
        {
            get { return _ancho; }
            set
            {
                if (value <= 0) throw new ArgumentException("El valor del ancho debe ser mayor a cero");
                else _ancho = value;
            }
        }

        private double _alto;
        public double Alto
        {
            get { return _alto; }
            set
            {
                if (value <= 0) throw new ArgumentException("El valor del alto debe ser mayor a cero");
                else _alto = value;
            }
        }

        public override string Tipo => "Triangulo";
        
        public Rectangulo(string nombre, string color, double ancho, double alto) : base(nombre, color)
        {
            Ancho = ancho;
            Alto = alto;
        }

        public override double CalcularArea()
        {
            return Ancho *  Alto;
        }

        public override double CalcularPerimetro()
        {
            return 2* (Ancho * Alto);
        }

    }
}
