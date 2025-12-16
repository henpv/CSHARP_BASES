# Proyecto: Sistema de Empleados (Herencia, Propiedades y Polimorfismo)

Este proyecto implementa un sistema básico de empleados utilizando
**C#**, diseñado para practicar:

-   Herencia
-   Clases abstractas
-   Polimorfismo
-   Sustitución de Liskov (LSP)
-   Uso avanzado de propiedades con validación
-   Sobrescritura de métodos

## 📌 Objetivo

Crear un sistema donde exista una **clase base abstracta `Empleado`**, y
distintas clases derivadas que calculan el salario según su tipo.

### Clases implementadas

#### 🧱 **Empleado (abstracta)**

-   Propiedades con validación:
    -   `Nombre`\
    -   `Identificacion`\
    -   `SalarioBase`\
    -   `Activo` (solo lectura, cambiado con métodos)
-   Métodos:
    -   `Activar()`\
    -   `Desactivar()`
-   Método abstracto:
    -   `CalcularSalario()`

#### 👨‍💼 **EmpleadoTiempoCompleto**

-   Calcula el salario sumando un bono fijo.
-   Cumple Liskov porque puede sustituir sin problemas a `Empleado`.

#### 🧑‍💻 **EmpleadoPorHoras**

-   Calcula salario multiplicando horas trabajadas × valor por hora.
-   Utiliza propiedades con validación para evitar valores negativos.

### 🧪 Polimorfismo

El programa usa una lista de empleados:

``` csharp
List<Empleado> empleados = new List<Empleado>();
```

Cada empleado es añadido sin importar su tipo, y se invoca
polimórficamente:

``` csharp
foreach (var emp in empleados)
{
    Console.WriteLine(emp.CalcularSalario());
}
```

### ✔ Resultado esperado

Un diseño orientado a objetos limpio, fácil de extender y que aplica los
principios base de la POO.

------------------------------------------------------------------------

## 📁 Estructura recomendada

    /ProyectoEmpleados
     ├── Empleado.cs
     ├── EmpleadoTiempoCompleto.cs
     ├── EmpleadoPorHoras.cs
     └── Program.cs

------------------------------------------------------------------------

## 🚀 Aprendizajes logrados

-   Uso de clases abstractas --- definir comportamientos comunes.
-   Herencia --- crear tipos de empleados reutilizando lógica base.
-   Polimorfismo --- tratar varios tipos como uno solo.
-   Encapsulación con propiedades --- proteger datos sensibles.
-   Liskov --- sustitución segura y coherente.
