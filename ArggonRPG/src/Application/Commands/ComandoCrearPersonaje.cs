namespace ArggonRPG;

public class ComandoCrearPersonaje : IComando
{
    private readonly List<IPersonaje> personajes;

    public ComandoCrearPersonaje(List<IPersonaje> personajes)
    {
        this.personajes = personajes;
    }

    public void Ejecutar()
    {
        Console.WriteLine("=== Selección de Clase ===");
        Console.WriteLine("1. Guerrero");
        Console.WriteLine("2. Volver al menú anterior");
        Console.Write("Selecciona una opción: ");
        string opcion = Console.ReadLine();

        if (opcion == "1")
        {
            Console.Write("Ingresa el nombre de tu personaje: ");
            string nombre = Console.ReadLine();
            IPersonaje nuevoPersonaje = PersonajeFactory.CrearPersonaje("Guerrero", nombre);
            personajes.Add(nuevoPersonaje);
            Console.WriteLine($"Personaje {nombre} (Guerrero) creado con éxito. Presiona Enter para continuar.");
            Console.ReadLine();
        }
    }
}