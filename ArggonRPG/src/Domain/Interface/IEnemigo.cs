namespace ArggonRPG.Domain.Interface;

public interface IEnemigo : IDamageable
{
    string Nombre { get; }
    int Atacar();
}