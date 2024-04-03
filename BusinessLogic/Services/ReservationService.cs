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
        private readonly IRepository<Session> sessionR;
        public ReservationService(IRepository<Session> sessionR)
        {
            this.sessionR = sessionR;
        }
        public void Create(int SessionId)
        {
            if(sessionR.GetByID(SessionId).AvailablePlace > 0) 
            {
                sessionR.GetByID(SessionId).AvailablePlace--;
            }   
        }
    }
}
