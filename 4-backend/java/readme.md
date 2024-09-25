# Ruta de Aprendizaje para Manejar el Backend usando Spring Boot

## Paso 0: Introducción al Desarrollo Backend y HTTP

- **Backend vs Frontend**: Comprender las diferencias entre backend y frontend en el desarrollo web.
- **Protocolo HTTP**: Aprender los conceptos básicos del protocolo HTTP y su importancia en el desarrollo web.
- **Métodos HTTP**: Conocer los métodos HTTP más comunes y su uso en el desarrollo de APIs RESTful.
- **Códigos de Estado HTTP**: Entender los códigos de estado HTTP y su significado en las respuestas del servidor.
- **APIs RESTful**: Comprender los principios de diseño de APIs RESTful y su implementación en el backend.
- **Seguridad en el Backend**: Conocer las prácticas de seguridad comunes en el desarrollo de aplicaciones backend.
- **Recursos Adicionales**: Para comprender todo lo anterior, recomiendo la lectura del siguiente libro: [What Every Web Developer Should Know About HTTP](../recursos/what-every-web-developer-should-know-about-http.pdf)

## Paso 1: Introducción a SQL

1. **Fundamentos de SQL**: Aprender sobre bases de datos, tablas y sintaxis básica de SQL.
2. **Operaciones CRUD**: Dominar las sentencias SELECT, INSERT, UPDATE y DELETE.
3. **Tipos de Datos**: Comprender los diferentes tipos de datos en SQL y cuándo usarlos.
4. **Restricciones**: Aprender sobre claves primarias, claves foráneas y otras restricciones.
5. **Joins**: Dominar los diferentes tipos de JOINs (INNER, LEFT, RIGHT, FULL).
6. **Agregaciones**: Aprender sobre GROUP BY, HAVING y funciones de agregación, ORDERBY y where.
7. **Indexación**: Comprender el concepto de indexación y su importancia para el rendimiento.
8. **Relaciones**: Dominar los diferentes tipos de relaciones (Uno a Uno, Uno a Muchos, Muchos a Muchos).

### Tarea Práctica

- Crear un esquema de base de datos simple para una librería (Libros, Autores, Clientes, Pedidos) con las tablas correspondientes y sus relaciones para hacerlo usar esta pagina que ayuda a crear diagramas [click](https://dbdiagram.io/d).
- Escribir consultas SQL para realizar operaciones CRUD en estas tablas.
- Escribir consultas complejas que involucren JOINs y agregaciones.

## Paso 2: Fundamentos de Spring Boot

1. **Spring Framework**: Comprender los fundamentos del Spring Framework y sus conceptos principales.
2. **Spring Boot**: Aprender qué es Spring Boot y cómo simplifica el desarrollo de aplicaciones Spring.
3. **Estructura del Proyecto**: Comprender la estructura de un proyecto Spring Boot.
4. **Inyección de Dependencias**: Aprender sobre la inyección de dependencias y cómo Spring la gestiona.
5. **Spring Boot Starters**: Comprender y utilizar varios starters de Spring Boot.
6. **application.properties**: Aprender a configurar tu aplicación usando application.properties.

### Tarea Práctica

- Configurar un nuevo proyecto Spring Boot utilizando Spring Initializer.
- Crear un endpoint REST simple de "Hola Mundo".
- Configurar propiedades de la aplicación (por ejemplo, puerto del servidor, conexión a la base de datos).

## Paso 3: Creación de APIs RESTful con Spring Boot

1. **Controladores REST**: Aprender a crear controladores REST en Spring Boot.
2. **Mapeo de Solicitudes**: Comprender las diferentes anotaciones de mapeo de solicitudes (@GetMapping, @PostMapping, etc.).
3. **Variables de Ruta y Parámetros de Solicitud**: Aprender a manejar variables de ruta y parámetros de solicitud.
4. **Cuerpo de la Solicitud**: Comprender cómo trabajar con cuerpos de solicitud en peticiones POST y PUT.
5. **Response Entity**: Aprender a utilizar ResponseEntity para controlar la respuesta HTTP.

### Tarea Práctica

- Crear un `LibroController` con endpoints para operaciones CRUD.
- Implementar códigos de estado HTTP adecuados y cuerpos de respuesta.
- Manejar diferentes tipos de parámetros (variables de ruta, parámetros de solicitud, cuerpo de la solicitud).

## Paso 4: Persistencia de Datos con Spring Data JPA

1. **ORM y JPA**: Comprender el Mapeo Objeto-Relacional y la API de Persistencia de Java.
2. **Entidades**: Aprender a crear entidades JPA.
3. **Repositorios**: Comprender e implementar repositorios de Spring Data JPA.
4. **JPQL y Consultas Nativas**: Aprender a escribir consultas JPQL y SQL nativas.
5. **Relaciones**: Implementar diferentes tipos de relaciones (Uno a Uno, Uno a Muchos, Muchos a Muchos).
6. **Mapper**: Implementar configuracion de mapeo de entidades a Dtos.
7. **Paginacion**: Implementar paginacion en cada servicio.

### Tarea Práctica

- Crear entidades JPA para tu librería (Libro, Autor, Cliente, Pedido).
- Implementar repositorios para estas entidades.
- Utilizar métodos de consulta derivados y consultas JPQL personalizadas.
- Implementar relaciones adecuadas entre entidades.

## Paso 5: Manejo de Excepciones y Validación

1. **Manejo Global de Excepciones**: Implementar manejo global de excepciones en Spring Boot.
2. **Excepciones Personalizadas**: Crear y utilizar excepciones personalizadas.
3. **Validación**: Utilizar Bean Validation (JSR 380) para la validación de entrada.
4. **Respuestas de Error**: Diseñar e implementar respuestas de error consistentes.

### Tarea Práctica

- Implementar manejo global de excepciones para tu API de librería.
- Agregar validación de entrada a tus clases de entidad y DTOs.
- Crear excepciones personalizadas para errores de lógica de negocio.
- Asegurar que todos los endpoints devuelvan respuestas de error adecuadas cuando sea necesario.

## Paso 6: Autenticación y Autorización

1. **Spring Security**: Comprender los fundamentos de Spring Security.
2. **Autenticación JWT**: Implementar autenticación basada en JWT.
3. **Autorización Basada en Roles**: Implementar control de acceso basado en roles.
4. **OAuth 2.0**: Comprender e implementar OAuth 2.0 (opcional).

### Tarea Práctica

- Implementar autenticación JWT para tu API de librería.
- Crear endpoints para registro y login de usuarios.
- Implementar autorización basada en roles (por ejemplo, ADMIN puede agregar/eliminar libros, USER solo puede ver).
- Asegurar tus endpoints de API con autenticación y autorización adecuadas.

## Paso 7: WebSockets en Spring Boot

1. **Protocolo WebSocket**: Comprender el protocolo WebSocket y sus ventajas sobre HTTP para comunicación en tiempo real.
2. **STOMP**: Aprender sobre el subProtocolo STOMP (Simple Text Oriented Messaging Protocol).
3. **Soporte de WebSocket en Spring**: Comprender cómo Spring Boot soporta la comunicación WebSocket.
4. **Configuración de WebSocket**: Aprender a configurar endpoints WebSocket en Spring Boot.
5. **Manejo de Mensajes**: Implementar el manejo de mensajes para la comunicación WebSocket.
6. **Transmisión**: Comprender cómo transmitir mensajes a múltiples clientes.
7. **Seguridad**: Aprender a asegurar las conexiones WebSocket.

### Tarea Práctica

- Implementar una funcionalidad de chat simple utilizando WebSockets en Spring Boot.
- Crear endpoints para conectar, enviar y recibir mensajes.
- Implementar la transmisión de mensajes a todos los clientes conectados.
- Asegurar la conexión WebSocket utilizando Spring Security.

## Proyecto Final: Backend de Red Social

Desarrollar un backend completo para una plataforma de redes sociales utilizando Spring Boot. La aplicación debe incluir las siguientes características:

0. Creación de diagrama de bases de datos usando [dbdiagram.io](https://dbdiagram.io/d).

   - tabla de usuarios
   - tabla de publicaciones
   - tabla de notificaciones
   - tabla de chat
   - tabla de feed de noticias

1. Gestión de Usuarios:

   - Registro de usuarios y autenticación utilizando JWT.
   - Perfiles de usuario con información básica.
   - Funcionalidad de seguir/dejar de seguir.

2. Gestión de Publicaciones:

   - Operaciones CRUD para publicaciones (texto, imágenes).
   - Me gusta/No me gusta en publicaciones.
   - Comentarios en publicaciones.

3. Sistema de Chat:

   - Chat en tiempo real utilizando WebSockets.
   - Soporte para chats uno a uno y grupales.
   - Funcionalidad de carga de archivos en chats (imágenes, documentos).

4. Feed de Noticias:

   - Recuperar publicaciones de usuarios seguidos.

5. Funcionalidad de Búsqueda:

   - Búsqueda de usuarios y publicaciones.

6. Notificaciones:

   - Notificaciones en tiempo real para nuevos seguidores, me gusta, comentarios y mensajes utilizando WebSockets.

7. Control de Acceso Basado en Roles:

   - Implementar roles (por ejemplo, Usuario Regular, Moderador, Administrador).
   - Definir permisos apropiados para cada rol.

8. Seguridad:

   - Implementar autenticación y autorización adecuadas para todos los endpoints.
   - Asegurar las conexiones WebSocket.

9. Manejo de Archivos:

   - Implementar carga y almacenamiento de archivos para avatares de usuario, imágenes de publicaciones y adjuntos de chat.
   - Manejar la recuperación y el servicio de archivos.

10. Documentación de API:
    - Documentar tu API utilizando Swagger o SpringFox.
   
11. Manejar cookies.

Este proyecto te permitirá aplicar todos los conceptos aprendidos a lo largo de la ruta de aprendizaje, incluyendo SQL, Spring Boot, APIs RESTful, autenticación, autorización y WebSockets. También te dará experiencia en la construcción de una aplicación compleja del mundo real con varias características interconectadas.

Pasos de Implementación:

1. Configurar la estructura del proyecto y las dependencias.
2. Implementar la autenticación y autorización de usuarios.
3. Crear APIs para la gestión de usuarios y la funcionalidad de seguir/dejar de seguir.
4. Implementar la creación, recuperación, actualización y eliminación de publicaciones.
5. Agregar funcionalidad de me gusta y comentarios a las publicaciones.
6. Implementar el feed de noticias.
7. Crear el sistema de chat utilizando WebSockets.
8. Agregar funcionalidad de carga de archivos para chat y publicaciones.
9. Implementar la funcionalidad de búsqueda.
10. Crear el sistema de notificaciones utilizando WebSockets.
11. Implementar el control de acceso basado en roles.
12. Agregar un manejo adecuado de errores y validación en toda la aplicación.
13. Documentar tu API utilizando Swagger o SpringFox.

Este proyecto proporcionará una aplicación integral de las habilidades aprendidas en la ruta de aprendizaje y te preparará para escenarios de desarrollo backend del mundo real.
