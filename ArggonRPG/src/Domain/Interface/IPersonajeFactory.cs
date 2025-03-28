namespace ArggonRPG.Domain.Interface;

public interface IPersonajeFactory
{
    IPersonaje CrearPersonaje(string clase, string nombre);
} 