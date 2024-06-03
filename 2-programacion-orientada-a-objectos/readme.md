# Ruta de aprendizaje POO (programacion orientada a objetos) ( Consola )

## Paso 1: Introduccion a la POO

- Definición de POO: Investiga qué es la Programación Orientada a Objetos.
- Pilares de POO: Investigar cuales son los pilares.
- Clases y Objetos: Aprende la diferencia entre una clase y un objeto en POO.
- Atributos y Métodos: Comprende qué son los atributos (variables) y métodos (funciones) de una clase.

### Tarea de Práctica:

- Crea una clase llamada Persona con atributos como `nombre`, `edad`, y métodos como `MostrarInformacion()`

- Crea 5 objetos (instancias) diferentes de la clase `Persona` y utiliza sus métodos para mostrar información.

### Tarea de Práctica 2

- Crea una clase Empleado con los siguientes atributos: `nombre`, `apellido`, `salario`, `fechaContratacion`.
- Implementa métodos para calcular el salario anual de un empleado, calcular el número de años de antigüedad y mostrar toda la información del empleado.

## Paso 2: Herencia y Polimorfismo

1. **Herencia**: Entender cómo una clase puede heredar atributos y métodos de otra clase.
2. **Clases Base y Derivadas**: Comprender la relación entre una clase base y sus clases derivadas, y cómo extender funcionalidades mediante la herencia.

## Tarea de Práctica:

- Define una clase base `Vehiculo` con atributos como `marca`, `modelo` y `año`, y un método `ObtenerInformacion()` que imprima la información del vehículo.

- Crea clases derivadas como Automovil, Motocicleta y Camioneta, que hereden de Vehiculo y sobrescribe el método ObtenerInformacion() para incluir información específica de cada tipo de vehículo.

## Paso 3: Encapsulación y Abstracción

### Tema: Encapsulación

1. **Encapsulación**: Aprender cómo ocultar los detalles internos de una clase y exponer una interfaz para interactuar con ella.
2. **Propiedades**: Entender cómo usar propiedades para controlar el acceso a los atributos de una clase.

### Tarea de Práctica:

- Crea la clase `Automovil` la cual tendra 5 atributos:
  - CantidadRuedas: sera accesible por cualquiera.
  - Color: sera accesible solo dentro de esa clase y para acceder a ella habra que usar metodos get y set.
  - cantidadPuertas: sera accesible dentro de la clase y sus hijos pero no se podra acceder desde fuera.
  - Motor: sera accesible solo desde esta clase y no habran metodos para acceder a ella.
  - Propietario: sera accesible por cualquiera.
- Demostrar con codigo que cada caso se cumple.

## Paso 4: Polimorfismo e Interfaces

1. **Polimorfismo**: Comprender cómo los objetos de diferentes clases pueden ser tratados de manera uniforme.

- tipos de polimorfismo:
  - Polimorfismo de sobrecarga
  - Polimorfismo de sobrescritura

2. **Interfaces**: Aprender cómo definir y utilizar interfaces para definir comportamientos comunes entre clases.

### Tarea de Práctica:

- Definir una interfaz `IVehiculo` con métodos como `Arrancar()` y `Detener()`
- implementarla en clases como `Automovil`, `Motocicleta`.

## Paso 5: Sobrecarga de Métodos y Constructores

1. **Sobrecarga de Métodos**: Entender cómo definir múltiples métodos con el mismo nombre pero diferentes parámetros.
2. **Constructores**: Aprender cómo definir múltiples constructores en una clase para permitir diferentes formas de inicialización de objetos.

### Tarea de Práctica:

- Sobrecargar el constructor de la clase `Persona` para permitir la creación de objetos con diferentes conjuntos de parámetros. (se creativo).
- Implementar un metodo que implemente sobrecarga llamado: `Comunicarse()`
- 
## Paso 6: Clase Abstracta vs Interfaces

**Tema: Clase Abstracta vs Interfaces**

### Concepto de Clase Abstracta:
Una clase abstracta es una clase que no puede ser instanciada directamente y puede contener métodos abstractos (métodos sin implementación) y métodos concretos (métodos con implementación). Las clases abstractas se utilizan para proporcionar una estructura común y definir un conjunto de métodos que deben ser implementados por las clases derivadas.

### Concepto de Interface:
Una interfaz define un contrato que especifica un conjunto de métodos y propiedades que una clase debe implementar. A diferencia de las clases abstractas, las interfaces solo pueden contener definiciones de métodos y propiedades, pero no pueden proporcionar implementaciones. Las interfaces se utilizan para definir un comportamiento común que puede ser compartido por diferentes clases, independientemente de su jerarquía de herencia.

### Tareas de Práctica:

1. Crear una clase abstracta `FiguraGeometrica` que contenga un método abstracto `CalcularArea()` y un método concreto `ImprimirInformacion()` que imprima información general sobre la figura geométrica.

2. Definir una interfaz `IDibujable` que contenga un método `Dibujar()` para representar gráficamente la figura geométrica.

3. Implementar la clase `Cuadrado` que herede de `FiguraGeometrica` e implemente la interfaz `IDibujable`. En la clase `Cuadrado`, proporcionar una implementación para el método `CalcularArea()` y para el método `Dibujar()`.

4. Implementar la clase `Circulo` que herede de `FiguraGeometrica` e implemente la interfaz `IDibujable`. En la clase `Circulo`, proporcionar una implementación para el método `CalcularArea()` y para el método `Dibujar()`.

Este ejercicio te ayudará a comprender la diferencia entre clases abstractas e interfaces y cómo se utilizan en la programación orientada a objetos para proporcionar una estructura común y definir comportamientos específicos. ¡Adelante con la práctica!


## Paso 7: Tipos Genéricos

### Tema: Tipos Genéricos

1. **Concepto de Tipos Genéricos**: Entender qué son los tipos genéricos y cómo permiten la reutilización de código con diferentes tipos de datos.
2. **Clases y Métodos Genéricos**: Aprender a definir clases y métodos genéricos que pueden trabajar con tipos de datos específicos determinados en tiempo de compilación.

### Tareas de Práctica:

- Crear una clase `Lista<T>` que implemente una lista genérica que puede contener elementos de cualquier tipo.
- Implementar métodos genéricos en la clase `Lista<T>` para agregar elementos, eliminar elementos y obtener elementos de la lista.

El uso de tipos genéricos proporciona flexibilidad y reutilización de código al permitir que las clases y métodos trabajen con diferentes tipos de datos sin necesidad de escribir código específico para cada tipo. ¡Explora y practica con los tipos genéricos para mejorar tu comprensión de la programación orientada objetos.

## Paso 8: Manejo de Excepciones

1. **Manejo de Excepciones**: Aprender a identificar y manejar errores y excepciones que pueden ocurrir durante la ejecución de un programa.
2. **Try-Catch**: Entender cómo utilizar bloques try-catch para manejar excepciones y controlar el flujo del programa.

### Tarea de Práctica:

- Implementar un método que realice una operación aritmética y manejar la excepción si se produce un error (por ejemplo, división por cero).

## Paso 9: Programación Orientada a Objetos Avanzada

### Tema: Patrones de Diseño y SOLID

1. **Patrones de Diseño**: Conocer algunos patrones de diseño comunes, como Singleton, Factory, Observer, etc., y entender cuándo y cómo aplicarlos.
2. **SOLID**: Familiarizarse con los principios SOLID (Single Responsibility, Open/Closed, Liskov Substitution, Interface Segregation, Dependency Inversion) y aprender a aplicarlos en el diseño de clases.

### Tarea de Práctica:

- Implementar el patrón Singleton en una clase utilitaria.
- Refactorizar una clase existente para cumplir con los principios SOLID.

## Descripción del Proyecto: Sistema de Gestión de Empleados

### Descripción:

El proyecto consiste en desarrollar un sistema de gestión de empleados para una empresa. Se utilizarán los principios de la programación orientada a objetos en C# para crear un sistema modular y flexible. El sistema permitirá registrar, actualizar, eliminar y mostrar información sobre los empleados de la empresa. Se aplicarán los siguientes pasos para lograr un diseño robusto y escalable:

- **Paso 1: Introducción a la POO y C#**: Definición de las clases base como `Persona` y `Empleado` con atributos y métodos básicos.
- **Paso 2: Herencia y Polimorfismo**: Creación de clases derivadas como `EmpleadoTiempoCompleto` y `EmpleadoTiempoParcial` para representar diferentes tipos de empleados.
- **Paso 3: Encapsulación y Abstracción**: Encapsulación de los atributos de las clases para garantizar el principio de encapsulamiento y uso de propiedades para controlar el acceso a los atributos.
- **Paso 4: Polimorfismo y Interfaces**: Definición de la interfaz `IGestorEmpleado` para gestionar las operaciones relacionadas con los empleados y su implementación en una clase `GestorEmpleado`.
- **Paso 5: Sobrecarga de Métodos y Constructores**: Sobrecarga del constructor de la clase `Empleado` y implementación de métodos sobrecargados para actualizar la información de los empleados.
- **Paso 6: Manejo de Excepciones**: Implementación de manejo de excepciones en los métodos que pueden generar errores, como la eliminación de un empleado inexistente.
- **Paso 7: Programación Orientada a Objetos Avanzada**: Implementación de patrones de diseño como Singleton para manejar la conexión a una base de datos y refactorización del código para cumplir con los principios SOLID.
- **Paso 8: Tipos Genéricos**: Creación de una clase genérica `Lista<T>` para almacenar objetos de cualquier tipo y definición de métodos genéricos para manipular la lista de empleados.
- **Paso 9: Aplicación de Principios SOLID**: Refactorización del código para cumplir con los principios de diseño SOLID (Single Responsibility, Open/Closed, Liskov Substitution, Interface Segregation, Dependency Inversion).
- **Paso 10 (Opcional): Clase para CRUD Genérico**: Creación de una clase genérica `CRUD<T>` que implemente métodos para realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) en una lista de objetos de tipo `T`.

Este proyecto tiene como objetivo crear un sistema completo y funcional para gestionar los empleados de una empresa, aplicando los conceptos de POO y C# aprendidos en cada paso.

## Requerimientos:

### Registro de Empleados:

- El sistema debe permitir registrar nuevos empleados proporcionando su nombre, edad y salario.
- Se deben validar los datos proporcionados para garantizar que sean válidos y coherentes.

### Actualización de Información:

- Se debe proporcionar la opción de actualizar la información de un empleado existente, incluyendo su nombre, edad y salario.
- Las actualizaciones deben reflejarse correctamente en la lista de empleados.

### Eliminación de Empleados:

- Debe ser posible eliminar un empleado existente de la lista de empleados.
- Se deben proporcionar controles para evitar la eliminación accidental de empleados.

### Mostrar Detalles de Empleados:

- El sistema debe permitir mostrar los detalles de todos los empleados almacenados en la lista.

- Los detalles mostrados deben incluir el nombre, edad y salario de cada empleado.

### Diseño Orientado a Objetos:

- El sistema debe seguir los principios de la programación orientada a objetos (POO), utilizando clases, herencia, encapsulamiento, polimorfismo, interfaces y tipos genéricos según sea necesario.
  Aplicación de Principios SOLID:

- Se debe aplicar los principios de diseño SOLID (Single Responsibility, Open/Closed, Liskov Substitution, Interface Segregation, Dependency Inversion) para garantizar un diseño flexible y mantenible.

### Clase para Operaciones CRUD Genéricas (Opcional):

- Se puede implementar una clase genérica CRUD<T> que contenga métodos para realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) en una lista de objetos de tipo T.
- Esta clase proporcionaría funcionalidad genérica para operaciones de CRUD en cualquier tipo de dato.

### Observaciones:

- El sistema debe ser modular y flexible, permitiendo futuras expansiones y modificaciones fácilmente.
- Se debe prestar especial atención a la validación de datos y al manejo de excepciones para garantizar la robustez y la integridad de los datos del sistema.
- Se recomienda seguir las mejores prácticas de codificación y documentación para facilitar el mantenimiento y la colaboración en el proyecto.
