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
    public class ReservationService : IReservationService
    {
        private readonly IMapper mapper;
        private readonly IRepository<PP> placepriceR;
        public ReservationService(IMapper mapper,
                                  IRepository<PP> placepriceR)
        {
            this.mapper = mapper;
            this.placepriceR = placepriceR;
        }
        public async Task Create(PlacePriceDto placePrice)
        {
            var place = new PP
            {
                Id = placePrice.Id,
                isReserved = true,
                PlaceId = placePrice.PlaceId,
                SessionId = placePrice.SessionId,
                Price = placePrice.Price,
            };
            if(placepriceR.GetByID(placePrice.Id).isReserved == true)
                throw new HttpException(Errors.PlaceIsReserved, System.Net.HttpStatusCode.BadRequest);
            else
            {
                placepriceR.Update(mapper.Map<PP>(place));
                placepriceR.Save(); 
            }
        }
    }
}
