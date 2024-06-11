﻿using AutoMapper;
using RentAVilla_Web.Models.Dto;

namespace RentAVilla_Web
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            
            CreateMap<VillaDTO, VillaCreateDTO>().ReverseMap();
            CreateMap<VillaDTO, VillaUpdateDTO>().ReverseMap();

            CreateMap<VillaNumberDTO, VillaNumberCreateDTO>().ReverseMap();
            CreateMap<VillaNumberDTO, VillaNumberUpdateDTO>().ReverseMap();


        }
    }
}
