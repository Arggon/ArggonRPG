namespace ArggonRPG;

public class ComandoSalir : IComando
{
    public void Ejecutar()
    {
        Environment.Exit(0);
    }
}