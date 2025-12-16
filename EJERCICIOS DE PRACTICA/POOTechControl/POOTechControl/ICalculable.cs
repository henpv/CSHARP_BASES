using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTechControl
{
    // Interfaz que define que una entidad puede realizar un cálculo numérico.
    // Se utiliza para unificar productos y empleados bajo un mismo comportamiento:
    // ambos pueden devolver un valor calculado (precio final o salario final).
    //
    // Gracias a esta interfaz, se puede crear una lista con distintos tipos
    // (empleados y productos) y tratarlos de forma homogénea.
    internal interface ICalculable
    {
        // Método que realiza el cálculo principal del objeto.
        // Para un empleado: calcula el salario total.
        // Para un producto: calcula el precio final.
        double Calcular();

        // Nombre del objeto, usado para mostrar información en pantalla.
        // Puede ser el nombre de un producto o el nombre de un empleado.
        string Nombre { get; }
    }
}
