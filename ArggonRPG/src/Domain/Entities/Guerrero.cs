﻿using ArggonRPG.Domain.Entities.Armas;

namespace ArggonRPG.Domain.Entities;

public class Guerrero : PersonajeBase
{
    public Guerrero(string nombre) : base(nombre, "Guerrero", 100)
    {
        Habilidades.Add(new HabilidadConcreta("Golpe Fuerte", 20));
        Habilidades.Add(new HabilidadConcreta("Corte Rápido", 15));

        // Equipar espada por defecto
        EquiparArma(new Espada());
    }
}