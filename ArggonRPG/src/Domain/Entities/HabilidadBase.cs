using ArggonRPG.Domain.Interface;
using ArggonRPG.Domain.Services;

namespace ArggonRPG.Domain.Entities;

public abstract class HabilidadBase(string nombre, int dañoBase) : IHabilidad
{
    public int DañoBase { get; protected set; } = dañoBase;
    protected float Multiplicador { get; set; } = 1.0f;
    public string Nombre { get; protected set; } = nombre;

    public virtual int Usar(PersonajeBase personaje)
    {
        var dañoTotal = DañoBase;

        // Si el personaje tiene un arma equipada, sumamos su daño
        if (personaje.ArmaEquipada != null) dañoTotal += personaje.ArmaEquipada.Daño;

        return DamageCalculator.CalcularDañoFinal(dañoTotal, Multiplicador);
    }
}