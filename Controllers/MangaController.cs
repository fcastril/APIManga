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
    }
}
