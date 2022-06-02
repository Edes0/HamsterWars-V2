using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects;

namespace HamsterWarsV2API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<Hamster, HamsterDto>()
            //.ForMember(c => c.FullAddress, opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));

            CreateMap<Battle, BattleDto>();

            CreateMap<BattleForCreationDto, Battle>();

            CreateMap<BattleForUpdateDto, Battle>();

            CreateMap<BattleForUpdateDto, Battle>().ReverseMap();

            CreateMap<Hamster, HamsterDto>();

            CreateMap<HamsterForCreationDto, Hamster>();

            CreateMap<HamsterForUpdateDto, Hamster>();

            CreateMap<HamsterForUpdateDto, Hamster>().ReverseMap();
        }
    }
}
