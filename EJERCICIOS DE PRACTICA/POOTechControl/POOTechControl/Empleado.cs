using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTechControl
{
    // Clase abstracta que representa a cualquier empleado dentro del sistema.
    // Define los datos base y el comportamiento común que deben tener todas
    // las clases de empleados. Implementa IIdentificable, ICalculable e
    // INombrable para asegurar que cada empleado tenga un Id, un Nombre y
    // un método de cálculo estándar.
    internal abstract class Empleado : IIdentificable, ICalculable, INombrable
    {
        // Campo privado donde se almacena la identificación del empleado.
        // Se mantiene encapsulado para aplicar validaciones al asignar valor.
        private string _identificacion;

        // Propiedad pública para leer o modificar la identificación del empleado.
        // Incluye validación para evitar valores nulos o vacíos.
        public string Identificacion
        {
            get => _identificacion;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("La identificación no puede estar vacía.");
                _identificacion = value;
            }
        }

        // Implementación de Id requerida por IIdentificable.
        // En los empleados, el Id es exactamente su Identificación.
        public string Id => Identificacion;

        // Campo privado que almacena el nombre del empleado.
        private string _nombre;

        // Propiedad para acceder y asignar el nombre del empleado.
        // Valida que el nombre no sea nulo ni vacío.
        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");
                _nombre = value;
            }
        }

        // Campo privado donde se almacena el salario base del empleado.
        private double _salarioBase;

        // Propiedad pública para leer o modificar el salario base.
        // Incluye validación para impedir valores negativos.
        public double SalarioBase
        {
            get => _salarioBase;
            set
            {
                if (value < 0)
                    throw new ArgumentException("El salario no puede ser menor a cero.");
                _salarioBase = value;
            }
        }

        // Indica si el empleado se encuentra activo en el sistema.
        // Solo puede modificarse mediante métodos propios de la clase.
        public bool Activo { get; private set; }

        // Constructor que inicializa los datos principales del empleado.
        // Usa las propiedades para aprovechar sus validaciones internas.
        public Empleado(string nombre, string identificación, double salarioBase)
        {
            Nombre = nombre;
            Identificacion = identificación;
            SalarioBase = salarioBase;
            Activo = true; // Todo empleado inicia como activo.
        }

        // Método que vuelve a activar al empleado.
        public void Activar()
        {
            Activo = true;
        }

        // Método que desactiva al empleado (por ejemplo, retiro o suspensión).
        public void Desactivar()
        {
            Activo = false;
        }

        // Implementación del método Calcular() de ICalculable.
        // Redirige el cálculo hacia el salario final determinado por cada tipo de empleado.
        public double Calcular()
        {
            return CalcularSalario();
        }

        // Método abstracto que obliga a las clases derivadas a definir
        // cómo se calcula el salario final, según su rol o tipo específico.
        public abstract double CalcularSalario();
    }
}
