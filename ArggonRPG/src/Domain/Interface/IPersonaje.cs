namespace ArggonRPG.Domain.Interface;

public interface IPersonaje
{
    string Nombre { get; }
    string Clase { get; }
    int Vida { get; }
    List<IHabilidad> Habilidades { get; }
    void RecibirDaño(int daño);
}