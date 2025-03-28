using ArggonRPG.Domain.Interface;

namespace ArggonRPG.Domain.Entities;

public abstract class PersonajeBase(string nombre, string clase, int vidaInicial) : IPersonaje, IDamageable
{
    public IArma? ArmaEquipada { get; private set; }
    public string Nombre { get; } = nombre;
    public string Clase { get; } = clase;
    public int Vida { get; protected set; } = vidaInicial;
    public List<IHabilidad> Habilidades { get; } = [];

    public void RecibirDaño(int daño)
    {
        Vida = Math.Max(0, Vida - daño);
    }

    public void EquiparArma(IArma arma)
    {
        if (ArmaEquipada != null) Vida -= ArmaEquipada.VidaAdicional;

        ArmaEquipada = arma;
        Vida += arma.VidaAdicional;
    }

    public void DesequiparArma()
    {
        if (ArmaEquipada != null)
        {
            Vida -= ArmaEquipada.VidaAdicional;
            ArmaEquipada = null;
        }
    }

    protected int CalcularDañoBase(int dañoBase)
    {
        return dañoBase + (ArmaEquipada?.Daño ?? 0);
    }

    public int UsarHabilidad(string nombreHabilidad)
    {
        var habilidad = Habilidades.FirstOrDefault(h => h.Nombre == nombreHabilidad);
        if (habilidad == null) throw new ArgumentException($"La habilidad {nombreHabilidad} no existe.");

        return habilidad.Usar(this);
    }
}