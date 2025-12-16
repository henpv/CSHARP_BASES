using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTechControl
{
    // Interfaz genérica que define el conjunto mínimo de operaciones que debe ofrecer
    // cualquier repositorio dentro del sistema. Su propósito es establecer un contrato
    // estándar para manejar colecciones de objetos, sin importar el tipo específico.
    //
    // IMPORTANCIA EN EL PROYECTO:
    // ------------------------------------------------------------
    // 1. Desacopla la lógica de negocio del almacenamiento.
    //    Las clases que usan el repositorio no necesitan saber cómo se guardan los datos,
    //    solo qué operaciones pueden realizar (agregar, eliminar, buscar, listar).
    //
    // 2. Estandariza operaciones CRUD básicas.
    //    Todas las entidades del proyecto se gestionan de manera homogénea.
    //
    // 3. Uso de Generics.
    //    La interfaz funciona para cualquier tipo T que implemente IIdentificable.
    //    Ejemplos:
    //        RepositorioEnMemoria<Producto>
    //        RepositorioEnMemoria<Empleado>
    //    Esto evita duplicación de código y hace el sistema más flexible.
    //
    // 4. Facilita el mantenimiento y las pruebas.
    //    Permite crear repositorios simulados (Mocks) o reemplazar la implementación
    //    por otra (como base de datos o archivos) sin tocar la lógica existente.
    //
    // En resumen:
    // Esta interfaz actúa como la base del manejo de datos en TechControl, asegurando
    // un diseño modular, limpio y fácil de extender.
    internal interface IRepositorio<T> where T : IIdentificable
    {
        // Agrega una entidad del tipo T al repositorio.
        void Agregar(T entidad);

        // Elimina la entidad cuyo Id coincida con el valor dado.
        void Eliminar(string id);

        // Busca y devuelve la entidad con el Id especificado.
        // Devuelve null si no existe coincidencia.
        T BuscarPorId(string id);

        // Devuelve una lista con todas las entidades almacenadas.
        List<T> ListarTodos();
    }
}