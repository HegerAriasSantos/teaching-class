# Ruta de Aprendizaje para Manejar Docker

## Paso 1: Introducción a Docker

1. **¿Qué es Docker?**: Entender el concepto de contenedores y cómo Docker los gestiona.
   - Diferencia entre contenedores y máquinas virtuales.
2. **Componentes de Docker**:
   - **Docker Engine**: El motor que ejecuta y gestiona los contenedores.
   - **Docker Images**: Imágenes preConstruidas que contienen todo lo necesario para ejecutar una aplicación.
   - **Docker Containers**: Instancias en ejecución de imágenes de Docker.
   - **Docker Hub**: Un registro público para compartir y descargar imágenes de Docker.
3. **Instalación de Docker**: Instalar Docker en tu sistema operativo.
   - Linux, macOS, Windows.
4. **Comandos Básicos**:
   - `docker run`: Ejecutar un contenedor.
   - `docker ps`: Ver contenedores en ejecución.
   - `docker stop`: Detener contenedores.
   - `docker rm`: Eliminar contenedores.

### Tarea Práctica

- Instalar Docker en tu sistema.
- Ejecutar el contenedor `hello-world` usando el comando `docker run`.
- Usar `docker ps` para ver los contenedores en ejecución.

---

## Paso 2: Imágenes Docker

1. **Creación de Imágenes**:
   - Entender qué es una imagen de Docker y cómo construirla.
   - **Dockerfile**: Aprender la estructura y sintaxis de un Dockerfile.
2. **Comandos Importantes**:
   - `docker build`: Crear una imagen a partir de un Dockerfile.
   - `docker images`: Listar las imágenes almacenadas localmente.
   - `docker rmi`: Eliminar imágenes de Docker.
3. **Docker Hub**:
   - Buscar y usar imágenes de Docker preconstruidas.
   - Publicar tus imágenes en Docker Hub.

### Tarea Práctica

- Crear un Dockerfile simple para ejecutar una aplicación de Node.js.
- Construir la imagen usando `docker build`.
- Publicar la imagen en Docker Hub.

**Ejemplo de Dockerfile**:

```dockerfile
# Usar una imagen base de Node.js
FROM node:14

# Establecer el directorio de trabajo en el contenedor
WORKDIR /app

# Copiar el archivo package.json y las dependencias de la aplicación
COPY package.json ./

# Instalar las dependencias
RUN npm install

# Copiar el resto del código
COPY . .

# Exponer el puerto 3000
EXPOSE 3000

# Comando para ejecutar la aplicación
CMD ["npm", "start"]
```

---

## Paso 3: Gestión de Contenedores

1. **Administrar Contenedores**:
   - **Iniciar y Detener Contenedores**: Aprender a iniciar, detener y reiniciar contenedores.
   - **Logs**: Ver los logs de un contenedor usando `docker logs`.
   - **Ejecución de Comandos dentro del Contenedor**: Usar `docker exec` para ejecutar comandos dentro de un contenedor en ejecución.
2. **Persistencia de Datos**:
   - Volúmenes de Docker para manejar datos persistentes.
   - **Bind Mounts**: Mapear directorios locales al sistema de archivos del contenedor.

### Tarea Práctica

- Ejecutar un contenedor que sirva una aplicación web.
- Usar `docker exec` para entrar al contenedor y explorar su sistema de archivos.
- Crear un volumen de Docker para persistir datos fuera del ciclo de vida del contenedor.

---

## Paso 4: Redes en Docker

1. **Redes en Docker**:
   - Comprender cómo Docker maneja redes para la comunicación entre contenedores.
   - Tipos de redes: **bridge**, **host**, **overlay**.
2. **Conectar Contenedores**:
   - Crear una red personalizada y conectar múltiples contenedores.
   - Usar `docker network` para crear, listar y eliminar redes.
3. **Puertos y Exposición**:
   - Exponer puertos de los contenedores al host.
   - Usar el parámetro `-p` para mapear puertos del host a los del contenedor.

### Tarea Práctica

- Crear una red Docker personalizada.
- Ejecutar dos contenedores que se comuniquen entre sí usando esa red.
- Mapear un puerto del contenedor al host para acceder a una aplicación web desde el navegador.

---

## Paso 5: Docker Compose

1. **¿Qué es Docker Compose?**: Usar **Docker Compose** para definir y correr múltiples contenedores como un servicio.
2. **Archivo `docker-compose.yml`**:
   - Sintaxis y estructura de un archivo `docker-compose.yml`.
   - Definir servicios, redes y volúmenes.
3. **Comandos de Docker Compose**:
   - `docker-compose up`: Iniciar los servicios definidos en el archivo.
   - `docker-compose down`: Detener y eliminar los contenedores, redes y volúmenes.
   - `docker-compose logs`: Ver los logs de los servicios.

### Tarea Práctica

- Crear un archivo `docker-compose.yml` para ejecutar una aplicación de Node.js con una base de datos MySQL.
- Iniciar los servicios usando `docker-compose up`.
- Ver los logs de los servicios y probar la conexión entre ellos.

**Ejemplo de `docker-compose.yml`**:

```yaml
version: "3"
services:
  app:
    image: node:14
    volumes:
      - .:/app
    working_dir: /app
    command: npm start
    ports:
      - "3000:3000"
    depends_on:
      - db

  db:
    image: mysql:5.7
    environment:
      MYSQL_ROOT_PASSWORD: rootpassword
      MYSQL_DATABASE: mydb
      MYSQL_USER: user
      MYSQL_PASSWORD: password
    volumes:
      - db_data:/var/lib/mysql

volumes:
  db_data:
```

---

## Paso 6: Docker en Producción

1. **Optimización de Imágenes**:
   - Reducir el tamaño de las imágenes mediante **multi-stage builds**.
   - Usar imágenes ligeras como **Alpine**.
2. **Escalabilidad**:
   - Usar **Docker Swarm** o **Kubernetes** para orquestar contenedores en producción.
3. **Seguridad en Docker**:
   - Buenas prácticas de seguridad (ejecutar como usuarios no root, escanear imágenes en busca de vulnerabilidades).

### Tarea Práctica

- Optimizar una imagen Docker usando un **multi-stage build**.
- Crear un archivo `docker-compose.yml` que defina múltiples réplicas de un servicio.
- Investigar el uso de Kubernetes para la orquestación de contenedores.

**Ejemplo de Multi-stage Build**:

```dockerfile
# Etapa de construcción
FROM node:14 as builder
WORKDIR /app
COPY package.json ./
RUN npm install
COPY . .
RUN npm run build

# Etapa de producción
FROM nginx:alpine
COPY --from=builder /app/build /usr/share/nginx/html
EXPOSE 80
CMD ["nginx", "-g", "daemon off;"]
```

---

## Proyecto Final: Aplicación Full Stack con Docker

Desarrollar y contenerizar una aplicación full stack utilizando Docker. La aplicación debe incluir:

1. **Backend**:

   - API construida con **Node.js/Express** o **Spring Boot**.
   - Conectar con una base de datos como **MySQL** o **PostgreSQL**.
   - Persistencia de datos usando volúmenes.

2. **Frontend**:

   - Aplicación construida con **React** o **Angular**.
   - Servida a través de **Nginx**.

3. **Redes y Docker Compose**:

   - Configurar una red personalizada para que frontend y backend puedan comunicarse.
   - Definir los servicios en un archivo `docker-compose.yml`.

4. **Optimización y Seguridad**:
   - Optimizar las imágenes usando multi-stage builds.
   - Implementar buenas prácticas de seguridad, como ejecutar los contenedores como un usuario no root.

### Tarea Práctica

- Crear el archivo `docker-compose.yml` que contenga servicios para frontend, backend y base de datos.
- Implementar multi-stage builds en tus Dockerfiles para reducir el tamaño de las imágenes.
- Asegurar que los servicios funcionen correctamente en conjunto utilizando una red personalizada de Docker.

---

Este enfoque te permitirá comprender y aplicar Docker en proyectos tanto pequeños como complejos, cubriendo desde conceptos básicos hasta implementación en producción.
