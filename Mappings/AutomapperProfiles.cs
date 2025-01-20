using AutoMapper;
using F1_Racing_System.Models.Domain;
using F1_Racing_System.Models.Dto;


namespace F1_Racing_System.Mappings
{
    public class AutomapperProfiles : Profile
    {
        public AutomapperProfiles()
        {
            CreateMap<Team, TeamDto>().ReverseMap();

        }
    }
}