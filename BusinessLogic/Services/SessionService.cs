using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using BusinessLogic.Specifications;
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

        public async Task Delete(int id)
        {
            if (id < 0) throw new HttpException(Errors.IdMustPositive, HttpStatusCode.BadRequest);

            var film = await sessionR.GetItemBySpec(new SessionSpecs.ById(id));

            if (film == null) throw new HttpException(Errors.ProductNotFound, HttpStatusCode.NotFound);

            sessionR.Delete(film);
            sessionR.Save();
        }

        public void Edit(SessionDto session)
        {
            sessionR.Update(mapper.Map<Session>(session));
            sessionR.Save();
        }

        public async Task<SessionDto?> Get(int id)
        {
            if (id < 0) throw new HttpException(Errors.IdMustPositive, HttpStatusCode.BadRequest);

            var item = await sessionR.GetItemBySpec(new SessionSpecs.ById(id));
            if (item == null) throw new HttpException(Errors.ProductNotFound, HttpStatusCode.NotFound);

            var dto = mapper.Map<SessionDto>(item);

            return dto;
        }

        public async Task<IEnumerable<SessionDto>> GetAll()
        {
            return mapper.Map<IEnumerable<SessionDto>>(await sessionR.GetListBySpec(new SessionSpecs.All()));
        }
    }
}
