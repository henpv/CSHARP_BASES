using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPropiedadesHerenciaPolimorfismo
{
    // La clase es 'internal', lo que significa que solo puede usarse dentro del mismo proyecto/ensamblado.
    // No es pública para otros ensamblados externos.
    internal abstract class Empleado
    {
        // ===============================
        //      CAMPOS PRIVADOS
        // ===============================
        // Estos campos almacenan la información real.
        // Son privados para aplicar encapsulación y obligar a usar las propiedades.
        private string _nombre;
        private string _identificacion;
        private double _salarioBase;


        // ===============================
        //      PROPIEDADES
        // ===============================
        // Las propiedades permiten controlar el acceso a esos campos con validaciones.

        public string Nombre
        {
            // Expression-bodied property: forma corta de escribir un getter
            get => _nombre;

            // Setter con validación
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("El nombre no puede ser nulo");

                _nombre = value;
            }
        }

        public string Identificacion
        {
            get => _identificacion;

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("La identificación no puede ser nula");

                _identificacion = value;
            }
        }

        public double SalarioBase
        {
            get => _salarioBase;

            set
            {
                if (value < 0)
                    throw new Exception("El salario no puede ser menor que cero");

                _salarioBase = value;
            }
        }

        // Propiedad automática con getter privado.
        // Solo la clase puede cambiar su valor (Activar/Desactivar).
        public bool Activo { get; private set; }

        // Propiedad abstracta y calculada que obliga a todas las clases hijas
        // a definir el tipo de empleado que representan.
        // No tiene 'set' porque su valor se calcula en cada clase derivada.
        // Ejemplos: "Tiempo Completo", "Medio Tiempo", "Comisión".
        public abstract string Tipo { get; }


        // ====================================
        //      PROPIEDAD CALCULADA
        // ====================================
        // Esta propiedad NO guarda datos.
        // Calcula el valor cada vez que se llama.
        // No necesita setter porque no almacena nada.
        public string Descripcion => $"Empleado: {this._nombre} - ID: {this._identificacion}";


        // ====================================
        //      CONSTRUCTOR PROTEGIDO
        // ====================================
        // Como la clase es abstracta, no se puede instanciar.
        // Pero las clases hijas sí deben llamar a este constructor.
        // No importa si el constructor es public, private o protected.   Si la clase es internal, solo será visible dentro del mismo proyecto.
        protected Empleado(string nombre, string identificacion, double salarioBase)
        {
            // Aquí usamos las propiedades, NO los campos privados,
            // para que las validaciones del setter se ejecuten.
            Nombre = nombre;
            Identificacion = identificacion;
            SalarioBase = salarioBase;

            // El empleado inicia activo por defecto.
            Activo = false;
        }


        // ===============================
        //  MÉTODOS CONTROL DE ESTADO
        // ===============================
        public void Activar()
        {
            Activo = true;
        }

        public void Desactivar()
        {
            Activo = false;
        }


        // =====================================
        //   MÉTODO ABSTRACTO
        // =====================================
        // No lleva "virtual" porque NO tiene implementación.
        // Las clases hijas están obligadas a implementarlo con "override".
        public abstract double Calcularsalario();
    }

}
