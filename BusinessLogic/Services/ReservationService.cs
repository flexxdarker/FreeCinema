using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using BusinessLogic.Specifications;
using DataAccess.Entities;
using DataAccess.Repostories;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class ReservationService : IReservation
    {
        private readonly IMapper mapper;
        private readonly IRepository<Film> filmR;
        private readonly IRepository<Reservation> reservationR;
        private readonly ISelectedService selectedService;
        private readonly IRepository<PlacePrice> placepriceR;
        public ReservationService(IMapper mapper,
                                  IRepository<Film> filmR,
                                  IRepository<Reservation> reservationR,
                                  ISelectedService selectedService,
                                  IRepository<PlacePrice> placepriceR)
        {
            this.mapper = mapper;
            this.filmR = filmR;
            this.reservationR = reservationR;
            this.selectedService = selectedService;
            this.placepriceR = placepriceR;
        }
        public async Task Create(string userId, int sessionId)
        {
            var ids = selectedService.GetPlaceIds();
            var places = await placepriceR.GetListBySpec(new PPSpecs.ByIds(ids));
            var reservation = new Reservation()
            {
                UserId = userId,
                PlacePrices = places.ToList(),
                SessionId = sessionId,
                TotalPrice = places.Sum(x => x.Price),
            };
            reservationR.Insert(reservation);
            reservationR.Save();
        }
        public async Task<IEnumerable<ReservationDto>> GetAllByUser(string userId)
        {
            var items = await reservationR.GetListBySpec(new ReservationSpecs.ByUser(userId));
            return mapper.Map<IEnumerable<ReservationDto>>(items);
        }
    }
}
