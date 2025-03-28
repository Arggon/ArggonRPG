using ArggonRPG.Domain.Interface;
using ArggonRPG.Domain.Services;

namespace ArggonRPG.Domain.Entities;

public class EnemigoBase(string nombre, int vida, int dañoBase = 10) : IEnemigo
{
    protected int DañoBase { get; set; } = dañoBase;
    public string Nombre { get; } = nombre;
    public int Vida { get; private set; } = vida;

    public virtual int Atacar()
    {
        return DamageCalculator.CalcularDañoFinal(DañoBase);
    }

    public void RecibirDaño(int daño)
    {
        Vida = Math.Max(0, Vida - daño);
    }
}