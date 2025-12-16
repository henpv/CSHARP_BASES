using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTransportControl
{
    internal abstract class Conductor : IIdentificable, INombrable, ICalculable
    {
        private string _identificacion;
        public string Id
        {
            get => _identificacion;
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("La identificación no puede ser nula.");
                else _identificacion = value;
            }
        }

        private string _nombre;
        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("El noombre nbo puede ser nulo.");
                else _nombre = value;
            }
        }

        private double _salarioBase;
        public double SalarioBase
        {
            get => _salarioBase;
            set
            {
                if (value < 0) throw new ArgumentException("El salario base no puede ser cero");
                else _salarioBase = value;
            }
        }

        private bool Activo { get; set; }

        public virtual string Tipo { get; }


        public Conductor(string id, string nombre, double salarioBase)
        {
            Id = id;
            Nombre = nombre;    
            SalarioBase = salarioBase;
            Activo = true;
        }

        public abstract double CalcularPagoMensual();

        public double Calcular()
        {
            return CalcularPagoMensual();
        }



    }
}
