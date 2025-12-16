using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPropiedadesHerenciaPolimorfismo
{
    // La clase es 'internal', así que solo es visible dentro del mismo ensamblado.
    // Hereda de 'Empleado', lo que significa que debe implementar el método abstracto Calcularsalario.
    internal class EmpleadoComision : Empleado
    {
        // ====================================
        //     PROPIEDADES ESPECÍFICAS
        // ====================================
        public double _ventasDelMes;
        public double VentasDelMes
        {
            get => _ventasDelMes;

            set
            {
                if (value < 0)
                    throw new Exception("Las ventas del mes no pueden ser negativas");

                _ventasDelMes = value;
            }
        }
        public double _porcentajeComision;
        public double PorcentajeComision
        {
            get => _porcentajeComision;

            set
            {
                if (value < 0 || value > 1) throw new Exception("El porcentaje debe estar entre 0 y 1");
                else _porcentajeComision = value / 100;

            }
        }

        // Implementación de la propiedad abstracta 'Tipo' de la clase base.
        // Retorna una descripción fija que identifica el tipo de empleado.
        // Como es una propiedad calculada solo lectura, se usa expresión lambda.
        public override string Tipo => "Comisión";

        // ====================================
        //     CONSTRUCTOR DE LA CLASE HIJA
        // ====================================
        // Recibe los datos específicos del empleado de tiempo completo.
        // Los primeros tres parámetros (nombre, identificación, salarioBase)
        // se envían al constructor de la clase base usando "base(...)"
        public EmpleadoComision(string nombre, string identificacion, double salarioBase, double ventasDelMes, double porcentajeComision) : base(nombre, identificacion, salarioBase)
        {
            VentasDelMes = ventasDelMes;
            PorcentajeComision = porcentajeComision;
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
            return SalarioBase + (VentasDelMes * PorcentajeComision);
            // Nota: SalarioBase se obtiene de la propiedad de la clase padre.
        }

        
    }
}
