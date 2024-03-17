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
        Task<IEnumerable<FilmDto>> GetAll();
        Task<IEnumerable<FilmDto>> Get(IEnumerable<int> ids);
        Task<FilmDto?> Get(int id);
        void Create(CreateFilmModel product);
        void Edit(FilmDto product);
        Task Delete(int id);
    }
}
