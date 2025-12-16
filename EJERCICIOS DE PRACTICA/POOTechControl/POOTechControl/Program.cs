using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POOTechControl
{
    internal class Program
    {
        /// <summary>
        /// Punto de entrada principal del programa.
        /// Gestiona repositorios de productos y empleados,
        /// ejecuta operaciones CRUD básicas y demuestra polimorfismo
        /// utilizando interfaces y clases abstractas.
        /// </summary>
        static void Main(string[] args)
        {
            // ---------------------------------------------------
            // 1. Crear repositorios genéricos para productos y empleados
            // ---------------------------------------------------
            var repoProductos = new RepositorioEnMemoria<Producto>();
            var repoEmpleados = new RepositorioEnMemoria<Empleado>();


            // ---------------------------------------------------
            // 2. Agregar productos (físicos y digitales)
            // ---------------------------------------------------
            repoProductos.Agregar(new ProductoFisico("123", "lapiz", 100, 7));
            repoProductos.Agregar(new ProductoFisico("124", "regla", 180, 8));
            repoProductos.Agregar(new ProductoDigital("369", "Escalera", 560, 15));
            repoProductos.Agregar(new ProductoDigital("368", "Martillo", 380, 11));
            repoProductos.Agregar(new ProductoFisico("125", "cuadero", 200, 8));
            repoProductos.Agregar(new ProductoFisico("126", "compas", 170, 6));
            repoProductos.Agregar(new ProductoDigital("367", "pala", 420, 10));
            repoProductos.Agregar(new ProductoDigital("366", "Destornillador", 210, 5));


            // ---------------------------------------------------
            // 3. Agregar empleados (tiempo completo y por horas)
            // ---------------------------------------------------
            repoEmpleados.Agregar(new EmpleadoTiempoCompleto("Carlos Pérez", "EMP001", 1200000, 150000));
            repoEmpleados.Agregar(new EmpleadoTiempoCompleto("María Gómez", "EMP002", 980000, 120000));
            repoEmpleados.Agregar(new EmpleadoTiempoCompleto("José Rodríguez", "EMP003", 1500000, 250000));
            repoEmpleados.Agregar(new EmpleadoTiempoCompleto("Ana Torres", "EMP004", 1050000, 180000));
            repoEmpleados.Agregar(new EmpleadoPorHoras("Laura Ruiz", "EMP101", 700000, 10, 5000));
            repoEmpleados.Agregar(new EmpleadoPorHoras("Daniel Castro", "EMP102", 820000, 15, 6000));
            repoEmpleados.Agregar(new EmpleadoPorHoras("Natalia Rivas", "EMP103", 750000, 8, 4500));
            repoEmpleados.Agregar(new EmpleadoPorHoras("Felipe Arango", "EMP104", 900000, 12, 5500));


            // ---------------------------------------------------
            // 4. Mostrar salarios de todos los empleados
            // ---------------------------------------------------
            Console.WriteLine("=== LISTADO DE EMPLEADOS ===");

            foreach (var empleado in repoEmpleados.ListarTodos())
            {
                Console.WriteLine(
                    $"Empleado: {empleado.Nombre} (ID: {empleado.Id}) - Salario Total: ${empleado.CalcularSalario()}"
                );
            }

            
            // ---------------------------------------------------
            // 5. Eliminar productos por ID y mostrar los restantes
            // ---------------------------------------------------
            Console.WriteLine("\n=== ELIMINANDO PRODUCTOS ===");

            EliminarProducto(repoProductos, "368");
            EliminarProducto(repoProductos, "123");

            Console.WriteLine("\n=== PRODUCTOS RESTANTES EN INVENTARIO ===");

            foreach (var p in repoProductos.ListarTodos())
            {
                Console.WriteLine(
                    $"Producto: {p.Nombre} (ID: {p.Id}) permanece en inventario."
                );
            }


            // ---------------------------------------------------
            // 6. Crear una lista de ICalculable y demostrar polimorfismo
            // ---------------------------------------------------
            Console.WriteLine("\n=== LISTA DE OBJETOS ICalculable ===");

            var listaC = new List<ICalculable>
            {
                new EmpleadoTiempoCompleto("Carla Páez", "EMP091", 1300000, 140000),
                new EmpleadoTiempoCompleto("Carlos Pérez", "EMP001", 1200000, 150000),
                new EmpleadoTiempoCompleto("María Gómez", "EMP002", 980000, 120000),
                new EmpleadoTiempoCompleto("José Rodríguez", "EMP003", 1500000, 250000),
                new ProductoFisico("123", "lapiz", 100, 7),
                new ProductoFisico("124", "regla", 180, 8),
                new ProductoDigital("369", "Escalera", 560, 15),
                new ProductoDigital("368", "Martillo", 380, 11)
            };

            foreach (var c in listaC)
            {
                Console.WriteLine(
                    $"Cálculo para {c.Nombre}: {c.Calcular()}"
                );
            }


            // ---------------------------------------------------
            // 7. Buscar empleado por nombre usando método de extensión
            // ---------------------------------------------------
            Console.WriteLine("\n=== BUSCAR EMPLEADO POR NOMBRE ===");

            var coincidencia = Utilidades.BuscarPorNombre(
                repoEmpleados.ListarTodos(),
                "Carlos Pérez"
            );

            if (coincidencia != null)
            {
                Console.WriteLine(
                    $"Empleado encontrado: {coincidencia.Nombre} (ID: {coincidencia.Id})"
                );
            }
            else
            {
                Console.WriteLine("No se encontró ningún empleado con ese nombre.");
            }
        }


        /// <summary>
        /// Método auxiliar para eliminar un producto con mensajes más limpios.
        /// </summary>
        private static void EliminarProducto(RepositorioEnMemoria<Producto> repo, string id)
        {
            var prod = repo.BuscarPorId(id);

            if (prod != null)
            {
                Console.WriteLine($"El producto {prod.Nombre} será eliminado.");
                repo.Eliminar(id);
            }
            else
            {
                Console.WriteLine($"No se encontró el producto con ID {id}.");
            }
        }
    }
}
