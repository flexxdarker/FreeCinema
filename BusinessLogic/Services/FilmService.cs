using AutoMapper;
using BusinessLogic.DTOs;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BusinessLogic.Services
{
    public class FilmService : IFilmService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Film> filmR;
        public FilmService(IMapper mapper, IRepository<Film> filmR)
        {
            this.mapper = mapper;
            this.filmR = filmR;
        }

        public void Create(CreateFilmModel film)
        {
            filmR.Insert(mapper.Map<Film>(film));
            filmR.Save();
        }

        public async Task Delete(int id)
        {
            if (id < 0) throw new HttpException(Errors.IdMustPositive, HttpStatusCode.BadRequest);

            var film = await filmR.GetListBySpec(new FilmSpecs.ById(id));

            if (film == null) throw new HttpException(Errors.ProductNotFound, HttpStatusCode.NotFound);

            filmR.Delete(film);
            filmR.Save();
        }

        public void Edit(FilmDto film)
        {
            filmR.Update(mapper.Map<Film>(film));
            filmR.Save();
        }

        public async Task<FilmDto?> Get(int id)
        {
            if (id < 0) throw new HttpException(Errors.IdMustPositive, HttpStatusCode.BadRequest);

            var item = await filmR.GetItemBySpec(new FilmSpecs.ById(id));
            if (item == null) throw new HttpException(Errors.ProductNotFound, HttpStatusCode.NotFound);

            var dto = mapper.Map<FilmDto>(item);

            return dto;
        }

        public async Task<IEnumerable<FilmDto>> Get(IEnumerable<int> ids)
        {
            return mapper.Map<List<FilmDto>>(await filmR.GetListBySpec(new FilmSpecs.ByIds(ids)));
        }

        public async Task<IEnumerable<FilmDto>> GetAll()
        {
            return mapper.Map<List<FilmDto>>(await filmR.GetListBySpec(new FilmSpecs.All()));
        }
    } 
}
