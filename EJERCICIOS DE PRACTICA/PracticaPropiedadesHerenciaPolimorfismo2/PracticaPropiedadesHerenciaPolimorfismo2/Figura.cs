using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPropiedadesHerenciaPolimorfismo2
{
    internal abstract class Figura
    {

        private string _nombre;
        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("El nombre no puede ser nulo o vacio");
                else _nombre = value;
            }
        }

        private string _color;
        public string Color
        {
            get => _color;
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("El color no puede ser nulo o vacio");
                else _color = value;    
            }
        }

        protected Figura(string nombre, string color)
        {
            _nombre = nombre;
            _color = color;
        }

        public abstract string Tipo {  get; }

        public abstract double CalcularArea();

        public abstract double CalcularPerimetro();


    }
}
