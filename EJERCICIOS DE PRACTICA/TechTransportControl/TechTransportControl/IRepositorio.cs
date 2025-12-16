using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTransportControl
{
    // Interfaz genérica que define el contrato básico que debe cumplir
    // cualquier repositorio dentro del sistema.
    //
    // Un repositorio se encarga de gestionar el almacenamiento y acceso
    // a las entidades, sin importar cómo o dónde se guardan.
    //
    // El uso de genéricos permite reutilizar esta interfaz para distintos
    // tipos de entidades (Vehículo, Conductor, Ruta, etc.).
    //
    // La restricción "where T : IIdentificable" garantiza que cualquier
    // entidad manejada por el repositorio tenga un Id único, necesario
    // para buscar y eliminar elementos de forma segura.
    internal interface IRepositorio<T> where T : IIdentificable
    {
        // Agrega una nueva entidad al repositorio.
        // La implementación concreta decidirá cómo se almacena
        // (en memoria, base de datos, archivo, etc.).
        void Agregar(T entidad);

        // Elimina una entidad del repositorio usando su identificador único.
        // No es necesario pasar el objeto completo, basta con el Id.
        void Eliminar(string Id);

        // Busca y devuelve una entidad cuyo Id coincida con el valor recibido.
        // Si no existe ninguna entidad con ese Id, retorna null.
        T BuscarPorId(string Id);

        // Devuelve una lista con todas las entidades almacenadas en el repositorio.
        // Permite recorrer, filtrar o mostrar los datos sin acceder directamente
        // a la estructura interna del repositorio.
        List<T> ListarTodos();
    }
}