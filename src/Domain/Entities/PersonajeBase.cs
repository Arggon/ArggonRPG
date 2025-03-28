namespace ArggonRPG;

public abstract class PersonajeBase : IPersonaje, IDamageable
{
    public string Nombre { get; private set; }
    public string Clase { get; private set; }
    public int Vida { get; protected set; }
    public List<IHabilidad> Habilidades { get; private set; }

    protected PersonajeBase(string nombre, string clase, int vidaInicial)
    {
        Nombre = nombre;
        Clase = clase;
        Vida = vidaInicial;
        Habilidades = new List<IHabilidad>();
    }

    public void RecibirDaño(int daño)
    {
        Vida = Math.Max(0, Vida - daño);
    }
} 