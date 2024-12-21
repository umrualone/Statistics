using AutoMapper;
using Statistics.Application.Dtos.Requests.Exersice;
using Statistics.Application.Dtos.Resources.Exersice;
using Statistics.Domain.Models;

namespace Statistics.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ExersiceCreateRequest, Exercise>();
            CreateMap<Exercise, ExersiceFullResources>();
        }
    }
}
