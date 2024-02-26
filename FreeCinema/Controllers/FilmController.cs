using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreeCinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly IFilmService filmService;

        public FilmController(IFilmService filmService)
        {
            this.filmService = filmService;
        }

        [HttpGet("all")]
        public IActionResult Get()
        {
            return Ok(filmService.GetAll());
        }

        [HttpGet("{id:int}")]
        public IActionResult Get([FromRoute] int id)
        {
            return Ok(filmService.Get(id));
        }

        [HttpPost]
        public IActionResult Create([FromForm] FilmDto model)
        {
            filmService.Create(model);
            return Ok();
        }


        [HttpPut]
        public IActionResult Edit([FromBody] FilmDto model)
        {
            filmService.Edit(model);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            filmService.Delete(id);
            return Ok();
        }
    }
}
