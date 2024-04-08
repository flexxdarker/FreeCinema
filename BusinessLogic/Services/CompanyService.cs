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
    public class CompanyService : ICompanyService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Company> companyR;
        public CompanyService(IMapper mapper, IRepository<Film> filmR)
        {
            this.mapper = mapper;
            this.companyR = companyR;
        }
        public async Task<IEnumerable<CompanyDto>> Get(IEnumerable<int> ids)
        {
            return mapper.Map<List<CompanyDto>>(await companyR.GetListBySpec(new CompanySpecs.ByIds(ids)));
        }

        public IEnumerable<CompanyDto> GetAll()
        {
            return mapper.Map<List<CompanyDto>>(companyR.GetAll());
        }
    }
}
