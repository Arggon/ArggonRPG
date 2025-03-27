namespace ArggonRPG;

public interface IEnemigo
{
    string Nombre { get; }
    int Vida { get; }
    int Atacar();
    void RecibirDaño(int daño);
}