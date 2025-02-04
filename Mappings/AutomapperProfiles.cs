using AutoMapper;
using F1_Racing_System.Models.Domain;
using F1_Racing_System.Models.Dto;
using F1_Racing_System.Models.Dto.Driver;
using F1_Racing_System.Models.Dto.Race;
using F1_Racing_System.Models.Dto.Team;


namespace F1_Racing_System.Mappings
{
    public class AutomapperProfiles : Profile
    {
        public AutomapperProfiles()
        {
            CreateMap<Team, TeamDto>().ReverseMap();
            CreateMap<Team, CreateTeamDto>().ReverseMap();
            CreateMap<Driver, DriverDto>().ReverseMap();
            CreateMap<Driver, CreateDriverDto>().ReverseMap();
            CreateMap<Race, RaceDto>().ReverseMap();
            CreateMap<CreateRaceDto, Race>().ReverseMap();
        }
    }
}