namespace ArggonRPG;

public abstract class HabilidadBase : IHabilidad
{
    public string Nombre { get; protected set; }
    public int DañoBase { get; protected set; }
    protected float Multiplicador { get; set; } = 1.0f;

    protected HabilidadBase(string nombre, int dañoBase)
    {
        Nombre = nombre;
        DañoBase = dañoBase;
    }

    public virtual int Usar()
    {
        return DamageCalculator.CalcularDañoFinal(DañoBase, Multiplicador);
    }
} 