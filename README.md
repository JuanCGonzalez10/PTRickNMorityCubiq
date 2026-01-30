# RickNMorityCubiq
Aplicación web desarrollada en Blazor WebAssembly que consume la API pública de Rick and Morty para mostrar personajes, permitir votaciones (likes/dislikes), paginación y filtros, con una interfaz visualmente inspirada en la serie.

### Descripción de la aplicación web

Esta aplicación web muestra una lista completa de los personajes de la serie Rick and Morty, obtenidos desde la API pública proporcionada en el documento.  
El usuario tiene la capacidad de:

- Ver y navegar entre las distintas páginas de personajes.
- Filtrar por nombre, especie o estado (también podrá combinar estos).
- Darle like o dislike al personaje que desee.
- Ver la información de los personajes en su respectiva tarjeta.

### Objetivo

Desarrollar una aplicación web que consuma la API pública de Rick and Morty, muestre visualmente los personajes disponibles y permita a los usuarios interactuar con cada uno mediante votos de "Like" y "Dislike".

### Requisitos
- .NET 8 o superior.
- Visual Studio 2022 (recomendado).

### Instrucciones para ejecutar la app

- Clonar el repositorio:
```
git clone <https://github.com/JuanCGonzalez10/RickNMorityCubiq.git>
```


- Abrir el proyecto en Visual Studio.

- Ejecutar la aplicación.

La aplicación se debería abrir en el navegador en localhost.

### Consumo de la API

Primero se inyecta el HttpClient en el componente Blazor.

La API se consume en `Pages/Characters` en el apartado `@code`, obteniendo los personajes y páginas mediante una petición GET:

```
        var response = await Http.GetFromJsonAsync<CharacterResponse>(
            $"https://rickandmortyapi.com/api/character?page={currentPage}");
```
También devuelve la información de la paginación en el objeto `Info`:

```
        totalPages = response.Info.Pages;
```
Usada para cargar los personajes de cada página y controlar los botones de anterior y siguiente.

### Funciones Adicionales:

- Filtros Dinámicos:
  - Nombre
  - Especie
  - Estado
- Paginación
- Estilo personalizado y animaciones leves
- Diseño responsive

### Estructura del proyecto 

- **Pages/**
  - `Characters.razor` 
- **Models/**
  - `Character.cs` 
- **wwwroot/**
  - **css/**
    - `app.css`
- **Layout/**
  - `MainLayout.razor`
  - `NavMenu.razor`
- `Program.cs`

### Decisiones Técnicas:

- Se decidió usar Blazor, ya que C# es el lenguaje que más domino y permite ejecutarlo directamente en el navegador; además, es ideal para un front sin JS.

- Separación de responsabilidades: Se separan models, Pages y estilos en distintas carpetas con el fin de mantener un código limpio y escalable.

- Bootstrap + CSS, que permite una base responsive con personalización visual con temática de la serie.

### Posibles mejoras futuras:

- Persistencia en almacenamiento (Base de datos o local).

- Ordenar personajes de acuerdo a su popularidad basado en los likes.

- Animaciones adicionales de acuerdo a la serie.

- Vistas con detalles y descripciones de los personajes.

### Estructura del proyecto 

- **Pages/**
  - `Index.razor` → Página principal

- **Models/**
  - `Character.cs` → Modelo del personaje
  - `CharacterResponse.cs`
  - `Info.cs`

- **wwwroot/**
  - **css/**
    - `app.css` → Estilos personalizados
  - **images/**
    - `titulo.png` → Imagen del título
  - `favicon.png`

- **Shared/**
  - `MainLayout.razor`

- `Program.cs`

## Autor
Juan Camilo González Hernández
