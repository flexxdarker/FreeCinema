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
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService reservationService;

        public ReservationController(IReservationService reservationService) 
        {
            this.reservationService = reservationService;
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = Roles.ADMIN)]
        [HttpPost]
        public IActionResult Create([FromForm]  int CinemaHallId)
        {
            reservationService.Create(CinemaHallId);
            return Ok();
        }
    }
}
