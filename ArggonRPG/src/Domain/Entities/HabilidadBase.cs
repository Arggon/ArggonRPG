﻿using ArggonRPG.Domain.Interface;
using ArggonRPG.Domain.Services;

namespace ArggonRPG.Domain.Entities;

public abstract class HabilidadBase(string nombre, int dañoBase) : IHabilidad
{
    public string Nombre { get; protected set; } = nombre;
    public int DañoBase { get; protected set; } = dañoBase;
    protected float Multiplicador { get; set; } = 1.0f;

    public virtual int Usar()
    {
        return DamageCalculator.CalcularDañoFinal(DañoBase, Multiplicador);
    }
} 