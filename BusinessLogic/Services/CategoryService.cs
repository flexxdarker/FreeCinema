using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using BusinessLogic.Specifications;
using DataAccess.Entities;
using DataAccess.Repostories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    internal class CategoryService : ICategoryService
    {
        private readonly Mapper mapper;
        private readonly IRepository<Category> categoryR;

        public CategoryService(Mapper mapper, IRepository<Category> categoryR)
        {
            this.mapper = mapper;
            this.categoryR = categoryR;
        }

        public async Task<IEnumerable<CategoryDto>> Get(IEnumerable<int> ids)
        {
            return mapper.Map<List<CategoryDto>>(await categoryR.GetListBySpec(new CategorySpecs.ByIds(ids)));
        }

        public async Task<IEnumerable<CategoryDto>> GetAll()
        {
            return mapper.Map<List<CategoryDto>>(await categoryR.GetListBySpec(new CategorySpecs.All()));
        }
    }
}
