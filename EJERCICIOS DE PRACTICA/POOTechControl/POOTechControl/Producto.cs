using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTechControl
{
    // Clase abstracta que representa un producto genérico dentro del sistema.
    // Define propiedades y comportamientos comunes para cualquier tipo de producto.
    // Implementa IIdentificable, ICalculable e INombrable para asegurar
    // que todos los productos tengan Id, Nombre y un cálculo asociado.
    internal abstract class Producto : IIdentificable, ICalculable, INombrable
    {
        // Campo privado donde se almacena el código interno del producto.
        private string _codigo;

        // Propiedad pública para acceder al código.
        // Incluye validación para impedir valores nulos o vacíos.
        public string Codigo
        {
            get => _codigo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El código no puede estar vacío.");
                _codigo = value;
            }
        }

        // Implementación de la propiedad Id de IIdentificable.
        // En este diseño, el Id del producto es exactamente su Código.
        public string Id => Codigo;

        // Campo interno que guarda el nombre del producto.
        private string _nombre;

        // Propiedad pública para acceder o asignar el nombre.
        // Valida que no se asignen valores vacíos o solo espacios.
        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El Nombre no puede estar vacío.");
                _nombre = value;
            }
        }

        // Campo privado donde se almacena el precio base del producto.
        private double _precioBase;

        // Propiedad pública que permite consultar o modificar el precio base.
        // Incluye validación para asegurar un valor positivo.
        public double PrecioBase
        {
            get => _precioBase;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El precio base debe ser mayor a cero.");
                _precioBase = value;
            }
        }

        // Indica si el producto se encuentra activo.
        // El valor solo puede modificarse desde dentro de la clase.
        public bool Activo { get; private set; }

        // Constructor que inicializa el producto con los datos requeridos.
        // Cada asignación aplica sus respectivas validaciones.
        public Producto(string codigo, string nombre, double precioBase)
        {
            Codigo = codigo;
            Nombre = nombre;
            PrecioBase = precioBase;

            // Todos los productos se crean activos inicialmente.
            Activo = true;
        }

        // Método para activar el producto.
        public void Activar()
        {
            Activo = true;
        }

        // Método para desactivar el producto.
        public void Desactivar()
        {
            Activo = false;
        }

        // Implementación de Calcular() de ICalculable.
        // Delegado al método que calcula el precio final del producto.
        public double Calcular()
        {
            return CalcularPrecioFinal();
        }

        // Método abstracto que las clases derivadas deben implementar.
        // Define la lógica para obtener el precio final según el tipo de producto.
        public abstract double CalcularPrecioFinal();
    }
}

