using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using TechTransportControl.POOTechControl;

namespace TechTransportControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Crear repositorios de vehículos y conductores
            var repoVehiculos = new RepositorioEnMemoria<Vehiculo>();
            var repoConductores = new RepositorioEnMemoria<Conductor>();

            // 2. Agregar vehículos (3 gasolina, 3 eléctricos)
            repoVehiculos.Agregar(new VehiculoGasolina("ABC123", "CHEVROLET", 45000000, 4800, 45));
            repoVehiculos.Agregar(new VehiculoGasolina("DEF456", "MAZDA", 52000000, 5200, 50));
            repoVehiculos.Agregar(new VehiculoGasolina("GHI789", "TOYOTA", 48000000, 5000, 47));

            repoVehiculos.Agregar(new VehiculoElectrico("JKL321", "TESLA", 180000000, 70, 5));
            repoVehiculos.Agregar(new VehiculoElectrico("MNO654", "NISSAN", 120000000, 85, 8));
            repoVehiculos.Agregar(new VehiculoElectrico("PQR987", "BMW", 160000000, 90, 2));

            // 3. Agregar conductores (3 fijos, 3 por viaje)
            repoConductores.Agregar(new ConductorFijo("7894634", "Joselito Juarez", 2000, 100));
            repoConductores.Agregar(new ConductorFijo("4561238", "Maria Fernanda", 2200, 120));
            repoConductores.Agregar(new ConductorFijo("9638527", "Carlos Ramirez", 2100, 110));

            repoConductores.Agregar(new ConductorPorViaje("10579634", "Adrian Arango", 1000, 20, 150));
            repoConductores.Agregar(new ConductorPorViaje("7412589", "Laura Gómez", 900, 30, 130));
            repoConductores.Agregar(new ConductorPorViaje("8523694", "Andrés Pérez", 800, 52, 160));

            // 4. Crear lista de ICalculable usando objetos EXISTENTES
            var listaCalculables = new List<ICalculable>();

            listaCalculables.AddRange(repoConductores.ListarTodos());
            listaCalculables.AddRange(repoVehiculos.ListarTodos());

            // 5. Mostrar Nombre - Tipo - Cálculo
            Console.WriteLine("\n--- CÁLCULOS ---");
            foreach (var item in listaCalculables)
            {
                Console.WriteLine($"{item.Nombre} - {item.Tipo} - {item.Calcular()}");
            }

            // 6. Buscar vehículo por nombre (método de extensión)
            var vehiculoEncontrado = repoVehiculos
                .ListarTodos()
                .BuscarPorNombre("MAZDA");

            if (vehiculoEncontrado != null)
            {
                Console.WriteLine($"\nVehículo encontrado: {vehiculoEncontrado.Nombre} (ID: {vehiculoEncontrado.Id})");
            }
            else
            {
                Console.WriteLine("\nNo existe vehículo de esa marca.");
            }

            // 7. Buscar conductor por Id
            var conductor = repoConductores.BuscarPorId("4561238");

            if (conductor != null)
            {
                Console.WriteLine(
                    $"\nConductor encontrado: {conductor.Nombre} | Tipo: {conductor.Tipo}");
            }

            // 8. Desactivar un vehículo y mostrar su estado
            var vehiculo = repoVehiculos.BuscarPorId("ABC123");

            if (vehiculo == null)
            {
                Console.WriteLine("\nEl vehículo no existe.");
                return;
            }

            if (vehiculo.Activo)
            {
                Console.WriteLine($"\nDesactivando vehículo {vehiculo.Nombre}...");
                vehiculo.Desactivar();
            }

            Console.WriteLine(
                $"Estado actual del vehículo {vehiculo.Nombre}: {(vehiculo.Activo ? "Activo" : "Desactivado")}");
        }
    }

}
