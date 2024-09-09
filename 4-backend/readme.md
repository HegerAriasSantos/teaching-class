PD: También puedes visitar la version en JAVA [click](./java/readme.md)

# Ruta de Aprendizaje para Manejar el Backend usando ASP.NET

## Paso 0: Introducción al Backend y HTTP

- **Backend vs Frontend**: Comprender las diferencias entre el backend y el frontend en el desarrollo web.
- **Protocolo HTTP**: Aprender los conceptos básicos del protocolo HTTP y su importancia en el desarrollo web.
- **Métodos HTTP**: Conocer los métodos HTTP más comunes y su uso en el desarrollo de APIs RESTful.
- **Códigos de Estado HTTP**: Entender los códigos de estado HTTP y su significado en las respuestas de servidor.
- **RESTful APIs**: Entender los principios de diseño de APIs RESTful y su implementación en el backend.
- **Seguridad en el Backend**: Conocer las prácticas de seguridad comunes en el desarrollo de aplicaciones backend.
- **Recursos Adicionales**: Para comprender todo lo anterior recomiendo la lectura del siguiente libro: [What Every Web Developer Should Know About HTTP](./recursos/what-every-web-developer-should-know-about-http.pdf)

## Paso 1: Introducción a ASP.NET

- **Definición de ASP.NET**: Investiga qué es ASP.NET y su propósito en el desarrollo web.
- **Historia y Evolución**: Aprende sobre la historia y evolución de ASP.NET, desde Web Forms hasta ASP.NET Core.
- **Entorno de Desarrollo**: Configura tu entorno de desarrollo con Visual Studio y .NET SDK.
- **Hola Mundo en ASP.NET**: Crea y ejecuta tu primera aplicación ASP.NET.

### Tarea de Práctica:

- Configura una aplicación ASP.NET Core desde cero.
- Crea un controlador simple con una action `helloWorld` que devuelva un mensaje "Hola Mundo".

## Paso 2: Fundamentos de ASP.NET Core

1. **Estructura del Proyecto**: Comprender la estructura básica de un proyecto ASP.NET Core.
2. **Configuración y Dependencias**: Aprende sobre el archivo `appsettings.json` y la inyección de dependencias en ASP.NET Core.
3. **Controladores y Rutas**: Entender cómo funcionan los controladores y las rutas en ASP.NET Core.
4. **Params en Rutas**: Utilizar parámetros en las rutas para manejar datos dinámicos.
5. **Query Params**: Aprender a manejar query params en las rutas de ASP.NET Core.

### Tarea de Práctica:

- Crea un controlador `ProductController` en donde se pondrán las acciones de CRUD.
- Implementa acción para mostrar una lista de productos, detalles de un producto, crear un nuevo producto y eliminar un producto todas estas acciones deben de mostrar su acción en texto, no devolver datos.
- Utiliza parámetros y query params en las rutas de tu controlador
- Configura la inyección de dependencias para acceder a los datos de los productos
- Configura una ruta personalizada `/product` en `Program.cs` para tu controlador `ProductController`.

controller example:

```csharp
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public string GetProducts()
        {
            return "Lista de Productos";
        }

        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return $"Detalles del Producto {id}";
        }

        [HttpPost]
        public string CreateProduct()
        {
            return "Crear un Nuevo Producto";
        }

        [HttpDelete("{id}")]
        public string DeleteProduct(int id)
        {
            return $"Eliminar Producto {id}";
        }
    }
}
```

## Paso 3: Modelos y Enlace de Datos

1. **Modelos**: Aprende a definir modelos en ASP.NET Core.
2. **Validación de Datos**: Implementa validación de datos en los modelos.
3. **Dtos y ViewModels**: Utiliza Data Transfer Objects y View Models para manejar datos en las vistas.

### Tarea de Práctica:

- Crea un modelo `Producto` con propiedades como `Nombre`, `precio` y `peso`.
- Implementa validación de datos en el modelo `Producto`.
- Crea un DTO (Data Transfer Object) para manejar la creación de productos.
- Crea validaciones personalizadas para el modelo `Producto`.
- Modifica el endpoint de creación de productos para manejar la validación de datos y obtener los datos del DTO.

### Example:

```csharp
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Weight { get; set; }
    }

    public class CreateProductDto
    {
        [Required]
        public string Name { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Weight { get; set; }
    }
}
```

## Paso 4: CRUD

1. **Operaciones CRUD**: Aprende a realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) usando una lista de `Productos`.
2. **Servicios y Repositorios**: Implementa servicios y patrones de repositorio para acceder a los datos, los datos serán almacenados en memoria usando una lista static en el repositorio.
3. **Agregar validaciones**: Implementa validaciones y manejo de errores en las operaciones CRUD.
4. **Controladores de API**: Diferencias entre controladores MVC y controladores de API.
5. **Routing y Endpoints**: Configuración de rutas y endpoints en una API.
6. **Serialization y Model Binding**: Manejo de JSON y enlace de modelos en APIs.

### Tarea de Práctica:

- Crea una API RESTful para manejar operaciones CRUD en la entidad `Product`.
- Configura rutas y endpoints para la API.
- Implementa serialization y validación de modelos en la API.
- Implementa servicios y repositorios para acceder a los datos de los productos (ojo el controlador llama al servicio y el servicio al repositorio, el repositorio es el que tiene la lista de productos)
- Implementa operaciones CRUD en la API para crear, leer, actualizar y eliminar productos.

## Paso 5: Autenticación y Autorización

1. **Identity en ASP.NET Core**: Configura Identity para la autenticación y gestión de usuarios.
2. **JWT y Autenticación basada en Tokens**: Implementa JWT para autenticación en APIs.

### Tarea de Práctica:

- Configura Identity en tu aplicación ASP.NET Core.
- Implementa autoriza acciones en el controlador `ProductController` basadas en token.
- Implementa autenticación basada en tokens usando JWT.
- Configura políticas de autorización para restringir el acceso a las operaciones CRUD de productos.
- Implementa un endpoint para generar tokens JWT y autenticar usuarios.
- Implementa un endpoint para registrar nuevos usuarios en la aplicación.

## Paso 6: Middleware y Servicios

1. **Middleware**: Comprender cómo funciona el middleware en ASP.NET Core.
2. **Servicios de Aplicación**: Aprende a registrar y utilizar servicios en ASP.NET Core.
3. **Inyección de Dependencias**: Utiliza la inyección de dependencias para acceder a servicios en controladores y middleware.
4. **Logging y Diagnóstico**: Configura logging y captura información de diagnóstico en tu aplicación.

### Tarea de Práctica:

- Implementa middleware personalizado para logging de solicitudes (puedes hacerlo como quieras, mandarlo por consola, construir un archivo txt o cualquier forma).
- Crea y registra un servicio personalizado para manejar lógica de negocio y configurar para ser un servicio injectable.
- Configura logging y captura información de diagnóstico.

# Proyecto Final: Sistema de Gestión de Compras

## Descripción

El proyecto consiste en desarrollar un sistema de gestión de compras utilizando ASP.NET Core. El sistema permitirá registrar, actualizar, eliminar y mostrar información sobre usuarios, productos y órdenes de compra. Además, se implementará un sistema de autenticación basado en JWT y todo se almacenará en memoria utilizando listas estáticas en los repositorios.

## Requerimientos

- **Autenticación por JWT**: Implementar autenticación utilizando JWT para asegurar las rutas de la API.
- **CRUD de Usuarios**: Funcionalidades para registrar, actualizar, eliminar y mostrar usuarios.
- **CRUD de Productos**: Funcionalidades para registrar, actualizar, eliminar y mostrar productos.
- **CRUD de Órdenes**: Funcionalidades para registrar, actualizar, eliminar y mostrar órdenes de compra.
- **Sistema de Compras**: Permitir a los usuarios realizar compras, registrando órdenes en el sistema.

## Diseño

- **Backend**: Utilizar ASP.NET Core para manejar la lógica de negocios y acceso a datos en memoria.
- **Autenticación y Autorización**: Implementar autenticación con JWT y autorización basada en roles.
- **APIs RESTful**: Proveer endpoints para manejar operaciones CRUD de usuarios, productos y órdenes.
- **Pruebas**: Escribir pruebas unitarias y de integración para asegurar la calidad del código.

## Observaciones

- **Modularidad**: Diseñar el sistema de forma modular para facilitar la expansión y mantenimiento.
- **Validación y Excepciones**: Implementar validación de datos y manejo de excepciones para robustez.
- **Documentación**: Seguir las mejores prácticas de documentación y comentarios en el código.

## Pasos de Implementación

1. **Configuración Inicial**: Configurar el proyecto y las dependencias necesarias.
2. **Estructura del Proyecto**: Definir la estructura básica del proyecto.
3. **Modelos y Repositorios en Memoria**: Crear modelos y configurar repositorios con listas estáticas.
4. **Operaciones CRUD**: Implementar operaciones CRUD para usuarios, productos y órdenes.
5. **Autenticación y Autorización**: Configurar JWT y roles de usuario.
6. **APIs RESTful**: Crear y documentar APIs RESTful.
7. **Middleware y Servicios**: Implementar middleware y servicios necesarios.
8. **Pruebas y Despliegue**: Escribir pruebas y desplegar la aplicación.

## Detalle de Implementación

### Paso 1: Configuración Inicial

- Crear un nuevo proyecto ASP.NET Core.
- Instalar paquetes necesarios:
  - `Microsoft.AspNetCore.Authentication.JwtBearer`
  - `Microsoft.AspNetCore.Identity`
  - `Microsoft.EntityFrameworkCore.InMemory`
  - `Swashbuckle.AspNetCore` (para documentación de API)

### Paso 2: Estructura del Proyecto

Organizar el proyecto en las siguientes carpetas:

- `Controllers`
- `Models`
- `Repositories`
- `Services`
- `Dtos`
- `Helpers`

### Paso 3: Modelos y Repositorios en Memoria

- **Modelos**: Crear clases para `User`, `Product` y `Order`.
- **Repositorios**: Implementar repositorios con listas estáticas para almacenar los datos en memoria.

```csharp
public static class UserRepository
{
    public static List<User> Users = new List<User>();
}

public static class ProductRepository
{
    public static List<Product> Products = new List<Product>();
}

public static class OrderRepository
{
    public static List<Order> Orders = new List<Order>();
}
```

### Paso 4: Operaciones CRUD

- Implementar controladores para manejar las operaciones CRUD.
- Crear servicios para encapsular la lógica de negocio.

### Paso 5: Autenticación y Autorización

- Configurar JWT en `Program.cs`:

```csharp
services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            // Configurar validación del token
        };
    });

```

- Crear controladores para manejar el registro y login de usuarios.

### Paso 6: APIs RESTful

- Crear endpoints para usuarios, productos y órdenes.
- Documentar APIs utilizando Swagger.

### Paso 7: Middleware y Servicios

- Implementar middleware para manejo de excepciones.
- Crear servicios para autenticación, autorización y lógica de negocios.

### Paso 8: Pruebas y Despliegue

- Escribir pruebas unitarias y de integración para asegurar la funcionalidad.
- Desplegar la aplicación en un entorno adecuado (por ejemplo, Azure o AWS).

## Ejemplo de Código

### Modelo de Usuario

```csharp
public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
}
```

### Controlador de Usuarios

```csharp
[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    [HttpPost("register")]
    public IActionResult Register(UserDto userDto)
    {
        // Lógica para registrar usuario
    }

    [HttpPost("login")]
    public IActionResult Login(LoginDto loginDto)
    {
        // Lógica para autenticar usuario y devolver JWT
    }

    // Otros métodos CRUD
}
```

### Configuración de JWT en Program.cs

```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddControllers();

    // Configurar JWT
    var key = Encoding.ASCII.GetBytes(Configuration["Jwt:Key"]);
    services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = Configuration["Jwt:Issuer"],
                ValidAudience = Configuration["Jwt:Issuer"],
                IssuerSigningKey = new SymmetricSecurityKey(key)
            };
        });

    services.AddSwaggerGen();
}

public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }

    app.UseRouting();
    app.UseAuthentication();
    app.UseAuthorization();
    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    });

    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
    });
}
```

Este diseño modular y paso a paso permitirá la construcción de un sistema robusto y escalable para la gestión de compras, utilizando prácticas y tecnologías modernas con ASP.NET Core.
