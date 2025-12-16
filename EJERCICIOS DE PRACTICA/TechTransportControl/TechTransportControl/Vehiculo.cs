using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTransportControl
{
    internal abstract class Vehiculo : IIdentificable, INombrable, ICalculable
    {
        private string _codigoVehiculo;
        public string Id
        {
            get { return _codigoVehiculo; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("El codigo no debe ser nulo.");
                else _codigoVehiculo = value;
            }
        }

        private string _marca;
        public string Nombre
        {
            get { return _marca; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("La marca no debe ser nulo.");
                else _marca = value;
            }
        }

        private double _valorBase;

        public double ValorBase
        {
            get { return _valorBase; }
            set
            {
                if (value <= 0) throw new ArgumentException("El valor base del vehiculo no puede ser igual a cero");
                else _valorBase = value;
            }
        }

        public bool Activo { get; set; }

        public virtual string Tipo { get; }

        public Vehiculo (string id, string nombre, double valorBase)
        {            
            Id = id;
            Nombre = nombre;
            ValorBase = valorBase;
            Activo = true;
        }

        public void Activar()
        {
            Activo = true;
        }

        public void Desactivar()
        {
            Activo = false;
        }

        public abstract double CalcularCostoMantenimiento();

        public double Calcular()
        {
            return CalcularCostoMantenimiento();
        }



    }
}
