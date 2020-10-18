using System.Collections.Generic;
using AutoMapper;
using backend.DTOs.Localizacion;
using backend.Models;

namespace backend.Profiles
{
    public class PaisProfile : Profile
    {
        public PaisProfile()
        {
            CreateMap<PaisCreateDTO, Pais>();
            CreateMap<Pais, PaisReadDTO>();
            // CreateMap<IEnumerable<Pais>, IEnumerable<PaisReadDTO>>();

            CreateMap<PaisUpdateDTO, Pais>();
        }
    }
}