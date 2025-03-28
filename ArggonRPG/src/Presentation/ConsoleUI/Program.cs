namespace ArggonRPG
{ 
    public class Program
    {
        private static List<IPersonaje> personajes = new List<IPersonaje>();

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Menú Principal ===");
                Console.WriteLine("1. Crear Personaje");
                Console.WriteLine("2. Seleccionar Personaje");
                Console.WriteLine("3. Salir");
                Console.Write("Selecciona una opción: ");
                string? opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        new ComandoCrearPersonaje(personajes).Ejecutar();
                        break;
                    case "2":
                        SeleccionarPersonaje();
                        break;
                    case "3":
                        new ComandoSalir().Ejecutar();
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Presiona Enter para continuar.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private static void SeleccionarPersonaje()
        {
            if (personajes.Count == 0)
            {
                Console.WriteLine("No hay personajes creados. Presiona Enter para volver al menú principal.");
                Console.ReadLine();
                return;
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Selección de Personaje ===");
                for (int i = 0; i < personajes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {personajes[i].Nombre} ({personajes[i].Clase})");
                }
                Console.WriteLine($"{personajes.Count + 1}. Volver al menú anterior");
                Console.Write("Selecciona una opción: ");
                string? opcion = Console.ReadLine();

                if (int.TryParse(opcion, out int seleccion))
                {
                    if (seleccion >= 1 && seleccion <= personajes.Count)
                    {
                        IPersonaje personajeSeleccionado = personajes[seleccion - 1];
                        MenuAccionesPersonaje(personajeSeleccionado);
                        return;
                    }
                    else if (seleccion == personajes.Count + 1)
                    {
                        return;
                    }
                }
                Console.WriteLine("Opción no válida. Presiona Enter para continuar.");
                Console.ReadLine();
            }
        }

        private static void MenuAccionesPersonaje(IPersonaje personaje)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"=== Acciones de {personaje.Nombre} ===");
                Console.WriteLine("1. Buscar rival");
                Console.WriteLine("2. Equipar Objetos");
                Console.WriteLine("3. Ver estadísticas");
                Console.WriteLine("4. Volver al menú anterior");
                Console.Write("Selecciona una opción: ");
                string? opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        BuscarRival(personaje);
                        break;
                    case "2":
                        Console.WriteLine("Función de equipar objetos aún no implementada. Presiona Enter para continuar.");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine($"Estadísticas de {personaje.Nombre}:");
                        Console.WriteLine($"Clase: {personaje.Clase}");
                        Console.WriteLine($"Vida: {personaje.Vida}");
                        Console.WriteLine("Presiona Enter para continuar.");
                        Console.ReadLine();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Presiona Enter para continuar.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private static void BuscarRival(IPersonaje jugador)
        {
            IEnemigo enemigo = new EnemigoBase("Goblin", 50);
            Console.WriteLine($"¡Has encontrado a un {enemigo.Nombre}!");
            Console.WriteLine("Presiona Enter para continuar.");
            Console.ReadLine();
            Encuentro(jugador, enemigo);
        }

        private static void Encuentro(IPersonaje jugador, IEnemigo enemigo)
        {
            while (jugador.Vida > 0 && enemigo.Vida > 0)
            {
                Console.Clear();
                Console.WriteLine($"=== Encuentro: {jugador.Nombre} vs {enemigo.Nombre} ===");
                Console.WriteLine($"Vida de {jugador.Nombre}: {jugador.Vida}");
                Console.WriteLine($"Vida de {enemigo.Nombre}: {enemigo.Vida}");
                Console.WriteLine("1. Atacar");
                Console.WriteLine("2. Huir");
                Console.Write("Selecciona una opción: ");
                string? opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Atacar(jugador, enemigo);
                        if (enemigo.Vida > 0)
                        {
                            int dañoEnemigo = enemigo.Atacar();
                            jugador.RecibirDaño(dañoEnemigo);
                            Console.WriteLine($"El {enemigo.Nombre} te atacó y te hizo {dañoEnemigo} de daño.");
                            Console.WriteLine("Presiona Enter para continuar.");
                            Console.ReadLine();
                        }
                        break;
                    case "2":
                        Console.WriteLine("Has huido del encuentro. Presiona Enter para continuar.");
                        Console.ReadLine();
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Presiona Enter para continuar.");
                        Console.ReadLine();
                        break;
                }
            }

            if (jugador.Vida <= 0)
            {
                Console.WriteLine("Has sido derrotado. Presiona Enter para continuar.");
            }
            else if (enemigo.Vida <= 0)
            {
                Console.WriteLine($"¡Has derrotado al {enemigo.Nombre}! Presiona Enter para continuar.");
            }
            Console.ReadLine();
        }

        private static void Atacar(IPersonaje jugador, IEnemigo enemigo)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Selecciona una habilidad ===");
                for (int i = 0; i < jugador.Habilidades.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {jugador.Habilidades[i].Nombre}");
                }
                Console.WriteLine($"{jugador.Habilidades.Count + 1}. Volver");
                Console.Write("Selecciona una opción: ");
                string? opcion = Console.ReadLine();

                if (int.TryParse(opcion, out int seleccion))
                {
                    if (seleccion >= 1 && seleccion <= jugador.Habilidades.Count)
                    {
                        IHabilidad habilidad = jugador.Habilidades[seleccion - 1];
                        int daño = habilidad.Usar();
                        enemigo.RecibirDaño(daño);
                        Console.WriteLine($"Usaste {habilidad.Nombre} e hiciste {daño} de daño a {enemigo.Nombre}.");
                        Console.WriteLine("Presiona Enter para continuar.");
                        Console.ReadLine();
                        return;
                    }
                    else if (seleccion == jugador.Habilidades.Count + 1)
                    {
                        return;
                    }
                }
                Console.WriteLine("Opción no válida. Presiona Enter para continuar.");
                Console.ReadLine();
            }
        }
    }
}