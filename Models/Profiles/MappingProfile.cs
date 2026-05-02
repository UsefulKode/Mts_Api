using AutoMapper;
using Mts_Api.Models;
using Mts_Api.Models.DTOs;

namespace Mts_Api.Models.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Mapping из User (сущность БД) в UserDto (для GET запросов)
            CreateMap<User, UserDTO>();

            // Mapping из CreateUserDto (для POST запросов) в User (сущность БД)
            // Обратите внимание: Id не маппится, т.к. генерируется БД.
            // Password будет обрабатываться отдельно (хешироваться)
            CreateMap<CreateUserDTO, User>();

            // Mapping из UpdateUserDto (для PUT запросов) в User (сущность БД)
            // Id не маппится, т.к. оно берется из URL
            // Password не маппится, т.к. обновляется отдельно
            CreateMap<UpdateUserDTO, User>();
        }
    }
}
