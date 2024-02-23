using BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IFilmService
    {
        IEnumerable<FilmDto> GetAll();
        FilmDto? Get(int id);
        void Create(FilmDto product);
        void Edit(FilmDto product);
        void Delete(int id);
    }
}
