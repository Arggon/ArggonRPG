using ArggonRPG.Domain.Interface;

namespace ArggonRPG.Domain.Entities;

public class EnemigoBase(string nombre, int vida) : IEnemigo
{
    public string Nombre { get; private set; } = nombre;
    public int Vida { get; private set; } = vida;

    public int Atacar()
    {
        return 10;
    }

    public void RecibirDaño(int daño)
    {
        Vida -= daño;
        if (Vida < 0) Vida = 0;
    }
}