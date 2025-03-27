namespace ArggonRPG;

public class PersonajeFactory
{
    public static IPersonaje CrearPersonaje(string clase, string nombre)
    {
        switch (clase)
        {
            case "Guerrero":
                return new Guerrero(nombre);
            default:
                throw new ArgumentException("Clase no válida");
        }
    }
}