# Ruta de Aprendizaje para Aplicar Testing en Frontend y Backend

## Paso 1: Introducción a Testing

1. **Qué es el Testing**: Comprender qué es el testing en desarrollo de software y su importancia.
2. **Tipos de Pruebas**:
   - **Unit Testing (Pruebas Unitarias)**: Probar partes pequeñas y aisladas de tu código.
   - **Integration Testing (Pruebas de Integración)**: Probar cómo las diferentes partes de tu aplicación trabajan juntas.
   - **End-to-End Testing (Pruebas de Extremo a Extremo)**: Simular la experiencia del usuario y probar toda la aplicación desde el frontend hasta el backend.
3. **Piramide de Pruebas**: Entender la pirámide de testing y la importancia de tener una buena base de pruebas unitarias antes de pasar a pruebas de integración y E2E.
4. **Herramientas de Testing**:
   - **Frontend**: Jest, React Testing Library, Cypress, Jasmine/Karma (para Angular).
   - **Backend**: JUnit, Mockito, Spring Test, Postman (para pruebas de APIs).

### Tarea Práctica

- Investigar y familiarizarse con herramientas comunes de testing en frontend y backend.
- Configurar el entorno de testing para un proyecto React, Angular o Spring Boot.

---

## Paso 2: Testing Unitario en Frontend (React o Angular)

1. **Pruebas Unitarias en React**: Usar **Jest** y **React Testing Library** para probar componentes React.
   - Escribir pruebas para componentes funcionales.
   - Simular eventos de usuario (clics, inputs).
   - Mockear datos y funciones usando `jest.fn()`.
2. **Pruebas Unitarias en Angular**: Usar **Jasmine** y **Karma**.
   - Probar componentes de Angular y servicios.
   - Mockear dependencias usando `TestBed`.

### Tarea Práctica

- Crear una aplicación sencilla con React o Angular.
- Escribir pruebas unitarias para un componente simple, probando su renderizado y eventos de usuario.
- Escribir pruebas para un servicio en Angular (si trabajas con Angular).

**Ejemplo en React**:

```javascript
import { render, screen, fireEvent } from "@testing-library/react";
import MyButton from "./MyButton";

test("debe renderizar el botón correctamente", () => {
	render(<MyButton label='Click Me' />);
	const button = screen.getByText("Click Me");
	expect(button).toBeInTheDocument();
});

test("debe disparar el evento de clic", () => {
	const handleClick = jest.fn();
	render(<MyButton label='Click Me' onClick={handleClick} />);
	const button = screen.getByText("Click Me");
	fireEvent.click(button);
	expect(handleClick).toHaveBeenCalledTimes(1);
});
```

---

## Paso 3: Testing Unitario en Backend (Spring Boot)

1. **JUnit**: Aprender a escribir pruebas unitarias para controladores, servicios y repositorios en **Spring Boot** usando **JUnit**.
2. **Mockito**: Usar **Mockito** para mockear dependencias y aislar las pruebas.
3. **Spring Test**: Integrar **Spring Test** para realizar pruebas unitarias sobre las funcionalidades de tu aplicación.

### Tarea Práctica

- Crear un proyecto Spring Boot con un controlador y servicio simples.
- Escribir pruebas unitarias para el servicio usando **JUnit** y **Mockito**.
- Probar el controlador con **MockMvc** para simular solicitudes HTTP.

**Ejemplo en Spring Boot**:

```java
@RunWith(SpringRunner.class)
@SpringBootTest
public class UserServiceTest {

    @Mock
    private UserRepository userRepository;

    @InjectMocks
    private UserService userService;

    @Test
    public void whenValidId_thenUserShouldBeFound() {
        User user = new User("John");
        when(userRepository.findById(1L)).thenReturn(Optional.of(user));

        User found = userService.getUserById(1L);
        assertEquals(found.getName(), "John");
    }
}
```

---

## Paso 4: Testing de Integración en Frontend

1. **React Testing Library y Mock Service Worker (MSW)**:
   - Probar la integración de componentes y servicios, incluyendo llamadas a APIs externas.
   - Mockear respuestas HTTP con **MSW**.
2. **Pruebas de Integración en Angular**:
   - Probar la interacción entre componentes y servicios en Angular usando **TestBed** y **HttpClientTestingModule**.

### Tarea Práctica

- Escribir pruebas de integración que verifiquen el comportamiento de componentes React/Angular y sus servicios.
- Mockear una API con **MSW** o **HttpClientTestingModule** en Angular.

**Ejemplo en React con MSW**:

```javascript
import { rest } from "msw";
import { setupServer } from "msw/node";

const server = setupServer(
	rest.get("/api/users", (req, res, ctx) => {
		return res(ctx.json([{ name: "John" }]));
	}),
);

beforeAll(() => server.listen());
afterEach(() => server.resetHandlers());
afterAll(() => server.close());

test("debe mostrar la lista de usuarios", async () => {
	render(<UserList />);
	const users = await screen.findAllByText(/John/);
	expect(users).toHaveLength(1);
});
```

---

## Paso 5: Testing de Integración en Backend

1. **Pruebas de Integración con Spring Boot**:

   - Probar cómo interactúan los componentes del backend (controladores, servicios, repositorios) usando **@SpringBootTest**.
   - Configurar una base de datos en memoria para realizar pruebas con datos reales (por ejemplo, H2).

2. **MockMvc**: Usar **MockMvc** para realizar pruebas de integración en controladores REST.

### Tarea Práctica

- Escribir pruebas de integración para tu proyecto Spring Boot.
- Configurar una base de datos en memoria y probar el flujo completo de creación y recuperación de datos.

**Ejemplo en Spring Boot**:

```java
@RunWith(SpringRunner.class)
@SpringBootTest
@AutoConfigureMockMvc
public class UserControllerIntegrationTest {

    @Autowired
    private MockMvc mockMvc;

    @Test
    public void shouldReturnListOfUsers() throws Exception {
        mockMvc.perform(get("/api/users"))
                .andExpect(status().isOk())
                .andExpect(jsonPath("$[0].name").value("John"));
    }
}
```

---

## Paso 6: Pruebas End-to-End (E2E) en Frontend

1. **Cypress**: Usar **Cypress** para escribir pruebas E2E que simulen la interacción del usuario con la interfaz.
2. **Protractor (Angular)**: Usar **Protractor** para escribir pruebas E2E en Angular.

### Tarea Práctica

- Crear un conjunto de pruebas E2E para tu aplicación frontend con Cypress o Protractor.
- Probar los flujos clave de la aplicación, como el login o el flujo de compra.

**Ejemplo en Cypress**:

```javascript
describe("Login Test", () => {
	it("debe permitir al usuario iniciar sesión", () => {
		cy.visit("/login");
		cy.get('input[name="username"]').type("user1");
		cy.get('input[name="password"]').type("password123");
		cy.get('button[type="submit"]').click();
		cy.url().should("include", "/dashboard");
	});
});
```

---

## Paso 7: Testing de APIs en Backend

1. **Postman/Newman**: Usar **Postman** para escribir pruebas de API y automatizarlas con **Newman**.
2. **Spring Boot Test con MockMvc**: Escribir pruebas automáticas para endpoints REST con **MockMvc** y **Spring Test**.

### Tarea Práctica

- Crear una colección de pruebas de API en **Postman** para los endpoints de tu aplicación.
- Integrar **Newman** para automatizar las pruebas de API como parte de un proceso CI/CD.

---

## Proyecto Final: Testing Completo de una Aplicación Full Stack

Desarrollar una aplicación full stack (React/Angular + Spring Boot) y escribir un conjunto completo de pruebas que incluya:

1. **Pruebas Unitarias** para todos los componentes frontend y backend.
2. **Pruebas de Integración** que verifiquen la comunicación entre el frontend y el backend.
3. **Pruebas E2E** para simular los flujos principales de usuario en la aplicación.
4. **Pruebas de API** para garantizar que los endpoints REST funcionen correctamente.

---

Este enfoque te permitirá dominar las prácticas de testing tanto en el frontend como en el backend, cubriendo pruebas unitarias, de integración y de extremo a extremo, así como pruebas automáticas de APIs.
