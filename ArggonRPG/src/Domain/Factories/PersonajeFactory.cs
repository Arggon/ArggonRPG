using ArggonRPG.Domain.Entities;
using ArggonRPG.Domain.Interface;

namespace ArggonRPG.Domain.Factories;

public abstract class PersonajeFactory
{
    public static IPersonaje CrearPersonaje(string clase, string nombre)
    {
        return clase switch
        {
            "Guerrero" => new Guerrero(nombre),
            _ => throw new ArgumentException("Clase no válida"),
        };
    }
}