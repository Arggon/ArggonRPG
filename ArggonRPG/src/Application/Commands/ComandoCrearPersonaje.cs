using ArggonRPG.Domain.Factories;
using ArggonRPG.Domain.Interface;

namespace ArggonRPG.Application.Commands;

public class ComandoCrearPersonaje(List<IPersonaje> personajes) : IComando
{
    public void Ejecutar()
    {
        Console.WriteLine("=== Selección de Clase ===");
        Console.WriteLine("1. Guerrero");
        Console.WriteLine("2. Volver al menú anterior");
        Console.Write("Selecciona una opción: ");
        var opcion = Console.ReadLine();

        if (opcion != "1") return;
        
        Console.Write("Ingresa el nombre de tu personaje: ");
        var nombre = Console.ReadLine();
        if (nombre != null)
        {
            var nuevoPersonaje = PersonajeFactory.CrearPersonaje("Guerrero", nombre);
            personajes.Add(nuevoPersonaje);
        }

        Console.WriteLine($"Personaje {nombre} (Guerrero) creado con éxito. Presiona Enter para continuar.");
        Console.ReadLine();
    }
}