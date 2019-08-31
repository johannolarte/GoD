using AutoMapper;
using GoD.WebApi.Core.Dto;
using GoD.WebApi.Core.Models;

namespace GoD.WebApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Player, PlayerDto>();
        }
    }
}