using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTechControl
{
    // Interfaz que representa a cualquier entidad que pueda ser identificada por un nombre.
    // Su propósito es permitir crear métodos genéricos que trabajen con objetos que tengan
    // un Nombre y un Id, sin importar la clase específica.
    //
    // Esta interfaz se usa, por ejemplo, en el método BuscarPorNombre, para garantizar
    // que cualquier objeto pasado tenga la propiedad Nombre disponible.
    internal interface INombrable
    {
        // Propiedad que representa el nombre visible del objeto.
        // Ejemplos: nombre de un empleado, nombre de un producto, etc.
        string Nombre { get; }

        // Propiedad para acceder al identificador único del objeto.
        // Puede ser un código, una identificación, un SKU, etc.
        string Id { get; }
    }
}
