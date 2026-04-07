# 🚀 Proyecto: "MangaCollector API"

El objetivo es que el aprendiz construya una API que permita gestionar su propia biblioteca de mangas.

## Historia de Usuario 1: Registrar un nuevo Manga
**Como** coleccionista de manga,
**Quiero** poder registrar un nuevo tomo en mi sistema,
**Para** mantener un control actualizado de mis adquisiciones.

### Criterios de Aceptación:

- El sistema debe permitir ingresar: Título, Autor, Número de Tomo y Precio.
- El campo "Título" no puede estar vacío.
- Al guardar, la API debe devolver el objeto creado con un ID único.

**💡 Tip de Backend:** Aquí aprenderás el verbo POST. En .NET, usa [HttpPost] en tu controlador. Recuerda que los datos viajan en el "Body" de la petición.

## Historia de Usuario 2: Listar mi colección
**Como** coleccionista,
**Quiero** ver una lista de todos los mangas que he registrado,
**Para** saber qué libros tengo disponibles.

### Criterios de Aceptación:

- La API debe devolver un listado de todos los registros en formato JSON.
- Si no hay registros, debe devolver una lista vacía.

**💡 Tip de Backend:** Aquí usas el verbo GET. Es la operación más sencilla. Asegúrate de que tu método en el controlador devuelva un ActionResult<IEnumerable<Manga>>.

## Historia de Usuario 3: Consultar detalle de un Manga
**Como** coleccionista,
**Quiero** buscar un manga específico por su ID,
**Para** ver su información detallada antes de prestarlo o leerlo.

### Criterios de Aceptación:

- El usuario debe enviar el ID como parámetro en la URL.
- Si el ID existe, muestra los datos.
- Si el ID no existe, la API debe responder con un error 404 Not Found.

**💡 Tip de Backend:** Este es un GET por ID. Aprenderás a usar parámetros en la ruta: [HttpGet("{id}")]. Manejar los códigos de estado (200 OK vs 404) es vital en el agilismo para que el frontend sepa qué pasó.

## Historia de Usuario 4: Actualizar información de un Manga
**Como** coleccionista,
**Quiero** corregir los datos de un manga (por ejemplo, si me equivoqué en el precio),
**Para** que mi información siempre sea verídica.

### Criterios de Aceptación:

- Se debe enviar el ID del manga y los nuevos datos.
- El sistema debe validar que el manga realmente exista antes de intentar actualizarlo.

**💡 Tip de Backend:** Aquí entra el verbo PUT. Es común comparar el ID que viene en la URL con el ID que viene dentro del objeto en el "Body" para asegurar que coincidan.

## Historia de Usuario 5: Eliminar un Manga
**Como** coleccionista,
**Quiero** borrar un registro de mi lista,
**Para** quitar mangas que he vendido o perdido.

### Criterios de Aceptación:

- Al enviar el ID, el registro debe desaparecer de la base de datos (o memoria).
- Debe retornar un código de éxito (204 No Content es el estándar).

**💡 Tip de Backend:** Usarás el verbo DELETE. Ten cuidado: ¡esta acción es irreversible en un CRUD básico!
