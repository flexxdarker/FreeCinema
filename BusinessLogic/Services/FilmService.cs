using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
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
        public void Create(FilmDto film)
        {
            filmR.Insert(mapper.Map<Film>(film));
            filmR.Save();
        }

        public void Delete(int id)
        {
            if (id < 0) throw new HttpException(Errors.IdMustPositive, HttpStatusCode.BadRequest);

            // delete product by id
            var product = filmR.GetByID(id);

            if (product == null) throw new HttpException(Errors.ProductNotFound, HttpStatusCode.NotFound);

            filmR.Delete(product);
            filmR.Save();
        }

        public void Edit(FilmDto film)
        {
            filmR.Update(mapper.Map<Film>(film));
            filmR.Save();
        }

        public FilmDto? Get(int id)
        {
            if (id < 0) throw new HttpException(Errors.IdMustPositive, HttpStatusCode.BadRequest);

            var item = filmR.GetByID(id);
            if (item == null) throw new HttpException(Errors.ProductNotFound, HttpStatusCode.NotFound);

            var dto = mapper.Map<FilmDto>(item);

            return dto;
        }

        public IEnumerable<FilmDto> GetAll()
        {
            return mapper.Map<List<FilmDto>>(filmR.GetAll());
        }
    }
}
