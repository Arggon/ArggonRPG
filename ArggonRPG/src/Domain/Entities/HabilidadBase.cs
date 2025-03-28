using ArggonRPG.Domain.Interface;

namespace ArggonRPG.Domain.Entities;

public class HabilidadBase(string nombre, int dañoBase) : IHabilidad
{
    public string Nombre { get; private set; } = nombre;
    private int DañoBase { get; set; } = dañoBase;

    public int Usar()
    {
        return DañoBase;
    }
}