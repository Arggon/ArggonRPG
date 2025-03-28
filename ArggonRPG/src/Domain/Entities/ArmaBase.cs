using ArggonRPG.Domain.Interface;

namespace ArggonRPG.Domain.Entities;

public abstract class ArmaBase(string nombre, int daño, int vidaAdicional, string tipo)
    : IArma
{
    public string Nombre { get; } = nombre;
    public int Daño { get; } = daño;
    public int VidaAdicional { get; } = vidaAdicional;
    public string Tipo { get; } = tipo;
}