using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTransportControl
{
    namespace POOTechControl
    {
        // Clase estática que agrupa métodos de utilidad reutilizables.
        // Al ser estática:
        // - No se pueden crear instancias de ella
        // - Solo contiene métodos estáticos
        internal static class Utilidades
        {
            // Método genérico que permite buscar un elemento por su Nombre
            // dentro de una lista genérica.
            //
            // 🔹 static:
            //   Es obligatorio para que el método pueda ser un método de extensión.
            //
            // 🔹 <T>:
            //   Hace que el método sea genérico y funcione con cualquier tipo.
            //
            // 🔹 this List<T> lista:
            //   - Convierte este método en un MÉTODO DE EXTENSIÓN.
            //   - Permite llamar al método como si fuera propio de List<T>.
            //   - Ejemplo:
            //       listaEmpleados.BuscarPorNombre("Carlos");
            //
            // 🔹 string nombre:
            //   Valor que se usará como criterio de búsqueda.
            public static T BuscarPorNombre<T>(this List<T> lista, string nombre)

                // Restricción genérica:
                // Se exige que T implemente INombrable para garantizar
                // que exista la propiedad Nombre.
                //
                // Sin esta restricción, el compilador no sabría si T
                // tiene o no la propiedad Nombre, y el código fallaría.
                where T : INombrable
            {
                // FirstOrDefault recorre la lista elemento por elemento
                // y devuelve:
                // - El PRIMER elemento cuyo Nombre coincida con el valor buscado
                // - null si no se encuentra ningún elemento
                //
                // x representa cada elemento de la lista durante el recorrido.
                return lista.FirstOrDefault(x =>

                    // Se compara el Nombre del elemento con el nombre buscado.
                    // StringComparison.OrdinalIgnoreCase permite:
                    // - Ignorar mayúsculas y minúsculas
                    // - Hacer la búsqueda más flexible y amigable
                    x.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)
                );
            }
        }
    }

}
