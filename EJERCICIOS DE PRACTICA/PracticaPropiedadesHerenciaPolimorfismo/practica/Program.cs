using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPropiedadesHerenciaPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ============================================
            // 1. Crear una lista polimórfica de empleados
            // ============================================
            List<Empleado> empleados = new List<Empleado>();


            // ============================================
            // 2. Agregar un empleado de cada tipo
            // ============================================

            // Empleado Tiempo Completo
            Empleado empTC = new EmpleadoTiempoCompleto(nombre: "Laura Gómez",identificacion: "LG1001",salarioBase: 2000000,horasExtras: 10,valorHoraExtra: 15000);

            // Empleado Medio Tiempo
            Empleado empMT = new EmpleadoMedioTiempo(nombre: "Carlos Ruiz",identificacion: "CR1002",salarioBase: 1200000,horasTrabajadas: 80,valorHora: 20000);

            // Empleado por Comisión
            Empleado empCom = new EmpleadoComision(nombre: "Ana Pérez",identificacion: "AP1003",salarioBase: 1000000,ventasDelMes: 30,porcentajeComision: 0.5);

            // Agregamos todos los empleados a la lista
            empleados.Add(empTC);
            empleados.Add(empMT);
            empleados.Add(empCom);


            // ============================================
            // 3. Activar a todos los empleados
            // ============================================
            foreach (var empleado in empleados)
            {
                empleado.Activar(); // Método heredado de la clase base
            }


            // ============================================
            // 4. Recorrer la lista usando polimorfismo puro
            // ============================================
            foreach (var empleado in empleados)
            {
                Console.WriteLine("====================================");

                // Tipo → propiedad abstracta implementada en cada clase hija
                Console.WriteLine($"Tipo: {empleado.Tipo}");

                // Descripción → propiedad calculada de la clase base
                Console.WriteLine($"Descripción: {empleado.Descripcion}");

                // Activo → propiedad administrada por métodos de la clase base
                Console.WriteLine($"Activo: {empleado.Activo}");

                // Salario → método abstracto implementado diferente en cada hijo
                Console.WriteLine($"Salario: {empleado.Calcularsalario()}");
            }

            Console.WriteLine("====================================");
        }
    }
}
