using ArggonRPG.Domain.Interface;

namespace ArggonRPG.Domain.Entities;

public abstract class PersonajeBase(string nombre, string clase, int vidaInicial) : IPersonaje, IDamageable
{
    public string Nombre { get; private set; } = nombre;
    public string Clase { get; private set; } = clase;
    public int Vida { get; protected set; } = vidaInicial;
    public List<IHabilidad> Habilidades { get; private set; } = new();

    public void RecibirDaño(int daño)
    {
        Vida = Math.Max(0, Vida - daño);
    }
} 