using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPropiedadesHerenciaPolimorfismo
{
    // La clase es 'internal', así que solo es visible dentro del mismo ensamblado.
    // Hereda de 'Empleado', lo que significa que debe implementar el método abstracto Calcularsalario.
    internal class EmpleadoMedioTiempo:Empleado
    {
        // ====================================
        //     PROPIEDADES ESPECÍFICAS
        // ====================================
        public double _horasTrabajadas;
        public double HorasTrabajadas
        {
            get => _horasTrabajadas;

            set
            {
                if (value < 0)
                    throw new Exception("Las horas trabajadas no pueden ser negativas");

                _horasTrabajadas = value;
            }
        }
        public double _valorHora;
        public double ValorHora
        {
            get => _valorHora;

            set
            {
                if (value < 0)
                    throw new Exception("El valor de las horas no puede ser negativo");

                _valorHora = value;
            }
        }

        // Implementación de la propiedad abstracta 'Tipo' de la clase base.
        // Retorna una descripción fija que identifica el tipo de empleado.
        // Como es una propiedad calculada solo lectura, se usa expresión lambda.
        public override string Tipo => "Medio Timempo";

        // ====================================
        //     CONSTRUCTOR DE LA CLASE HIJA
        // ====================================
        // Recibe los datos específicos del empleado de tiempo completo.
        // Los primeros tres parámetros (nombre, identificación, salarioBase)
        // se envían al constructor de la clase base usando "base(...)"
        public EmpleadoMedioTiempo(string nombre, string identificacion, double salarioBase, int horasTrabajadas, double valorHora ):base(nombre, identificacion, salarioBase)
        {
            HorasTrabajadas = horasTrabajadas;
            ValorHora = valorHora;
        }

        // ====================================
        //  IMPLEMENTACIÓN DEL MÉTODO ABSTRACTO
        // ====================================
        // Como la clase base definió un método abstracto:
        //      public abstract double Calcularsalario();
        // La clase hija está obligada a implementarlo usando 'override'.
        // Aquí defines la lógica específica del cálculo.
        public override double Calcularsalario()
        {
            return HorasTrabajadas * ValorHora;
        }
    }
}
