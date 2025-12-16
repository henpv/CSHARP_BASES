# Ejercicio de Programación Orientada a Objetos --- POOTechControl

Este proyecto propone un ejercicio integral para practicar múltiples
conceptos avanzados de **C# y POO**, incluyendo:

-   Clases abstractas\
-   Interfaces\
-   Programación genérica (Generics)\
-   Restricciones de tipos (where T : ...)\
-   Repositorios genéricos\
-   Relación entre clases padre e interfaces\
-   Implementaciones concretas

------------------------------------------------------------------------

## 🎯 Objetivo del ejercicio

Crear un sistema básico para gestionar entidades dentro de un proyecto
llamado **POOTechControl**, aplicando buenas prácticas de arquitectura y
uso adecuado de POO.

El estudiante deberá:

1.  Crear una clase padre abstracta.
2.  Implementar varias clases hijas.
3.  Definir interfaces (incluyendo una interfaz genérica de
    repositorio).
4.  Usar programación genérica para manejar entidades de forma flexible.
5.  Implementar un repositorio en memoria totalmente funcional.
6.  Aplicar una interfaz IIdentificable que obligue a que todas las
    entidades tengan un Id.
7.  Usar la restricción `where T : IIdentificable`.

------------------------------------------------------------------------

## 🧩 Detalles del ejercicio

### 1. **Crear una interfaz `IIdentificable`**

Define el contrato para cualquier entidad que deba tener un Id único.

### 2. **Crear una clase abstracta `EntidadBase`**

Debe implementar la interfaz anterior y agregar comportamiento común.

### 3. **Crear 2 o 3 clases hijas**

Por ejemplo: - Producto\
- Empleado\
- Cliente

Cada clase debe extender `EntidadBase` y agregar sus propias
propiedades.

### 4. **Crear la interfaz genérica de repositorio**

`IRepositorio<T>`\
Esta interfaz debe incluir operaciones CRUD esenciales:

-   Agregar\
-   Eliminar\
-   BuscarPorId\
-   ListarTodos

Y debe incluir la restricción:

    where T : IIdentificable

### 5. **Crear el repositorio en memoria**

Clase: `RepositorioEnMemoria<T>`

Implementa la interfaz anterior y administra una lista interna de
elementos.

### 6. **Ejemplo de uso**

Crear un repositorio de productos, agregar productos y buscarlos por Id.

------------------------------------------------------------------------

## 📘 Resultado esperado

Al finalizar el ejercicio tendrás:

-   Un sistema modular y escalable.
-   Un repositorio genérico reutilizable.
-   Clase base + clases hijas bien estructuradas.
-   Implementación real de programación genérica.
-   Código limpio siguiendo buenas prácticas.

Este ejercicio te prepara para trabajar arquitectura real en C#.

------------------------------------------------------------------------

## 📦 Entregables del ejercicio

-   Interfaces (`IIdentificable`, `IRepositorio<T>`)
-   Clase abstracta (`EntidadBase`)
-   Clases hijas
-   Repositorio genérico funcionando
-   Programa de prueba (opcional)

------------------------------------------------------------------------

## 📅 Nivel del ejercicio

**Intermedio--Avanzado**\
Recomendado para estudiantes que quieren dominar POO moderna en C#.

------------------------------------------------------------------------

¡Listo para empezar! 🚀
