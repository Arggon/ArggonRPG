using ArggonRPG.Application.Commands;
using ArggonRPG.Domain.Factories;
using ArggonRPG.Domain.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace ArggonRPG.Application.Configuration;

public static class ServicesConfiguration
{
    public static IServiceCollection ConfigureServices(this IServiceCollection services)
    {
        services.AddSingleton<IPersonajeFactory, PersonajeFactory>();
        services.AddScoped<ComandoCrearPersonaje>();
        return services;
    }
} 