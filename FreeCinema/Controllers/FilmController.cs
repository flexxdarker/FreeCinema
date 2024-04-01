using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using FreeCinema.Helpers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreeCinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly IFilmService filmService;
        private readonly ICategoryService categoryService;

        public FilmController(IFilmService filmService)
        {
            this.filmService = filmService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> Get()
        {
            return Ok(await filmService.GetAll());
        }
        [HttpGet("categories")]
        public async Task<IActionResult> GetCategories()
        {
            return Ok(await categoryService.GetAll());
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            return Ok(await filmService.Get(id));
        }

        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = Roles.ADMIN)]
        [HttpPost]
        public IActionResult Create([FromForm] CreateFilmModel model)
        {
            filmService.Create(model);
            return Ok();
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = Roles.ADMIN)]
        [HttpPut]
        public IActionResult Edit([FromBody] FilmDto model)
        {
            filmService.Edit(model);
            return Ok();
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = Roles.ADMIN)]
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await filmService.Delete(id);
            return Ok();
        }
    }
}
