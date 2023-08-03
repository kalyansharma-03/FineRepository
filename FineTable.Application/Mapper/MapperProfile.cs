using AutoMapper;
using FineTable.Application.DTO.Request;
using FineTable.Application.DTO.Response;
using FineTable.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FineTable.Application.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
            CreateMap<FineRequest, EFine>();
            CreateMap<EFine, FineResponse>();


        }
    }
}
