using AutoMapper;
using UserRegistration.Shared.Models;

namespace UserRegistration.Server
{
    public class MapperConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<User, User>();
            });
            return mappingConfig;
        }
    }
}
