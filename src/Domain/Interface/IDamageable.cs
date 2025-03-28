namespace ArggonRPG;

public interface IDamageable
{
    int Vida { get; }
    void RecibirDaño(int daño);
} 