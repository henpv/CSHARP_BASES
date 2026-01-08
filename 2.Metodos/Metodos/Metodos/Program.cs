using System;

namespace Metodos
{
    internal class Program
    {
        /*
         * ============================
         * MÉTODO MAIN (PUNTO DE ENTRADA)
         * ============================
         *
         * - Main es el punto de inicio de toda aplicación en C#
         * - Es static, por lo tanto pertenece a la clase y no a una instancia
         * - Desde Main solo se pueden llamar directamente métodos static
         *   o métodos de instancia creando previamente un objeto
         * - void indica que el método no retorna ningún valor
         * - string[] args permite recibir argumentos desde la línea de comandos
         */
        static void Main(string[] args)
        {
            // Para que un método se ejecute, siempre debe ser llamado

            int resultado1 = SumaNumeros();
            Console.WriteLine("El resultado de la suma sin parámetros es: " + resultado1);

            int resultado2 = SumaNumerosParametros(5, 15);
            Console.WriteLine($"El resultado de la suma con parámetros es: {resultado2}");

            SumaNumerosSinRetorno(2);

            // Llamado a métodos con expresión lambda (=>)
            Console.WriteLine(SumaNumerosParametrosLambda(7, 9));
            MostrarSuma(20, 11);


            //Ejemplos de Sobrecarga de Métodos
            Console.WriteLine(Sumares(1,2));
            Console.WriteLine(Sumares(1,2).GetType());

            Console.WriteLine(Sumares(5.5,2));
            Console.WriteLine(Sumares(5.5,2).GetType());

            Console.WriteLine(Sumares(1,2,3));

            Console.WriteLine(Mostrar("Texto", 23));
            Console.WriteLine(Mostrar(23, "Texto"));

            //Ejemplos de un mismo metodo con parametros opcionales
            Console.WriteLine(Multiplicacion(5));
            Console.WriteLine(Multiplicacion(5,5));
            Console.WriteLine(Multiplicacion(5,5,5));

        }

        /*
         * ============================
         * CONCEPTO GENERAL DE MÉTODOS
         * ============================
         *
         * - Un método es un conjunto de instrucciones que realizan una tarea específica
         * - Un método NO se ejecuta hasta que es llamado
         * - Todos los métodos deben estar dentro de una clase
         * - Se debe indicar:
         *      • Tipo de retorno (o void)
         *      • Nombre del método
         *      • Parámetros (opcionales)
         *
         * Estructura:
         * TipoRetorno NombreMetodo(parámetros)
         * {
         *     Cuerpo del método
         * }
         */

        // ============================
        // MÉTODOS SIN PARÁMETROS
        // ============================

        static int SumaNumeros()
        {
            int num1 = 2;
            int num2 = 5;
            return num1 + num2;
        }

        // ============================
        // MÉTODOS CON PARÁMETROS
        // ============================

        static int SumaNumerosParametros(int num1, int num2)
        {
            return num1 + num2;
        }

        /*
         * Un método void no retorna ningún valor.
         * Se usa cuando la acción principal es ejecutar algo
         * como imprimir en pantalla o modificar un estado.
         */
        static void SumaNumerosSinRetorno(int num1)
        {
            int num2 = 5;
            Console.WriteLine(
                "El resultado de la suma es: {0}",
                num1 + num2
            );
        }

        // ============================
        // MÉTODOS CON EXPRESIÓN LAMBDA
        // ============================

        /*
         * El operador => es una forma abreviada de definir métodos
         * que contienen una sola expresión.
         * Funciona igual que usar llaves y return.
         */
        static int SumaNumerosParametrosLambda(int num1, int num2) => num1 + num2;

        static void MostrarSuma(int a, int b) => Console.WriteLine(a + b);

        // ============================
        // ÁMBITO / CONTEXTO / ALCANCE
        // ============================

        /*
         * El ámbito define desde dónde una variable, método o clase
         * puede ser accedida.
         *
         * Regla de oro:
         * Una variable solo existe dentro del bloque { }
         * donde fue declarada y en sus bloques internos.
         */

        static void EjemploMetodo()
        {
            int numero = 10; // Variable local
            Console.WriteLine(numero); // ✔ válida
        }
        // Console.WriteLine(numero); ❌ ERROR: fuera del ámbito

        static void EjemploBloque()
        {
            if (true)
            {
                int valor = 5; // Solo existe dentro del if
                Console.WriteLine(valor); // ✔
            }

            // Console.WriteLine(valor); ❌ ERROR
        }

        // ============================
        // VARIABLES DE CLASE (CAMPOS)
        // ============================

        class Persona
        {
            string nombre; // Variable de clase (campo)

            void AsignarNombre()
            {
                nombre = "Juan";
            }

            void MostrarNombre()
            {
                Console.WriteLine(nombre);
            }
        }

        /*
         * Diferencia entre variable local y variable de clase:
         * - Una variable local puede ocultar una variable de clase
         * - La variable local tiene prioridad dentro de su ámbito
         */
        class Ejemplo
        {
            int numero = 10;

            void Metodo()
            {
                int numero = 5; // Variable local
                Console.WriteLine(numero); // 5
            }

            void OtroMetodo()
            {
                Console.WriteLine(numero); // 10
            }
        }

        // ============================
        // ÁMBITO DE PARÁMETROS
        // ============================

        static int Sumar(int a, int b)
        {
            // a y b solo existen dentro de este método
            return a + b;
        }

        // ============================
        // ÁMBITO DE MÉTODOS
        // ============================

        class Calculadora
        {
            void MetodoPrivado()
            {
                Console.WriteLine("Solo accesible desde esta clase");
            }

            public void MetodoPublico()
            {
                MetodoPrivado(); // ✔ permitido
            }
        }

        // ============================
        // SOBRECARGA DE MÉTODOS
        // ============================

        /*
         * La sobrecarga permite definir varios métodos con el mismo nombre
         * siempre que cambie su firma:
         * - Cantidad de parámetros
         * - Tipo de parámetros
         * - Orden de los parámetros
         */

        static int Sumares(int a, int b)
        {
            return a + b;
        }

        static int Sumares(int a, int b, int c)
        {
            return a + b + c;
        }

        static double Sumares(double a, double b)
        {
            return a + b;
        }

        static string Mostrar(string texto, int numero)
        {
            return texto + numero;
        }

        static string Mostrar(int numero, string texto)
        {
            return numero + texto;
        }

        /*
         * ❌ NO es sobrecarga:
         * Cambiar solo el tipo de retorno NO es válido
         */
        static int Calcular(int a, int b)
        {
            return a + b;
        }
        // static double Calcular(int a, int b) ❌ ERROR


        // ============================
        // SOBRECARGA DE MÉTODOS
        // ============================

        /*
         * La sobrecarga permite definir varios métodos con el mismo nombre
         * siempre que cambie su firma:
         * - Cantidad de parámetros
         * - Tipo de parámetros
         * - Orden de los parámetros
         */


        // ============================
        // PARÁMETROS OPCIONALES
        // ============================

        /*
         * Los párametros opscionales permiten imitar una sobrecarga de metodos
         * ya que uno, varios o todos los parametros que se le pasen al metodo
         * puden tener valores definidos y por lo tanto no es obligatorio permitirlo
         */

        //Al definir dos parametros opcionales con valores po defecto iguales a 1
        //el metodo no los pide obligatoriamiente, por lo tanto solamente
        //es obligatorio pasar el num1, los otros dos pueden o no enviarse
        //Como regla, los parametros opcionales siempre van depues de los parametros obligatorios
        static double Multiplicacion(double num1, double num2 = 1 , double num3 = 1 )
        {
            return num1 * num2 * num3;
        }
    }
}
