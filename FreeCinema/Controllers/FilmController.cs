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
        public async Task<IActionResult> Get()
        {
            return Ok(await filmService.GetAll());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            return Ok(await filmService.Get(id));
        }

        [HttpPost]
        public IActionResult Create([FromForm] CreateFilmModel model)
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
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await filmService.Delete(id);
            return Ok();
        }
    }
}
