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
        private readonly IFilmService productsService;

        public FilmController(IFilmController productsService)
        {
            this.productsService = productsService;
        }

        [HttpGet("all")]
        public IActionResult Get()
        {
            return Ok(productsService.GetAll());
        }

        [HttpGet("{id:int}")]
        public IActionResult Get([FromRoute] int id)
        {
            return Ok(productsService.Get(id));
        }

        [HttpPost]
        public IActionResult Create([FromForm] FilmDto model)
        {
            productsService.Create(model);
            return Ok();
        }


        [HttpPut]
        public IActionResult Edit([FromBody] FilmDto model)
        {
            productsService.Edit(model);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            productsService.Delete(id);
            return Ok();
        }
    }
}
