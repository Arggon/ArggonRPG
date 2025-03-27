namespace ArggonRPG;

public class Guerrero : PersonajeBase
{
    public Guerrero(string nombre) : base(nombre, "Guerrero", 100)
    {
        Habilidades.Add(new HabilidadBase("Golpe Fuerte", 20));
        Habilidades.Add(new HabilidadBase("Corte Rápido", 15));
    }
}