using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTechControl
{
    // Esta clase implementa un repositorio genérico en memoria.
    // Funciona con cualquier tipo T que implemente la interfaz IIdentificable.
    // Esto garantiza que cada entidad tenga un Id único que permita buscarla o eliminarla.
    internal class RepositorioEnMemoria<T> : IRepositorio<T>
        where T : IIdentificable // Restricción: solo acepta tipos con propiedad 'Id'
    {
        // Lista interna donde se almacenan todas las entidades del repositorio.
        // Funciona como una base de datos temporal en memoria.
        private List<T> listaT = new List<T>();

        // Agrega una nueva entidad del tipo T al repositorio.
        public void Agregar(T entidad)
        {
            listaT.Add(entidad);
        }

        // Busca una entidad dentro del repositorio usando su Id (string).
        // Retorna la primera coincidencia o null si no existe.
        public T BuscarPorId(string id)
        {
            // x representa cada objeto dentro de la lista.
            // Se compara x.Id con el id ingresado.
            return listaT.FirstOrDefault(x => x.Id == id);
        }

        // Elimina una entidad del repositorio a partir de su Id.
        public void Eliminar(string id)
        {
            // Primero buscamos si la entidad existe.
            T entidad = BuscarPorId(id);

            // Si la entidad fue encontrada (distinta de null)
            if (entidad != null)
            {
                // Se elimina de la lista interna.
                listaT.Remove(entidad);
            }
        }

        // Devuelve la lista completa de entidades almacenadas.
        // Se utiliza para mostrar todas las entidades registradas.
        public List<T> ListarTodos()
        {
            return listaT;
        }


    }
}
