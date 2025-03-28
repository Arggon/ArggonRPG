namespace ArggonRPG;

public class PersonajeFactory
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