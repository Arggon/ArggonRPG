using ArggonRPG.Domain.Entities;
using ArggonRPG.Domain.Interface;

namespace ArggonRPG.Domain.Factories;

public class PersonajeFactory : IPersonajeFactory
{
    public IPersonaje CrearPersonaje(string clase, string nombre)
    {
        return clase switch
        {
            "Guerrero" => new Guerrero(nombre),
            _ => throw new ArgumentException($"Clase no válida: {clase}")
        };
    }
} 