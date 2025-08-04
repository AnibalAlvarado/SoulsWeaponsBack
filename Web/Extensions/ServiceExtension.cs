using Business.Implementations;
using Business.Interfaces;
using Data.Implementations;
using Data.Interfaces;
using Entity.Dtos;

namespace Web.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {

            // Genéricos base
            services.AddScoped(typeof(IBaseModelBusiness<,>), typeof(BaseModelBusiness<,>));
            services.AddScoped(typeof(IBaseModelData<>), typeof(BaseModelData<>));

            // Concretos
            services.AddScoped<ICardBusiness, CardBusiness>();
            services.AddScoped<ICardData, CardData>();

            services.AddScoped<IDeckBusiness, DeckBusiness>();
            services.AddScoped<IDeckData, DeckData>();

            services.AddScoped<IPlayerBusiness, PlayerBusiness>();
            services.AddScoped<IPlayerData, PlayerData>();

            services.AddScoped<IGamePlayerBusiness, GamePlayerBusiness>();
            services.AddScoped<IGamePlayerData, GamePlayerData>();

            services.AddScoped<IRoomBusiness, RoomBusiness>();
            services.AddScoped<IRoomData, RoomData>();

            return services;
        }
    }
}
