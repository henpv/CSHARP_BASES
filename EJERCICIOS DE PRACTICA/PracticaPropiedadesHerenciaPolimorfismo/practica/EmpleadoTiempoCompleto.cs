using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPropiedadesHerenciaPolimorfismo
{
    // La clase es 'internal', así que solo es visible dentro del mismo ensamblado.
    // Hereda de 'Empleado', lo que significa que debe implementar el método abstracto Calcularsalario.
    internal class EmpleadoTiempoCompleto:Empleado
    {
        // ====================================
        //     PROPIEDADES ESPECÍFICAS
        // ====================================
        public double _horasExtras;
        public double HorasExtras
        {
            get => _horasExtras;

            set
            {
                if (value < 0)
                    throw new Exception("Las horas extras no pueden ser negativas");

                _horasExtras = value;
            }
        }
        public double _valorHoraExtra;
        public double ValorHoraExtra
        {
            get => _valorHoraExtra;

            set
            {
                if (value < 0)
                    throw new Exception("El valor de las horas extras no puede ser negativo");

                _valorHoraExtra = value;
            }
        }

        // Implementación de la propiedad abstracta 'Tipo' de la clase base.
        // Retorna una descripción fija que identifica el tipo de empleado.
        // Como es una propiedad calculada solo lectura, se usa expresión lambda.
        public override string Tipo => "Tiempo Completo";

        // ====================================
        //     CONSTRUCTOR DE LA CLASE HIJA
        // ====================================
        // Recibe los datos específicos del empleado de tiempo completo.
        // Los primeros tres parámetros (nombre, identificación, salarioBase)
        // se envían al constructor de la clase base usando "base(...)"
        public EmpleadoTiempoCompleto(string nombre, string identificacion, double salarioBase, int horasExtras, double valorHoraExtra) : base(nombre, identificacion, salarioBase)
        {
            HorasExtras = horasExtras;
            ValorHoraExtra = valorHoraExtra;
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
            return SalarioBase + (HorasExtras * ValorHoraExtra);
            // Nota: SalarioBase se obtiene de la propiedad de la clase padre.
        }

    }
}
