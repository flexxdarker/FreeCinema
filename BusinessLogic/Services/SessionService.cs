using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using DataAccess.Entities;
using DataAccess.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    internal class SessionService : ISessionService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Session> sessionR;
        public SessionService(IMapper mapper, IRepository<Session> sessionR)
        {
            this.mapper = mapper;
            this.sessionR = sessionR;
        }

        public void Create(SessionDto session)
        {
            sessionR.Insert(mapper.Map<Session>(sessionR));
            sessionR.Save();
        }

        public void Delete(int id)
        {
            if (id < 0) throw new HttpException(Errors.IdMustPositive, HttpStatusCode.BadRequest);

            var film = sessionR.GetByID(id);

            if (film == null) throw new HttpException(Errors.ProductNotFound, HttpStatusCode.NotFound);

            sessionR.Delete(film);
            sessionR.Save();
        }

        public void Edit(SessionDto session)
        {
            sessionR.Update(mapper.Map<Session>(session));
            sessionR.Save();
        }

        public SessionDto? Get(int id)
        {
            if (id < 0) throw new HttpException(Errors.IdMustPositive, HttpStatusCode.BadRequest);

            var item = sessionR.GetByID(id);
            if (item == null) throw new HttpException(Errors.ProductNotFound, HttpStatusCode.NotFound);

            var dto = mapper.Map<SessionDto>(item);

            return dto;
        }

        public IEnumerable<SessionDto> GetAll()
        {
            return mapper.Map<List<SessionDto>>(sessionR.GetAll());
        }
    }
}
