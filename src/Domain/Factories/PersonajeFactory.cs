namespace ArggonRPG;

public interface IPersonajeFactory
{
    IPersonaje CrearPersonaje(string clase, string nombre);
}

public class PersonajeFactory : IPersonajeFactory
{
    private readonly Dictionary<string, Func<string, IPersonaje>> _creadores;

    public PersonajeFactory()
    {
        _creadores = new Dictionary<string, Func<string, IPersonaje>>
        {
            { "Guerrero", nombre => new Guerrero(nombre) }
        };
    }

    public IPersonaje CrearPersonaje(string clase, string nombre)
    {
        if (_creadores.TryGetValue(clase, out var creador))
        {
            return creador(nombre);
        }
        throw new ArgumentException($"Clase no válida: {clase}");
    }
} 