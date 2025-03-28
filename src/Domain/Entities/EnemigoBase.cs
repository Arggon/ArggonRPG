namespace ArggonRPG;

public class EnemigoBase : IEnemigo, IDamageable, IAtaque
{
    public string Nombre { get; private set; }
    public int Vida { get; private set; }
    protected int DañoBase { get; set; }

    public EnemigoBase(string nombre, int vida, int dañoBase = 10)
    {
        Nombre = nombre;
        Vida = vida;
        DañoBase = dañoBase;
    }

    public virtual int Atacar()
    {
        return DamageCalculator.CalcularDañoFinal(DañoBase);
    }

    public void RecibirDaño(int daño)
    {
        Vida = Math.Max(0, Vida - daño);
    }
} 