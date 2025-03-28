namespace ArggonRPG.Domain.Interface;

public interface IArma
{
    string Nombre { get; }
    int Daño { get; }
    int VidaAdicional { get; }
    string Tipo { get; }
}