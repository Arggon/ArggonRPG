namespace ArggonRPG;

public class HabilidadBase : IHabilidad
{
    public string Nombre { get; private set; }
    public int DañoBase { get; private set; }

    public HabilidadBase(string nombre, int dañoBase)
    {
        Nombre = nombre;
        DañoBase = dañoBase;
    }

    public int Usar()
    {
        return DañoBase; // Daño fijo por simplicidad
    }
}