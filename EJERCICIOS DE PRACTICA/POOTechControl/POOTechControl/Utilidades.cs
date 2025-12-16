using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTechControl
{
    // Clase estática que contiene funciones auxiliares para el proyecto.
    // Aquí se incluyen métodos que no pertenecen a una sola entidad,
    // sino que sirven de apoyo general al sistema.
    internal static class Utilidades
    {
        // Método genérico de extensión que permite buscar un elemento dentro de una lista
        // usando su propiedad "Nombre". Solo funciona en tipos que implementen INombrable.
        //
        // Parámetros:
        // - lista: la lista donde se hará la búsqueda.
        // - nombre: el texto que se quiere encontrar en la propiedad Nombre.
        //
        // Funcionamiento:
        // - Recorre la lista y devuelve el primer elemento cuyo Nombre coincida,
        //   ignorando mayúsculas/minúsculas.
        // - Si no encuentra coincidencias, devuelve null.
        //
        // Ejemplo de uso:
        // var coincidencia = Utilidades.BuscarPorNombre(repoEmpleados.ListarTodos(),"Carlos Pérez");

        public static T BuscarPorNombre<T>(this List<T> lista, string nombre)
            where T : INombrable
        {
            return lista.FirstOrDefault(x =>
                x.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        }
    }
}
