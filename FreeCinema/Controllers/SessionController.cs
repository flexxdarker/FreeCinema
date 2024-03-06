using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreeCinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        private readonly ISessionService sessionService;
        public SessionController(ISessionService sessionService)
        {
            this.sessionService = sessionService;
        }
        [HttpGet("all")]
        public IActionResult Get()
        {
            return Ok(sessionService.GetAll());
        }

        [HttpGet("{id:int}")]
        public IActionResult Get([FromRoute] int id)
        {
            return Ok(sessionService.Get(id));
        }

        [HttpPost]
        public IActionResult Create([FromForm] SessionDto model)
        {
            sessionService.Create(model);
            return Ok();
        }


        [HttpPut]
        public IActionResult Edit([FromBody] SessionDto model)
        {
            sessionService.Edit(model);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            sessionService.Delete(id);
            return Ok();
        }
    }
}
