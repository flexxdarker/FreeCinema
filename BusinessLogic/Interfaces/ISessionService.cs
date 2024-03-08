using BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface ISessionService
    {
        Task<IEnumerable<SessionDto>> GetAll();
        Task<SessionDto?> Get(int id);
        void Create(SessionDto product);
        void Edit(SessionDto product);
        Task Delete(int id);
    }
}
