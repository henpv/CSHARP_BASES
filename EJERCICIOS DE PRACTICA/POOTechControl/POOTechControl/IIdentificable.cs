using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTechControl
{
    // -----------------------------------------------------------
    //  IIdentificable
    // -----------------------------------------------------------
    // Esta interfaz se utiliza para garantizar que cualquier clase
    // que se quiera guardar en el repositorio genérico T
    // tenga obligatoriamente un identificador único (string Id).
    //
    // ¿Por qué es NECESARIA en este proyecto?
    //
    // 1. El repositorio genérico funciona con tipos T.
    //    Para poder buscar, eliminar o acceder por ID,
    //    el repositorio debe poder leer la propiedad "Id".
    //
    // 2. Sin esta interfaz, el repositorio NO SABRÍA si T tiene Id.
    //    Es decir, en repositorios genéricos no se puede asumir
    //    que todas las clases tienen la misma propiedad,
    //    así que necesitamos una interfaz que garantice esta obligación.
    //
    // 3. Producto y Empleado implementan esta interfaz.
    //    Así el repositorio puede tratar ambos como "IIdentificable",
    //    sin importar que sean clases completamente diferentes.
    //
    // 4. También permite aplicar el Principio de Sustitución (LSP):
    //    Cualquier objeto que implemente IIdentificable puede ser usado
    //    en RepositorioEnMemoria<T>.
    //
    // 5. Permite escribir código genérico reutilizable.
    //    Ejemplo: BuscarPorId() funciona igual para productos o empleados.
    //
    // En resumen:
    // ➜ Esta interfaz define un CONTRATO mínimo para que el repositorio
    //    pueda trabajar correctamente con cualquier tipo de entidad.
    //
    // -----------------------------------------------------------
    internal interface IIdentificable
    {
        // Propiedad de solo lectura.
        // Cada clase que implemente esta interfaz debe definir cómo obtener su Id.
        string Id { get; }
    }
}