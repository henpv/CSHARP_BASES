# Proyecto: Sistema de Figuras Geométricas (Propiedades, Herencia y Polimorfismo)

Proyecto práctico en **C#** enfocado en reforzar:

-   Herencia
-   Clases abstractas
-   Propiedades con validación
-   Polimorfismo
-   Sustitución de Liskov (LSP)

## 📌 Objetivo

Diseñar un sistema donde exista una clase abstracta `Figura`, y cada
figura concreta (Círculo, Rectángulo, Triángulo) implemente:

-   Cálculo del área
-   Propiedades con validaciones geométricamente correctas

### Clases implementadas

#### 🧱 **Figura (abstracta)**

Métodos abstractos: - `CalcularArea()`

Propiedad con validación: - `Nombre` (no puede ser vacío)

#### ⚪ **Círculo**

Propiedades: - `Radio` (debe ser \> 0)

Cálculo del área:

``` csharp
Math.PI * Radio * Radio
```

#### ▭ **Rectángulo**

Propiedades: - `Base` - `Altura`\
Ambas deben ser \> 0

Área:

``` csharp
Base * Altura
```

#### 🔺 **Triángulo**

Propiedades: - `LadoA`, `LadoB`, `LadoC`\
- Cumplen la desigualdad triangular.

Área:\
Usa la fórmula de Herón.

### 🧪 Polimorfismo

Permite almacenar todas las figuras en una sola lista:

``` csharp
List<Figura> figuras = new List<Figura>();
```

Y calcular áreas sin saber el tipo concreto:

``` csharp
foreach (var f in figuras)
{
    Console.WriteLine(f.CalcularArea());
}
```

### ✔ Liskov aplicado

Cada figura **se comporta de manera válida** cuando se trata como
`Figura`, sin romper reglas internas.

------------------------------------------------------------------------

## 📁 Estructura recomendada

    /ProyectoFiguras
     ├── Figura.cs
     ├── Circulo.cs
     ├── Rectangulo.cs
     ├── Triangulo.cs
     └── Program.cs

------------------------------------------------------------------------

## 🚀 Aprendizajes logrados

-   Validación correcta mediante propiedades.
-   Herencia bien aplicada para reutilizar código.
-   Polimorfismo para generalizar comportamientos.
-   Liskov garantizando coherencia en las clases derivadas.
