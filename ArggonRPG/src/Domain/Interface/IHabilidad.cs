using ArggonRPG.Domain.Entities;

namespace ArggonRPG.Domain.Interface;

public interface IHabilidad
{
    string Nombre { get; }
    int Usar(PersonajeBase personaje);
}