namespace ArggonRPG;

public class EnemigoBase : IEnemigo
{
    public string Nombre { get; private set; }
    public int Vida { get; private set; }

    public EnemigoBase(string nombre, int vida)
    {
        Nombre = nombre;
        Vida = vida;
    }

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