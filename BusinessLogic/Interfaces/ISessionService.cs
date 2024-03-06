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
        IEnumerable<SessionDto> GetAll();
        SessionDto? Get(int id);
        void Create(SessionDto product);
        void Edit(SessionDto product);
        void Delete(int id);
    }
}
