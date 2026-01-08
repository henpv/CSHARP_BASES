// =======================================================
// SINTAXIS BÁSICA DE C#
// Repositorio de fundamentos – versión ordenada y comentada
// =======================================================

// -------------------------------------------------------
// USING
// -------------------------------------------------------
// Los using permiten importar namespaces (bibliotecas)
// para poder usar sus clases y métodos sin escribir
// el nombre completo.
using System;


// -------------------------------------------------------
// NAMESPACE
// -------------------------------------------------------
// Un namespace es un contenedor lógico de clases.
// Ayuda a organizar el código y evitar conflictos de nombres.
namespace SintaxisBasica
{
    // ---------------------------------------------------
    // CLASE PRINCIPAL
    // ---------------------------------------------------
    // Las clases son plantillas que definen atributos y métodos.
    // La clase Program contiene el método Main, punto de inicio
    // de la aplicación.
    internal class Program
    {
        // ------------------------------------------------
        // MÉTODO MAIN
        // ------------------------------------------------
        // Punto de entrada del programa.
        static void Main(string[] args)
        {
            // --------------------------------------------
            // COMENTARIOS Y ESTRUCTURA
            // --------------------------------------------
            // Un bloque de código está delimitado por { }
            // y define un ámbito (scope).

            // Una sentencia es una instrucción que finaliza
            // normalmente con punto y coma (;).

            // Comentario de una sola línea

            /*
             * Comentario de múltiples líneas
             * útil para explicaciones largas
             */

            // --------------------------------------------
            // SALIDA POR CONSOLA
            // --------------------------------------------
            // WriteLine es un método de la clase Console
            // que imprime texto en la consola.
            Console.WriteLine("Hello World");
            //INTERPOLACIÓN DE STRING
            int anios = 36;
            Console.WriteLine($"Yo tengo una edad de {anios}");
            Console.WriteLine("Yo tengo una edad de {0}",anios);

            // --------------------------------------------
            // TIPOS DE DATOS
            // --------------------------------------------
            // Tipos por VALOR: almacenan directamente el dato
            // (int, double, bool, char, struct)

            // Tipos por REFERENCIA: almacenan una referencia
            // a una dirección de memoria (string, class, array)


            // --------------------------------------------
            // VARIABLES
            // --------------------------------------------
            // Una variable es un espacio en memoria que puede
            // cambiar su valor durante la ejecución.

            // Declaración
            int edad;

            // Inicialización
            edad = 28;

            // Declaración e inicialización
            int edad2 = 30;


            // --------------------------------------------
            // DECLARACIONES EXPLÍCITAS E IMPLÍCITAS
            // --------------------------------------------
            // Explícita: se indica el tipo de dato
            int numeroExplicito = 10;

            // Implícita: el compilador infiere el tipo
            var numeroImplicito = 20; // sigue siendo int


            // --------------------------------------------
            // OPERADORES ARITMÉTICOS
            // --------------------------------------------
            // Permiten realizar operaciones matemáticas
            // básicas entre valores numéricos.

            int suma = 5 + 3;                 // Adición
            int resta = 5 - 3;                // Sustracción
            int multiplicacion = 5 * 3;       // Multiplicación
            int division = 10 / 2;            // División (entera si ambos son int)
            int modulo = 10 % 3;              // Residuo de la división

            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Resta: {resta}");
            Console.WriteLine($"Multiplicación: {multiplicacion}");
            Console.WriteLine($"División: {division}");
            Console.WriteLine($"Módulo: {modulo}");

            // --------------------------------------------
            // OPERADORES DE ASIGNACIÓN COMPUESTA
            // --------------------------------------------
            // Son atajos que combinan una operación
            // aritmética con una asignación.

            int contador = 10;

            contador += 5; // contador = contador + 5  -> 15
            contador -= 3; // contador = contador - 3  -> 12
            contador *= 2; // contador = contador * 2  -> 24
            contador /= 4; // contador = contador / 4  -> 6
            contador %= 4; // contador = contador % 4  -> 2

            // Incremento y decremento
            contador++; // equivalente a contador = contador + 1
            contador--; // equivalente a contador = contador - 1



            // --------------------------------------------
            // OPERADORES DE COMPARACIÓN
            // --------------------------------------------
            bool esMayor = 10 > 5;    // true
            bool esMenor = 10 < 5;    // false
            bool esIgual = 10 == 10;  // true
            bool esDiferente = 10 != 5; // true
            bool mayorOIgual = 10 >= 10; // true
            bool menorOIgual = 5 <= 10;  // true


            // --------------------------------------------
            // CONVERSIONES DE DATOS
            // --------------------------------------------
            // Convertir datos significa transformar un valor
            // de un tipo de dato a otro compatible.

            // --------------------------------------------
            // CONVERSIÓN IMPLÍCITA
            // --------------------------------------------
            // Ocurre automáticamente cuando no hay pérdida
            // de información (conversiones seguras).

            int numeroInt = 100;
            double numeroDouble = numeroInt; // int -> double

            // --------------------------------------------
            // CONVERSIÓN EXPLÍCITA (CASTING)
            // --------------------------------------------
            // Debe indicarse manualmente cuando existe
            // posible pérdida de información.

            double precio = 19.99;
            int precioEntero = (int)precio; // pierde decimales

            // --------------------------------------------
            // CONVERSIÓN MEDIANTE MÉTODOS (Convert)
            // --------------------------------------------
            // Útil cuando se trabaja con strings o entradas
            // de usuario.

            string textoNumero = "123";
            int numeroConvertido = Convert.ToInt32(textoNumero);

            // --------------------------------------------
            // PARSE Y TRY PARSE
            // --------------------------------------------
            // Parse lanza excepción si falla la conversión
            int numeroParseado = int.Parse("456");

            // TryParse evita excepciones y devuelve true/false
            bool conversionExitosa = int.TryParse("789", out int resultado);

            // resultado solo tiene valor si conversionExitosa es true



            // --------------------------------------------
            // CONSTANTES
            // --------------------------------------------
            // Una constante es un valor que no puede cambiar
            // durante la ejecución del programa.

            const double PI = 3.1416;
            const int DIAS_SEMANA = 7;

            // PI = 3.15; // ❌ Error de compilación


            // --------------------------------------------
            // FIN DEL PROGRAMA
            // --------------------------------------------
            Console.WriteLine("Fin del programa");
        }
    }
}

