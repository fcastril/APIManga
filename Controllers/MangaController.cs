using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BibliotecaMangasAPI.models;

namespace BibliotecaMangasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MangaController : ControllerBase
    {
        private static List<Manga> biblioteca = new List<Manga>();

        private static int contadorId = 1;

        [HttpPost]
        public ActionResult<Manga> CrearManga(Manga manga)
        {
            if (string.IsNullOrWhiteSpace(manga.titulo))
            {
                return BadRequest("El título no puede estar vacío");
            }
            
            manga.Id = contadorId;
            contadorId++;

            biblioteca.Add(manga);

            return Ok(manga);
        }
        [HttpGet]
        public ActionResult<List<Manga>> ObtenerMangas()
        {
            return Ok(biblioteca);
        }
        [HttpGet("{id}")]
        public ActionResult<Manga> ObtenerMangaPorId(int id)
        {
            var manga = biblioteca.FirstOrDefault(m => m.Id == id);

            if (manga == null)
            {
                return NotFound("Manga no encontrado");
            }

            return Ok(manga);
        }
        [HttpPut("{id}")]
        public ActionResult<Manga> ActualizarManga(int id, Manga mangaActualizado)
        {
            var manga = biblioteca.FirstOrDefault(m => m.Id == id);

            if (manga == null)
            {
                return NotFound("Manga no encontrado");
            }

            if (string.IsNullOrWhiteSpace(mangaActualizado.titulo))
            {
                return BadRequest("El título no puede estar vacío");
            }

            manga.titulo = mangaActualizado.titulo;
            manga.autor = mangaActualizado.autor;
            manga.NumeroTomo = mangaActualizado.NumeroTomo;
            manga.precio = mangaActualizado.precio;

            return Ok(manga);
        }
        [HttpDelete("{id}")]
        public ActionResult EliminarManga(int id)
        {
            var manga = biblioteca.FirstOrDefault(m => m.Id == id);

            if (manga == null)
            {
                return NotFound("Manga no encontrado");
            }

            biblioteca.Remove(manga);

            return NoContent();
        }
    }
}
