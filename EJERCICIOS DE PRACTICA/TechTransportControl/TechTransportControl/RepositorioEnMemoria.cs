using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTransportControl
{
    // Implementación concreta de un repositorio genérico en memoria.
    //
    // ⚠️ IMPORTANTE:
    // Aunque la interfaz IRepositorio<T> ya exige que T implemente IIdentificable,
    // la clase genérica TAMBIÉN debe declarar esta restricción si necesita usar
    // directamente miembros de esa interfaz (como la propiedad Id).
    //
    // Además, se agrega la restricción `class` para garantizar que:
    // - T sea un tipo de referencia
    // - Se pueda devolver `null` cuando una búsqueda no encuentre resultados
    // - Evitar el error CS0403 del compilador
    internal class RepositorioEnMemoria<T> : IRepositorio<T>
        where T : class, IIdentificable
    {
        // Lista interna que almacena las entidades en memoria.
        //
        // Esta lista es el "almacén real" del repositorio.
        // Todas las operaciones (agregar, buscar, eliminar, listar)
        // trabajan directamente sobre esta colección.
        //
        // Se utiliza List<T> porque:
        // - Es simple
        // - Es eficiente para este escenario
        // - Es suficiente para una implementación en memoria
        private List<T> ListaT = new List<T>();

        // Implementación del método Agregar definido en la interfaz IRepositorio.
        //
        // Recibe una entidad del tipo genérico T y la guarda en la lista interna.
        public void Agregar(T entidad)
        {
            // Se agrega directamente la entidad a la lista.
            //
            // No se realizan validaciones aquí porque:
            // - Se asume que la entidad ya fue validada al construirse
            // - El repositorio solo se encarga de almacenar y recuperar datos
            ListaT.Add(entidad);
        }

        // Implementación del método BuscarPorId del contrato IRepositorio.
        //
        // Recibe un Id (string) y devuelve:
        // - La entidad cuyo Id coincida
        // - null si no se encuentra ninguna coincidencia
        public T BuscarPorId(string Id)
        {
            // Se recorre manualmente la lista (sin LINQ)
            // para encontrar la entidad cuyo Id coincida.
            //
            // Esto es posible porque la restricción
            // `where T : IIdentificable` garantiza que T
            // posee la propiedad Id.
            foreach (T elemento in ListaT)
            {
                if (elemento.Id == Id)
                    return elemento;
            }

            // Si no se encontró ninguna entidad, se retorna null.
            //
            // Esto solo es válido porque T está restringido a `class`,
            // es decir, un tipo de referencia.
            return null;
        }

        // Implementación del método Eliminar del contrato IRepositorio.
        //
        // Elimina una entidad a partir de su Id.
        public void Eliminar(string Id)
        {
            // Primero se intenta localizar la entidad en el repositorio.
            T entidad = BuscarPorId(Id);

            // Solo se elimina si la entidad existe.
            // Esto evita errores al intentar eliminar un objeto inexistente.
            if (entidad != null)
                ListaT.Remove(entidad);
        }

        // Devuelve todas las entidades almacenadas en el repositorio.
        //
        // Se retorna la lista completa para permitir:
        // - Recorridos con foreach
        // - Búsquedas adicionales
        // - Operaciones de presentación (mostrar en consola, etc.)
        public List<T> ListarTodos()
        {
            return ListaT;
        }
    }


}
