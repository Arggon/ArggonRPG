namespace ArggonRPG.Domain.Interface;

public interface IDamageable
{
    int Vida { get; }
    void RecibirDaño(int daño);
}