using ArggonRPG.Domain.Interface;

namespace ArggonRPG.Application.Commands;

public class ComandoSalir : IComando
{
    public void Ejecutar()
    {
        Environment.Exit(0);
    }
}