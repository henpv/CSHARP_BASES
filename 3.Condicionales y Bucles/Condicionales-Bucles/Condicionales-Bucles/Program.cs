using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Condicionales_Bucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // =========================================================================
            // VARIABLES BOOLEANAS
            // =========================================================================

            // Para declarar una variable booleana se utiliza el tipo de dato bool
            bool haceFrio;

            // Una variable booleana solo puede tomar dos valores: true o false
            haceFrio = true;

            // Al imprimir la variable, se mostrará uno de los dos valores posibles
            Console.WriteLine(haceFrio);

            // El operador ! (negación lógica) permite invertir el valor de una variable booleana
            Console.WriteLine(!haceFrio);

            // =========================================================================
            // OPERADORES DE COMPARACIÓN
            // =========================================================================
            /*
             * Igual que            -->  ==
             * Diferente que        -->  !=
             * Menor que            -->  <
             * Menor o igual que    -->  <=
             * Mayor que            -->  >
             * Mayor o igual que    -->  >=
             */

            // =========================================================================
            // OPERADORES LÓGICOS
            // =========================================================================
            /*
             * Y lógico (AND)   -->  &&  --> Todas las condiciones deben ser verdaderas
             * O lógico (OR)    -->  ||  --> Al menos una condición debe ser verdadera
             */

            // =========================================================================
            // ESTRUCTURAS DE CONTROL DE FLUJO
            // =========================================================================
            /*
             * Las estructuras de control de flujo permiten alterar el orden secuencial
             * de ejecución de un programa.
             * Gracias a ellas, el programa puede:
             * - Tomar decisiones (if, else, switch)
             * - Repetir tareas (while, do-while, for)
             * 
             * Esto evita que el código se ejecute siempre de arriba hacia abajo
             * de forma rígida.
             */

            // =========================================================================
            // ESTRUCTURA CONDICIONAL IF
            // =========================================================================
            // Evalúa una condición booleana (true o false) y ejecuta acciones
            // dependiendo del resultado.

            Console.WriteLine("\nEjemplo de estructura condicional IF:");

            int edad = 15;
            Console.WriteLine("Vamos a evaluar si eres mayor de edad");

            // Se evalúa la condición: ¿edad es mayor o igual a 18?
            if (edad >= 18)
            {
                // Este bloque se ejecuta si la condición es true
                Console.WriteLine("Adelante, puedes ingresar porque eres mayor de edad");
            }
            else
            {
                // El else es opcional y se ejecuta cuando la condición es false
                Console.WriteLine("No puedes ingresar, no eres mayor de edad");
            }

            /*
             * NOTA:
             * Si el cuerpo del if o del else tiene una sola línea,
             * se pueden omitir las llaves, utilizando el operador lambda.
             * 
             * if (edad >= 18) => Console.WriteLine("Adelante, puedes ingresar porque eres mayor de edad");
             * 
             */

            // =========================================================================
            // IF CON MÚLTIPLES VALIDACIONES Y OPERADORES LÓGICOS
            // =========================================================================

            int edades;
            string carne;

            Console.Write("\nIntroduce tu edad: "); // \n genera un salto de línea
            edades = Int32.Parse(Console.ReadLine());
            // ReadLine siempre devuelve un string, por eso es necesario convertirlo a int

            Console.Write("¿Tiene carné de conducir? (s/n): ");
            carne = Console.ReadLine();

            // El operador && obliga a que TODAS las condiciones sean verdaderas
            if (edades >= 18 && carne == "s")
            {
                Console.WriteLine("Cumples con la edad y tienes carné para conducir.");
            }
            // El operador || permite que al menos UNA condición sea verdadera
            else if (edades >= 18 || carne == "s")
            {
                Console.WriteLine("Cumples solo uno de los requisitos y no puedes conducir.");
            }
            else
            {
                Console.WriteLine("No cumples con la edad ni tienes carné de conducir.");
            }

            // =========================================================================
            // IF ANIDADOS
            // =========================================================================
            // Un if puede contener otro if dentro de su bloque para realizar
            // validaciones adicionales.

            bool esMiembro = true;
            int categoria;

            // Cuando una variable es booleana, no es necesario compararla con true
            if (esMiembro)
            {
                Console.Write("La categoría de su membresía es 1 o 2: ");
                categoria = Int32.Parse(Console.ReadLine());

                if (categoria == 1)
                    Console.WriteLine("Su categoría es Regular.");
                else
                    Console.WriteLine("Su categoría es Premium.");
            }
            else
            {
                Console.WriteLine("Usted no es miembro.");
            }

            // =========================================================================
            // ESTRUCTURA CONDICIONAL SWITCH
            // =========================================================================
            /*
             * - Cada case debe ser único
             * - Solo funciona con tipos como int, char y string
             * - Cada case debe finalizar con break
             * - También se puede usar return o throw
             */
            Console.WriteLine("\nEjemplo de estructura condicional SWITCH:");

            Console.Write("Elige un medio de transporte (bicicleta, carro, tren, moto, avion): ");
            string medioTransporte = Console.ReadLine();

            switch (medioTransporte) // Expresión de control
            {
                case "bicicleta":
                    Console.WriteLine("Elegiste Bicicleta.");
                    break;

                case "carro":
                    Console.WriteLine("Elegiste Carro, velocidad media 70 km/h.");
                    break;

                case "tren":
                    Console.WriteLine("Elegiste Tren, velocidad media 150 km/h.");
                    break;

                case "moto":
                    Console.WriteLine("Elegiste Moto, velocidad media 50 km/h.");
                    break;

                case "avion":
                    Console.WriteLine("Elegiste Avión, velocidad media 400 km/h.");
                    break;

                default:
                    // Se ejecuta si no coincide ningún case
                    Console.WriteLine("El medio de transporte no es válido.");
                    break;
            }

            // =========================================================================
            // BUCLES
            // =========================================================================
            /*
             * Un bucle (o ciclo) permite repetir una secuencia de instrucciones
             * mientras una condición se cumpla.
             * 
             * Tipos más comunes:
             * - while: número indeterminado de repeticiones
             * - do-while: se ejecuta al menos una vez
             * - for: número conocido de repeticiones
             */

            // =========================================================================
            // BUCLE WHILE
            // =========================================================================
            // Se utiliza cuando no se sabe cuántas veces se repetirá el código

            string respuesta = "no";

            while (respuesta != "si")
            {
                Console.Write("Estás dentro del bucle WHILE, ¿deseas salir? (si/no): ");
                respuesta = Console.ReadLine();
            }

            Console.WriteLine("Has salido del bucle WHILE.");

            // =========================================================================
            // EJEMPLO PRÁCTICO: ADIVINAR UN NÚMERO
            // =========================================================================

            Random random = new Random();
            int numero = random.Next(1, 100);
            int valor = 0;
            int intentos = 0;

            while (valor != numero)
            {
                intentos++;
                Console.Write("Adivina el número (1 a 100): ");
                valor = Int32.Parse(Console.ReadLine());

                if (valor < numero)
                    Console.WriteLine("El número ingresado es menor.");
                else if (valor > numero)
                    Console.WriteLine("El número ingresado es mayor.");
                else
                    Console.WriteLine($"¡Felicidades! Adivinaste en {intentos} intentos. Número: {numero}");
            }

            // =========================================================================
            // BUCLE DO - WHILE
            // =========================================================================
            // A diferencia del while, el do-while se ejecuta al menos una vez
            // aunque la condición sea falsa.

            Console.WriteLine("\nEjemplo de bucle DO-WHILE:");

            int numeroValidar = 100;

            do
            {
                Console.WriteLine($"El número a validar tiene un valor de {numeroValidar}.");
            }
            while (numeroValidar < 10);

            // =========================================================================
            // BUCLE FOR
            // =========================================================================
            /*
             * El bucle for se utiliza cuando se conoce de antemano
             * cuántas veces se debe repetir una instrucción.
             *
             * Su estructura es:
             * for (inicialización; condición; incremento/decremento)
             *
             * 1. Inicialización: se ejecuta una sola vez al inicio
             * 2. Condición: se evalúa antes de cada iteración
             * 3. Incremento: se ejecuta al final de cada iteración
             */

            Console.WriteLine("\nEjemplo de bucle FOR:");

            // En este ejemplo el bucle se ejecutará 5 veces
            for (int i = 1; i <= 5; i++)
            {
                // i es la variable de control del bucle
                Console.WriteLine($"Iteración número: {i}");
            }

            // =========================================================================
            // BUCLE FOREACH
            // =========================================================================
            /*
             * El bucle foreach se utiliza para recorrer colecciones
             * como arreglos (arrays), listas u otras estructuras.
             *
             * A diferencia del for:
             * - No se usa un índice manual
             * - Es más legible
             * - Evita errores de desbordamiento
             */

            Console.WriteLine("\nEjemplo de bucle FOREACH:");

            // Declaración de un arreglo de strings
            string[] mediosTransporte = { "Bicicleta", "Carro", "Tren", "Moto", "Avión" };

            // El foreach recorre automáticamente cada elemento del arreglo
            foreach (string medio in mediosTransporte)
            {
                // 'medio' representa el elemento actual de la colección
                Console.WriteLine($"Medio de transporte: {medio}");
            }

            /*
             * El foreach:
             * - Avanza automáticamente al siguiente elemento
             * - No permite modificar el tamaño de la colección
             * - Es ideal cuando solo se necesita leer los valores
             */

        }
    }
}