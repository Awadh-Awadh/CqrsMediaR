using AutoMapper;
using Shared.DTOs;
using Shared.Models;

namespace Shared.Profiles;

public class PersonProfile : Profile
{
    public PersonProfile()
    { 
        // souce -> destination 
        
        CreateMap<Person, PersonReadDto>();
        
       // CreateMap<CreatePersonDto, Person>();
    }
}