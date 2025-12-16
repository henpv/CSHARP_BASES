using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPropiedadesHerenciaPolimorfismo2
{
    internal class Triangulo:Figura
    {
        private double _ladoA;
        public double LadoA
        {
            get { return _ladoA; }
            set 
            {
                if (value <= 0) throw new ArgumentException("El valor debe ser mayor a cero");
                else _ladoA = value;
            }
        }

        private double _ladoB;
        public double LadoB
        {
            get { return _ladoB; }
            set
            {
                if (value <= 0) throw new ArgumentException("El valor debe ser mayor a cero");
                else _ladoB = value;
            }
        }

        private double _ladoC;
        public double LadoC
        {
            get { return _ladoC; }
            set
            {
                if (value <= 0) throw new ArgumentException("El valor debe ser mayor a cero");
                else _ladoC = value;
            }
        }

        public override string Tipo => "Triangulo";

        public Triangulo(string nombre, string color, double ladoA, double ladoB, double ladoC) : base(nombre, color)
        {
            LadoA = ladoA;
            LadoB = ladoB;  
            LadoC = ladoC;
            ValidaTriangulo();
        }

        private void ValidaTriangulo()
        {
            if (LadoA >= (LadoB + LadoC) || LadoB >= (LadoA + LadoC) || LadoC >= (LadoA + LadoB))
            {
                throw new ArgumentException("La suma de dos lados no puede ser menor o igual al tercer lado");
            }   
        }

        public override double CalcularArea()
        {
            double s = (LadoA + LadoB + LadoC) / 2;

            return Math.Sqrt(s * (s - LadoA) * (s - LadoB) * (s - LadoC));
        }

        public override double CalcularPerimetro()
        {
            return  LadoA + LadoB +  LadoC; 
        }   

    }
}
