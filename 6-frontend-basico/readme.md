# Ruta de Aprendizaje para Frontend Básico

## Paso 0: Introducción al Desarrollo Frontend

- **Frontend vs Backend**: Comprender las diferencias entre frontend y backend en el desarrollo web.
- **Ecosistema Frontend**: Conocer las tecnologías principales del desarrollo frontend (HTML, CSS, JavaScript).
- **Navegadores Web**: Entender cómo funcionan los navegadores y cómo interpretan el código frontend.
- **Herramientas de Desarrollo**: Familiarizarse con las herramientas de desarrollo del navegador (DevTools).
- **Control de Versiones**: Aprender los fundamentos de Git para el control de versiones.
- **Editores de Código**: Configurar un editor de código como Visual Studio Code para el desarrollo frontend.

## Paso 1: Fundamentos de HTML

1. **Estructura Básica**: Aprender la estructura básica de un documento HTML.
2. **Elementos HTML**: Conocer los elementos HTML más comunes y su uso.
3. **Semántica HTML**: Entender la importancia de la semántica en HTML5.
4. **Formularios**: Aprender a crear formularios y sus diferentes tipos de inputs.
5. **Multimedia**: Incorporar imágenes, audio y video en páginas web.
6. **Accesibilidad**: Comprender los principios básicos de accesibilidad web.
7. **SEO Básico**: Aprender prácticas básicas de SEO en la estructura HTML.

### Tarea Práctica

- Crear una página web personal con información sobre ti, incluyendo una foto, una breve biografía y un formulario de contacto.
- Asegurarte de usar elementos semánticos adecuados y considerar la accesibilidad.

## Paso 2: Fundamentos de CSS

1. **Selectores CSS**: Dominar los diferentes tipos de selectores CSS.
2. **Modelo de Caja**: Comprender el modelo de caja en CSS.
3. **Layout**: Aprender sobre posicionamiento, float y display.
4. **Flexbox**: Dominar el uso de Flexbox para layouts flexibles.
5. **Grid**: Aprender a usar CSS Grid para layouts complejos.
6. **Responsive Design**: Implementar diseño responsivo con media queries.
7. **Animaciones y Transiciones**: Crear animaciones y transiciones básicas con CSS.

### Tarea Práctica

- Estilizar la página web personal creada en el paso anterior.
- Implementar un diseño responsivo que se adapte a móviles, tablets y desktops.
- Añadir algunas animaciones sutiles (por ejemplo, en hover de botones).

## Paso 3: JavaScript Básico

1. **Sintaxis Básica**: Aprender la sintaxis básica de JavaScript.
2. **Variables y Tipos de Datos**: Comprender los diferentes tipos de datos en JavaScript.
3. **Operadores**: Dominar los operadores aritméticos, de comparación y lógicos.
4. **Estructuras de Control**: Aprender sobre if/else, switch, bucles (for, while).
5. **Funciones**: Comprender cómo definir y usar funciones.
6. **Arrays y Objetos**: Trabajar con arrays y objetos en JavaScript.
7. **DOM Manipulation**: Aprender a manipular el DOM con JavaScript.
8. **Eventos**: Manejar eventos del usuario (click, submit, etc.).

### Tarea Práctica

- Añadir interactividad a la página web personal:
  - Implementar un formulario de contacto con validación en JavaScript.
  - Crear una galería de imágenes interactiva.
  - Añadir un modo oscuro que se pueda activar/desactivar con un botón.

## Paso 4: JavaScript Avanzado

1. **Scope y Closures**: Entender el alcance de las variables y closures.
2. **This Keyword**: Comprender el funcionamiento de 'this' en diferentes contextos.
3. **Prototypes y Herencia**: Aprender sobre la herencia basada en prototipos.
4. **ES6+ Features**: Dominar características modernas como arrow functions, destructuring, spread/rest operators.
5. **Asincronía**: Comprender callbacks, promesas y async/await.
6. **Módulos**: Aprender a trabajar con módulos ES6.
7. **Manejo de Errores**: Implementar manejo de errores efectivo.
8. **Patrones de Diseño**: Conocer patrones comunes como Módulo, Observer, Singleton.

### Tarea Práctica

- Refactorizar el JavaScript de la página web personal:
  - Usar ES6+ features donde sea apropiado.
  - Implementar la carga asíncrona de datos (por ejemplo, para la galería de imágenes).
  - Organizar el código en módulos.
  - Aplicar al menos un patrón de diseño (por ejemplo, el patrón Módulo para encapsular funcionalidad).

## Paso 5: JavaScript en el Navegador y Buenas Prácticas

1. **Event Loop**: Comprender cómo funciona el event loop en JavaScript.
2. **Rendimiento**: Aprender técnicas de optimización de rendimiento.
3. **Storage**: Trabajar con localStorage y sessionStorage.
4. **AJAX y Fetch API**: Realizar peticiones HTTP asíncronas.
5. **Cross-Browser Compatibility**: Manejar diferencias entre navegadores.
6. **Debugging**: Dominar técnicas de debugging en el navegador.
7. **Seguridad Frontend**: Conocer vulnerabilidades comunes y cómo prevenirlas.

### Tarea Práctica

- Optimizar la página web personal:
  - Implementar lazy loading para imágenes.
  - Usar localStorage para guardar preferencias del usuario (por ejemplo, el modo oscuro).
  - Añadir una funcionalidad que requiera una petición AJAX (por ejemplo, cargar posts de un blog).

## Paso 6: Sass (Syntactically Awesome Style Sheets)

1. **Sintaxis**: Aprender la sintaxis de Sass (tanto SCSS como Sass).
2. **Variables**: Usar variables para mantener estilos consistentes.
3. **Nesting**: Anidar selectores para escribir CSS más limpio.
4. **Partials e Imports**: Organizar el código CSS en múltiples archivos.
5. **Mixins**: Crear mixins para reutilizar grupos de declaraciones CSS.
6. **Funciones**: Utilizar y crear funciones en Sass.
7. **Herencia**: Usar @extend para compartir propiedades entre selectores.
8. **Operadores**: Realizar cálculos en Sass.

### Tarea Práctica

- Refactorizar los estilos de la página web personal usando Sass:
  - Organizar los estilos en múltiples archivos parciales.
  - Usar variables para colores, fuentes y tamaños comunes.
  - Crear mixins para media queries y estilos repetitivos.
  - Implementar un sistema de grilla simple usando funciones y mixins de Sass.

## Paso 7: TypeScript

1. **Sintaxis Básica**: Aprender la sintaxis de TypeScript, incluyendo tipos (`type`), interfaces (`interface`) y clases.
2. **Tipos**: Usar tipos básicos como `number`, `string`, `boolean`, y tipos más complejos como `array`, `tuple`, `enum` y `union`.
3. **Interfaces y Tipos Personalizados**: Definir interfaces y tipos personalizados. Diferencias clave entre ambos:

   - **Interfaces**: Son extensibles, es decir, pueden ser extendidas o combinadas (usando `extends`), lo que las hace útiles para diseñar contratos que serán implementados por clases o describir objetos.
   - **Tipos (`type`)**: Permiten descripciones más complejas como unir (`Union Types`) o intersectar (`Intersection Types`) varios tipos. No son extensibles directamente como las interfaces, pero permiten combinar tipos mediante operadores lógicos.

   **Ejemplo**:

   ```typescript
   // Type
   type UserType = {
   	name: string;
   	age: number;
   };

   // Interface
   interface UserInterface {
   	name: string;
   	age: number;
   }

   // Interfaces pueden extenderse
   interface Admin extends UserInterface {
   	permissions: string[];
   }
   ```

4. **Clases y Herencia**: Crear clases, implementar herencia y utilizar modificadores de acceso (`public`, `private`, `protected`).

   **Ejemplo**:

   ```typescript
   class Person {
   	constructor(public name: string, private age: number) {}
   	public greet() {
   		console.log(`Hello, my name is ${this.name}`);
   	}
   }

   class Employee extends Person {
   	constructor(name: string, age: number, public jobTitle: string) {
   		super(name, age);
   	}
   }
   ```

5. **Generics**: Implementar funciones y clases genéricas para manejar tipos dinámicos de manera segura.

   **Ejemplo**:

   ```typescript
   function getArray<T>(items: T[]): T[] {
   	return new Array<T>().concat(items);
   }

   let numberArray = getArray<number>([1, 2, 3]);
   let stringArray = getArray<string>(["a", "b", "c"]);
   ```

6. **Módulos y Namespaces**: Organizar el código en módulos y namespaces, separando responsabilidades y facilitando el mantenimiento.

7. **Tipos Avanzados**: Usar `Intersection Types`, `Union Types`, `Type Guards` y `Type Assertions` para construir tipos más avanzados.

   **Ejemplo de Union Type**:

   ```typescript
   type Shape = "circle" | "square" | "triangle";
   ```

8. **Decoradores**: Aplicar decoradores a clases, propiedades y métodos para añadir funcionalidad adicional.

9. **Promesas y Tipos Asíncronos**: Manejar promesas y la sintaxis `async/await` con los tipos adecuados.

   **Ejemplo**:

   ```typescript
   async function fetchData(): Promise<string> {
   	return "data";
   }
   ```

### Diferencia entre `type` e `interface`

- **Interfaces** son más adecuadas para estructurar objetos, especialmente en el contexto de clases y objetos que puedan necesitar ser extendidos en el futuro.
- **Types** permiten definir cualquier tipo, como tipos primitivos o combinaciones complejas con unión (`Union Types`) e intersección (`Intersection Types`). Son más flexibles cuando se trata de trabajar con tipos complejos que no siempre están basados en objetos.

### Operadores de Tipos

1. **`keyof`**: Extrae las claves de un objeto o interfaz como un tipo. Esto es útil cuando quieres restringir los valores de un tipo a solo las claves de otro tipo.

   **Ejemplo**:

   ```typescript
   interface User {
   	name: string;
   	age: number;
   	email: string;
   }

   // El tipo 'UserKey' ahora es 'name' | 'age' | 'email'
   type UserKey = keyof User;

   // Esto solo acepta las claves del objeto User
   function getUserProperty(user: User, key: UserKey) {
   	return user[key];
   }
   ```

2. **`typeof`**: Se utiliza para obtener el tipo de una variable o función. Es útil cuando quieres inferir el tipo de una constante existente sin tener que duplicar el tipo manualmente.

   **Ejemplo**:

   ```typescript
   const person = {
   	name: "John",
   	age: 30,
   };

   // Type 'PersonType' será equivalente a { name: string; age: number; }
   type PersonType = typeof person;

   // Se puede usar para tipar otras variables
   const newPerson: PersonType = {
   	name: "Jane",
   	age: 25,
   };
   ```

3. **`in`**: Se usa en los tipos de mapeo para iterar sobre cada propiedad de un tipo existente y generar un nuevo tipo.

   **Ejemplo**:

   ```typescript
   type Status = "success" | "error" | "loading";

   type StatusMap = {
   	[K in Status]: boolean;
   };

   // StatusMap ahora es equivalente a:
   // {
   //   success: boolean;
   //   error: boolean;
   //   loading: boolean;
   // }
   ```

4. **`as`**: Utilizado para realizar una conversión de tipo explícita. A veces es útil para cambiar temporalmente el tipo de una variable.

   **Ejemplo**:

   ```typescript
   let someValue: any = "Hello, world!";
   let strLength: number = (someValue as string).length;
   ```

---

### Tarea Práctica

- Refactorizar una aplicación en JavaScript usando TypeScript:
  - Reemplazar los archivos `.js` por `.ts` y definir los tipos correctos en funciones y variables.
  - Crear interfaces para describir objetos complejos usados en la aplicación.
  - Aplicar `Generics` en funciones que manejan distintos tipos de datos.
  - Usar operadores avanzados como `keyof` para limitar tipos basados en claves de objetos.
  - Implementar una clase con herencia para modelar las entidades principales de la aplicación.
  - Usar `async/await` con tipado asíncrono para manejar operaciones de red (API requests).

---

Con este enfoque, estarás utilizando la potencia completa de TypeScript, creando un código más seguro, robusto y mantenible.

## Proyecto Final: Portfolio Personal Interactivo

Desarrollar un portfolio personal completo que muestre tus habilidades en HTML, CSS, JavaScript y Sass. El proyecto debe incluir:

1. Página de Inicio:

   - Introducción personal con animaciones sutiles.
   - Navegación interactiva.

2. Sección de Proyectos:

   - Galería de proyectos con filtros interactivos.
   - Modal o página individual para cada proyecto con más detalles.

3. Sección de Habilidades:

   - Visualización interactiva de tus habilidades (por ejemplo, gráficos animados).

4. Blog:

   - Listado de entradas de blog con paginación.
   - Página individual para cada entrada.

5. Formulario de Contacto:

   - Con validación en tiempo real y envío asíncrono.

6. Características Adicionales:

   - Modo oscuro/claro con toggle y persistencia.
   - Diseño totalmente responsivo.
   - Animaciones y transiciones fluidas.
   - Lazy loading para imágenes y contenido.

7. Optimización:

   - Garantizar un buen rendimiento (usar herramientas como Lighthouse).
   - Implementar buenas prácticas de SEO.

Pasos de Implementación:

1. Planificar la estructura y el diseño del portfolio.
2. Crear la estructura HTML semántica.
3. Estilizar el portfolio usando Sass, implementando un diseño responsivo.
4. Añadir interactividad y funcionalidades dinámicas con JavaScript.
5. Implementar características avanzadas como el modo oscuro y la carga lazy.
6. Optimizar el rendimiento y la accesibilidad.
7. Realizar pruebas y depuración en diferentes navegadores y dispositivos.
8. Desplegar el portfolio en una plataforma de hosting (por ejemplo, GitHub Pages).

Este proyecto te permitirá aplicar todos los conceptos aprendidos a lo largo de la ruta de aprendizaje, resultando en un portfolio profesional que demuestre tus habilidades en desarrollo frontend.
