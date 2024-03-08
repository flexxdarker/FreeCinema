using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Profiles
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile(IFileService fileService)
        {
            CreateMap<FilmDto, Film>()
                .ForMember(x => x.Category, opt => opt.Ignore());
            CreateMap<Film, FilmDto>();

            CreateMap<RegisterModel, User>()
                .ForMember(x => x.UserName, opts => opts.MapFrom(s => s.Email));

            CreateMap<SessionDto, Session>()
                .ForMember(x => x.CinemaHall, opt => opt.Ignore())
                .ForMember(x => x.Film, opt => opt.Ignore());
            CreateMap<Session, SessionDto>();
        }
    }
}
