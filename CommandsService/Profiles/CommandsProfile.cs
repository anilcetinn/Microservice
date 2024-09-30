using AutoMapper;
using CommandService.Dtos;
using CommandsService.Dtos;
using CommandsService.Models;

namespace CommandService.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Platform,PlatformReadDto>();
            CreateMap<CommandCreateDto,Command>();
            CreateMap<Command,CommandReadDto>();
            CreateMap<PlatformPublishedDto,Platform>()
                .ForMember(dest=>dest.ExternalID,opt => opt.MapFrom(src => src.Id));
        }
    }
}