using ArggonRPG.Domain.Interface;

namespace ArggonRPG.Domain.Entities;

public abstract class PersonajeBase(string nombre, string clase, int vidaInicial) : IPersonaje, IDamageable
{
    public string Nombre { get; } = nombre;
    public string Clase { get; } = clase;
    public int Vida { get; protected set; } = vidaInicial;
    public List<IHabilidad> Habilidades { get; } = [];

    public void RecibirDaño(int daño)
    {
        Vida = Math.Max(0, Vida - daño);
    }
}